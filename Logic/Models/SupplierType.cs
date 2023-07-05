using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class SupplierType
    {
        public int SupplierTypeID { get; set; }
        public string SupplierTypeDescription { get; set;}

        public DataTable list()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPSupplierTypeList");
            return R;
        }

    }
}
