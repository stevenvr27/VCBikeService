using Logic.Services;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Logic.Models
{
    public class Customer
    {
        // atributos 
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAdress { get; set; }

        

        public int CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        public bool Active { get; set; }

        //atributos compuestos
        public CustomerType MyTypeCustomer { get; set; }

        //constructor 
        public Customer()
        {
            MyTypeCustomer = new CustomerType(); 
        }
        //metodo agregar y su respectivo llamado al procedimiento almacenado 
        public bool Add()
        {
            bool R = false;

             Connection connection = new Connection();

             

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
        //metodo actualizar  y su respectivo llamado al procedimiento almacenado 
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
            //metodo eliminar cual enrealidad desactiva al cliente  y su respectivo llamado al procedimiento almacenado 
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
        //metodo eliminar para siempre de la bd  y su respectivo llamado al procedimiento almacenado 
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
            //metodo activar y su respectivo llamado al procedimiento almacenado 
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
            //metodo Consultar por el ID  y su respectivo llamado al procedimiento almacenado 
            bool R = false;
            Connection MiCnn = new Connection();

              
            MiCnn.parameterlist.Add(new SqlParameter("@ID", this.CustomerID));

            DataTable consulta = new DataTable();
            
            consulta = MiCnn.EjecutarSELECT("SPCustomerSearchID");

             
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R; ;

        }
        public Customer SearchID(int pIdCliente)
        {
            //metodo buscar el Id  y su respectivo llamado al procedimiento almacenado 
            Customer R = new Customer();

            Connection MyCnn = new Connection();

            MyCnn.parameterlist.Add(new SqlParameter("@ID", pIdCliente));

            DataTable DataCliente = new DataTable();
            DataCliente = MyCnn.EjecutarSELECT("SPSearchCustomerID");

            

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
        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPCustomerList");
            return R;
        }

        public bool ConsultEmail()
        {
            //consultar correo  y su respectivo llamado al procedimiento almacenado 
            bool R = false;
            Connection MiCnn = new Connection();

           
            MiCnn.parameterlist.Add(new SqlParameter("@Email", this.CustomerEmail));

            DataTable consulta = new DataTable();
             
            consulta = MiCnn.EjecutarSELECT("SPCustomerEmail");
             
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }
        public bool ConsultPhone()
        {
            //metodo Consultar por numero telefonico y su respectivo llamado al procedimiento almacenado 
            bool R = false;
            Connection MiCnn = new Connection();

             
            MiCnn.parameterlist.Add(new SqlParameter("@Phone", this.CustomerPhone));

            DataTable consulta = new DataTable();
           
            consulta = MiCnn.EjecutarSELECT("SPCustomerPhone");

             
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }
        //Datatable cual trae la lista de clientes activos si activo =true
        public DataTable ListCustomerActive(  string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("SpCustomerListActive");

            return R;
        }
        public DataTable ListCustomer(  ) //Data table me trae las compras que ha echo el cliente 
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            R = Micnn.EjecutarSELECT("SPNewBuyItem ");

            return R;
        }
        //Datatable cual trae la lista de clientes inactivos si activo =false
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
            // metodo para buscar el id y que me retorne info del cliente 
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



