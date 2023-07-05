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
        public bool Add()
        {
            bool R false; 

            Connection connection = new Connection();



 
        public bool AddUser()
        {

        public DataTable ListActive(string psearchfilter)
 
        {
            bool R = false;

            Connection connection = new Connection();

 
            //connection.parameterlist.Add(new SqlParameter("@Email", this.Email));
 
        public bool Update()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@UserName", this.UserName));
            connection.parameterlist.Add(new SqlParameter("@UserCardID", this.UserCardID));
            connection.parameterlist.Add(new SqlParameter("@Email", this.Email));
            connection.parameterlist.Add(new SqlParameter("@PhoneNumber", this.PhoneNumber));
            connection.parameterlist.Add(new SqlParameter("@Address", this.Address));
            connection.parameterlist.Add(new SqlParameter("@UserPassword", this.UserPassword));
            connection.parameterlist.Add(new SqlParameter("@UserRoleID", this.MyRol.UserRoleID));
            connection.parameterlist.Add(new SqlParameter("@UserID", this.UserID));

            int result = connection.EjecutarInsertUpdateDelete("SPUserUpdate");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }

        public bool Delete()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.UserID));
            int r = connection.EjecutarInsertUpdateDelete("SPUSerDesactive");

            if (r > 0)
            {
                R = true;
            }

            return R;

        }


        public bool ConsultCardID()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de cedula 
            MiCnn.parameterlist.Add(new SqlParameter("@CardID ", this.UserCardID));

            DataTable consulta = new DataTable();
            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPUserSearchForID");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R; ;

        }


        public bool ConsultEmail()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@Email", this.Email));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPUserSearchForEmail");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }



        public DataTable ListActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SPUserListActive");

            return R;
        }


        public DataTable ListInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = Micnn.EjecutarSELECT("SPUserListActive");

            return R;
        }



        public bool SearchID()
        {
            bool R = false;
            return R;
        }

        public User SearchCardIDReturnUser()
        {
            User R = new User();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.UserID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SPUserSearchID");

            if (dt != null && dt.Rows.Count > 0)
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



        public User ValidateUser(string pEmail, string pContrasennia)
        {
            User R = new User();

            Connection MiCnn = new Connection();

            Crypto crypto = new Crypto();
            string ContrasenniaEncriptada = crypto.EncriptarEnUnSentido(pContrasennia);

            MiCnn.parameterlist.Add(new SqlParameter("@usuario", pEmail));
            MiCnn.parameterlist.Add(new SqlParameter("@password", ContrasenniaEncriptada));

            //necesito un datatable para capturar la info del usuario 
            DataTable dt = new DataTable();

            dt = MiCnn.EjecutarSELECT("SPValidateUser");

            if (dt != null && dt.Rows.Count > 0)
            {
                //esta consulta debería tener solo un registro, 
                //se crea un objeto de tipo datarow para capturar la info 
                //contenida en index 0 del dt (datatable)
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

    


