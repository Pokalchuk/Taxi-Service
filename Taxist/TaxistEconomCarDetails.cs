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
    public partial class TaxistEconomCarDetails : Form
    {
        EconomCar car;
        public TaxistEconomCarDetails(Car mainCar)
        {
            InitializeComponent();
            car = (EconomCar)mainCar;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\TinyButtonClickPush.wav");
            click.Play();
            car.IsChildSeat = checkBoxChildSeat.Checked;
            car.IsWheelChair = checkBoxWheelChair.Checked;
            car.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            this.Close();
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
