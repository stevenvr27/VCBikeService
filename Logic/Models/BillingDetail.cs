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
    public  class BillingDetail
    {
        public string DescripcionItem { get; set; }
        public decimal Amount { get; set; }
        public decimal TotalLine { get; set; }
        public decimal UnitaryPrice { get; set; }
        public decimal PercentageDiscount { get; set; }
        public decimal SubTotalLine { get; set; }
        public decimal ImpuestoLine { get; set; }

        public Item MyItem { get; set; }
        public BillingDetail()
        {
                MyItem = new Item();
        }

        public DataTable ListBillingActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SpBillingListActive");

            return R;
        }

        public DataTable ListBillingInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SpBillingListActive");

            return R;
        }

    }
}
