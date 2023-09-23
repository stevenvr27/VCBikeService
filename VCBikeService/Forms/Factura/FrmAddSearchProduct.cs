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

        public DataTable listitem { get; set; }

        Logic.Models.Item MyItem { get; set; }

        public FrmAddSearchProduct()
        {
            this.KeyPreview = true;
            InitializeComponent();
            listitem = new DataTable();
            MyItem = new Logic.Models.Item();
        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private void LlenarLista()
        {
            listitem = MyItem.newbuy();

            DgvListaItems.DataSource = listitem;
            DgvListaItems.ClearSelection();

        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();
        }




        private void btnadd_Click(object sender, EventArgs e)
        {
            if (ValidarItem())
            {
                DataRow existingRow = null;
                int newQuantity = Convert.ToInt32(TxtCantidad.Value);

                // Verificar si el producto ya existe en la factura
                foreach (DataRow row in Globals.Frmfactura.Localdetailist.Rows)
                {
                    if (row["ItemItemID"].ToString() == MyItem.ItemID.ToString())
                    {
                        existingRow = row;
                        break;
                    }
                }

                if (existingRow != null && checkBoxAgregarMasCantidad.Checked)
                {
                    // Si ya existe y el CheckBox está seleccionado, agregamos la nueva cantidad a la cantidad existente
                    int existingQuantity = Convert.ToInt32(existingRow["Amount"]);
                    newQuantity += existingQuantity;
                    existingRow["Amount"] = newQuantity;

                    // Actualizar el TotalLine de la fila existente con la nueva cantidad
                    decimal unitaryPrice = Convert.ToDecimal(existingRow["UnitaryPrice"]);
                    decimal impuestos = Convert.ToDecimal(existingRow["ImpuestoLine"]);
                    decimal totalLine = (unitaryPrice * newQuantity) + impuestos;
                    existingRow["TotalLine"] = totalLine;

                    // Actualizar el impuesto para reflejar la nueva cantidad
                    decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());

                    decimal PrecioMenosDescuento = unitaryPrice - ((unitaryPrice * PorcentajeDescuento) / 100);
                    decimal Impuestos = ((PrecioMenosDescuento * MyItem.Tax.AmountTax) / 100) * newQuantity;
                    existingRow["ImpuestoLine"] = Impuestos;
                }
                else
                {

                    DataRow NuevaLineaDetalleEnFacturacion = Globals.Frmfactura.Localdetailist.NewRow();

                    NuevaLineaDetalleEnFacturacion["ItemItemID"] = MyItem.ItemID;




                     

                    NuevaLineaDetalleEnFacturacion["Amount"] = TxtCantidad.Value;

                    NuevaLineaDetalleEnFacturacion["PercentageDiscount"] = Convert.ToDecimal(TxtDescuento.Text.Trim());

                    NuevaLineaDetalleEnFacturacion["UnitaryPrice"] = MyItem.SellPrice;

                    //calculo del impuesto por línea
                    decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());

                    decimal PrecioMenosDescuento = MyItem.SellPrice - ((MyItem.SellPrice * PorcentajeDescuento) / 100);
                    decimal Impuestos = ((PrecioMenosDescuento * MyItem.Tax.AmountTax) / 100) * TxtCantidad.Value;
                    NuevaLineaDetalleEnFacturacion["ImpuestoLine"] = Impuestos;

                    decimal TotalLinea = PrecioMenosDescuento * TxtCantidad.Value + Impuestos;
                    NuevaLineaDetalleEnFacturacion["TotalLine"] = TotalLinea;



                    NuevaLineaDetalleEnFacturacion["SubTotalLine"] = TxtCantidad.Value * PrecioMenosDescuento;

                    //una vez que se han alimentado los datos para la línea, se procede a adjuntar al datatable en detalles
                    //del form de facturación
                    Globals.Frmfactura.Localdetailist.Rows.Add(NuevaLineaDetalleEnFacturacion);
                }
                //Retornamos ok como respuesta al form de facturación
                DialogResult = DialogResult.OK;
            }
        }

    

        

        private bool ValidarItem()
        {
            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 && TxtCantidad.Value > 0)
            {
                //validación correcta
                R = true;
            }
            else
            {
                if (DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un item de la lista", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (TxtCantidad.Value == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }
            return R;

        }


        private void FrmAddSearchProduct_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }

       
        

        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgvListaItems.SelectedRows[0];


                int Idusuario = Convert.ToInt32(Mifila.Cells["CItemID"].Value);

                MyItem = new Logic.Models.Item();

                MyItem.ItemID = Idusuario;

                MyItem = MyItem.ConsultarPorID(Idusuario);

                if (MyItem != null && MyItem.ItemID > 0)
                {
                    TxtIVA.Text = MyItem.Tax.AmountTax.ToString();
                    TxtPrecioUnitario.Text = MyItem.SellPrice.ToString();

                    //calcular el monto del precio final (tomando en cuenta el % de descuento)
                    CalcularPrecioFinal(MyItem, Convert.ToDecimal(TxtDescuento.Text.Trim()));




                }
            }
        }

        private void CalcularPrecioFinal(Logic.Models.Item pProducto, decimal PorcentajeDescuento)
        {


            decimal PrecioConDescuento = pProducto.SellPrice - ((pProducto.SellPrice * PorcentajeDescuento) / 100);

            decimal PrecioConImpuesto = PrecioConDescuento + ((PrecioConDescuento * pProducto.Tax.AmountTax) / 100);

            TxtPrecioFinal.Text = PrecioConImpuesto.ToString();
        }

        private void FrmAddSearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyCode == Keys.Escape)
                {
                    // Cierra el formulario si se presiona Escape
                    this.Close();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    // Realiza el clic en el botón "Facturar" si se presiona Enter
                    btnadd.PerformClick();
                }
            
        }
    }

}
