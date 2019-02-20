using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class User
    {
        public int id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public User() { }
        public User(string Username,string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public Boolean validate()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
            {
                return true;
            }
            return false;
        }
    }
}
