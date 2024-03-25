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
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public override string Password
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public Administrator(string login, string password)
        {
            throw new NotImplementedException();
        }

        public override bool Authorization(string login, string password, List<User> users)
        {
            throw new NotImplementedException();
        }

        public bool BlockUser(string userLogin, ref List<User> users)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTrip(int tripNumber, DateTime date, ref List<Trip> trips)
        {
            throw new NotImplementedException();
        }
    }

}
