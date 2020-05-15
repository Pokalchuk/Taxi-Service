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
        //public Car myCar;
        public UserEconomSettings()
        {
            InitializeComponent();
            //myCar = car;
            //economCar = (EconomCar)car;
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\ButtonClick.wav");
            click.Play();
            List<EconomCar> economCars = new List<EconomCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\XML\EconomCars.xml"))
            {
                economCars = (List<EconomCar>)xmlSerializer.Deserialize(stream);
            }

            economCar = new EconomCar();
            economCar.IsChildSeat = checkBoxChildSeat.Checked;
            economCar.IsWheelChair = checkBoxWheelChair.Checked;
            economCar.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);

            for (int i = 0; i < economCars.Count; ++i)
            {
                if ((economCars[i].isMatch(economCar)) != null)
                {
                    MessageBox.Show(economCars[i].CarNumber);
                    economCar = economCars[i];
                    break;
                }
            }
            DialogResult = DialogResult.OK;
            
            //MessageBox.Show(economCar.CarNumber);
            //make new form and consturct(EconomCar car) and then make if exit=>exit if open first form unhide menu form
        }

        private void checkBoxChildSeat_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            click.Play();
        }

        private void checkBoxWheelChair_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            click.Play();
        }

        private void numericUpDownAmountPeople_ValueChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Click.wav");
            click.Play();
        }
    }
}
