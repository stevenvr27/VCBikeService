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
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }

        public string UserCardID { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool Active { get; set; }

        public UserRole MyRol { get; set; }

 
        public User()
        {
            MyRol = new UserRole();
        }

    }
}

    


