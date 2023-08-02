using System.Data;

namespace Logic.Models
{
    public class CustomerType
    {
        //atributos 
        public int CustomerTypeID { get; set; }
        public string Description { get; set; }


        // datatable me trae la lista de tipos de clientes 
        public DataTable ListCustomerType()
        {

            DataTable a = new DataTable();
            Services.Connection Micnn = new Services.Connection();
            a = Micnn.EjecutarSELECT("SPCustomerTypeList");
            return a;
        } 

    }
}
