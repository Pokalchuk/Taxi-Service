using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    [Serializable]
    public class Car
    {
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarNumber { get; set; }
        public int NumberOfSeats { get; set; }
        public Taxist taxist;
        public User User;
        public Car(string name,string model,string number,int seats,Taxist taxist)
        {
            CarName = name;
            CarModel = model;
            CarNumber = number;
            NumberOfSeats = seats;
            this.taxist = taxist;
        }
        public Car()
        {
            CarName = "";
            CarModel = "";
            CarNumber = "";
            NumberOfSeats = 0;
            taxist = null;
        }
        public Car(int numberOfSeats)
        {
            NumberOfSeats = numberOfSeats;
        }
    }
}
