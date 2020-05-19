using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaxiService
{
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
    }
}
