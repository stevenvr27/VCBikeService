using System.Data;

namespace Logic.Models
{
    public  class BuyType
    {
        //Atributos 
        public int BuyTypeID { get; set; }
        public string Description { get; set; }


        //datatable trae la lista de los tipos de compras 
        public DataTable list()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPBuyTypeList");
            return R;
        }

    }
}
