using System;
using System.Collections.Generic;
using System.Text;

namespace Projet_OOP
{
    class Teacher : Person
    {

        List<Student> GroupStudents { get; set; }

        public Teacher(string name, string adress, string phoneNumber, string login, string password, List<Student> students)
        {
            this.Name = name;
            this.Adress = adress;
            this.PhoneNumber = phoneNumber;
            this.Login = login;
            this.Password = password;
            this.GroupStudents = students;
        }
    }

}
