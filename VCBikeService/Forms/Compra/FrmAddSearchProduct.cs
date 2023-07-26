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
using VCBikeService.Forms.Compra;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmAddSearchProduct : Form
    {

       public  DataTable ListaProductos { get; set; }

        public Logic.Models.Item  MiProductoLocal { get; set; }

        public FrmAddSearchProduct()
        {
            InitializeComponent();
            ListaProductos = new DataTable();
            MiProductoLocal = new Logic.Models. Item();
        }

         

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
        private void LlenarLista()
        {
            ListaProductos = MiProductoLocal.newbuy();

            DgvLista.DataSource = ListaProductos;
            DgvLista.ClearSelection();

        }

        private void FrmAddSearchProduct_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

       

       
        private void Limpiar()
        {
            SubTotal1 = 0;
            TotalDescuento = 0;
            SubTotal2 = 0;
            TotalImpuesto = 0;
            Total = 0;
            PrecioUnitario = 0;
            TasaImpuesto = 0;
            PorcentajeDescuento = 0;
            Cantidad = 0;

             
            TxtIVA.Text = "0";
            TxtTotal.Text = "0";

        }

        private void DgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Limpiar();
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow fila = DgvLista.SelectedRows[0];
                decimal Precio = Convert.ToDecimal(fila.Cells["CSellPrice"].Value);
                decimal IVA = Convert.ToDecimal(fila.Cells["CTasaImpuesto"].Value);

                TxtIVA.Text = IVA.ToString();
                TxtPrecioUnitario.Text = Precio.ToString();


                Calcular();
            }



        }
        private void Calcular()
        {
            //Este método calcula los valores de
            //subtotal, descuento, impuesto y total para la línea 
            //en este caso particular se debe validar que el descuento
            //no supere el 100%
            //if (ValidarDescuento())
           // {
                Cantidad = Convert.ToDecimal(NudCantidad.Value);
                PorcentajeDescuento = Convert.ToDecimal(desc.Value);

                PrecioUnitario = Convert.ToDecimal(TxtPrecioUnitario.Text.Trim());
                TasaImpuesto = Convert.ToDecimal(TxtIVA.Text.Trim());

                //1. Canculo del Subtotal 
                SubTotal1 = Cantidad * PrecioUnitario;

                if (PorcentajeDescuento > 0)
                {
                    TotalDescuento = (SubTotal1 * PorcentajeDescuento) / 100;
                }

                SubTotal2 = SubTotal1 - TotalDescuento;

                }

                Total = SubTotal2 + TotalImpuesto;

                TxtTotal.Text = string.Format("{0:N2}", Total);


        }


        //    return R;
        //}

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        

        private void NudCantidad_Leave(object sender, EventArgs e)
        {
            Calcular();
        }



        



        }

    }
    
}
