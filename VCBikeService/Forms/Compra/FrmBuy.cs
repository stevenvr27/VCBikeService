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
        
        private bool itemSeleccionado = false;
        public int CantidadItemSeleccionado = 0;
        public int IDItem = 0;
        public decimal SubTotal1 { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUnitario { set; get; }
        public decimal TasaImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Cantidad { get; set; }

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
                DgvLista.ClearSelection();
               


            }

            
        }
       

        private void FrmBuy_Load(object sender, EventArgs e)
        {
           // loadTypeBilling();

           // Clean();
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
