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
                Login login = new Login();
                login.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm();
                orderTaxi.ShowDialog();

                this.Close();
            }
            else
            {
                this.Hide();
                LoginTaxist loginTaxist = new LoginTaxist();
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
                Registration registration = new Registration();
                registration.ShowDialog();
                OrderTaxiForm orderTaxi = new OrderTaxiForm();
                orderTaxi.ShowDialog();

                this.Close();
            }
            else
            {
                this.Hide();
                RegistrationTaxist registrationTaxist = new RegistrationTaxist();
                registrationTaxist.ShowDialog();
                this.Close();
            }
          
        }
    }
}
