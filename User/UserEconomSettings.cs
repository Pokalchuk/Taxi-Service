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
    public partial class UserEconomSettings : Form
    {
        public EconomCar economCar;
        public UserEconomSettings(bool isEnglish)
        {
            InitializeComponent();
            if(isEnglish)
            {
                labelPeople.Text = "People:";
                checkBoxChildSeat.Text = "Child seat:";
                checkBoxWheelChair.Text = "Wheel chair:";
                buttonFind.Text = "Find";
            }
            else
            {
                labelPeople.Text = "К-сть людей:";
                checkBoxChildSeat.Text = "Дитячий візок";
                checkBoxWheelChair.Text = "Інвалідне крісло";
                buttonFind.Text = "Знайти";
            }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            List<EconomCar> economCars = new List<EconomCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\EconomCars.xml"))
            {
                economCars = (List<EconomCar>)xmlSerializer.Deserialize(stream);
            }

            economCar = new EconomCar();
            economCar.IsChildSeat = checkBoxChildSeat.Checked;
            economCar.IsWheelChair = checkBoxWheelChair.Checked;
            economCar.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);

            for (int i = 0; i < economCars.Count; ++i)
            {
                if ((economCars[i].IsMatch(economCar)) != null)
                {
                    economCar = economCars[i];
                    break;
                }
            }
            DialogResult = DialogResult.OK;
        }
        private void checkBoxChildSeat_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
        private void checkBoxWheelChair_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
        private void numericUpDownAmountPeople_ValueChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Click");
        }
    }
}
