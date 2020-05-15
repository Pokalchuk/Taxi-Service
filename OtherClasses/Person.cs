using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaxiService
{
    enum TypeOfPerson
    {
        USER = 1, TAXIST = 2
    };
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        [XmlIgnore]
        public DateTime birthDate;
        public Person()
        {
            Name = "";
            Surname = "";
        }

        public Person(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public Person(string name,string surname,DateTime dateTime)
        {
            Name = name;
            Surname = surname;
            birthDate = dateTime;
        }
      
        public DateTime AddBirthDate(int year,int month,int day)
        {
            birthDate = new DateTime(year, month, day);
            return birthDate;
        }

        
    }
}
