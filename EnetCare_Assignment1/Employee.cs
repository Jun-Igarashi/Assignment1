using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnetCare
{
    public class Employee
    {
        string Username { get; set; }
        string Fullname { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string Address { get; set; }
        Type type { get; set; }
        DistributionCenter Associated { get; set; }


        public enum Type
        {
            Agent,
            Docor,
            Manager
        }

        public void Employee()
        {
        }

        public void Employee(string username, string fullname, string email, string password, string address, Type type)
        {
            Username = username;
            Fullname = fullname;
            Email = email;
            Password = password;
            Address = address;
            this.type = type;
        }
    }
}