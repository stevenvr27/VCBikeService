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
        
        public string UserCardID { get; set; }

        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool Active { get; set; }

        public UserRole MyRol { get; set; }





        public DataTable ListActive()
        {
            DataTable R = new DataTable();
            
             Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));

            R = Micnn.EjecutarSELECT("SPUsersList ");

            return R;
        }

        public DataTable ListInactive()
        {
            DataTable R = new DataTable();
            return R;
        }

        public bool Delete()
        {
            bool R = false;

            return R;

        }
        public bool SearchID()
        {
            bool R = false;
            return R;
        }

        public User SearchCardIDReturnUser()
        {
            User R  = new User();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.UserID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SPUserSearchID");

            if(dt!= null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.UserID = Convert.ToInt32(dr["UserID"]);
                R.PhoneNumber = Convert.ToString(dr["PhoneNumber"]);
                R.UserCardID = Convert.ToString(dr["UserCardID"]);

                R.UserName = Convert.ToString(dr["UserName"]);
                R.Email = Convert.ToString(dr["Email"]);
                R.Address = Convert.ToString(dr["Address"]);

                R.UserPassword = string.Empty;

                R.MyRol.UserRoleID = Convert.ToInt32(dr["UserRoleID"]);
                R.MyRol.Description = Convert.ToString(dr["Description"]);



            }



            return R;

        }



    }

    

}
