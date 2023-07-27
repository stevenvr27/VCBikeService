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
        

        public DataTable ListaProductos { get; set; }


        public FrmSupplierBuy()
        {
            InitializeComponent();
            MiCompraLocal = new Buy();
           Supplier = new Supplier();

            ListaProductos = new DataTable();
        }

        private void FrmSupplierBuy_Load(object sender, EventArgs e)
        {
            textUserName.Text = Globals.MyGlobalUser.UserName;
            LoadMethodPayment();
            LoadBuyType();

        }

        private void BtnClienteBuscar_Click(object sender, EventArgs e)
        {
            Form FormSearchSupplier = new FrmSupplyerSearch();
            DialogResult resp = FormSearchSupplier.ShowDialog();

            if (resp == DialogResult.OK)
            {
                

                if (!string.IsNullOrEmpty(TxtSupplierD.Text.Trim()))
                {
                    int IdSupply = Convert.ToInt32(TxtSupplierD.Text.Trim());
                    

                    if (true)
                    {
                        TxtSupplyName.Visible = false;
                        lblNameSupply.Visible = false;
                        LabelCodigo.Visible = false;
                        textUserName.Visible = false;
                        lblNameUser.Visible = false;
                        lblNameSupply.Visible = false;

                       MiCompraLocal.Supplier = MiCompraLocal.Supplier.SearchID(IdSupply);
                        TxtSupplyName.Text = MiCompraLocal.Supplier.SupplierName;
                        textUserName.Text = Globals.MyGlobalUser.UserName;
                       

                        TxtSupplyName.Visible = true;
                        labelProveedor.Visible = false;
                        lblNameSupply.Visible= true;
                        LabelCodigo.Visible = true;
                        lblNameUser.Visible = true;
                        textUserName.Visible = true;
                        lblNameSupply.Visible = true;

                    }



                }

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
        private void CleanForm()
        {
            TxtSupplierD.Clear();
            TxtNotes.Clear();
            TxtSupplierD.Clear();
        }
      
         

        private void BtnProductoAgregar_Click(object sender, EventArgs e)
        {
            Form MiFormBusqueda = new FrmSupplyAddProduct();
            DialogResult respuesta = MiFormBusqueda.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                DgvLista.DataSource = ListaProductos;
            }
        }
    }
}