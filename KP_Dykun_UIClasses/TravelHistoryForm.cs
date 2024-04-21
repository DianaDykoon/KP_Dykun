using KP_Dykun_Classes;
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

namespace KP_Dykun_UIClasses
{
    public partial class TravelHistoryForm : Form
    {
        List<Trip> trips = new();
        public TravelHistoryForm()
        {
            InitializeComponent();
            trips = ReadTripsFromFileJson("trips.json");
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listTripHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnShowCompanions.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void btnShowCompanions_Click(object sender, EventArgs e)
        {
            try
            {
                listCompanions.Text = "";
                listCompanions.Visible = true;
                string driverInfo = listTripHistory.SelectedItem.ToString();
                string[] splitDriverInfo = driverInfo.Split(",");

                foreach (Trip trip in trips)
                {
                    if (trip.Number == int.Parse(splitDriverInfo[0]))
                    {
                        foreach (var companion in trip.companions)
                            listTripHistory.Items.Add(companion.CompanionInfo());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть поїздку!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static List<Trip>? ReadTripsFromFileJson(string path)
        {
            List<Trip>? trips = null;
            try
            {
                trips = JsonSerializer.Deserialize<List<Trip>>(File.ReadAllText(path));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return trips;
        }
    }
}
