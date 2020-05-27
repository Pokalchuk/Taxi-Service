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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public Registration(bool isEnglish)
        {
            InitializeComponent();
            if (isEnglish)
            {
                labelName.Text = "Enter your name:";
                labelSurname.Text = "Enter your surname:";
                labelNickname.Text = "Enter your nickname:";
                labelPassword.Text = "Enter your password:";
                labelConfirmPassword.Text = "Confirm password:";
                labelBirthday.Text = "Your birthday";
                buttonRegister.Text = "Register";
            }
            else
            {
                labelName.Text = "Введіть ім'я:";
                labelSurname.Text = "Введіть призвіще:";
                labelNickname.Text = "Введіть нікнейм:";
                labelPassword.Text = "Введіть пароль:";
                labelConfirmPassword.Text = "Підтвердіть пароль:";
                labelBirthday.Text = "Дата вашого народження";
                buttonRegister.Text = "Реєстрація";
            }
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
                    string.IsNullOrEmpty(textBoxConfirmPass.Text))
                {
                    throw new Exception("Some field is empty!!!");
                }

                if (textBoxPassword.Text != textBoxConfirmPass.Text)
                {
                    throw new Exception("Password mismatch");
                }

                string filePath = $@"..\..\Files\Users\{textBoxNickname.Text}.txt";
                if (File.Exists(filePath))
                {
                    throw new Exception("User already exist!!!");
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(textBoxNickname.Text);
                        writer.WriteLine(textBoxPassword.Text);
                    }
                    MessageBox.Show("Successful registration");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
        }
    }
}
