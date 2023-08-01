using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms.Productos
{
    public partial class FrmSearchProduct : Form
    {

        private Logic.Models.Item Myitem { get; set; }
        private DataTable ListItem { get; set; }
        public FrmSearchProduct()
        {
            InitializeComponent();
            Myitem = new Logic.Models.Item();
            ListItem = new DataTable();
        }

        private void BtnDeleteproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.frmSupplierBuy.Visible)
            {
                Globals.frmSupplierBuy = new Compra.FrmSupplierBuy();
                Globals.frmSupplierBuy.Show();
            }
        }

        private void btnfacturacliente_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmBuy();
                Globals.Frmfactura.Show();
            }
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            loadlistproduct();
        }


        private void loadlistproduct()
        {
            ListItem = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchItem.Text.Trim()) && TxtSearchItem.Text.Count() >= 3)
            {

                searchfilter = TxtSearchItem.Text.Trim();
            }


            

                ListItem = Myitem.ListActiveSellPrice(searchfilter);
            
            DgProduct.DataSource = ListItem;
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadlistproduct();
        }

        private void FrmSearchProduct_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }
    }
}
