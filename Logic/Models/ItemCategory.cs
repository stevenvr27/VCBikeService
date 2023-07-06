using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class ItemCategory
    {
        public int  ItemCategoryID { get; set; }
        public string Description { get; set; }

        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPItemTypeList");
            return R;
        }

    }
}
