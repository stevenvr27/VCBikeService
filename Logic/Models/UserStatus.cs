using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class UserStatus
    {
       public int UserStatusID { get; set; }
        public string Status { get; set; }
        
        
        
        public DataTable List()
        {
            DataTable R = new DataTable();
            return R;
        }


    }
}
