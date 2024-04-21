using KP_Dykun_Classes;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Dykun_UIClasses
{
    public partial class AuthorizationForm : Form
    {
        string login = "";
        string password = "";
        Companion companionAuthoriz = new Companion();
        Driver driverAuthoriz = new Driver();
        Administrator administratorAuthoriz = new Administrator();

        List<User>? users = new ();
        List<Administrator>? administrators = new();
        List<Driver>? drivers = new ();
        List<Companion>? companions = new();

        public AuthorizationForm()
        {
            InitializeComponent();
            drivers = ReadDriversFromFileJson("drivers.json");
            companions = ReadCompanionsFromFileJson("companions.json");
            administrators = ReadAdministratorsFromFileJson("administrators.json");

            foreach (var driver in drivers!)
                users.Add(driver);

            foreach (var companion in companions!)
                users.Add(companion);

            foreach (var administrator in administrators!)
                users.Add(administrator);
        }


        // new Companion("Diana", "12345678", "+38(099)-9811127");
        // new Driver("Alex07", "7778654", "+38(097)-0124570");
        // new Administrator("Admin07", "admin@_109");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            password = txtPassword.Text;

            companionAuthoriz.Login = login;
            companionAuthoriz.Password = password;

            driverAuthoriz.Login = login;
            driverAuthoriz.Password = password;

            administratorAuthoriz.Login = login;
            administratorAuthoriz.Password = password;

            if (companionAuthoriz.Authorization(login, password, users))
            {
                var user = companions!.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                try
                {
                    string jsonstring = "";
                    jsonstring = JsonSerializer.Serialize(user);
                    File.WriteAllText("User.json", jsonstring);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Form companionForm = new CompanionMainForm();
                companionForm.ShowDialog();
            }

            else if (driverAuthoriz.Authorization(login, password, users))
            {
                var user = drivers.Where(x => x.Login == login && x.Password == password).ToList();
                try
                {
                    string jsonstring = "";
                    jsonstring = JsonSerializer.Serialize(user);
                    File.WriteAllText("User.json", jsonstring);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Form driverForm = new DriverMainForm();
                driverForm.ShowDialog();
            }

            else if (administratorAuthoriz.Authorization(login, password, users))
            {
                var user = administrators.Where(x => x.Login == login && x.Password == password).ToList();
                try
                {
                    string jsonstring = "";
                    jsonstring = JsonSerializer.Serialize(user);
                    File.WriteAllText("User.json", jsonstring);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Form adminForm = new AdminForm();
                adminForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Невірний логін або пароль!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLblRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Form form = new RegistrationForm();
            form.ShowDialog();
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
    }
}
