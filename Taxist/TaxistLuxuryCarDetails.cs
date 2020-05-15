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
    public partial class TaxistLuxuryCarDetails : Form
    {
        LuxuryCar car;
        public TaxistLuxuryCarDetails(Car mainCar)
        {
            InitializeComponent();
            car = (LuxuryCar)mainCar;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\TinyButtonClickPush.wav");
            click.Play();
            car.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            car.IsTv = checkBoxTv.Checked;
            car.IsAlcohol = checkBoxAlcohol.Checked;
            this.Close();
        }

        private void checkBoxTv_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            click.Play();
        }

        private void checkBoxAlcohol_CheckedChanged(object sender, EventArgs e)
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
