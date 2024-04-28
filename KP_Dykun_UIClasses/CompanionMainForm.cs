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
    public partial class CompanionMainForm : Form
    {
        string pointOfDeparture = "";
        string destination = "";
        short numberOfSeats = 0;
        DateTime date = new DateTime();
        List<Trip>? trips = new();

        Companion? companion = new Companion();

        public CompanionMainForm()
        {
            InitializeComponent();
            trips = ReadTripsFromFileJson("trips.json");

            try
            {
                companion = JsonSerializer.Deserialize<Companion>(File.ReadAllText("User.json"));
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Помилка при читаннi з JSON файлу: {ex.Message}", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewTripHistory_Click(object sender, EventArgs e)
        {
            TravelHistoryForm form = new TravelHistoryForm();
            foreach (var trip in trips)
            {
                foreach (var comp in trip.Companions)
                {
                    if (comp.Login == companion.Login && trip.Date < DateTime.Now)
                        form.listTripHistory.Items.Add(trip.TripInfo());
                }
            }

            form.ShowDialog();
        }

        private void txtDeparture_Enter(object sender, EventArgs e)
        {
            if (txtDeparture.Text == "Звідки?")
                txtDeparture.Text = "";
        }

        private void txtDeparture_Leave(object sender, EventArgs e)
        {
            if (txtDeparture.Text.Length == 0)
                txtDeparture.Text = "Звідки?";
        }

        private void txtDestination_Enter(object sender, EventArgs e)
        {
            if (txtDestination.Text == "Куди?")
                txtDestination.Text = "";
        }

        private void txtDestination_Leave(object sender, EventArgs e)
        {
            if (txtDestination.Text.Length == 0)
                txtDestination.Text = "Куди?";
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm form = new UserProfileForm();
            form.lblLogin.Text = companion.Login;
            form.txtBoxName.Text = companion.Name;
            form.txtBoxPassword.Text = companion.Password;
            form.txtBoxPhoneNumber.Text = companion.PhoneNumber;
            form.pctPhoto.Image = Image.FromFile(companion.PhotoPath);
            form.ShowDialog();
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

        static void SaveTripsToFileJson(List<Trip> trips, string path)
        {
            try
            {
                string jsonstring = "";
                jsonstring = JsonSerializer.Serialize(trips);
                File.WriteAllText(path, jsonstring);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchTrips_Click(object sender, EventArgs e)
        {
            listFoundTrips.Items.Clear();
            pointOfDeparture = txtDeparture.Text;
            destination = txtDestination.Text;
            numberOfSeats = short.Parse(nmrcUpDownSeats.Text);
            date = dtTimePickerDate.Value;

            listFoundTrips.Visible = true;
            lstBoxHeaders.Visible = true;
            btnBookPlace.Visible = true;

            if (companion.SearchTrip(date, numberOfSeats, pointOfDeparture, destination))
            {
                var foundTrips = trips.Where(x => x.Destination == destination &&
                    x.PointOfDeparture == pointOfDeparture &&
                    x.NumberOfSeats >= numberOfSeats && x.Date.Year == date.Year &&
                    x.Date.Month == date.Month && x.Date.Day == date.Day).ToList();

                foreach (var trip in foundTrips)
                    listFoundTrips.Items.Add(trip.TripInfo());
            }

        }

        private void btnBookPlace_Click(object sender, EventArgs e)
        {
            try
            {
                string tripInfo = listFoundTrips.SelectedItem.ToString();
                string[] splitTripInfo = tripInfo.Split(",");
                foreach (var foundTrip in trips)
                {
                    if (foundTrip.Number == int.Parse(splitTripInfo[0]))
                    {
                        if (companion!.BookPlace(foundTrip.Number, numberOfSeats, trips))
                        {
                            foundTrip.AddCompanion(companion);
                            short foundTripNumberOfSeats = foundTrip.NumberOfSeats;
                            short numberOfSeatsRequired = (short)(foundTripNumberOfSeats - numberOfSeats);
                            foundTrip.NumberOfSeats = numberOfSeatsRequired;
                            MessageBox.Show("Місце успішно заброньовано", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                SaveTripsToFileJson(trips, "trips.json");
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть поїздку!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPlannedTrips_Click(object sender, EventArgs e)
        {
            PlannedTravelsForm form = new();
            foreach (var trip in trips!)
            {
                foreach (var comp in trip.Companions)
                {
                    if (comp.Login == companion!.Login && trip.Date > DateTime.Now)
                        form.listTripsPlanned.Items.Add(trip.TripInfo());
                }
            }

            form.ShowDialog();
        }
    }
}
