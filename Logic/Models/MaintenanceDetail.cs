using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class MaintenanceDetail
    {
        public Maintenance MyMaintenance { get; set; }
        public Item Myitem { get; set; }
        public decimal UnitaryPrice { get; set; }
        public decimal Discount  { get; set;}

        



    }
}
