using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiService
{
    public partial class DetailsArrivalCar : Form
    {
        public Car car;
        public static int CheckPrice(Car car)
        {
            Random rand = new Random();
            if(car is EconomCar)
            {
                int price = 32;
                if (((EconomCar)car).IsChildSeat)
                {
                    price += 10;
                }
                if (((EconomCar)car).IsWheelChair)
                {
                    price += 10;
                }
                if (((EconomCar)car).NumberOfSeats>=3)
                {
                    price += 5;
                }
                price += rand.Next(10);
                return price;
            }
            else if (car is LuxuryCar)
            {
                int price = 65;
                if (((LuxuryCar)car).IsAlcohol)
                {
                    price += 25;
                }
                if (((LuxuryCar)car).IsTv)
                {
                    price += 30;
                }
                price += rand.Next(25);
                return price;
            }
            else if (car is Truck)
            {
                int price = 45;
                price += (((Truck)car).MaxKilogramsOfCargo/100);
                price += rand.Next(15);
                return price;
            }
            else{ return 0; }
        }
        public DetailsArrivalCar(Car _car,bool isEnglish)
        {
            InitializeComponent();
            car = _car;
            labelCarNameChange.Text = car.CarName;
            labelCarModelChange.Text = car.CarModel;
            labelCarNumberChange.Text = car.CarNumber;
            labelTaxistNameChange.Text = car.taxist.Name;
            labelPriceCheck.Text = CheckPrice(car).ToString() + " UAH";
            Random rand = new Random();
            DateTime currentTime = DateTime.Now;
            DateTime FewMinutesLater = currentTime.AddMinutes(rand.Next(10));
            labelTime.Text = FewMinutesLater.ToString("HH:mm:ss tt");
            Image image = null;
            pictureBoxCar.SizeMode = PictureBoxSizeMode.StretchImage;   
            if (car is EconomCar)
            {
                image = Image.FromFile($@"..\..\Images\EconomCar.jpg");
            }
            else if (car is LuxuryCar)
            {
                image = Image.FromFile($@"..\..\Images\LuxuryCar.jpg");
            }
            else if (car is Truck)
            {
                image = Image.FromFile($@"..\..\Images\Truck.jpg");
            }
            pictureBoxCar.Image = image;

            if(isEnglish)
            {
                labelCarName.Text = "Car name:";
                labelCarModel.Text = "Car model:";
                labelCarNumber.Text = "Car number:";
                labelTaxistName.Text = "Taxist name:";
                labelArrivalTime.Text = "Arrival time:";
                labelPrice.Text = "Price:";
                 
            }
            else
            {
                labelCarName.Text = "Марка:";
                labelCarModel.Text = "Модель:";
                labelCarNumber.Text = "Номер:";
                labelTaxistName.Text = "Ім'я таксиста:";
                labelArrivalTime.Text = "Час прибуття:";
                labelPrice.Text = "Ціна:";
            }

        }
        private void buttonOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
