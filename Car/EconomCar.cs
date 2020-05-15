using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiService
{
    [Serializable]
    public class EconomCar : Car
    {
        public bool IsChildSeat { get; set; }
        public bool IsWheelChair { get; set; }
        public EconomCar() : base()
        {
            IsChildSeat = false;
            IsWheelChair = false;
        }
        public EconomCar(string name, string model, string number, int seats, Taxist taxist, bool isChildSeat, bool isWheelChair) : base(name, model, number, seats, taxist)
        {
            this.IsChildSeat = isChildSeat;
            this.IsWheelChair = isWheelChair;
        }

        public EconomCar(int numberOfSeats, bool isChildSeat, bool isWheelChair, User user) : base(numberOfSeats)
        {
            this.IsChildSeat = isChildSeat;
            this.IsWheelChair = isWheelChair;
            User = user;
        }

        public EconomCar isMatch(EconomCar car)
        {
            if (IsChildSeat == car.IsChildSeat &&
                IsWheelChair == car.IsWheelChair &&
                this.NumberOfSeats >= car.NumberOfSeats)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        //public EconomCar isMatchTaxistWork(List<EconomCar> usersEconomBase, District district,ref User user)
        //{
        //    EconomCar rightCar;
        //    for (int i = 0; i < usersEconomBase.Count; ++i)
        //    {
        //        if (usersEconomBase[i].IsChildSeat == this.IsChildSeat &&
        //        usersEconomBase[i].IsWheelChair == this.IsWheelChair &&
        //        usersEconomBase[i].NumberOfSeats <= this.NumberOfSeats &&
        //        district.districts.Contains(usersEconomBase[i].User.Street))
        //        {
        //            user = usersEconomBase[i].User;
        //            rightCar = usersEconomBase[i];
        //            return rightCar;
        //        }
        //    }
        //    return null;
        //}


        public User UserMatchTaxistWork(List<EconomCar> usersEconomBase, District district)
        {
            User user;
            for (int i = 0; i < usersEconomBase.Count; ++i)
            {
                if (usersEconomBase[i].IsChildSeat == this.IsChildSeat &&
                usersEconomBase[i].IsWheelChair == this.IsWheelChair &&
                usersEconomBase[i].NumberOfSeats <= this.NumberOfSeats &&
                district.districts.Contains(usersEconomBase[i].User.Street))
                {
                    user = usersEconomBase[i].User;
                    return user;
                }
            }
            return null;
        }
    }
}
