using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_TestProject
{
    [TestClass]
    public class CompanionTest
    {
        [TestMethod]
        public void AuthorizationTest_login_incorrect()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            List<User> users = new List<User>();
            users.Add(companion);

            // Act
            bool actual = companion.Authorization("Alex", "1234567", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_password_incorrect()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            List<User> users = new List<User>();

            users.Add(companion);

            // Act
            bool actual = companion.Authorization("Alex", "7654321", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_login_password_correct()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            List<User> users = new List<User>();
            users.Add(companion);

            // Act
            bool actual = companion.Authorization("Alex10", "1234567", users);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RegistrationTest_login_length_less_4()
        {
            // Arrange
            string login = "A";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.Registration(login, "1234567", "Alex", "+38(099)-9811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_password_length_less_7()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "123", "+38(099)-9811127", "Jackson");

            // Act
            bool actual = companion.Registration("Alex10", "123", "Alex", "+38(099)-9811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_name_empty()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "");

            // Act
            bool actual = companion.Registration("Alex10", "1234567", "", "+38(099)-9811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_phoneNumber_invalid_format()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "0999811127", "Alex");

            // Act
            bool actual = companion.Registration("Alex10", "1234567", "Alex", "0999811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void RegistrationTest_correct()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.Registration("Alex10", "1234567", "Alex", "+38(099)-9811127");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void SearchTripTest_date_incorrect()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.SearchTrip(new DateTime(2024, 3, 12), 3, "Kharkiv", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SearchTripTest_numberOfSeatsRequired_less_1()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.SearchTrip(new DateTime(2024, 5, 29), 0, "Kharkiv", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SearchTripTest_pointOfDeparture_empty()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.SearchTrip(new DateTime(2024, 5, 29), 2, "", "Poltava");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void SearchTripTest_correct()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            bool actual = companion.SearchTrip(new DateTime(2024, 5, 29), 1, "Kharkiv", "Poltava");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void BookPlaceTest_trip_not_found()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");
            List<Trip> trips = new List<Trip>();

            // Act
            bool actual = companion.BookPlace(1, 1, trips);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void BookPlaceTest_trip_found_date_correct()
        {
            // Arrange
            List<Trip> trips = new List<Trip>();
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");
            Trip trip = new Trip(new DateTime(2024, 3, 18), "Kharkiv", "Poltava", 2, driver);
            trips.Add(trip);


            // Act
            bool actual = companion.BookPlace(trip.Number, 1, trips);

            // Assert
            Assert.IsTrue(actual);
        }


        [TestMethod]
        public void ViewTripHistoryTest_2_trips()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");

            Trip trip = new Trip(new DateTime(2024, 3, 10), "Kharkiv", "Poltava", 2, driver);
            trip.Companions.Add(companion);
            Trip trip2 = new Trip(new DateTime(2024, 3, 12), "Poltava", "Kharkiv", 2, driver);
            trip2.Companions.Add(companion);

            trips.Add(trip);
            trips.Add(trip2);

            // Act
            List<Trip> companionTrips = companion.ViewTripHistory(login, trips);

            // Assert
            Assert.AreEqual(2, companionTrips.Count);
        }

        [TestMethod]
        public void ViewTripHistoryTest_0_trips()
        {
            // Arrange
            List<Trip> trips = new();
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");

            // Act
            List<Trip> companionTrips = companion.ViewTripHistory(login, trips);

            // Assert
            Assert.AreEqual(0, companionTrips.Count);
        }

        [TestMethod]
        public void LoadPhotoTest_incorrect_format()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");
            string path = "C:\\Users\\User\\Pictures\\VRChat\\2024-01\\VRChat_2024-01-08_03-40-33.861_1920x1080.png";

            // Act
            bool actual = companion.LoadPhoto(path);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void LoadPhotoTest_correct_format()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");
            string path = "C:\\Users\\User\\Pictures\\Image_20230414_0001.jpg";

            // Act
            bool actual = companion.LoadPhoto(path);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_password_length_less_7()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "12345678", "+38(099)-9811127", "Alex");
            companion.Registration("Alex10", "12345678", "Alex", "+38(099)-9811127");

            // Act
            bool actual = companion.UpdateProfile("123", "Alex", "+38(099)-9811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_name_empty()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "12345678", "+38(099)-9811127", "Alex");
            companion.Registration("Alex10", "12345678", "Alex", "+38(099)-9811127");

            // Act
            bool actual = companion.UpdateProfile("12345678", "", "+38(099)-9811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_phoneNumber_invalid_format()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");
            companion.Registration("Alex10", "12345678", "Alex", "+38(099)-9811127");

            // Act
            bool actual = companion.UpdateProfile("12345678", "Alex", "0999811127");

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void UpdateProfileTest_correct()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "12345678", "+38(099)-9811127", "Alex");
            companion.Registration("Alex10", "12345678", "Alex", "+38(099)-9811127");

            // Act
            bool actual = companion.UpdateProfile("987654321", "Alex", "+38(099)-9811127");

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CompanionInfoTest()
        {
            // Arrange
            string login = "Alex10";
            Companion companion = new(login, "1234567", "+38(099)-9811127", "Alex");
            companion.Registration("Alex10", "1234567", "Alex", "+38(099)-9811127");

            string expected = "Alex10, Alex, +38(099)-9811127";

            // Act
            string actual = companion.CompanionInfo();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
