using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_TestProject
{
    [TestClass]
    public class AdministratorTest
    {
        [TestMethod]
        public void AuthorizationTest_login_incorrect()
        {
            // Arrange
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");
            List<User> users = new List<User>();
            users.Add(admin);

            // Act
            bool actual = admin.Authorization("Admin7", "admin@1007_", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_password_incorrect()
        {
            // Arrange
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");
            List<User> users = new List<User>();
            users.Add(admin);

            // Act
            bool actual = admin.Authorization("Admin1007", "admin1007", users);

            // Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void AuthorizationTest_login_password_correct()
        {
            // Arrange
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");

            List<User> users = new List<User>();
            users.Add(admin);

            // Act
            bool actual = admin.Authorization("Admin1007", "admin@1007_", users);

            // Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void BlockUserTest_block_driver()
        {
            // Arrange
            List<User> users = new List<User>();
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");

            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");
            users.Add(driver);


            // Act
            bool actual = admin.BlockUser("Jackson07", ref users);

            // Assert
            Assert.IsTrue(actual);
            Assert.AreEqual(0, users.Count);
        }

        [TestMethod]
        public void BlockUserTest_block_companion()
        {
            // Arrange
            List<User> users = new List<User>();
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");

            Companion companion = new("Alex10", "1234567", "+38(099)-9811127", "Alex");
            users.Add(companion);

            // Act
            bool actual = admin.BlockUser("Alex10", ref users);

            // Assert
            Assert.IsTrue(actual);
            Assert.AreEqual(0, users.Count);
        }

        [TestMethod]
        public void DeleteTripTest_Trip_already_taken_place()
        {
            // Arrange
            List<Trip> trips = new List<Trip>();
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");

            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");
            Trip trip = new(new DateTime(2024, 3, 10), "Kharkiv", "Poltava", 2, driver);
            trips.Add(trip);

            // Act
            bool actual = admin.DeleteTrip(trip.Number, new DateTime(2024, 3, 10), ref trips);

            // Assert
            Assert.IsFalse(actual);
            Assert.AreEqual(1, trips.Count);
        }

        [TestMethod]
        public void DeleteTripTest_Trip_not_yet_taken_place()
        {
            // Arrange
            List<Trip> trips = new List<Trip>();
            string login = "Admin1007";
            Administrator admin = new(login, "admin@1007_");

            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");
            Trip trip = new(new DateTime(2024, 5, 30), "Kharkiv", "Poltava", 2, driver);
            trips.Add(trip);

            // Act
            bool actual = admin.DeleteTrip(trip.Number, new DateTime(2024, 5, 30), ref trips);

            // Assert
            Assert.IsTrue(actual);
            Assert.AreEqual(0, trips.Count);
        }
    }
}
