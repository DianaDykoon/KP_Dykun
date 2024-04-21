using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public class Driver : User
    {
        private string _login;
        private string _password;
        private string _phoneNumber;
        private string _name;
        private byte[] _photo;

        //public List<int> _tripNumbers = new ();

        public override string Login
        {
            get => _login;
            set => _login = value;
        }

        public override string Password
        {
            get => _password;
            set => _password = value;
        }

        [JsonPropertyName("Phone number")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public byte[] Photo
        {
            get => _photo;
            set => _photo = value;
        }

        public Driver(string login, string password, string phoneNumber, string name)
        {
            Login = login;
            Password = password;
            PhoneNumber = phoneNumber;
            Name = name;
        }

        public Driver() { }

        public override bool Authorization(string login, string password, List<User> users)
        {
            var p = users.Where(s => s.Login == login).ToList();
            if (p.Count == 0)
            {
                return false;
            }
            var k = users.Where(s => s.Login == login && s.Password == password).ToList();
            if (k.Count == 0 || k[0] is not Driver)
                return false;
            return true;
        }

        public bool Registration(string login, string password, string name, string phoneNumber)
        {
            string pattern = @"^\+38\(\d{3}\)-\d{7}$";
            if (login.Length < 4 || password.Length < 7 || string.IsNullOrEmpty(name))
                return false;

            if (!Regex.IsMatch(phoneNumber, pattern))
                return false;

            return true;
        }

        public bool CreateTrip(DateTime date, short numberOfAvailableSeats, string pointOfDeparture, string destination)
        {
            if (numberOfAvailableSeats < 1)
                return false;
            if (date < DateTime.Now)
                return false;
            if (string.IsNullOrEmpty(destination) || string.IsNullOrEmpty(pointOfDeparture))
                return false;

            return true;
        }

        public List<Trip> ViewTripHistory(string login, List<Trip> trips)
        {
            List<Trip> driverTrip = new List<Trip>();
            foreach (var trip in trips)
            {
                if (trip.Driver.Login == login)
                    driverTrip.Add(trip);
            }
            return driverTrip;
        }

        public bool LoadPhoto(string filePath)
        {
            if (!File.Exists(filePath))
                return false;
            string[] allowedFormat = { ".bmp", ".jpg" };
            string extension = Path.GetExtension(filePath).ToLower();
            if (!allowedFormat.Contains(extension))
                return false;

            Photo = File.ReadAllBytes(filePath);
            return true;
        }

        public bool UpdateProfile(string password, string name, string phoneNumber)
        {
            string pattern = @"^\+38\(\d{3}\)-\d{7}$";
            if (password.Length < 7 || string.IsNullOrEmpty(name))
                return false;

            if (!Regex.IsMatch(phoneNumber, pattern))
                return false;

            return true;
        }

        public string DriverInfo()
        {
            return $"{Login}, {Name}, {PhoneNumber}";
        }
    }
}
