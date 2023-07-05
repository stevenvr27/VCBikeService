using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class CustomerType
    {
        public int CustomerTypeID { get; set; }
        public string Description { get; set; }


        public DataTable ListCustomerType()
        {

            DataTable a = new DataTable();
            Services.Connection Micnn = new Services.Connection();
            a = Micnn.EjecutarSELECT("SPCustomerTypeList");
            return a;
        } 

    }
}
