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

        public decimal SubTotal1 { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal SubTotal2 { get; set; }
        public decimal TotalImpuesto { get; set; }
        public decimal Total { get; set; }
        public decimal PrecioUnitario { set; get; }
        public decimal TasaImpuesto { get; set; }
        public decimal PorcentajeDescuento { get; set; }
        public decimal Cantidad { get; set; }

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

            NudCantidad.Value = 1;
            TxtPrecioUnitario.Text = "0";
            TxtDescuento.Text = "0";
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
            if (ValidarDescuento())
            {
                Cantidad = Convert.ToDecimal(NudCantidad.Value);
                PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());

                PrecioUnitario = Convert.ToDecimal(TxtPrecioUnitario.Text.Trim());
                TasaImpuesto = Convert.ToDecimal(TxtIVA.Text.Trim());

                //1. Canculo del Subtotal 
                SubTotal1 = Cantidad * PrecioUnitario;

                if (PorcentajeDescuento > 0)
                {
                    TotalDescuento = (SubTotal1 * PorcentajeDescuento) / 100;
                }

                SubTotal2 = SubTotal1 - TotalDescuento;

                if (TasaImpuesto > 0)
                {
                    TotalImpuesto = (SubTotal2 * TasaImpuesto) / 100;
                }

                Total = SubTotal2 + TotalImpuesto;

                TxtTotal.Text = string.Format("{0:N2}", Total);

            }

        }
        private bool ValidarDescuento()
        {
            bool R = false;
            try
            {
                if (!string.IsNullOrEmpty(TxtDescuento.Text.Trim()) &&
                Convert.ToDecimal(TxtDescuento.Text.Trim()) >= 0 &&
                Convert.ToDecimal(TxtDescuento.Text.Trim()) <= 100)
                {
                    R = true;
                }
                else
                {
                    if (Convert.ToDecimal(TxtDescuento.Text.Trim()) > 100)
                    {
                        MessageBox.Show("Los descuentos no pueden ser superiores a 100", "Error de validación", MessageBoxButtons.OK);
                        return false;
                    }
                    if (Convert.ToDecimal(TxtDescuento.Text.Trim()) < 0)
                    {
                        MessageBox.Show("Los descuentos no pueden ser números negativos", "Error de validación", MessageBoxButtons.OK);
                        return false;
                    }

                }
            }
            catch (Exception)
            {
                TxtDescuento.Text = "0";
                TxtDescuento.SelectAll();
            }

            return R;
        }

        private void TxtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtDescuento.Text.Trim()))
            {
                TxtDescuento.Text = "0";
                TxtDescuento.SelectAll();
            }
        }

        private void NudCantidad_Leave(object sender, EventArgs e)
        {
            Calcular();
        }

        private void NudCantidad_ValueChanged(object sender, EventArgs e)
        {
            Calcular();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1 &&
                !string.IsNullOrEmpty(TxtTotal.Text.Trim()) &&
                Convert.ToDecimal(TxtTotal.Text.Trim()) > 0)
            {
                DataGridViewRow r = DgvLista.SelectedRows[0];
                int IdItem = Convert.ToInt32(r.Cells["CItemID"].Value);
                string NombreItem = Convert.ToString(r.Cells["CItemName"].Value);


                if (Duplicado(IdItem) == 0)
                {
                    DataRow NuevaFilaEnFacturacion = Globals.FrmCompra.ListaProductos.NewRow();

                    NuevaFilaEnFacturacion["IDInventario"] = IdItem;
                    NuevaFilaEnFacturacion["ItemName"] = NombreItem;
                    NuevaFilaEnFacturacion["PrecioVenta"] = PrecioUnitario;
                    NuevaFilaEnFacturacion["Cantidad"] = Cantidad;
                    NuevaFilaEnFacturacion["TasaImpuesto"] = TasaImpuesto;
                    NuevaFilaEnFacturacion["PorcentajeDescuento"] = PorcentajeDescuento;
                    NuevaFilaEnFacturacion["SubTotal"] = SubTotal1;
                    NuevaFilaEnFacturacion["SubTotal2"] = SubTotal2;
                    NuevaFilaEnFacturacion["ImpuestosTotal"] = TotalImpuesto;
                    NuevaFilaEnFacturacion["TotalLinea"] = Total;
                    NuevaFilaEnFacturacion["DescuentoTotal"] = TotalDescuento;
                    Globals.FrmCompra.ListaProductos.Rows.Add(NuevaFilaEnFacturacion);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    MessageBox.Show("Ya existe ese Item en la lista de la Factura",
                       " Error Item Duplicado!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int Duplicado(int valor)
        {
            int resultado = 0;
            foreach (DataRow row in Globals.FrmCompra.ListaProductos.Rows)
            {
                int encontrar = Convert.ToInt32(row["IDInventario"]);
                if (encontrar == valor)
                {
                    resultado = 1;
                }
            }
            return resultado;
        }
    }
    
}
