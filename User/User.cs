using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class User : Person
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Street { get; set; }
        public User() : base()
        {
            Nickname = "";
            Password = "";
        }
        public User(string name, string surname,string street) : base(name, surname) 
        {
            Street = street;
        }
    }
}
