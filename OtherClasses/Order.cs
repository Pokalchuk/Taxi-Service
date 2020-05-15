using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiService
{
    //struct TimeOfArrival
    enum Choice
    {
        YES = 1,
        NO = 2
    };

    class Order
    {
        public string CurrentAdress { get; set; }
        public string FinalAdress { get; set; }
        public int AmountPeople { get; set; }
        public string CommentForTaxist { get; set; }
        public int Price { get; set; }

    }
}
