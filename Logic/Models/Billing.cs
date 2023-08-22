using Logic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Logic.Models
{//si
    public class Billing
    { 
        //atributos 
        public int BillingID { get; set; }
        public DateTime Date { get; set; } 

        public decimal SubTotal { get; set; }
        public decimal Descuentos { get; set; }
     
        public decimal Impuesto { get; set; }
        public decimal Total { get; set; }
        public string Notes { get; set; }
        public bool Active { get; set; }

        //atributos compuestos 
        public Customer MyCustomer { get; set; }
        public User MyUser { get; set; }
        public MethodPayment MYMethodPayment { get; set; }

        public BillingDetail MyDetail { get; set; }

        public BillingType billingType { get; set; }

         public List<BillingDetail> DetailItems { get; set; }

       //constructor  
        public Billing()
        {
            MyCustomer = new Customer();
            MyUser = new User();
            Date = DateTime.Now;
            DetailItems = new List<BillingDetail>();
            MYMethodPayment = new MethodPayment();
            billingType = new BillingType();
            MyDetail = new BillingDetail();


        }
        // metodo agregar y su respecitvo llamado al procedimiento almacenado 
        public bool Add()
        {
            bool R = false;
             
            Connection MyCnnEncabezado = new Connection();

             
          
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@date", this.Date));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@subtotal", this.SubTotal));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@descuentos", this.Descuentos)); 
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@Impuestos", this.Impuesto));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@total", this.Total));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@notas", this.Notes));  
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@idcliente", this.MyCustomer.CustomerID));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@idusuario", this.MyUser.UserID));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@MethodPayment", this.MYMethodPayment.MethodPaymentID));
            MyCnnEncabezado.parameterlist.Add(new SqlParameter("@billingTypeID", this.billingType.BillingTypeID));
            Object Retorno = MyCnnEncabezado.EjecutarSELECTEscalar ("SpBillingAddHeader");

            int IdFacturaRecienCreada = 0;

            if (Retorno != null)
            {
                IdFacturaRecienCreada = Convert.ToInt32(Retorno.ToString());

                // Una vez que se tiene el ID de la factura, se pueden agregar los detalles
                this.BillingID = IdFacturaRecienCreada;

                foreach (BillingDetail item in this.DetailItems)
                {
                    // Se hace un insert por cada iteración en detalles
                    Connection MyCnnDetalle = new Connection();

                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@idfactura", IdFacturaRecienCreada));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@idproducto", item.MyItem.ItemID)); 
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@cantidad", item.Amount));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@precio", item.UnitaryPrice));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@porcentajedescuento", item.PercentageDiscount));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@subtotallinea", item.SubTotalLine));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@impuestoslinea", item.ImpuestoLine));
                    MyCnnDetalle.parameterlist.Add(new SqlParameter("@total", item.TotalLine));

                    MyCnnDetalle.EjecutarInsertUpdateDelete("SpBillingAddDetail");
 
                   

                     
                     
                }

                R = true;
            }

            return R;
        }

        // metodo actualizar prodcuto en stock  y su respecitvo llamado al procedimiento almacenado 
        public bool UpdateProductStock()
        {

            bool R = false;
            Connection connection = new Connection();
           
           

            connection.parameterlist.Add(new SqlParameter("@ProductoID", this.MyDetail.MyItem.ItemID));
            connection.parameterlist.Add(new SqlParameter("@NuevaCantidad", this.MyDetail.MyItem.Stock));

            int result = connection.EjecutarInsertUpdateDelete("SpUpdateProductStock");

            if (result > 0)
            {
                R = true;
            }
            return R;
        }


        // metodo eliminar que realmente Desactiva al cliente   y su respecitvo llamado al procedimiento almacenado   

        public bool Delete()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.BillingID));
            int r = connection.EjecutarInsertUpdateDelete("SPBillingDesactive");

            if (r > 0)
            {
                R = true;
            }

            return R;

        }
        // metodo eliminar para siempre de la bd  y su respecitvo llamado al procedimiento almacenado 
        public bool DeleteForEver()
        {
            bool R = false;
            Connection connection = new Connection();
            connection.parameterlist.Add(new SqlParameter("@ID", this.BillingID));
            int r = connection.EjecutarInsertUpdateDelete("SPDeleteBilling");

            if (r > 0)
            {
                R = true;
            }

            return R;
        }
        // metodo buscar el id retornar factura  y su respecitvo llamado al procedimiento almacenado 
        public Billing SearchIDReturnBilling()
        {

            Billing R = new Billing();
            Connection Micnn = new Connection();
            Micnn.parameterlist.Add(new SqlParameter("@ID", this.BillingID));
            DataTable dt = new DataTable();
            dt = Micnn.EjecutarSELECT("SPBillingSearchID");
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                R.BillingID = Convert.ToInt32(dr["BillingID"]);
                R.Date = Convert.ToDateTime(dr["Date"]);
                R.MyCustomer.CustomerName = Convert.ToString(dr["CustomerName"]);
                R.MyUser.UserName = Convert.ToString(dr["UserName"]);
                R.MyDetail.TotalLine = Convert.ToDecimal(dr["TotalLine"]);
                R.MYMethodPayment.Description = Convert.ToString(dr["Description"]);
                R.billingType.Description = Convert.ToString(dr["Expr1"]);

            }



            return R;

        }
        // metodo suma del detalle y su respecitvo llamado al procedimiento almacenado 
        public DataTable Detailsummary()
        {
            DataTable R = new DataTable();

            Connection MyCnn = new Connection();

            R = MyCnn.EjecutarSELECT("SpBillingDetailsummary", true);

            R.PrimaryKey = null;
            return R;
        }
        private void Totalizar()
        {
            
            this.SubTotal = 0;
             
            this.Impuesto = 0;
            this.Total = 0;

        }




    }
}
