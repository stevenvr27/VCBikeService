using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logic.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public int CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public bool Active { get; set; }

        public DataTable ListActive()
        {
            DataTable R = new DataTable();
            Connection MiCnn = new Connection();
            MiCnn.parameterlist.Add(new SqlParameter("@AverActivos", true));
            R = MiCnn.EjecutarSELECT("SpCustomerList");
            return R;
        }




    }

    
}
