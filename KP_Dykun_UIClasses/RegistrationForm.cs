using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.Json;
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
        List<User>? users = new List<User>();

        public RegistrationForm()
        {
            InitializeComponent();
            users = ReadUsersFromFileJson("users.json");
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {

        }

        static List<User>? ReadUsersFromFileJson(string path)
        {
            List<User>? users = null;
            try
            {
                users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText(path));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return users;
        }
    }
}
