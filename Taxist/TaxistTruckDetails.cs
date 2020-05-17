﻿using System;
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
    public partial class TaxistTruckDetails : Form
    {
        Truck truck;
        public TaxistTruckDetails(Car carMain)
        {
            InitializeComponent();
            truck = (Truck)carMain;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("TinyButtonClickPush");
            truck.MaxKilogramsOfCargo = Convert.ToInt32(numericUpDownCargo.Value);
            truck.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);
            this.Close();
        }

        private void numericUpDownAmountPeople_ValueChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }

        private void numericUpDownCargo_ValueChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Click");
        }
    }
}
