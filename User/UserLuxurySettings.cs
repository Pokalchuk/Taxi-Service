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
    public partial class UserLuxurySettings : Form
    {
        public LuxuryCar luxuryCar;
        public UserLuxurySettings(bool isEnglish)
        {
            InitializeComponent();
            if (isEnglish)
            {
                label1.Text = "People:";
                checkBoxTv.Text = "TV";
                checkBoxAlcohol.Text = "Alcohol";
                buttonFind.Text = "Find";
            }
            else
            {
                label1.Text = "К-сть людей:";
                checkBoxTv.Text = "Телевізор";
                checkBoxAlcohol.Text = "Алкоголь";
                buttonFind.Text = "Знайти";
            }
        }
        private void buttonFind_Click(object sender, EventArgs e)
        {
            Sound.MakeSound("ButtonClick");
            List<LuxuryCar> luxuryCars = new List<LuxuryCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"..\..\XML\LuxuryCars.xml"))
            {
                luxuryCars = (List<LuxuryCar>)xmlSerializer.Deserialize(stream);
            }

            luxuryCar = new LuxuryCar();
            luxuryCar.IsTv = checkBoxTv.Checked;
            luxuryCar.IsAlcohol = checkBoxAlcohol.Checked;
            luxuryCar.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);

            for (int i = 0; i < luxuryCars.Count; ++i)
            {
                if ((luxuryCars[i].IsMatch(luxuryCar)) != null)
                {
                    luxuryCar = luxuryCars[i];
                    break;
                }
            }
            DialogResult = DialogResult.OK;
        }
        private void checkBoxTv_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
        private void checkBoxAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            Sound.MakeSound("Switch");
        }
    }
}
