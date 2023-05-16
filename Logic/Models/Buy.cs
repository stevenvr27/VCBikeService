using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class Buy
    {
        public int BuyID { get; set; }

        public DateTime BuyDate { get; set; } 

        public int BuyNumber { get; set; }
        public string BuyNotes { get; set;}

        public bool Active { get; set; }


    }
}
