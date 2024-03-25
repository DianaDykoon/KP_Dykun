using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public class Companion : User
    {
        private string _login;
        private string _password;
        private string _phoneNumber;
        private string _name;
        private byte[] _photo;

        public override string Login
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override string Password
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string PhoneNumber
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public string Name
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public byte[] Photo
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Companion(string login, string password, string phoneNumber, string name)
        {
        }

        public override bool Authorization(string login, string password, List<User> users)
        {
            throw new NotImplementedException();
        }

        public bool Registration(string login, string password, string name, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public bool SearchTrip(DateTime date, short numberOfSeatsRequired, string pointOfDeparture, string destination)
        {
            throw new NotImplementedException();
        }

        public bool BookPlace(int tripNumber, short numberOfSeatsRequired, DateTime date, List<Trip> trips)
        {
            throw new NotImplementedException();
        }

        public List<Trip> ViewTripHistory(string login, List<Trip> trips)
        {
            throw new NotImplementedException();
        }

        public bool RateDriver(int numberOfTrip, Driver driver, int grade, List<Trip> trips)
        {
            throw new NotImplementedException();
        }

        public bool LoadPhoto(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProfile(string password, string name, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public string CompanionInfo()
        {
            throw new NotImplementedException();
        }
    }

}
