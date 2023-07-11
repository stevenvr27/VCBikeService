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
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAdress { get; set; }

        public int CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public bool Active { get; set; }

        public CustomerType MyTypeCustomer { get; set; }

        public Customer()
        {
            MyTypeCustomer = new CustomerType(); 
        }

        public bool Add()
        {
            bool R = false;

            Connection connection = new Connection();

            //connection.parameterlist.Add(new SqlParameter("@Email", this.Email));

            //Crypto crypto = new Crypto();
            //string Passwordencrypted = crypto.EncriptarPassword(this.UserPassword);
            // connection.parameterlist.Add(new SqlParameter("@Password", Passwordencrypted));

            connection.parameterlist.Add(new SqlParameter("@CustomerName", this.CustomerName));
            connection.parameterlist.Add(new SqlParameter("@CustomerEmail", this.CustomerEmail)); 
            connection.parameterlist.Add(new SqlParameter("@customerPhone", this.CustomerPhone));
            connection.parameterlist.Add(new SqlParameter("@CustomerAdress", this.CustomerAdress));
            connection.parameterlist.Add(new SqlParameter("@Custumertype", this.MyTypeCustomer.CustomerTypeID)); 

            int result = connection.EjecutarInsertUpdateDelete("SPCustomerAdd");

            if (result > 0)
            {
                R = true;
            }
            return R;

        }
        public bool Update()
        {
            bool R = false;
            Connection connection = new Connection();


            connection.parameterlist.Add(new SqlParameter("@CustomerName", this.CustomerName));
            connection.parameterlist.Add(new SqlParameter("@CustomerEmail", this.CustomerEmail));
            connection.parameterlist.Add(new SqlParameter("@customerPhone", this.CustomerPhone));
            connection.parameterlist.Add(new SqlParameter("@CustomerAdress", this.CustomerAdress));
            connection.parameterlist.Add(new SqlParameter("@CustomerTypeID", this.MyTypeCustomer.CustomerTypeID));
            connection.parameterlist.Add(new SqlParameter("@CustomerID", this.CustomerID));

            int result = connection.EjecutarInsertUpdateDelete("SPCostumerUpdate");

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
            connection.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));
            int r = connection.EjecutarInsertUpdateDelete("SPCustomerDesactive");

            if (r > 0)
            {
                R = true;
            }

            return R;

        }
        public bool DeleteForEver()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));
            int r = connection.EjecutarInsertUpdateDelete("SPDeleteCustomer");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }
        public bool Activate()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));
            int r = connection.EjecutarInsertUpdateDelete("SPCustomerReturnActive");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultID()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de cedula 
            MiCnn.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));

            DataTable consulta = new DataTable();
            //paso 1.3.3 y 1.3.4
            consulta = MiCnn.EjecutarSELECT("SPCustomerSearchID");

            //paso 1.3.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R; ;

        }
        public Customer SearchID(int pIdCliente)
        {
           Customer R = new Customer();

            Connection MyCnn = new Connection();

            MyCnn.parameterlist.Add(new SqlParameter("@ID", pIdCliente));

            DataTable DataCliente = new DataTable();
            DataCliente = MyCnn.EjecutarSELECT("SPSearchCustomerID");

            //Una vez tenemos un datatable con la data procedemos a llenar las
            //propiedades del objeto de retono. 

            if (DataCliente != null && DataCliente.Rows.Count > 0)
            {
                DataRow Fila = DataCliente.Rows[0];

                R.CustomerID = Convert.ToInt32(Fila["CustomerID"]);
                R.CustomerPhone = Convert.ToInt32(Fila["CustomerPhone"]);
                R.CustomerName = Convert.ToString(Fila["CustomerName"]);
                R.CustomerEmail = Convert.ToString(Fila["CustomerEmail"]);
                
                
            }

            return R;
        }


        public bool ConsultEmail()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@Email", this.CustomerEmail));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPCustomerEmail");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }

        public DataTable ListCustomerActive(  string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SpCustomerListActive");

            return R;
        }
        public DataTable ListCustomer(bool VerActivos = true, string pFiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SPNewBuyItem ");

            return R;
        }

        public DataTable ListCustomerInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));


            R = Micnn.EjecutarSELECT("SpCustomerListActive");

            return R;
        }

        public Customer SearchIDReturnCustumer()
        {

            Customer R = new Customer();
            Connection Micnn = new Connection();
            Micnn.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));
            DataTable dt = new DataTable();
            dt = Micnn.EjecutarSELECT("SPCustomerSearchID");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.CustomerID = Convert.ToInt32(dr["CustomerID"]);
                R.CustomerPhone = Convert.ToInt32(dr["CustomerPhone"]);
                R.CustomerName = Convert.ToString(dr["CustomerName"]);
                R.CustomerEmail = Convert.ToString(dr["CustomerEmail"]);
                R.CustomerAdress = Convert.ToString(dr["CustomerAdress"]);
                R.MyTypeCustomer.Description = Convert.ToString(dr["Description"]);
                R.MyTypeCustomer.CustomerTypeID = Convert.ToInt32(dr["CustomerTypeID"]);

            }



            return R;

        }



    }





}



