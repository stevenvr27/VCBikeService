using System.Data;

namespace Logic.Models
{
    public class Tax
    {
        //atributos 
        public int TaxID { get; set; }
        public string TaxName { get; set;}
        public decimal AmountTax { get; set;}

        //datatable lista los impuestos 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPUTaxList");
            return R;
        }
       
    }
}
