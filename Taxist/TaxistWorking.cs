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
            Sound.MakeSound("ButtonClick");
            comboBoxDistrict.Enabled = false;
            district = new District(comboBoxDistrict.SelectedItem.ToString());
            List<EconomCar> usersEconomBase = new List<EconomCar>();
            List<LuxuryCar> usersLuxuryBase = new List<LuxuryCar>();
            List<Truck> usersTruckBase = new List<Truck>();

            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersEconomCars.xml"))
            {
                usersEconomBase = (List<EconomCar>)xmlSerializerEconom.Deserialize(stream);
            }

            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersLuxuryCars.xml"))
            {
                usersLuxuryBase = (List<LuxuryCar>)xmlSerializerLuxury.Deserialize(stream);
            }

            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.OpenRead(@"..\..\XML\UserBase\UsersTrucks.xml"))
            {
                usersTruckBase = (List<Truck>)xmlSerializerTruck.Deserialize(stream);
            }

            if(carTaxist is EconomCar)
            {
                user = ((EconomCar)carTaxist).UserMatchTaxistWork(usersEconomBase, district);
            }
            else if(carTaxist is LuxuryCar)
            {
                user = ((LuxuryCar)carTaxist).UserMatchTaxistWork(usersLuxuryBase, district);
            }
            else if(carTaxist is Truck)
            {
                user = ((Truck)carTaxist).UserMatchTaxistWork(usersTruckBase, district);
            }
            this.Hide();
            TaxistWorkInfo taxistWorkInfo = new TaxistWorkInfo(user);
            taxistWorkInfo.ShowDialog();
            this.Close();
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
    }
}
