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
    public partial class TaxistWorkInfo : Form
    {
        public User user;
        public TaxistWorkInfo(User _user)
        {
            user = _user;
            InitializeComponent();
            labelNameChange.Text = user.Name;
            labelStreetChange.Text = user.Street;
        }
    }
}
