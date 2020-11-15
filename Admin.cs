using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_OOP
{
    class Admin : Person
    {
        public Admin(string name, string adress, string phoneNumber, string login, string password)
        {
            this.Name = name;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Login = login;
            this.Password = password;
        }

    }

}
