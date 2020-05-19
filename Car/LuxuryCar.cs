using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    [Serializable]
    public class LuxuryCar : Car
    {
        public bool IsTv { get; set; }
        public bool IsAlcohol { get; set; }
        public LuxuryCar() : base()
        {
            IsTv = false;
            IsAlcohol = false;
        }
        public LuxuryCar(string name, string model, string number, int seats, Taxist taxist, bool isTv, bool isFreeAlcohol) : base(name, model, number, seats, taxist)
        {
            this.IsTv = isTv;
            this.IsAlcohol = isFreeAlcohol;
        }
        public LuxuryCar(int numberOfSeats, bool isTv, bool isAlcohol, User user) : base(numberOfSeats)
        {
            this.IsTv = isTv;
            this.IsAlcohol = isAlcohol;
            User = user;
        }
        public LuxuryCar IsMatch(LuxuryCar car)
        {
            if (IsTv == car.IsTv &&
                IsAlcohol == car.IsAlcohol &&
                this.NumberOfSeats >= car.NumberOfSeats)
            {
                return this;
            }
            else
            {
                return null;
            }

        }
        public User UserMatchTaxistWork(List<LuxuryCar> usersLuxuryBase, District district)
        {
            User user;
            for (int i = 0; i < usersLuxuryBase.Count; ++i)
            {
                if (usersLuxuryBase[i].IsAlcohol == this.IsAlcohol &&
                usersLuxuryBase[i].IsTv == this.IsTv &&
                usersLuxuryBase[i].NumberOfSeats <= this.NumberOfSeats &&
                district.districts.Contains(usersLuxuryBase[i].User.Street))
                {
                    user = usersLuxuryBase[i].User;
                    return user;
                }
            }
            return null;
        }
    }
}
