using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace KP_Dykun_Classes
{
    public class Companion : User
    {
        public delegate void CompanionHandler(string message);
        public event CompanionHandler? Notify;

        private string _login;
        private string _password;
        private string _phoneNumber;
        private string _name;
        private string _photoPath;

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

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [JsonPropertyName("Phone number")]
        public string PhoneNumber
        {
            get => _phoneNumber;
            set => _phoneNumber = value;
        }

        

        public string PhotoPath
        {
            get => _photoPath;
            set => _photoPath = value;
        }

        public Companion(string login, string password, string phoneNumber, string name)
        {
            _login = login;
            _password = password;
            _phoneNumber = phoneNumber;
            _name = name;
        }

        public Companion() { }

        public override bool Authorization(string login, string password, List<User> users)
        {
            var p = users.Where(s => s.Login == login).ToList();
            if (p.Count == 0)
            {
                return false;
            }
            var k = users.Where(s => s.Login == login && s.Password == password).ToList();
            if (k.Count == 0 || k[0] is not Companion)
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

        public bool SearchTrip(DateTime date, short numberOfSeatsRequired, string pointOfDeparture, string destination)
        {
            if (date < DateTime.Now || numberOfSeatsRequired < 1)
                return false;

            if (string.IsNullOrEmpty(pointOfDeparture) || string.IsNullOrEmpty(destination))
                return false;

            return true;
        }

        public bool BookPlace(int tripNumber, short numberOfSeatsRequired, List<Trip> trips)
        {
            var trip = trips.Where(t => t.Number == tripNumber).FirstOrDefault();
            if (trip is null)
            {
                Notify?.Invoke($"Поїздки з номером {tripNumber} не існує.");
                return false;
            }

            if (numberOfSeatsRequired > trip.NumberOfSeats)
            {
                Notify?.Invoke($"Недостатня кількість місць.");
                return false;
            }
            
            Notify?.Invoke($"Успішно заброньовано місце.");
            return true;
        }

        public List<Trip> ViewTripHistory(string login, List<Trip> trips)
        {
            List<Trip> companionTrip = new List<Trip>();
            foreach (var trip in trips)
            {
                foreach (var comTrip in trip.Companions)
                    if (comTrip.Login == login)
                        companionTrip.Add(trip);
            }
            return companionTrip;
        }

        public bool LoadPhoto(string filePath)
        {
            if (!File.Exists(filePath))
                return false;
            string[] allowedFormat = { ".bmp", ".jpg" };
            string extension = Path.GetExtension(filePath).ToLower();
            if (!allowedFormat.Contains(extension))
                return false;

            PhotoPath = filePath;
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

        public string CompanionInfo()
        {
            return $"{Login}, {Name}, {PhoneNumber}";
        }
    }

}
