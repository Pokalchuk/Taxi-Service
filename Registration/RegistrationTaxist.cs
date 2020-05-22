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
    public partial class RegistrationTaxist : Form
    {
        Car car;
        Taxist taxist;
        public RegistrationTaxist()
        {
            InitializeComponent();
            taxist = new Taxist();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            try
            {
                if (string.IsNullOrEmpty(textBoxName.Text) ||
                    string.IsNullOrEmpty(textBoxSurname.Text) ||
                    dateTimePicker1.Value == null ||
                    string.IsNullOrEmpty(textBoxNickname.Text) ||
                    string.IsNullOrEmpty(textBoxPassword.Text) ||
                    string.IsNullOrEmpty(textBoxConfirmPass.Text) ||
                    string.IsNullOrEmpty(textBoxCarName.Text) ||
                    string.IsNullOrEmpty(textBoxCarModel.Text) ||
                    string.IsNullOrEmpty(textBoxCarNumber.Text))
                {
                    throw new Exception("Some field is empty!!!");
                }

                if (textBoxPassword.Text != textBoxConfirmPass.Text)
                {
                    throw new Exception("Password mismatch");
                }

                string filePath = $@"..\..\Files\Taxists\{textBoxNickname.Text}.txt";
                if (File.Exists(filePath))
                {
                    throw new Exception("Taxist with this nickname is already exist!!!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(textBoxNickname.Text);
                        writer.WriteLine(textBoxPassword.Text);
                        writer.WriteLine(comboBoxCarsType.SelectedItem.ToString());
                    }
                }

                taxist.Name = textBoxName.Text;
                taxist.Surname = textBoxSurname.Text;
                taxist.birthDate = dateTimePicker1.Value;
                taxist.Nickname = textBoxNickname.Text;
                taxist.Password = textBoxPassword.Text;

                car.taxist = taxist;
                car.CarName = textBoxCarName.Text;
                car.CarModel = textBoxCarModel.Text;
                car.CarNumber = textBoxCarNumber.Text;

                if (comboBoxCarsType.Text == "Econom")
                {
                    XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(EconomCar));
                    using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{taxist.Nickname}.xml"))
                    {
                        xmlSerializerCar.Serialize(stream, ((EconomCar)car));
                    }

                }
                else if (comboBoxCarsType.Text == "Luxury")
                {
                    XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(LuxuryCar));
                    using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{taxist.Nickname}.xml"))
                    {
                        xmlSerializerCar.Serialize(stream, ((LuxuryCar)car));
                    }
                }
                else if (comboBoxCarsType.Text == "Truck")
                {
                    XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(Truck));
                    using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{taxist.Nickname}.xml"))
                    {
                        xmlSerializerCar.Serialize(stream, ((Truck)car));
                    }
                }
                comboBoxCarsType.Enabled = false;

                this.Hide();
                TaxistWorking taxistWorking = new TaxistWorking(car);
                taxistWorking.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }

        private void comboBoxCarsType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCarsType.SelectedItem.ToString() == "Econom")
            {
                car = new EconomCar();
                TaxistEconomCarDetails economCarDetails = new TaxistEconomCarDetails(car);
                economCarDetails.ShowDialog();
            }
            else if (comboBoxCarsType.SelectedItem.ToString() == "Luxury")
            {
                car = new LuxuryCar();
                TaxistLuxuryCarDetails luxuryCarDetails = new TaxistLuxuryCarDetails(car);
                luxuryCarDetails.ShowDialog();
            }
            else if (comboBoxCarsType.SelectedItem.ToString() == "Truck")
            {
                car = new Truck();
                TaxistTruckDetails truckDetails = new TaxistTruckDetails(car);
                truckDetails.ShowDialog();
            }
        }
    }
}
