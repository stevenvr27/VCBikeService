using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Barcode { get; set; }
        public decimal Stock { get; set; }
        public decimal UnitaryCost { get; set; }
        public decimal SellPrice { get; set; }

        public bool Active { get; set; }


    }
}
