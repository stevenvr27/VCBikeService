using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class MethodPayment
    {
       int MethodPaymentID { get; set; }
      string Description { get; set; }


        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPMethodPageList");
            return R;
        }


    }
}
