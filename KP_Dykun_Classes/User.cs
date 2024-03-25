using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KP_Dykun_Classes
{
    public abstract class User
    {
        public abstract string Login { get; set; }
        public abstract string Password { get; set; }
        public abstract bool Authorization(string login, string password, List<User> users);
    }

}
