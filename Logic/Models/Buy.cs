using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Xml.Linq;

namespace Logic.Models
{
    public class Buy
    {
        //atributos 
        public int BuyID { get; set; }

        public DateTime BuyDate { get; set; }


        public string BuyNotes { get; set; }

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
            BuyDate = DateTime.Now;

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
        public DataTable Listbuy(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", true));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = Micnn.EjecutarSELECT("SPListaDecompras");

            return R;
        }
        public Buy SearchIDReturnbuy()
        {
            // metodo para buscar el id y que me retorne info del cliente 
            Buy R = new Buy();

            Connection Micnn = new Connection();
            Micnn.parameterlist.Add(new SqlParameter("@ID", this.BuyID));
            DataTable dt = new DataTable();
            dt = Micnn.EjecutarSELECT("SPbuysearchid");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.Supplier.SupplierName = Convert.ToString(dr["SupplierName"]);
                R.MyUser.UserName = Convert.ToString(dr["UserName"]);
                R.BuyDate = Convert.ToDateTime(dr["BuyDate"]);



            }



            return R;

        }
        public DataTable Listbuyinactive(string pFiltroBusqueda)
        {
            DataTable R = new DataTable();

            Connection Micnn = new Connection();

            Micnn.parameterlist.Add(new SqlParameter("@VerActivo ", false));
            Micnn.parameterlist.Add(new SqlParameter("@FiltroBusqueda", pFiltroBusqueda));

            R = Micnn.EjecutarSELECT("SPListaDecompras");

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

            Object Retorno = connection.EjecutarSELECTEscalar("SPBuyAdd");

            int IdFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                // Una vez que se tiene el ID de la factura, se pueden agregar los detalles
                this.BuyID = IdFacturaRecienCreada;

                foreach (BuyDetail item in this.BuyDetail)
                {
                    // Se hace un insert por cada iteración en detalles
                    Connection MyCnnDetalle = new Connection();

                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@BuyID", IdFacturaRecienCreada));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@ItemID", item.ItemID));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@total", item.Total));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@UnitaryPrice ", item.UnitaryPrice));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@NuevoArticulos", item.NuevoArticulos));
                    

                    MyCnnDetalle.EjecutarInsertUpdateDelete("SPBuyDetailAdd");
                      
                    


                }
                  R = true;
                
            }

            return R;
        }




        // metodo eliminar y su respectivo llamado al procedimiento almacenado 
        public bool Delete()
        {
            bool R = false;

            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.BuyID));
            int r = connection.EjecutarInsertUpdateDelete("SPBuyDelete");

            if (r < 0)
            {
                R = true;
            }

            return R;


        }
    }
}


            
         