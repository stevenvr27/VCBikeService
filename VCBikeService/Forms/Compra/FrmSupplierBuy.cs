using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmSupplierBuy : Form
    {
        public Buy MiCompraLocal { get; set; }

        public Supplier Supplier { get; set; }
        public User User { get; set; }


        public DataTable ListaProductos { get; set; }


        public FrmSupplierBuy()
        {
            InitializeComponent();
            MiCompraLocal = new Buy();
            Supplier = new Supplier();
            User = new User();


            ListaProductos = new DataTable();
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
        private void Date (){
          TxtDate.Text = DateTime.Now.ToLongDateString();


        }

        private void user()
        {
            string Username = Globals.MyGlobalUser.UserName; ;
            TxtUSer.Text = Username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.frmSupplierBuy.Visible)
            {
                Globals.FrmSupplyAddProduct = new Compra.FrmSupplyAddProduct();
                Globals.FrmSupplyAddProduct.Show();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSupplierBuy_Load(object sender, EventArgs e)
        {
            user();
            LoadMethodPayment();
            LoadBuytype();
            Date();
        }
    }
}