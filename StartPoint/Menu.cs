using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxiService
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");

            if (radioButtonUser.Checked)
            {
                this.Hide();
                Login login = new Login(gunaCheckBox1.Checked);
                login.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm(gunaCheckBox1.Checked);
                orderTaxi.ShowDialog();

                this.Close();
            }
            else
            {
                this.Hide();
                LoginTaxist loginTaxist = new LoginTaxist(gunaCheckBox1.Checked);
                loginTaxist.ShowDialog();

                this.Close();
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");

            if (radioButtonUser.Checked)
            {
                this.Hide();
                Registration registration = new Registration(gunaCheckBox1.Checked);
                registration.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm(gunaCheckBox1.Checked);
                orderTaxi.ShowDialog();

                this.Close();
            }
            else
            {
                this.Hide();
                RegistrationTaxist registrationTaxist = new RegistrationTaxist(gunaCheckBox1.Checked);
                registrationTaxist.ShowDialog();
                this.Close();
            }
          
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(gunaCheckBox1.Checked)
            {
                label1.Text = "WELCOME";
                buttonLogin.Text = "Login";
                buttonRegistration.Text = "Registration";
                radioButtonUser.Text = "User";
                radioButtonTaxist.Text = "Taxist";
            }
            else
            {
                label1.Text = "ВІТАЄМО";
                buttonLogin.Text = "Увійти";
                buttonRegistration.Text = "Реєстрація";
                radioButtonUser.Text = "Користувач";
                radioButtonTaxist.Text = "Таксист";
            }
        }
    }
}
