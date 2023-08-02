using System.Data;

namespace Logic.Models
{
    public  class Unit
    {
        //atributos 
        public int IDUnit { get; set; }
        public string UnitMeasurement { get; set; }

        //datatable lista las unidades de medida 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPUnitItemList");
            return R;
        }
    }
}
