using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Dykun_UIClasses
{
    public partial class DriverMainForm : Form
    {
        string pointOfDeparture = "";
        string destination = "";
        short numberOfAvailableSeats = 0;
        DateTime date = new DateTime();
        List<Trip>? trips = new();
        Driver? driver = new Driver();

        public DriverMainForm()
        {
            InitializeComponent();
            trips = ReadTripsFromFileJson("trips.json");

            try
            {
                driver = JsonSerializer.Deserialize<Driver>(File.ReadAllText("User.json"));
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

        private void btnViewTripHistory_Click(object sender, EventArgs e)
        {
            TravelHistoryForm form = new TravelHistoryForm();
            var driverTrips = trips!.Where(t => t.Driver.Login == driver!.Login && t.Date < DateTime.Now).ToList();
            foreach (var trip in driverTrips)
                form.listTripHistory.Items.Add(trip.TripInfo());
            form.ShowDialog();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            UserProfileForm form = new UserProfileForm();
            form.lblLogin.Text = driver!.Login;
            form.txtBoxName.Text = driver.Name;
            form.txtBoxPassword.Text = driver.Password;
            form.txtBoxPhoneNumber.Text = driver.PhoneNumber;
            form.pctPhoto.Image = Image.FromFile(driver.PhotoPath);
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateTrip_Click(object sender, EventArgs e)
        {
            date = dtTimePickerTripDate.Value;
            pointOfDeparture = txtDeparture.Text;
            destination = txtDestination.Text;
            numberOfAvailableSeats = short.Parse(nmrcUpDownSeats.Text);

            if (driver!.CreateTrip(date, numberOfAvailableSeats, pointOfDeparture, destination))
            {
                Trip trip = new Trip(date, pointOfDeparture, destination, numberOfAvailableSeats, driver);
                trips!.Add(trip);
                SaveTripsToFileJson(trips, "trips.json");
                trips = ReadTripsFromFileJson("trips.json");
                txtDeparture.Text = "";
                txtDestination.Text = "";
                nmrcUpDownSeats.ResetText();

                MessageBox.Show("Поїздку успішно створено", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else if (pointOfDeparture.Length < 3)
                MessageBox.Show("Введіть місце відправки", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (destination.Length < 3)
                MessageBox.Show("Введіть місце призначення", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (date < DateTime.Now)
                MessageBox.Show("Оберіть коректну дату поїздки", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnPlannedTrips_Click(object sender, EventArgs e)
        {
            PlannedTravelsForm form = new ();
            var driverTrips = trips!.Where(t => t.Driver.Login == driver!.Login && t.Date > DateTime.Now).ToList();
            foreach (var trip in driverTrips)
                form.listTripsPlanned.Items.Add(trip.TripInfo());
            form.ShowDialog();
        }
    }
}
