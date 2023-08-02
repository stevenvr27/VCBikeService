using System.Data;

namespace Logic.Models
{
    public  class ItemCategory
    {
        //atributos 
        public int  ItemCategoryID { get; set; }
        public string Description { get; set; }
        //lista los tipos de categorias del los items 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPItemTypeList");
            return R;
        }

    }
}
