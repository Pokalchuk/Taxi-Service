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
        Car car;
        public OrderTaxiForm()
        {
            InitializeComponent();
            comboBoxCarsType.SelectedIndex = 0;
            car = new Car();
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
                    UserEconomSettings economSettings = new UserEconomSettings();
                    if (economSettings.ShowDialog() == DialogResult.OK)
                    {
                        car = economSettings.economCar;
                    }
                }
                else if (comboBoxCarsType.SelectedItem.ToString() == "Luxury")
                {
                    UserLuxurySettings luxurySettings = new UserLuxurySettings();
                    if(luxurySettings.ShowDialog() == DialogResult.OK)
                    {
                        car = luxurySettings.luxuryCar;
                    }
                }
                else if (comboBoxCarsType.SelectedItem.ToString() == "Truck")
                {
                    UserTruckSettings truckSettings = new UserTruckSettings();
                    if(truckSettings.ShowDialog()==DialogResult.OK)
                    {
                        car = truckSettings.truck;
                    }
                }
                this.Hide();
                DetailsArrivalCar detailsArrivalCar = new DetailsArrivalCar(car);
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
