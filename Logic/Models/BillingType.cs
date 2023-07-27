using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
   public  class BillingType
    {

        public int BillingTypeID { get; set; }
        public string Description { get; set; }

        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPBillingTypeList");
            return R;
        }
    }
}
