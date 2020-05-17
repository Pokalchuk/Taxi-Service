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
            Sound.MakeSound("TinyButtonClickPush");
            car.IsChildSeat = checkBoxChildSeat.Checked;
            car.IsWheelChair = checkBoxWheelChair.Checked;
            car.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            this.Close();
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
