using Guna.UI.WinForms;
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
      
        public TaxistWorkInfo(User _user,bool isEnglish)
        {
            user = _user;
            InitializeComponent();
            string[] street = user.Street.Split(new char[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            labelNameChange.Text = user.Name;
            labelStreetChange.Text = street[0] + " " +street[1];
            labelEntranceChange.Text = street[street.Length-1] ;
            if (isEnglish)
            {
                labelName.Text = "Name:";
                labelStreet.Text = "Street:";
                labelEntrance.Text = "Entrance:";
            }
            else
            {
                labelName.Text = "Ім'я:";
                labelStreet.Text = "Вулиця:";
                labelEntrance.Text = "Під'їзд:";
            }
        }
    }
}
