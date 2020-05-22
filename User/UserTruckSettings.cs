using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TaxiService
{
    public partial class UserTruckSettings : Form
    {
        public Truck truck;
        public UserTruckSettings(bool isEnglish)
        {
            InitializeComponent();
            if (isEnglish)
            {
                labelCargo.Text = "Max kilograms cargo:";
                labelPeople.Text = "People:";
            }
            else
            {
                labelCargo.Text = "Вантажопідйомність(кг):";
                labelPeople.Text = "К-сть людей:";
            }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            List<Truck> trucks = new List<Truck>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.OpenRead(@"..\..\XML\Trucks.xml"))
            {
                trucks = (List<Truck>)xmlSerializer.Deserialize(stream);
            }
            truck = new Truck();
            truck.KilogramsCargo = Convert.ToInt32(numericUpDownCargo.Value);
            truck.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            for (int i = 0; i < trucks.Count; ++i)
            {
                if ((trucks[i].IsMatch(truck)) != null)
                {
                    truck = trucks[i];
                    break;
                }
            }
            DialogResult = DialogResult.OK;
        }
    }
}
