using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;

namespace Logic.Models
{
    public  class Buy
    {
        //atributos 
        public int BuyID { get; set; }

        public DateTime BuyDate { get; set; } 

        public int BuyNumber { get; set; }
        public string BuyNotes { get; set;}

        public bool Active { get; set; }

        //Atributos compuestos 
        public User MyUser { get; set; }    
        public Supplier Supplier { get; set; }
        public BuyType BuyType { get; set; }

        public MethodPayment methodPayment { get; set; }

        // lista 

        public List<BuyDetail> BuyDetail { get; set; }


       // constructor 
        public Buy() 
        {
             MyUser = new User();
             Supplier = new Supplier();
              methodPayment = new MethodPayment();
              BuyDetail = new List<BuyDetail>();
             
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




    }
}
