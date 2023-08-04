using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class BuyDetail
    {
        
        public decimal Total { get; set; }
        public decimal UnitaryPrice { get; set; }

        public int BuyID { get; set; }  
        public int ItemID { get; set; }   
    }
}
