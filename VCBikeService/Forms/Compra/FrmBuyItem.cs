using Logic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace VCBikeService.Forms.Productos
{
    public partial class FrmBuyItem : Form
    {

        private Logic.Models.Item Myitem { get; set; }
        private Logic.Models.BuyDetail BuyDetail { get; set; }
        private Logic.Models.Buy Mybuy { get; set; }
        private DataTable ListItem { get; set; }

        public FrmBuyItem()
        {
            InitializeComponent();
            Myitem = new Logic.Models.Item();
            ListItem = new DataTable();
            Mybuy = new Logic.Models.Buy();
            BuyDetail = new Logic.Models.BuyDetail();

        }

        private void BtnDeleteproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void clean()
        {
            TxtProductName.Clear();
            TxtIDProduct.Clear();
            txtbuytype.SelectedIndex = -1;
            txtmetpag.SelectedIndex = -1;
            TxtSupplier.SelectedIndex = -1;
            TxtCantidad.Text = "0";
            txtUnitaryPrice.Text = "0";

            TxtPrecioFinal.Text = "0";


        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtIDProduct.Text.Trim()) && !string.IsNullOrEmpty(TxtProductName.Text.Trim())
                     && txtbuytype.SelectedIndex > -1 && txtmetpag.SelectedIndex > -1 && txtbuytype.SelectedIndex > -1)
            {
                Mybuy = new Logic.Models.Buy();
                Mybuy.MybuyType.BuyTypeID = Convert.ToInt32(txtbuytype.SelectedValue);
                Mybuy.methodPayment.MethodPaymentID = Convert.ToInt32(txtmetpag.SelectedValue);
                Mybuy.Supplier.SupplierID = Convert.ToInt32(TxtSupplier.SelectedValue);
                Mybuy.MyUser.UserID = Globals.MyGlobalUser.UserID;
                Myitem = new Logic.Models.Item();
                Myitem.Stock = Convert.ToInt32(TxtCantidad.Value);
                Myitem.UnitaryCost = Convert.ToDecimal(txtUnitaryPrice.Text.Trim());
                Myitem.ItemID = Convert.ToInt32(TxtIDProduct.Text.Trim());
                BuyDetail = new Logic.Models.BuyDetail();
               
                BuyDetail.UnitaryPrice = Convert.ToDecimal(txtUnitaryPrice.Text.Trim());
                BuyDetail.Total = Convert.ToDecimal(TxtPrecioFinal.Text.Trim());



                foreach (DataRow item in ListItem.Rows)
                {
                    BuyDetail buyDetail = new BuyDetail();
                    buyDetail.ItemID = Convert.ToInt32(item["ItemID"]);

                    if (decimal.TryParse(txtUnitaryPrice.Text.Trim(), out decimal unitaryPrice))
                    {
                        buyDetail.UnitaryPrice = unitaryPrice;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Unitary Price input.", "Error", MessageBoxButtons.OK);
                        return; // Exit the loop or function, since there's an issue.
                    }

                    if (decimal.TryParse(TxtPrecioFinal.Text.Trim(), out decimal totalPrice))
                    {
                        buyDetail.Total = totalPrice;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Total Price input.", "Error", MessageBoxButtons.OK);
                        return; // Exit the loop or function, since there's an issue.
                    }

                    Mybuy.BuyDetail.Add(buyDetail);
                }
                 


                string msg = string.Format("¿Está seguro que deseas crear la compra ?", Mybuy.BuyID);

                DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                    int stockNuevo = Convert.ToInt32(TxtCantidad.Value);
                    int stockActualEnBaseDeDatos = Myitem.ObtenerStockDesdeBaseDeDatos(Myitem.ItemID);

                    int stockTotal = stockActualEnBaseDeDatos + stockNuevo;

                    Myitem.Stock = stockTotal;
                    Myitem.UnitaryCost = Convert.ToDecimal(txtUnitaryPrice.Text.Trim());






                    if (Mybuy.Add())
                    {
                        Item item = new Item();  // Crear una instancia de la clase Item
                        if (item.ActualizarStockEnBaseDeDatos(Myitem.ItemID, stockTotal, Myitem.UnitaryCost))
                        {

                            MessageBox.Show("La compra no se pudo crear!", ":/", MessageBoxButtons.OK);
                            clean();



                        }
                        else
                        {

                            MessageBox.Show("Compra creada correctamente!", ":)", MessageBoxButtons.OK);
                            clean();
                            loadlistproduct();


                        }
                    }






                }
                else
                {
                    MessageBox.Show("La compra no se pudo crear!", ":/", MessageBoxButtons.OK);
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Te Faltan Datos que ingresar ", ":/", MessageBoxButtons.OK);

            }








        }




        private void btnfacturacliente_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();
                Globals.Frmfactura.Show();
            }
        }

        private void FrmSearchProduct_Load(object sender, EventArgs e)
        {
            loadlistproduct();
            Date();
            LoadMethodPayment();
            LoadBuytype();
            LoadSupplier();
        }


        private void loadlistproduct()
        {
            ListItem = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchItem.Text.Trim()) && TxtSearchItem.Text.Count() >= 3)
            {

                searchfilter = TxtSearchItem.Text.Trim();
            }
            ListItem = Myitem.ListUnitaryCost(searchfilter);

            DgProduct.DataSource = ListItem;
        }
        private void LoadBuytype()
        {
            Logic.Models.BuyType type = new Logic.Models.BuyType();

            DataTable dt = new DataTable();
            dt = type.list();

            if (dt != null && dt.Rows.Count > 0)
            {
                txtbuytype.ValueMember = "ID";
                txtbuytype.DisplayMember = "Descrip";
                txtbuytype.DataSource = dt;
                txtbuytype.SelectedIndex = -1;

            }
        }
        private void LoadMethodPayment()
        {
            Logic.Models.MethodPayment type = new Logic.Models.MethodPayment();

            DataTable i = new DataTable();
            i = type.List();

            if (i != null && i.Rows.Count > 0)
            {
                txtmetpag.ValueMember = "ID";
                txtmetpag.DisplayMember = "Descrip";
                txtmetpag.DataSource = i;
                txtmetpag.SelectedIndex = -1;

            }
        }
        private void LoadSupplier()
        {
            Logic.Models.Supplier type = new Logic.Models.Supplier();

            DataTable i = new DataTable();
            i = type.list();

            if (i != null && i.Rows.Count > 0)
            {
                TxtSupplier.ValueMember = "ID";
                TxtSupplier.DisplayMember = "Descrip";
                TxtSupplier.DataSource = i;
                TxtSupplier.SelectedIndex = -1;
            }
        }


        private void Date()
        {
            TxtDate.Text = DateTime.Now.ToLongDateString();


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

        private void DgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Mifila = DgProduct.SelectedRows[0];


            int Iditem = Convert.ToInt32(Mifila.Cells["CItemID"].Value);

            Myitem = new Logic.Models.Item();


            Myitem.ItemID = Iditem;
            Myitem = Myitem.SearchItemandBuy();
            if (Myitem != null && Myitem.ItemID > 0)
            {
                TxtIDProduct.Text = Convert.ToString(Myitem.ItemID);
                TxtProductName.Text = Myitem.ItemName;
                txtUnitaryPrice.Text = Myitem.UnitaryCost.ToString();



            }
        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtUnitaryPrice_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void calcular()
        {
           


            int stock = Convert.ToInt32(TxtCantidad.Value);
            decimal valorUnitario;

            if (decimal.TryParse(txtUnitaryPrice.Text.Trim(), out valorUnitario))
            {
                decimal total = valorUnitario * stock;
                TxtPrecioFinal.Text = total.ToString();
            }
          



        }

    }
}
