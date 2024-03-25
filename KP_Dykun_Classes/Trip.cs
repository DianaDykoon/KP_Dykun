using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public class Trip : ITrip
    {
        static int currentNumber = 1;
        [Key]
        private int _number;
        private DateTime _date;
        private string _pointOfDeparture;
        private string _destination;
        private short _NumberOfSeats;
        private Driver _driver;
        public List<Companion> companions;

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string PointOfDeparture
        {
            get { return _pointOfDeparture; }
            set { _pointOfDeparture = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public short NumberOfSeats
        {
            get { return _NumberOfSeats; }
            set { _NumberOfSeats = value; }
        }

        public Driver Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }

        public Trip(DateTime date, string pointOfDeparture, string destination, short numberOfSeats, Driver driver)
        {
            Date = date;
            PointOfDeparture = pointOfDeparture;
            Destination = destination;
            NumberOfSeats = numberOfSeats;
            Driver = driver;
            companions = new List<Companion>();
            Number = currentNumber++;
        }

        public string TripInfo()
        {
            return $"{Driver.Name}, {Date.Day}.{Date.Month}.{Date.Year}, {PointOfDeparture}, " +
                $"{Destination}, {NumberOfSeats}";
        }
    }

}
