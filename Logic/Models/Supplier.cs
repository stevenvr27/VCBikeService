using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public int PhoneNumber { get; set; }
        public string SupplierName { get; set; }

        public string SupplierCardID { get; set; }
        public string SupplierEmail { get; set; }

        public string Address { get; set;}
        public SupplierType MyType { get; set; }


        public Supplier()
        {
            MyType = new SupplierType();
        }

        public DataTable ListActive()
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();
            R = Micnn.EjecutarSELECT("SPListSupplierActive");

            return R;
        }
        public DataTable ListInactive()
        {
            DataTable R = new DataTable();
            return R;
        }

    }
}
