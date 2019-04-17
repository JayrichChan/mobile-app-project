using System;
using System.Collections.Generic;
using System.Text;

namespace project.Models
{
    class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Users() { }
        public Users(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }

        public bool CheckInput()
        {
            if (!this.Username.Equals("") && !this.Password.Equals(""))
                return true;
            else
                return false;
        }

    }
}
