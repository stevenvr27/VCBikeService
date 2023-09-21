using Logic.Models;
using Logic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Productos;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmBuysearch : Form
    {
        private DataTable Lista { get; set; }
        public Buy MyBuy { get; set; }
        public BuyDetail MyDetail { get; set; }
        public Item myitem { get; set; }
        public BuyType mytype { get; set; }

        public FrmBuysearch()
        {
            this.KeyPreview = true;
            InitializeComponent();
            Lista = new DataTable();
            MyBuy = new Buy();
            loadlistproduct();
            MyDetail = new BuyDetail();
            myitem = new Item();
            mytype = new BuyType();
        }


        private void loadlistproduct()
        {
            Lista = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchCustomer.Text.Trim()) && TxtSearchCustomer.Text.Count() >= 3)
            {

                searchfilter = TxtSearchCustomer.Text.Trim();
            }


            if (CheckCustomer.Checked)
            {

                Lista = MyBuy.Listbuy(searchfilter);
            }
            else
            {
                Lista = MyBuy.Listbuyinactive(searchfilter);
            }
            DgBuys.DataSource = Lista;
        }



        private void CheckCustomer_CheckedChanged_1(object sender, EventArgs e)
        {
            loadlistproduct();
        }

        private void FrmBuysearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario si se presiona Escape
                this.Close();
            }
        }

        private void DgBuys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgBuys.SelectedRows.Count == 1)
            {
                DataGridViewRow Mifila = DgBuys.SelectedRows[0];

                int IDBuy = Convert.ToInt32(Mifila.Cells["CBuyID"].Value);
                int Cantidad = Convert.ToInt32(Mifila.Cells["CNuevoArticulos"].Value);
                String Nombre = Convert.ToString(Mifila.Cells["CItemName"].Value);
                int stock = Convert.ToInt32(Mifila.Cells["CStock"].Value);
                int total = Convert.ToInt32(Mifila.Cells["CTotal"].Value);
                int ID = Convert.ToInt32(Mifila.Cells["CItemID"].Value);
                myitem =new Logic.Models.Item();
                MyBuy.BuyID = IDBuy;
                MyBuy = MyBuy.SearchIDReturnbuy();
                txtcantidad.Text = Convert.ToString(Cantidad);
                txtitemname.Text = Convert.ToString(Nombre);
               txtcode.Text = Convert.ToString(ID);
                txtstock.Text = Convert.ToString(stock);
                txttotal.Text = Convert.ToString(total);
                TxtIDbuy.Text = Convert.ToString(IDBuy);
                TxtUser.Text = MyBuy.MyUser.UserName;
             
                TxtDate.Text = Convert.ToString(MyBuy.BuyDate);
                txtsupplier.Text = MyBuy.Supplier.SupplierName;

            }
        }

        private void BtnCancelC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct = new Productos.FrmBuyItem();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void clean()
        {

            TxtIDbuy.Clear();
            TxtUser.Clear();
             txttotal.Clear();
            txtstock.Clear();
            TxtDate.Clear();
            txtsupplier.Clear();
        }

       
        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUser.Text.Trim()))
            {
                string msg = string.Format("¿Está seguro que deseas eliminar  la compra ?", MyBuy.BuyID);

                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                MyBuy.BuyID = Convert.ToInt32(TxtIDbuy.Text.Trim());

                if (respuesta == DialogResult.Yes)
                {
                    if (MyBuy.Delete())
                    {

                        calcular();
                        

                    }
                    else
                    {
                        MessageBox.Show("la compra no ha sido  eliminada correctamente , revisar.", "!!!", MessageBoxButtons.OK);
                    }
                    clean();
                    loadlistproduct();

                }
                else
                {
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar una compra .", "!!!", MessageBoxButtons.OK);

            }

        }

        public void calcular()
        {
            int stockviejo = Convert.ToInt32( txtstock.Text.Trim());
            int nuevo = Convert.ToInt32(txtcantidad.Text.Trim());
            int stock = stockviejo - nuevo;
           myitem.Stock =stock;
            DataGridViewRow Mifila = DgBuys.SelectedRows[0];
            int ID = Convert.ToInt32(Mifila.Cells["CItemID"].Value);
              myitem.ItemID = ID ;

           if(myitem.UpdateStock())
            {
                MessageBox.Show("la compra    eliminada correctamente , revisar.", "!!!", MessageBoxButtons.OK);
            }
           else
            {
                MessageBox.Show("Algo salio mal , revisar.", "!!!", MessageBoxButtons.OK);
            }


            





        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }

}
