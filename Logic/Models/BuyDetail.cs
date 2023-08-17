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

        public int NuevoArticulos  { get; set; }


        public BuyDetail SearchIDReturnbuydetail()
        {
            // metodo para buscar el id y que me retorne info del cliente 
            BuyDetail R = new BuyDetail();

            Connection Micnn = new Connection();
            Micnn.parameterlist.Add(new SqlParameter("@ID", this.BuyID));
            DataTable dt = new DataTable();
            dt = Micnn.EjecutarSELECT("SPbuysearchidbuydetail");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.NuevoArticulos = Convert.ToInt32(dr["NuevoArticulos"]);
                 
            }



            return R;

        }



    }
}
