using System.Data;

namespace Logic.Models
{
    public class MethodPayment
    {
        //atributos 
        public int MethodPaymentID { get; set; }
        public string Description { get; set; }

        //data table me lista los metodos de pago 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPMethodPageList");
            return R;
        }


    }
}
