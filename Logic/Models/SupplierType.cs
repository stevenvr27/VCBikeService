using System.Data;

namespace Logic.Models
{
    public  class SupplierType
    {
        //atributos 
        public int SupplierTypeID { get; set; }
        public string SupplierTypeDescription { get; set;}

        //datatable lista los tipos de proveedores
        public DataTable list()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPSupplierTypeList");
            return R;
        }

    }
}
