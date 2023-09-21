using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class BiciType
    {
        public int BiciTypeID { get; set; }
        public string Description { get; set; }


        //datatable trae la lista de los tipos de compras 
        public DataTable list()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPBiciTypeList");
            return R;
        }

    }
}
