using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public class Administrator : User
    {
        private string _login;
        private string _password;

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

        public Administrator(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override bool Authorization(string login, string password, List<User> users)
        {
            var p = users.Where(s => s.Login == login).ToList();
            if (p.Count == 0)
            {
                return false;
            }
            var k = users.Where(s => s.Login == login && s.Password == password).ToList();
            if (k.Count == 0)
                return false;
            return true;
        }

        public bool BlockUser(string userLogin, ref List<User> users)
        {
            var user = users.Where(p => p.Login == userLogin).FirstOrDefault();
            if (user is not null)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }

        public bool DeleteTrip(int tripNumber, DateTime date, ref List<Trip> trips)
        {
            var trip = trips.Where(p => p.Number == tripNumber).FirstOrDefault();
            if (trip is null)
                return false;

            if (trip.Date < DateTime.Now)
                return false;

            trips.Remove(trip);
            return true;
        }
    }

}
