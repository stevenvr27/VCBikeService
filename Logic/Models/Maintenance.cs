using CrystalDecisions.ReportAppServer.DataDefModel;
using System;
using System.Collections.Generic;
using Logic.Services;
using System.Data;
using System.Data.SqlClient;

namespace Logic.Models
{
    public  class Maintenance
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string Brand { get; set; }
       public  decimal Total {get; set; }
        public string Notas {get; set; }
         

        public Customer MyCustomer { get; set; }
        public User Myuser { get; set; }
        public BiciType MybiciType { get; set; }


        public Maintenance()
        {
               
            MyCustomer = new Customer();
            Myuser = new User();
            MybiciType = new BiciType();

        }

        public bool Add()
        {
            bool R = false;
            Logic.Services.Connection connection = new Logic.Services.Connection();

            connection.parameterlist.Add(new SqlParameter("@CustomerID", this.MyCustomer.CustomerID));
            connection.parameterlist.Add(new SqlParameter("@UserID", this.Myuser.UserID));
            connection.parameterlist.Add(new SqlParameter("@Total", this.Total));
            connection.parameterlist.Add(new SqlParameter("@Date", this.Date));
            connection.parameterlist.Add(new SqlParameter("@Tipo", this.MybiciType.BiciTypeID));
            connection.parameterlist.Add(new SqlParameter("@Brand", this.Brand));
            connection.parameterlist.Add(new SqlParameter("@Notas", this.Notas));

            int result = connection.EjecutarInsertUpdateDelete("SPMaintenanceAdd");

            if (result > 0)
            {
                R = true;
            }
            return R;

        }


    }
}
