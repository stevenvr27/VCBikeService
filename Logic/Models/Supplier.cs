using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public int PhoneNumber { get; set; }
        public string SupplierName { get; set; }

        public int SupplierCardID { get; set; }
        public string SupplierEmail { get; set; }

        public string Address { get; set;}
        public SupplierType MyType { get; set; }


        public Supplier()
        {
            MyType = new SupplierType();
        }

        public bool AddSupply()
        {
            bool R = false;

            Connection connection = new Connection();

             

            connection.parameterlist.Add(new SqlParameter("@SupplierName", this.SupplierName));
            connection.parameterlist.Add(new SqlParameter("@PhoneNumber", this.PhoneNumber));
            connection.parameterlist.Add(new SqlParameter("@SupplierCardID", this.SupplierCardID));
            connection.parameterlist.Add(new SqlParameter("@SupplierEmail", this.SupplierEmail));
            connection.parameterlist.Add(new SqlParameter("@Address", this.Address));
            connection.parameterlist.Add(new SqlParameter("@SupplierTypeID", this.MyType.SupplierTypeID));
             

            int result = connection.EjecutarInsertUpdateDelete("SPAddSuply");

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
            connection.parameterlist.Add(new SqlParameter("@SupplierName", this.SupplierName));
            connection.parameterlist.Add(new SqlParameter("@PhoneNumber", this.PhoneNumber));
            connection.parameterlist.Add(new SqlParameter("@SupplierCardID", this.SupplierCardID));
            connection.parameterlist.Add(new SqlParameter("@SupplierEmail", this.SupplierEmail));
            connection.parameterlist.Add(new SqlParameter("@Address", this.Address));
            connection.parameterlist.Add(new SqlParameter("@SupplierTypeID", this.MyType.SupplierTypeID));
            connection.parameterlist.Add(new SqlParameter("@SupplierID", this.SupplierID));
            int result = connection.EjecutarInsertUpdateDelete("SPSupplyUpdate");

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
            connection.parameterlist.Add(new SqlParameter("@ID", this.SupplierID));
            int r = connection.EjecutarInsertUpdateDelete("SPSupplyDesactive");

            if (r > 0)
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
            R = Micnn.EjecutarSELECT("SPListSupplierActive");

            return R;
        }
        public DataTable ListInactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));
            R = Micnn.EjecutarSELECT("SPListSupplierActive");
            return R;
        }

        public Supplier SearchIDReturnSupply()
        {
            Supplier R = new Supplier();
            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@ID", this.SupplierID));

            DataTable dt = new DataTable();

            dt = Micnn.EjecutarSELECT("SearchIDReturnSupply");

            if (dt != null && dt.Rows.Count > 0)
            {
                 
                DataRow dr = dt.Rows[0];

                R.SupplierID = Convert.ToInt32(dr["SupplierID"]);
                R.PhoneNumber = Convert.ToInt32(dr["PhoneNumber"]);
                R.SupplierCardID = Convert.ToInt32(dr["SupplierCardID"]);

                R.SupplierName = Convert.ToString(dr["SupplierName"]);
                R.SupplierEmail = Convert.ToString(dr["SupplierEmail"]);
                R.Address = Convert.ToString(dr["Address"]);

                 
                R.MyType.SupplierTypeID = Convert.ToInt32(dr["SupplierTypeID"]);
                R.MyType.SupplierTypeDescription = Convert.ToString(dr["Description"]);



            }



            return R;

        }

        public bool Activate()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.SupplierID));
            int r = connection.EjecutarInsertUpdateDelete("SPSuplyReturnActive");

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
            connection.parameterlist.Add(new SqlParameter("@ID", this.SupplierID));
            int r = connection.EjecutarInsertUpdateDelete("SPDeleteSupply");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }

        public bool ConsultEmail()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@Email", this.SupplierEmail));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPSupplySearchForEmail");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }
        
       public bool consultcardid()
        {
            bool R = false;
            Connection MiCnn = new Connection();

            //agregamos el parametro de correo 
            MiCnn.parameterlist.Add(new SqlParameter("@CardID", this.SupplierCardID));

            DataTable consulta = new DataTable();
            //paso 1.4.3 y 1.4.4
            consulta = MiCnn.EjecutarSELECT("SPSupplySearchForCardID");

            //paso 1.4.5
            if (consulta != null && consulta.Rows.Count > 0)
            {
                R = true;
            }

            return R;


        }

        public Supplier SearchID(int pIdSupply)
        {
           Supplier R = new Supplier();

            Connection MyCnn = new Connection();

            MyCnn.parameterlist.Add(new SqlParameter("@ID", pIdSupply));

            DataTable DataCliente = new DataTable();
            DataCliente = MyCnn.EjecutarSELECT("SPSearchSupplierID");

            //Una vez tenemos un datatable con la data procedemos a llenar las
            //propiedades del objeto de retono. 

            if (DataCliente != null && DataCliente.Rows.Count > 0)
            {
                DataRow Fila = DataCliente.Rows[0];

                R.SupplierID = Convert.ToInt32(Fila["SupplierID"]);
                R.PhoneNumber = Convert.ToInt32(Fila["PhoneNumber"]);
                R.SupplierName = Convert.ToString(Fila["SupplierName"]);
                R.SupplierEmail = Convert.ToString(Fila["SupplierEmail"]);
                
                
            }

            return R;
        }

        public DataTable ListSupplier()
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            R = Micnn.EjecutarSELECT("SPListSupplier ");

            return R;
        }

    }
}
