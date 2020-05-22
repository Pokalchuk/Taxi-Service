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
    public partial class OrderTaxiForm : Form
    {
        private bool IsEnglish { get; set; }
        Car car;
        public OrderTaxiForm(bool isEnglish)
        {
            InitializeComponent();
            comboBoxCarsType.SelectedIndex = 0;
            car = new Car();
            IsEnglish = isEnglish;
            if (IsEnglish)
            {
                labelChoiceCar.Text = "Choice car:";
                labelCurrentAdress.Text = "Current address:";
                labelFinalAdress.Text = "Final address:";
            }
            else
            {
                labelChoiceCar.Text = "Вибір машини:";
                labelCurrentAdress.Text = "Звідки:";
                labelFinalAdress.Text = "Куди:";
            }
        }
        private void buttonFindCar_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            try
            {
                if (string.IsNullOrEmpty(textBoxCurrentAdress.Text) || string.IsNullOrEmpty(textBoxFinalAddress.Text))
                {
                    throw new Exception("Some field is empty");
                }

                if (comboBoxCarsType.SelectedItem.ToString() == "Econom")
                {
                    UserEconomSettings economSettings = new UserEconomSettings(IsEnglish);
                    if (economSettings.ShowDialog() == DialogResult.OK)
                    {
                        car = economSettings.economCar;
                    }
                }
                else if (comboBoxCarsType.SelectedItem.ToString() == "Luxury")
                {
                    UserLuxurySettings luxurySettings = new UserLuxurySettings(IsEnglish);
                    if(luxurySettings.ShowDialog() == DialogResult.OK)
                    {
                        car = luxurySettings.luxuryCar;
                    }
                }
                else if (comboBoxCarsType.SelectedItem.ToString() == "Truck")
                {
                    UserTruckSettings truckSettings = new UserTruckSettings(IsEnglish);
                    if(truckSettings.ShowDialog()==DialogResult.OK)
                    {
                        car = truckSettings.truck;
                    }
                }
                this.Hide();
                DetailsArrivalCar detailsArrivalCar = new DetailsArrivalCar(car,IsEnglish);
                detailsArrivalCar.ShowDialog();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

  
    }
}
