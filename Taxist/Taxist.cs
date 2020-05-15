using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    [Serializable]
    public class Taxist : Person
    {

        public string Nickname { get; set; }
        public string Password { get; set; }
        public Car car;
        //public string CurrentAdress { get; set; }
        public Taxist() : base()
        {
            Nickname = "";
            Password = "";
            car = null;
        }
        public Taxist(string name, string surname) : base(name, surname) { car = null; }
        public void AddTaxist(string name, string surname, DateTime dateTime, string nickname, string password)
        {
            Name = name;
            Surname = surname;
            birthDate = dateTime;
            Nickname = nickname;
            Password = password;
        }
    }
}
