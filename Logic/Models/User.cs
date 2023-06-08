using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Logic.Models
{
    public  class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        
        public int UserCardID { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool Active { get; set; }




        public DataTable ListActive()
        {
            DataTable R = new DataTable();
            
             Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@AVerActive", true));

            R = Micnn.EjecutarSELECT("SPUserList");

            return R;
        }

        public DataTable ListInactive()
        {
            DataTable R = new DataTable();
            return R;
        }

    }

    

}
