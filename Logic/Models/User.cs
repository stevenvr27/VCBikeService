using Logic.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Logic.Models
{
    public class User
    {
        //atributos 
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }

        public int UserCardID { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool Active { get; set; }

        //atributos compuestos 
        public UserRole MyRol { get; set; }

        
        public User()
        {
            MyRol = new UserRole();
        }
        //data table lista los usuarios 
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPListUSers");
            return R;
        }
        //data table lista los usuarios segun una condicion en especifico 
        public DataTable ListUser()
        {
            DataTable R = new DataTable();
            Services.Connection MiCnn = new Services.Connection();
            R = MiCnn.EjecutarSELECT("SPUserListas");
            return R;
        }
        //metodo agregar y su respectivo llamado al procedimiento almacenado 
        public bool AddUser()
        {
            bool R = false;

            Connection connection = new Connection();

           Crypto crypto = new Crypto();
            string Passwordencrypted = crypto.EncriptarEnUnSentido(this.UserPassword);
            connection.parameterlist.Add(new SqlParameter("@UserPassword", Passwordencrypted));

            connection.parameterlist.Add(new SqlParameter("@UserName", this.UserName));
            connection.parameterlist.Add(new SqlParameter("@UserCardID", this.UserCardID));
            connection.parameterlist.Add(new SqlParameter("@Email", this.Email));
            connection.parameterlist.Add(new SqlParameter("@PhoneNumber", this.PhoneNumber));
            connection.parameterlist.Add(new SqlParameter("@Address", this.Address));
            connection.parameterlist.Add(new SqlParameter("@UserRoleID", this.MyRol.UserRoleID));

            int result = connection.EjecutarInsertUpdateDelete("SPUserAdd");

            if (result > 0)
            {
                R = true;
            }
            return R;

        }
        //metodo actualizar y su respectivo llamado al procedimiento almacenado 
        public bool Update()
        {
            bool R = false;
            Connection connection = new Connection();
            Crypto crypto = new Crypto();
            string Passwordencrypted = crypto.EncriptarEnUnSentido(this.UserPassword);
            connection.parameterlist.Add(new SqlParameter("@UserPassword", Passwordencrypted));
            connection.parameterlist.Add(new SqlParameter("@UserName", this.UserName));
            connection.parameterlist.Add(new SqlParameter("@UserCardID", this.UserCardID));
            connection.parameterlist.Add(new SqlParameter("@Email", this.Email));
            connection.parameterlist.Add(new SqlParameter("@PhoneNumber", this.PhoneNumber));
            connection.parameterlist.Add(new SqlParameter("@Address", this.Address));
         
            connection.parameterlist.Add(new SqlParameter("@UserRoleID", this.MyRol.UserRoleID));
            connection.parameterlist.Add(new SqlParameter("@UserID", this.UserID));

            int result = connection.EjecutarInsertUpdateDelete("SPUserUpdate");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }

        public bool ValidateCredentials()
        {
            bool isValid = false;

            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@Name", this.UserName));
            connection.parameterlist.Add(new SqlParameter("@Email", this.Email)); 

            object result = connection.EjecutarSELECTEscalar("SPValidateCredentials");

            if (result != null && result != DBNull.Value)
            {
                isValid = Convert.ToInt32(result) == 1;
            }

            return isValid;
        }

        //metodo validad credenciales  y su respectivo llamado al procedimiento almacenado 
        public bool ValidateUserCredentials(string name, string email, string userCardID)
        {
            bool isValid = false;

            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@Name", name));
            connection.parameterlist.Add(new SqlParameter("@Email", email));
            connection.parameterlist.Add(new SqlParameter("@UserCardID", userCardID));

            object result = connection.EjecutarSELECTEscalar("SPValidateUserCredentials");
            if (result != null && result != DBNull.Value)
            {
                isValid = Convert.ToInt32(result) == 1;
            }

            return isValid;
        }
        //metodo actualizar contraseña y su respectivo llamado al procedimiento almacenado 
        public bool UpdatePAssword(string newPassword)
        {
            bool R = false;
            Connection connection = new Connection();
            Crypto crypto = new Crypto();
            string Passwordencrypted = crypto.EncriptarEnUnSentido(newPassword);

            connection.parameterlist.Add(new SqlParameter("@UserPassword", Passwordencrypted));


            connection.parameterlist.Add(new SqlParameter("@UserID", this.UserID));
            connection.parameterlist.Add(new SqlParameter("@UserPassword", Passwordencrypted));

            int result = connection.EjecutarInsertUpdateDelete("SPUserUpdatepasword");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }
        // trae la contraseña encryptada  
        public string GetDecryptedPassword(Crypto crypto)
        {
            return crypto.DesEncriptarPassword(this.UserPassword);
        }
        //metodo eliminar y su respectivo llamado al procedimiento almacenado 
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
        //metodo eliminar para siempre y su respectivo llamado al procedimiento almacenado 
        public bool DeleteForEver()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.UserID));
            int r = connection.EjecutarInsertUpdateDelete("SPDeleteUSer");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }
        //metodo activar y su respectivo llamado al procedimiento almacenado 
        public bool Activate()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.UserID));
            int r = connection.EjecutarInsertUpdateDelete("SPUserReturnActive");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }
        //metodo consultar por la cedula y su respectivo llamado al procedimiento almacenado 
        public bool ConsultCardID()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            
            MiCnn.parameterlist.Add(new SqlParameter("@CardID", this.UserCardID));

            DataTable consulta = new DataTable();
             
            consulta = MiCnn.EjecutarSELECT("SPUserSearchForID");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R; ;

        }



        //  //metodo consultar por email y su respectivo llamado al procedimiento almacenado 
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


        // data table lista los usuarios activos 
        public DataTable ListActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SPUserListActive");

            return R;
        }

         // datatable lista los usuarios inactivos 
        public DataTable ListInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = Micnn.EjecutarSELECT("SPUserListActive");

            return R;
        }

        // //metodo busca la cedula y trae cierta info del usuariocon el  respectivo llamado al procedimiento almacenado  

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
                R.PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]);
                R.UserCardID = Convert.ToInt32(dr["UserCardID"]);

                R.UserName = Convert.ToString(dr["UserName"]);
                R.Email = Convert.ToString(dr["Email"]);
                R.Address = Convert.ToString(dr["Address"]);

                R.UserPassword = string.Empty;

                R.MyRol.UserRoleID = Convert.ToInt32(dr["UserRoleID"]);
                R.MyRol.Description = Convert.ToString(dr["Description"]);



            }



            return R;

        }



        //metodo valida que el usuario exista con   su respectivo llamado al procedimiento almacenado 
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
                R.PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]);
                R.UserCardID = Convert. ToInt32(dr["UserCardID"]);

                R.UserName = Convert.ToString(dr["UserName"]);
                R.Email = Convert.ToString(dr["Email"]);
                R.Address = Convert.ToString(dr["Address"]);

                R.UserPassword = string.Empty;

                R.MyRol.UserRoleID = Convert.ToInt32(dr["UserRoleID"]);
                R.MyRol.Description = Convert.ToString(dr["Description"]);

                // Check if the user is active before returning
                R.Active = Convert.ToBoolean(dr["Active"]);
                if (!R.Active)
                {
                    R.UserID = -1; // Set a negative value to indicate an inactive user
                }


            }

            return R;

        }

    }
}

    


