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

        public DataTable ListaProductos { get; set; }
        
        

        public FrmBuy()
        {
            InitializeComponent();
            MiCompraLocal = new Buy();
            MyBilling = new Billing();
            ListaProductos = new DataTable();
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


        private void FrmBuy_Load(object sender, EventArgs e)
        {
            // loadTypeBilling();


            LoadBuyType();
            LoadMethodPayment();
        }

        private void BtnClienteBuscar_Click(object sender, EventArgs e)
        {
            Form FormSearchCustomer = new FrmSearchCustomer();
            DialogResult resp = FormSearchCustomer.ShowDialog();

            if (resp == DialogResult.OK)
            {

                if (!string.IsNullOrEmpty(TxtClienteID.Text.Trim()))
                {
                    int IdCliente = Convert.ToInt32(TxtClienteID.Text.Trim());

                    //se incluyen los datos en la composición del cliente
                    if (true)
                    {
                        labelCliente.Visible = false;
                        


                    }
                    

                    
                }

            }
        }
    }
