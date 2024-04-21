﻿using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Dykun_UIClasses
{
    public partial class RegistrationForm : Form
    {
        string login = "";
        string password = "";
        string name = "";
        string phoneNumber = "";
        string role = "";
        List<Administrator>? administrators = new();
        List<Driver>? drivers = new();
        List<Companion>? companions = new();
        List<User> users = new();

        Companion companionRegistration = new Companion();
        Driver driverRegistration = new Driver();

        public RegistrationForm()
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

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            login = txtLogin.Text;
            password = txtPassword.Text;
            name = txtName.Text;
            phoneNumber = txtPhoneNumber.Text;
            role = cmbRole.Text;

            companionRegistration.Name = name;
            companionRegistration.Login = login;
            companionRegistration.Password = password;
            companionRegistration.PhoneNumber = phoneNumber;
            companionRegistration.LoadPhoto("C:\\Users\\User\\Pictures\\Saved Pictures\\UserPhoto.jpg");

            driverRegistration.Name = name;
            driverRegistration.Login = login;
            driverRegistration.Password = password;
            driverRegistration.PhoneNumber = phoneNumber;
            driverRegistration.LoadPhoto("C:\\Users\\User\\Pictures\\Saved Pictures\\UserPhoto.jpg");

            switch (role)
            {
                case "Попутник":
                    var companion = users.Where(p => p.Login == login).ToList();
                    if (companion.Count != 0)
                    {
                        MessageBox.Show("Цей логін вже зайнято", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    if (companionRegistration.Registration(login, password, name, phoneNumber))
                    {
                        companions.Add(companionRegistration);
                        SaveCompanionsToFileJson(companions, "companions.json");

                        try
                        {
                            string jsonstring = "";
                            jsonstring = JsonSerializer.Serialize(companionRegistration);
                            File.WriteAllText("User.json", jsonstring);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Form form = new CompanionMainForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        if (login.Length < 3)
                            MessageBox.Show("Логін повинен бути більше 3-х символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (password.Length < 6)
                            MessageBox.Show("Пароль повинен бути більше 6-ти символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (string.IsNullOrEmpty(name))
                            MessageBox.Show("Введіть ім'я", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Введіть телефон у форматі +38(XXX)-XXXXXXX", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                        
                    break;

                case "Водій":
                    var driver = users.Where(p => p.Login == login).ToList();
                    if (driver.Count != 0)
                    {
                        MessageBox.Show("Цей логін вже зайнято", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    if (driverRegistration.Registration(login, password, name, phoneNumber))
                    {
                        drivers.Add(driverRegistration);
                        SaveDriversToFileJson(drivers, "drivers.json");

                        try
                        {
                            string jsonstring = "";
                            jsonstring = JsonSerializer.Serialize(driverRegistration);
                            File.WriteAllText("User.json", jsonstring);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        Form form = new DriverMainForm();
                        form.ShowDialog();
                    }
                    else
                    {
                        if (login.Length < 3)
                            MessageBox.Show("Логін повинен бути більше 3-х символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (password.Length < 6)
                            MessageBox.Show("Пароль повинен бути більше 6-ти символів", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (string.IsNullOrEmpty(name))
                            MessageBox.Show("Введіть ім'я", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Введіть телефон у форматі +38(XXX)-XXXXXXX", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

                default:
                    MessageBox.Show("Оберіть роль із запропонованих", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
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
