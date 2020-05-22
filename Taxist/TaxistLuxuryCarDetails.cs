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
        public TaxistLuxuryCarDetails(Car mainCar,bool isEnglish)
        {
            InitializeComponent();
            car = (LuxuryCar)mainCar;
            if (isEnglish)
            {
                labelAmountSeats.Text = "Amount seats:";
                checkBoxTv.Text = "TV";
                checkBoxAlcohol.Text = "Alcohol";
            }
            else
            {
                labelAmountSeats.Text = "К-сть сидінь:";
                checkBoxTv.Text = "Телевізор";
                checkBoxAlcohol.Text = "Алкоголь";
            }
        }
        private void buttonOk_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("TinyButtonClickPush");
            car.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            car.IsTv = checkBoxTv.Checked;
            car.IsAlcohol = checkBoxAlcohol.Checked;
            this.Close();
        }
        private void checkBoxTv_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
        private void checkBoxAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
        private void numericUpDownAmountPeople_ValueChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Click");
        }

       
    }
}
