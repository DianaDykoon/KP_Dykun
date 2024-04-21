using KP_Dykun_Classes;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KP_Dykun_UIClasses
{
    public partial class UserProfileForm : Form
    {
        List<Driver>? drivers = new();
        List<Companion>? companions = new();

        public UserProfileForm()
        {
            InitializeComponent();

            drivers = ReadDriversFromFileJson("drivers.json");
            companions = ReadCompanionsFromFileJson("companions.json");
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewTripHistory_Click(object sender, EventArgs e)
        {
            Form form = new TravelHistoryForm();
            form.ShowDialog();
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Изображения (*.jpg, *.bmp) | *.jpg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (var companion in companions)
                {
                    if (companion.Login == lblLogin.Text)
                    {
                        if (companion.LoadPhoto(ofd.FileName))
                        {
                            SaveCompanionsToFileJson(companions, "companions.json");
                            Application.Exit();
                        }
                        else
                            MessageBox.Show("Помилка", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                foreach (var driver in drivers)
                {
                    if (driver.Login == lblLogin.Text)
                    {
                        if (driver.LoadPhoto(ofd.FileName))
                        {
                            SaveDriversToFileJson(drivers, "drivers.json");
                            Application.Exit();
                        }
                        else
                            MessageBox.Show("Помилка", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void btnChangeProfile_Click(object sender, EventArgs e)
        {
            foreach (var companion in companions)
            {
                if (companion.Login == lblLogin.Text)
                {
                    if (companion.UpdateProfile(txtBoxPassword.Text, txtBoxName.Text, txtBoxPhoneNumber.Text))
                    {
                        companion.Password = txtBoxPassword.Text;
                        companion.Name = txtBoxName.Text;
                        companion.PhoneNumber = txtBoxPhoneNumber.Text;
                        SaveCompanionsToFileJson(companions, "companions.json");
                        Application.Exit();
                    }
                    else
                    {
                        if (txtBoxPassword.Text.Length < 6)
                            MessageBox.Show("Пароль повинен бути більше 6-ти символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (string.IsNullOrEmpty(txtBoxName.Text))
                            MessageBox.Show("Введіть ім'я", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Введіть телефон у форматі +38(XXX)-XXXXXXX", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            foreach (var driver in drivers)
            {
                if (driver.Login == lblLogin.Text)
                {
                    if (driver.UpdateProfile(txtBoxPassword.Text, txtBoxName.Text, txtBoxPhoneNumber.Text))
                    {
                        driver.Password = txtBoxPassword.Text;
                        driver.Name = txtBoxName.Text;
                        driver.PhoneNumber = txtBoxPhoneNumber.Text;
                        SaveDriversToFileJson(drivers, "drivers.json");
                        Application.Exit();
                    }
                    else
                    {
                        if (txtBoxPassword.Text.Length < 6)
                            MessageBox.Show("Пароль повинен бути більше 6-ти символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (string.IsNullOrEmpty(txtBoxName.Text))
                            MessageBox.Show("Введіть ім'я", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Введіть телефон у форматі +38(XXX)-XXXXXXX", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }


        static List<Driver>? ReadDriversFromFileJson(string path)
        {
            List<Driver>? drivers = null;
            try
            {
                drivers = JsonSerializer.Deserialize<List<Driver>>(File.ReadAllText(path));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return drivers;
        }
        static List<Companion>? ReadCompanionsFromFileJson(string path)
        {
            List<Companion>? companions = null;
            try
            {
                companions = JsonSerializer.Deserialize<List<Companion>>(File.ReadAllText(path));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return companions;
        }
        static List<Administrator>? ReadAdministratorsFromFileJson(string path)
        {
            List<Administrator>? administrators = null;
            try
            {
                administrators = JsonSerializer.Deserialize<List<Administrator>>(File.ReadAllText(path));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return administrators;
        }

        static void SaveDriversToFileJson(List<Driver> drivers, string path)
        {
            try
            {
                string jsonstring = "";
                jsonstring = JsonSerializer.Serialize(drivers);
                File.WriteAllText(path, jsonstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void SaveCompanionsToFileJson(List<Companion> companions, string path)
        {
            try
            {
                string jsonstring = "";
                jsonstring = JsonSerializer.Serialize(companions);
                File.WriteAllText(path, jsonstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
