using KP_Dykun_Classes;

namespace KP_Dykun_TestProject
{
    [TestClass]
    public class DriverTest
    {
        [TestMethod]
        public void AuthorizationTest_login_incorrect()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");
            List<User> users = new List<User>();

            users.Add(driver);

            // Act
            bool actual = driver.Authorization("Jackson", "1234567", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_password_incorrect()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            List<User> users = new List<User>();

            users.Add(driver);

            // Act
            bool actual = driver.Authorization("Jackson07", "7654321", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_login_password_correct()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            List<User> users = new List<User>();

            users.Add(driver);

            // Act
            bool actual = driver.Authorization("Jackson07", "1234567", users);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RegistrationTest_login_length_less_4()
        {
            // Arrange
            string login = "JJ";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.Registration(login, "1234567", "Jackson", "+38(099)-7843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_password_length_less_7()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "123", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.Registration("Jackson07", "123", "Jackson", "+38(099)-7843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_name_empty()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "");

            // Act
            bool actual = driver.Registration("Jackson07", "1234567", "", "+38(099)-7843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_phoneNumber_invalid_format()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "0997843126", "Jackson");

            // Act
            bool actual = driver.Registration("Jackson07", "1234567", "Jackson", "0997843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_correct()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver2 = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver2.Registration("Jackson07", "1234567", "Jackson", "+38(099)-7843126");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CreateTripTest_date_incorrect()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.CreateTrip(new DateTime(2024, 3, 12), 3, "Kharkiv", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CreateTripTest_numberOfAvailableSeats_less_1()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.CreateTrip(new DateTime(2024, 5, 29), 0, "Kharkiv", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CreateTripTest_pointOfDeparture_empty()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.CreateTrip(new DateTime(2024, 5, 29), 2, "", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CreateTripTest_destination_empty()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.CreateTrip(new DateTime(2024, 5, 29), 2, "Kharkiv", "");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void CreateTripTest_correct()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            bool actual = driver.CreateTrip(new DateTime(2024, 5, 29), 2, "Kharkiv", "Poltava");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void ViewTripHistoryTest_2_trips()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            Trip trip = new(new DateTime(2024, 3, 10), "Kharkiv", "Poltava", 2, driver);
            Trip trip2 = new(new DateTime(2024, 3, 12), "Poltava", "Kharkiv", 2, driver);

            trips.Add(trip);
            trips.Add(trip2);

            // Act
            List<Trip> driverTrips = driver.ViewTripHistory(login, trips);

            // Assert
            Assert.AreEqual(2, driverTrips.Count);
        }

        [TestMethod]
        public void ViewTripHistoryTest_0_trips()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            // Act
            List<Trip> driverTrips = driver.ViewTripHistory(login, trips);

            // Assert
            Assert.AreEqual(0, driverTrips.Count);
        }

        [TestMethod]
        public void RateCompanionTest_driver_not_travel_with_companion()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            Companion companion = new("Alex1", "4321123", "+38(099)-7543326", "Alex");
            Trip trip = new Trip(new DateTime(2024, 3, 12), "Kharkiv", "Poltava", 2, driver);
            trips.Add(trip);

            // Act
            bool actual = driver.RateCompanion(1, companion, 5, trips);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RateCompanionTest_grade_less_0()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            Companion companion = new("Alex1", "4321123", "+38(099)-7543326", "Alex");
            Trip trip = new Trip(new DateTime(2024, 3, 12), "Kharkiv", "Poltava", 2, driver);
            trips.Add(trip);
            trip.companions.Add(companion);

            // Act
            bool actual = driver.RateCompanion(2, companion, -2, trips);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RateCompanionTest_grade_more_0_driver_travel_with_companion()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");

            Companion companion = new("Alex1", "4321123", "+38(099)-7543326", "Alex");
            Trip trip = new Trip(new DateTime(2024, 3, 12), "Kharkiv", "Poltava", 2, driver);
            trip.companions.Add(companion);
            trips.Add(trip);


            // Act
            bool actual = driver.RateCompanion(trip.Number, companion, 5, trips);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void LoadPhotoTest_incorrect_format()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");
            string path = "C:\\Users\\User\\Pictures\\VRChat\\2024-01\\VRChat_2024-01-08_03-40-33.861_1920x1080.png";

            // Act
            bool actual = driver.LoadPhoto(path);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LoadPhotoTest_correct_format()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "1234567", "+38(099)-7843126", "Jackson");
            string path = "C:\\Users\\User\\Pictures\\Image_20230414_0001.jpg";

            // Act
            bool actual = driver.LoadPhoto(path);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_password_length_less_7()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "12345678", "+38(099)-7843126", "Jackson");
            driver.Registration("Jackson07", "12345678", "Jackson", "+38(099)-7843126");

            // Act
            bool actual = driver.UpdateProfile("123", "Jackson", "+38(099)-7843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_name_empty()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "12345678", "+38(099)-7843126", "Jackson");
            driver.Registration("Jackson07", "12345678", "Jackson", "+38(099)-7843126");

            // Act
            bool actual = driver.UpdateProfile("12345678", "", "+38(099)-7843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_phoneNumber_invalid_format()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "12345678", "+38(099)-7843126", "Jackson");
            driver.Registration("Jackson07", "12345678", "Jackson", "+38(099)-7843126");

            // Act
            bool actual = driver.UpdateProfile("12345678", "Jackson", "0997843126");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_correct()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "12345678", "+38(099)-7843126", "Jackson");
            driver.Registration("Jackson07", "12345678", "Jackson", "+38(099)-7843126");

            // Act
            bool actual = driver.UpdateProfile("987654321", "Jackson", "+38(099)-7843126");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void DriverInfoTest()
        {
            // Arrange
            string login = "Jackson07";
            Driver driver = new(login, "12345678", "+38(099)-7843126", "Jackson");
            driver.Registration("Jackson07", "12345678", "Jackson", "+38(099)-7843126");

            string expected = "Jackson07, Jackson, +38(099)-7843126";

            // Act
            string actual = driver.DriverInfo();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}