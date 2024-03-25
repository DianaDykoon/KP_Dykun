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
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public DateTime Date
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string PointOfDeparture
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public string Destination
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public short NumberOfSeats
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Driver Driver
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Trip(DateTime date, string pointOfDeparture, string destination, string numberOfSeats, Driver driver)
        {
            throw new NotImplementedException();
        }

        public string TripInfo()
        {
            throw new NotImplementedException();
        }
    }

}
