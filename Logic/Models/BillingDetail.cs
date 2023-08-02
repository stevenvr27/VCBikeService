using Logic.Services;
using System.Data.SqlClient;
using System.Data;

namespace Logic.Models
{
    public  class BillingDetail
    {
        //atributos
        public decimal Amount { get; set; }
        public decimal TotalLine { get; set; }
        public decimal UnitaryPrice { get; set; }
        public decimal PercentageDiscount { get; set; }
        public decimal SubTotalLine { get; set; }
        public decimal ImpuestoLine { get; set; }

        //atributos compuestos 
        public Item MyItem { get; set; }

        //constructor 
        public BillingDetail()
        {
            MyItem = new Item();
        }

        // Datatable lista las facturas segun su activo = true 

        public DataTable ListBillingActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SpBillingListActive");

            return R;
        }

        // Datatable lista las facturas segun su activo = false
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
