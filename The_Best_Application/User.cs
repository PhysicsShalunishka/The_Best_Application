using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace The_Best_Application
{
    public class User
    {
        public string Login { get; }
        public string Password { get; }
        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
        public bool IsCorrect()
        {
            if (new Database("Data Source=dataBase.db;Version=3;").ValidUser(Login, Password))
                return true;
            return false;
        }
    }
}
