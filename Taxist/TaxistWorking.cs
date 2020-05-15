using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TaxiService
{
    public partial class TaxistWorking : Form
    {
        //public District districts;
        public bool IsAccepted;
        public Car carTaxist;
        public District district;
        public Car rightCar;
        public User user;
        public TaxistWorking(Car car)
        {
            InitializeComponent();
            carTaxist = car;
            user = new User();
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\ButtonClick.wav");
            click.Play();
            comboBoxDistrict.Enabled = false;
            district = new District(comboBoxDistrict.SelectedItem.ToString());
            List<EconomCar> usersEconomBase = new List<EconomCar>();
            List<LuxuryCar> usersLuxuryBase = new List<LuxuryCar>();
            List<Truck> usersTruckBase = new List<Truck>();

            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\XML\UserBase\UsersEconomCars.xml"))
            {
                usersEconomBase = (List<EconomCar>)xmlSerializerEconom.Deserialize(stream);
            }

            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\XML\UserBase\UsersLuxuryCars.xml"))
            {
                usersLuxuryBase = (List<LuxuryCar>)xmlSerializerLuxury.Deserialize(stream);
            }

            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.OpenRead(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\XML\UserBase\UsersTrucks.xml"))
            {
                usersTruckBase = (List<Truck>)xmlSerializerTruck.Deserialize(stream);
            }

            if(carTaxist is EconomCar)
            {
                user = ((EconomCar)carTaxist).UserMatchTaxistWork(usersEconomBase, district);

             
                ///The method above is used instead of the code below
                //rightCar = new EconomCar();
                //for (int i = 0; i < usersEconomBase.Count; ++i)
                //{
                //    if (usersEconomBase[i].IsChildSeat == ((EconomCar)carTaxist).IsChildSeat &&
                //    usersEconomBase[i].IsWheelChair == ((EconomCar)carTaxist).IsWheelChair &&
                //    usersEconomBase[i].NumberOfSeats <= carTaxist.NumberOfSeats &&
                //    district.districts.Contains(usersEconomBase[i].User.Street))
                //    {
                //        user = usersEconomBase[i].User;
                //        rightCar = usersEconomBase[i];
                //        break;
                //    }
                //}
            }
            else if(carTaxist is LuxuryCar)
            {
                user = ((LuxuryCar)carTaxist).UserMatchTaxistWork(usersLuxuryBase, district);

                ///The method above is used instead of the code below
                //rightCar = new LuxuryCar();
                //MessageBox.Show("LuxuryCar");
                //for (int i = 0; i < usersLuxuryBase.Count; ++i)
                //{
                //    if (usersLuxuryBase[i].IsAlcohol == ((LuxuryCar)carTaxist).IsAlcohol &&
                //    usersLuxuryBase[i].IsTv == ((LuxuryCar)carTaxist).IsTv &&
                //    usersLuxuryBase[i].NumberOfSeats <= carTaxist.NumberOfSeats &&
                //    district.districts.Contains(usersLuxuryBase[i].User.Street))
                //    {
                //        user = usersLuxuryBase[i].User;
                //        rightCar = usersLuxuryBase[i];
                //        break;
                //    }
                //}

            }
            else if(carTaxist is Truck)
            {
                user = ((Truck)carTaxist).UserMatchTaxistWork(usersTruckBase, district);

                ///The method above is used instead of the code below
                //rightCar = new Truck();
                //MessageBox.Show("Truck");
                //for (int i = 0; i < usersTruckBase.Count; ++i)
                //{
                //    if (usersTruckBase[i].KilogramsCargo <= ((Truck)carTaxist).MaxKilogramsOfCargo &&
                //    usersTruckBase[i].NumberOfSeats <= carTaxist.NumberOfSeats &&
                //    district.districts.Contains(usersTruckBase[i].User.Street))
                //    {
                //        user = usersTruckBase[i].User;
                //        rightCar = usersTruckBase[i];
                //        break;
                //    }
                //}
            }
            this.Hide();
            TaxistWorkInfo taxistWorkInfo = new TaxistWorkInfo(user);
            taxistWorkInfo.ShowDialog();
            this.Close();
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer @switch = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            @switch.Play();
        }
    }
}
