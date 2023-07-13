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

namespace VCBikeService.Forms.Compra
{
    public partial class FrmSupplyAddProduct : Form
    {

        DataTable ListaProductos { get; set; }

        Item MiProductoLocal { get; set; }

        public FrmSupplyAddProduct()
        {
            InitializeComponent();
            ListaProductos = new DataTable();
            MiProductoLocal = new Item();
        }

        private void FrmSupplyAddProduct_Load(object sender, EventArgs e)
        {
            LlenarLista();
        }
        private void LlenarLista()
        {
            ListaProductos = new DataTable();

            ListaProductos = MiProductoLocal.ListarEnBusqueda();

            DgProduct.DataSource = ListaProductos;

            DgProduct.ClearSelection();

        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgProduct.SelectedRows.Count == 1)
            {
                DataGridViewRow row = DgProduct.SelectedRows[0];

                //se extraen los valores del producto de la fila seleccionada
                int IdProducto = Convert.ToInt32(row.Cells["CItemID"].Value);
                string NombreProducto = Convert.ToString(row.Cells["CItemName"].Value);
                string CodigoBarras = Convert.ToString(row.Cells["CBarcode"].Value);
                decimal Precio = Convert.ToDecimal(row.Cells["CUnitaryCost"].Value);
                decimal Cantidad = NumUDCantidad.Value;

                //Se crea una nueva fila del datatable de detalle del formulario
                //de registro de compra y además se asigna los valores recolectados
                DataRow MiFila = Globals.frmSupplierBuy.ListaProductos.NewRow();
                MiFila["CItemID"] = IdProducto;
                MiFila["CCantidad"] = Cantidad;
                MiFila["CUnitaryCost"] = Precio;
                MiFila["CItemNAme"] = NombreProducto;
                MiFila["CBarcode"] = CodigoBarras;

                Globals.frmSupplierBuy.ListaProductos.Rows.Add(MiFila);

                DialogResult = DialogResult.OK;
            }

        }

    }
    
}
