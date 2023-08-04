using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Logic.Models
{
    public  class Buy
    {
        //atributos 
        public int BuyID { get; set; }

        public DateTime BuyDate { get; set; } 

       
        public string BuyNotes { get; set;}

        public bool Active { get; set; }

        //Atributos compuestos 
        public User MyUser { get; set; }    
        public Supplier Supplier { get; set; }
        public BuyType MybuyType { get; set; }

        public MethodPayment methodPayment { get; set; }

        // lista 

        public List<BuyDetail> BuyDetail { get; set; }


       // constructor 
        public Buy() 
        {
             MyUser = new User();
             Supplier = new Supplier();
            MybuyType = new BuyType();
              methodPayment = new MethodPayment();
              BuyDetail = new List<BuyDetail>();
             BuyDate= DateTime.Now;
             
        }

        //Datatable trae el esquema detalle 
        public DataTable CargarEsquemaDetalle()
        {
            DataTable R = new DataTable();

            Connection MiCnn = new Connection();

            R = MiCnn.EjecutarSELECT("SPBuydetail", true);

            //como estamos cargando el esquema, también viene la indicación del PK 
            //se debe anular esa opción 
            R.PrimaryKey = null;

            return R;

        }
        public bool Add()
        {
            bool R = false;

            Connection connection = new Connection();



            connection.parameterlist.Add(new SqlParameter("@BuyDate", this.BuyDate));
            connection.parameterlist.Add(new SqlParameter("@BuyNotes", this.BuyNotes));
            connection.parameterlist.Add(new SqlParameter("@Type", this.MybuyType.BuyTypeID));
            connection.parameterlist.Add(new SqlParameter("@Pague", this.methodPayment.MethodPaymentID));
            connection.parameterlist.Add(new SqlParameter("@Supplier", this.Supplier.SupplierID));
            connection.parameterlist.Add(new SqlParameter("@User", this.MyUser.UserID));

            int result = connection.EjecutarInsertUpdateDelete("SPBuyAdd");


            if (result > 0)
            {
                R = true;
            }
            return R;

        }



    }
}
