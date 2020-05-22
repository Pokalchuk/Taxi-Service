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
    public partial class LoginTaxist : Form
    {
        private bool IsEnglish { get; set; }
        Car car;

        public LoginTaxist(bool isEnglish)
        {
            InitializeComponent();
            IsEnglish = isEnglish;
            if (IsEnglish)
            {
                labelNickname.Text = "Enter your nickname";
                labelPassword.Text = "Enter your password";
                buttonLogin.Text = "Login";
            }
            else
            {
                labelNickname.Text = "Введіть ваш нікнейм";
                labelPassword.Text = "Введіть ваш пароль";
                buttonLogin.Text = "Увійти";
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            string typeCar = "";
            string nickname = "";
            try
            {
                if (string.IsNullOrEmpty(textBoxNickname.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    throw new Exception("Some field is empty!!!");
                }

                string filePath = $@"..\..\Files\Taxists\{textBoxNickname.Text}.txt";
                if (!File.Exists(filePath))
                {
                    throw new Exception($"User with nickname: {textBoxNickname.Text}\nDoes not exist!!!");
                }
                else
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        nickname = reader.ReadLine();
                        string password = reader.ReadLine();
                        typeCar = reader.ReadLine();
                        if (textBoxNickname.Text == nickname && textBoxPassword.Text == password)
                        {
                            MessageBox.Show("Successful login");
                            this.Close();
                        }
                        else
                        {
                            throw new Exception("Incorrect password\nEnter again!");
                        }
                    }
                }
                this.Hide();
                
                if (typeCar == "Econom")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(EconomCar));
                    using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
                    {
                        car = (EconomCar)xmlSerializer.Deserialize(stream);
                    }
                }
                else if (typeCar == "Luxury")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(LuxuryCar));
                    using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
                    {
                        car = (LuxuryCar)xmlSerializer.Deserialize(stream);
                    }
                }
                else if (typeCar == "Truck")
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Truck));
                    using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
                    {
                        car = (Truck)xmlSerializer.Deserialize(stream);
                    }
                }
                TaxistWorking taxistWorking = new TaxistWorking(car,IsEnglish);
                taxistWorking.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
