using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Tax
    {
        public int TaxID { get; set; }
        public string TaxName { get; set;}
        public decimal AmountTax { get; set;}

        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPUTaxList");
            return R;
        }
    }
}
