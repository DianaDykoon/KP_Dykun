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
    public partial class PlannedTravelsForm : Form
    {
        List<Trip>? trips = new();

        public PlannedTravelsForm()
        {
            InitializeComponent();
            trips = ReadTripsFromFileJson("trips.json");
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnShowCompanions_Click(object sender, EventArgs e)
        {
            try
            {
                listCompanions.Items.Clear();
                
                string tripInfo = listTripsPlanned.SelectedItem!.ToString()!;
                string[] splitTripInfo = tripInfo.Split(",");
                listCompanions.Visible = true;
                listCompanionsInfo.Visible = true;

                foreach (Trip trip in trips!)
                {
                    if (trip.Number == int.Parse(splitTripInfo[0]))
                    {
                        foreach (var companion in trip.Companions)
                            listCompanions.Items.Add(companion.CompanionInfo());
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть поїздку!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
