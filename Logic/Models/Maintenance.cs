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

        public List<MaintenanceDetail> productosAgregados = new List<MaintenanceDetail>();


        public Maintenance()
        {
               
            MyCustomer = new Customer();
            productosAgregados = new List<MaintenanceDetail>();
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

            // Agrega el parámetro de salida para capturar el ID del nuevo mantenimiento
            SqlParameter outputParameter = new SqlParameter("@NewMaintenanceID", SqlDbType.Int);
            outputParameter.Direction = ParameterDirection.Output;
            connection.parameterlist.Add(outputParameter);

            // Ejecuta el procedimiento almacenado para agregar el mantenimiento
            Object result = connection.EjecutarInsertUpdateDelete("SPMaintenanceAdd");

            int MAntenimientoRecienCreado = 0;

            if (result != null)
            {
                // Obtiene el ID del nuevo mantenimiento desde el parámetro de salida
                MAntenimientoRecienCreado = Convert.ToInt32(outputParameter.Value);

                this.ID = MAntenimientoRecienCreado;

                foreach (MaintenanceDetail item in this.productosAgregados)
                {
                    // Utiliza la misma instancia de 'connection' para los detalles del mantenimiento
                    connection.parameterlist.Clear(); // Limpia los parámetros anteriores

                    connection.parameterlist.Add(new SqlParameter("@ID", MAntenimientoRecienCreado));
                    connection.parameterlist.Add(new SqlParameter("@ItemID", item.Myitem.ItemID));
                    connection.parameterlist.Add(new SqlParameter("@unitaryprice", item.UnitaryPrice));
                    connection.parameterlist.Add(new SqlParameter("@Discount", item.Discount));

                    // Ejecuta el comando utilizando 'connection' para agregar detalles del mantenimiento
                    connection.EjecutarInsertUpdateDelete("SPMaintenanceDetailAdd");
                }
                R = true;
            }
            return R;
        }

        public DataTable ListMaintenanceActive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Logic.Services.Connection Micnn = new Logic.Services.Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));



            R = Micnn.EjecutarSELECT("ListMaintenanceActive");

            return R;
        }
    }
}
