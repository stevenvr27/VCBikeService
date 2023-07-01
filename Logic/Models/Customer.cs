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

       

        public DataTable ListCustomerActive()
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo", true));



            R = Micnn.EjecutarSELECT("SpCustomerList");

            return R;
        }

        public DataTable ListCustomerInactive()
        {
            DataTable R = new DataTable();
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



            }



            return R;

        }



    }





}



