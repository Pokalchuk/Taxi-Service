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

namespace TaxiService
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            try
            {
                if (string.IsNullOrEmpty(textBoxNickname.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
                {
                    throw new Exception("Some field is empty!!!");
                }

                string filePath = $@"..\..\Files\Users\{textBoxNickname.Text}.txt";
                if (!File.Exists(filePath))
                {
                    throw new Exception($"User with nickname: {textBoxNickname.Text}\nDoes not exist!!!");
                }
                else
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string nickname = reader.ReadLine();
                        string password = reader.ReadLine();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
