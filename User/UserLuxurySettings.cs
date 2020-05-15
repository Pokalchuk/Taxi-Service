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
        public UserLuxurySettings()
        {
            InitializeComponent();

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\ButtonClick.wav");
            click.Play();
            List<LuxuryCar> luxuryCars = new List<LuxuryCar>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\XML\LuxuryCars.xml"))
            {
                luxuryCars = (List<LuxuryCar>)xmlSerializer.Deserialize(stream);
            }

            luxuryCar = new LuxuryCar();
            luxuryCar.IsTv = checkBoxTv.Checked;
            luxuryCar.IsAlcohol = checkBoxAlcohol.Checked;
            luxuryCar.NumberOfSeats = Convert.ToInt32(numericUpDownAmountPeople.Value);

            for (int i = 0; i < luxuryCars.Count; ++i)
            {
                if ((luxuryCars[i].isMatch(luxuryCar)) != null)
                {
                    luxuryCar = luxuryCars[i];
                    break;
                }
            }
            DialogResult = DialogResult.OK;
            //MessageBox.Show(luxuryCar.CarNumber);
        }

        private void checkBoxTv_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            click.Play();
        }

        private void checkBoxAlcohol_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer(@"F:\WinForms\TaxiServiceMainLast\TaxiServiceMain\TaxiService\Sounds\Switch.wav");
            click.Play();
        }
    }
}
