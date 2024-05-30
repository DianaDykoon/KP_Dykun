using KP_Dykun_Classes;
using Microsoft.VisualBasic.ApplicationServices;
using OfficeLab;
using System.Text.Json;

namespace KP_Dykun_UIClasses
{
    public partial class AdminForm : Form
    {
        readonly List<Driver>? drivers = new();
        readonly List<Companion>? companions = new();
        List<Trip>? trips = new();

        public AdminForm()
        {
            InitializeComponent();

            drivers = ReadDriversFromFileJson("drivers.json");
            companions = ReadCompanionsFromFileJson("companions.json");
            trips = ReadTripsFromFileJson("trips.json");

            foreach (var driver in drivers!)
                listDrivers.Items.Add(driver.DriverInfo());

            foreach (var companion in companions!)
                listCompanions.Items.Add(companion.CompanionInfo());

            foreach (var trip in trips!)
                listTrips.Items.Add(trip.TripInfo());
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

        private void btnDeleteDriver_Click(object sender, EventArgs e)
        {
            try
            {
                string driverInfo = listDrivers.SelectedItem!.ToString()!;
                string[] splitDriverInfo = driverInfo.Split(",");

                drivers!.Remove(drivers.First(p => p.Login == splitDriverInfo[0]));
                SaveDriversToFileJson(drivers, "drivers.json");

                MessageBox.Show("Користувач успішно заблокован", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listDrivers.Items.Clear();

                foreach (var driver in drivers)
                    listDrivers.Items.Add(driver.DriverInfo());
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть користувача!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteCompanion_Click(object sender, EventArgs e)
        {
            try
            {
                string companionInfo = listCompanions.SelectedItem!.ToString()!;
                string[] splitCompanionInfo = companionInfo.Split(",");

                companions!.Remove(companions.First(p => p.Login == splitCompanionInfo[0]));
                SaveCompanionsToFileJson(companions, "companions.json");
                MessageBox.Show("Користувач успішно заблокован", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listCompanions.Items.Clear();

                foreach (var companion in companions)
                    listCompanions.Items.Add(companion.CompanionInfo());
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть користувача!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDeleteTrip_Click(object sender, EventArgs e)
        {
            try
            {
                Administrator administrator = new Administrator();
                string tripInfo = listTrips.SelectedItem!.ToString()!;
                string[] splitTripInfo = tripInfo.Split(",");

                // trips!.Remove(trips.First(p => p.Number == int.Parse(splitTripInfo[0])));
                var tripToDelete = trips!.FirstOrDefault(p => p.Number == int.Parse(splitTripInfo[0]));

                administrator.Notify += DisplayMessage;
                administrator.DeleteTrip(tripToDelete!.Number, tripToDelete.Date, ref trips!);

                SaveTripsToFileJson(trips, "trips.json");
                listTrips.Items.Clear();

                foreach (var trip in trips)
                    listTrips.Items.Add(trip.TripInfo());
            }
            catch (Exception)
            {
                MessageBox.Show("Спочатку оберіть поїздку!", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        static void DisplayMessage(Administrator sender, AdministratorEventArgs e)
        {
            MessageBox.Show($"Операцiя: {e.Message}\n номер поїздки: {e.TripNumber}", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteDriver.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void listCompanions_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteCompanion.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void listTrips_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDeleteTrip.Font = new Font("Segoe UI", 11, FontStyle.Bold);
        }

        private void buttonExcelExport_Click(object sender, EventArgs e)
        {

            string fileName = "CompanionsTrips";
            string fullName = $"{Directory.GetCurrentDirectory()}\\{fileName}.xlsx";
            using (ExcelDoc excelDoc = new ExcelDoc())
            {
                for (int i = 0; i < companions!.Count; i++)
                    excelDoc[i + 1, 1] = companions[i].CompanionInfo();

                excelDoc.createSheet();
                excelDoc.SaveAs(fullName);
            }
            MessageBox.Show($"Список попутників збережено у\n {fullName}", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(2000);

           // string fileNameTrips = "Trips";
           // string fullNameTrips = $"{Directory.GetCurrentDirectory()}\\{fileNameTrips}.xlsx";
            using (ExcelDoc excelDoc = new ExcelDoc(fullName))
            {
                for (int i = 0; i < trips!.Count; i++)
                    excelDoc[i + 1, 1] = trips[i].TripInfo();

                excelDoc.SaveAs(fullName);
            }
            MessageBox.Show($"Список поїздок збережено у\n {fullName}", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(2000);
        }

        private void buttonWordExport_Click(object sender, EventArgs e)
        {
            string fileNameDoc = "DriversTrips";
            string fullNameDoc = $"{Directory.GetCurrentDirectory()}\\{fileNameDoc}.docx";
            using (WordDoc wordDoc = new WordDoc())
            {

                for (int i = 0; i < drivers!.Count; i++)
                    wordDoc[i + 1] = drivers[i].DriverInfo();

                wordDoc.CreateTable(drivers.Count, 3, "Таблиця 1 – Список водіїв");

                for (int i = 0; i < drivers.Count; i++)
                {
                    string driverInfo = drivers[i].DriverInfo();
                    string[] splitDriverInfo = driverInfo.Split(",");

                    for (int j = 0; j < splitDriverInfo.Length; j++)
                    {
                        wordDoc[i + 1, j + 1] = splitDriverInfo[j];
                    }
                }
                wordDoc.SaveAs(fullNameDoc);
            }
            MessageBox.Show($"Список водіїв збережено у\n {fullNameDoc}", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(2000);

            //string fileNameDocTrips = "Trips";
            //string fullNameDocTrips = $"{Directory.GetCurrentDirectory()}\\{fileNameDocTrips}.docx";
            using (WordDoc wordDoc = new WordDoc(fullNameDoc))
            {
                wordDoc.CreateTable(trips.Count, 6, "Таблиця 2 – Список поїздок");

                for (int i = 0; i < trips.Count; i++)
                {
                    string tripInfo = trips[i].TripInfo();
                    string[] splitTripInfo = tripInfo.Split(",");

                    for (int j = 0; j < splitTripInfo.Length; j++)
                    {
                        wordDoc[i + 1, j + 1] = splitTripInfo[j];
                    }
                }

                wordDoc.SaveAs(fullNameDoc);
            }
            MessageBox.Show($"Список поїздок збережено у\n {fullNameDoc}", "Увага!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Thread.Sleep(2000);
        }
    }
}
