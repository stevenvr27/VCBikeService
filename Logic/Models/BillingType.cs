using System.Data;

namespace Logic.Models
{
    public  class BillingType
    {
        //atributos 
        public int BillingTypeID { get; set; }
        public string Description { get; set; }

        // Lista los tipo de facturas que tenemos en la bd 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPBillingTypeList");
            return R;
        }
    }
}
