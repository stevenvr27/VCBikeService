using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Productos;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmBuy : Form
    {
        public Buy MiCompraLocal { get; set; }
        public Billing MyBilling { get; set; }

        public DataTable ListaProductos { get; set; }
        
        

        public FrmBuy()
        {
            InitializeComponent();
            MiCompraLocal = new Buy();
            MyBilling = new Billing();
            ListaProductos = new DataTable();
        }
     

     
        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form miform = new FrmAddSearchProduct();

            DialogResult respuesta = miform.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;

                total();
            }

            
        }
        private void total()
        {
              
            if (ListaProductos.Rows.Count > 0)
            {
                

                decimal totalItems = 0;
                decimal totalMonto = 0;

                foreach (DataRow row in ListaProductos.Rows)
                {
                    totalItems += Convert.ToDecimal(row["Cantidad"]);
                    //totalItems = totalItems + algo

                    totalMonto += Convert.ToDecimal(row["PrecioVentaUnitario"]) * Convert.ToDecimal(row["Cantidad"]);

                }

                TxtTotalCantidad.Text = totalItems.ToString();

                //este formato sirve para representar un valor monetario, 
                //existen muchísimos más formatos personalizados, por favor investigar
                //{0:N2}
                TxtTotal.Text = string.Format("{0:C2}", totalMonto);

            }

        }
        private void LoadBuyType()
        {
            Logic.Models.BuyType type = new Logic.Models.BuyType();

            DataTable dt = new DataTable();
            dt = type.list();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbBuyType.ValueMember = "ID";
                CbBuyType.DisplayMember = "Descrip";
                CbBuyType.DataSource = dt;
                CbBuyType.SelectedIndex = -1;

            }
        }

        private void LoadMethodPayment()
        {
            Logic.Models.MethodPayment type = new Logic.Models.MethodPayment();

            DataTable i = new DataTable();
            i = type.List();

            if (i != null && i.Rows.Count > 0)
            {
                cvMethodp.ValueMember = "ID";
                cvMethodp.DisplayMember = "Descrip";
                cvMethodp.DataSource = i;
                cvMethodp.SelectedIndex = -1;

            }
        }


        private void FrmBuy_Load(object sender, EventArgs e)
        {
            // loadTypeBilling();

            // Clean();

            LoadBuyType();
            LoadMethodPayment();
        }

        private void BtnClienteBuscar_Click(object sender, EventArgs e)
        {
            Form FormSearchCustomer = new FrmSearchCustomer();
            DialogResult resp = FormSearchCustomer.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //cargar la info del usuario en la composición de MiFacturaLocal 
                //y además mostrar el nombre del usuario en el Label 

                if (!string.IsNullOrEmpty(TxtClienteID.Text.Trim()))
                {
                    int IdCliente = Convert.ToInt32(TxtClienteID.Text.Trim());

                    //se incluyen los datos en la composición del cliente
                    if (true)
                    {
                        labelCliente.Visible = false;
                        
                        MyBilling.MyCustomer = MyBilling.MyCustomer.SearchID(IdCliente);

                        LblClienteNombre.Text = MyBilling.MyCustomer.CustomerName;
                        LblClienteNombre.Visible = true;
                        nombre.Visible = true;

                    }
                    

                    
                }

            }

        }

        
    }
}
