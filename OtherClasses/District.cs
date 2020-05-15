using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    public class District
    {
        public List<string> districts;
        public District(string district)
        {
            districts = new List<string>();

            if(district == "Central")
            {
                districts.Add("Shevchenka");
                districts.Add("Mir");
                districts.Add("Volodimira");
            }
            else if (district == "Wetland")
            {
                districts.Add("Soborna");
                districts.Add("Oleni Teligi");
                districts.Add("Romanovicha");
            }
            else if (district == "Richland")
            {
                districts.Add("Moskovskaya");
                districts.Add("Polovtsia");
                districts.Add("Omega");
            }
            else if (district == "Monroe")
            {
                districts.Add("Vishneva");
                districts.Add("Zlota");
                districts.Add("Sagaychuka");
            }
            else if (district == "Dane")
            {
                districts.Add("Bohoyavlenska");
                districts.Add("Ogirkova");
                districts.Add("Yabluneva");
            }
        }
    }
}
