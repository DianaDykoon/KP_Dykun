using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        List<User> users = new ();
        Companion companion = new Companion("Diana", "12345678", "+38(099)-9811127", "Diana");
        Driver driver = new Driver("Diana", "7778654", "+38(097)-0124570", "Diana");
        Administrator administrator = new Administrator("Admin07", "admin@_109");

        public AuthorizationForm()
        {
            InitializeComponent();
            users.Add(companion);
            users.Add(administrator);
            users.Add(driver);
        }

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
                Form companionForm = new CompanionMainForm();
                companionForm.ShowDialog();
            }

            else if (driverAuthoriz.Authorization(login, password, users))
            {
                Form driverForm = new DriverMainForm();
                driverForm.ShowDialog();
            }

            else if (administratorAuthoriz.Authorization(login, password, users))
            {
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
    }
}
