using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    [Serializable]
    public class Truck : Car
    {
        public int KilogramsCargo { get; set; }
        public int MaxKilogramsOfCargo { get; set; }
        public Truck() : base()
        {
            KilogramsCargo = 0;
            MaxKilogramsOfCargo = 0;
        }
        public Truck(string name, string model, string number, int seats, Taxist taxist, int maxKilogramsOfCargo) : base(name, model, number, seats, taxist)
        {
            this.MaxKilogramsOfCargo = maxKilogramsOfCargo;
        }

        public Truck(int numberOfSeats, int kilogramsCargo,User user) : base(numberOfSeats)
        {
            this.KilogramsCargo = kilogramsCargo;
            User = user;
        }


        public Truck isMatch(Truck car)
        {
            if (this.MaxKilogramsOfCargo >= car.KilogramsCargo &&
                this.NumberOfSeats >= car.NumberOfSeats)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public User UserMatchTaxistWork(List<Truck> usersTruckBase, District district)
        {
            User user;
            for (int i = 0; i < usersTruckBase.Count; ++i)
            {
                if (usersTruckBase[i].KilogramsCargo <= this.MaxKilogramsOfCargo &&
                usersTruckBase[i].NumberOfSeats <= this.NumberOfSeats &&
                district.districts.Contains(usersTruckBase[i].User.Street))
                {
                    user = usersTruckBase[i].User;
                    return user;
                }
            }
            return null;
        }
    }
}
