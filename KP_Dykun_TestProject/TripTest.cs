using KP_Dykun_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_TestProject
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void TripInfoTest()
        {
            // Arrange
            Driver driver = new("Jackson07", "1234567", "+38(099)-7843126", "Jackson");
            Trip trip = new(new DateTime(2024, 5, 30), "Kharkiv", "Poltava", 2, driver);

            string expected = "Jackson, 30.5.2024, Kharkiv, Poltava, 2";

            // Act
            string actual = trip.TripInfo();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
