using System.Data;

namespace Logic.Models
{
    public  class UserRole
    {
        //atributos 
        public int UserRoleID { get; set; }
        public string Description { get; set; }

        //datatable lista los roles del usuario
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPUserList");
            return R;
        }

    }
}
