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

namespace VCBikeService.Forms.Factura
{
    public partial class FrmNewBilling : Form
    {

        private DataTable billigs {get;set;}
        private Logic.Models.Billing Mybilling { get; set; }

        private Logic.Models.Item myitem { get; set; }
        private Logic.Models.BillingDetail MybillingDetail { get; set; }
        public FrmNewBilling()
        {
            InitializeComponent();
            billigs = new DataTable();
            MybillingDetail = new BillingDetail();
            Mybilling = new Logic.Models.Billing();
            myitem = new Logic.Models.Item();
            
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();

                Globals.Frmfactura.Show();
            }
        }
        private void LoadListBilling()

        {
            billigs = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchCustomer.Text.Trim()) && TxtSearchCustomer.Text.Count() >= 3)
            {

                searchfilter = TxtSearchCustomer.Text.Trim();
            }


            

                billigs = MybillingDetail.ListBillingActive(searchfilter);
                
            
            DgCustList.DataSource = billigs;
        }
        private void BtnCancelC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmNewBilling_Load(object sender, EventArgs e)
        {
            LoadListBilling();
        }

        private void CheckCustomer_CheckedChanged(object sender, EventArgs e)
        {
            LoadListBilling();
            
        }

        private void BtnDeleteC_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtUser.Text.Trim())
            && !string.IsNullOrEmpty(TxtTypeBilling.Text.Trim()) && !string.IsNullOrEmpty(TxtTotal.Text.Trim()) && !string.IsNullOrEmpty(TxtDate.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtMethodPague.Text.Trim()))
            {
                if (Mybilling.BillingID > 0)
                {
                   

                        DialogResult r = MessageBox.Show("¿Está seguro de Desactivar esta Factura?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (Mybilling.Delete())
                            {
                                MessageBox.Show("la Factura se ha inactivado  correctamente.", "!!!", MessageBoxButtons.OK);
                                clean();
                                LoadListBilling();
                            }

                        }
                    
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar una Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void clean()
        { 
            TxtIDBilling.Clear();
            TxtTypeBilling.Clear();
            TxtCustomer.Clear();
            TxtDate.Clear();
            TxtMethodPague.Clear();
            TxtTotal.Clear();
            TxtUser.Clear();
            TxtSearchCustomer.Clear();
            
        }

        private void DgCustList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgCustList.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgCustList.SelectedRows[0];


                int IDBilling = Convert.ToInt32(Mifila.Cells["CBillingID"].Value);
                int cantidad = Convert.ToInt32(Mifila.Cells["CAmount"].Value);
                int id = Convert.ToInt32(Mifila.Cells["CItemID"].Value);
                string nombre = Convert.ToString(Mifila.Cells["CItemName"].Value);
                Mybilling = new Logic.Models.Billing();


                Mybilling.BillingID = IDBilling;



                Mybilling = Mybilling.SearchIDReturnBilling();

                if (Mybilling != null && Mybilling.BillingID > 0)
                {


                    TxtIDBilling.Text = Convert.ToString(Mybilling.BillingID);

                    TxtDate.Text = Convert.ToString(Mybilling.Date);
                    TxtCustomer.Text = Mybilling.MyCustomer.CustomerName;
                    txtCantidad.Text = Convert.ToString(cantidad);
                    txtnameproduct.Text = Convert.ToString(nombre);
                    txtIDproduct.Text = Convert.ToString(id);

                    TxtUser.Text =  Mybilling.MyUser.UserName;

                    TxtTotal.Text = Convert.ToString(Mybilling.MyDetail.TotalLine );

                    //Combobox

                    TxtMethodPague.Text = Convert.ToString(Mybilling.MYMethodPayment.Description);

                    TxtTypeBilling.Text = Convert.ToString(Mybilling.billingType.Description);

                }
            }
        }

        private void BtnCleanC_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUser.Text.Trim())
            && !string.IsNullOrEmpty(TxtTypeBilling.Text.Trim()) && !string.IsNullOrEmpty(TxtTotal.Text.Trim()) && !string.IsNullOrEmpty(TxtDate.Text.Trim()) &&
            !string.IsNullOrEmpty(TxtMethodPague.Text.Trim()))
            {
                if (Mybilling.BillingID > 0  )
                {
                    int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());
                    DataGridViewRow Mifila = DgCustList.SelectedRows[0];
                    int stock = Convert.ToInt32(Mifila.Cells["CStock"].Value);
                    int total = cantidad + stock;

                     myitem.ItemID = Convert.ToInt32( txtIDproduct.Text.Trim());
                    myitem.Stock = total;

                    if (myitem.UpdateStock())
                    {
                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar esta Factura?",
                                                                "???",
                                                                MessageBoxButtons.YesNo,
                                                                MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (Mybilling.DeleteForEver())
                            {
                                MessageBox.Show("la Factura  ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                clean();
                                LoadListBilling();
                            }

                        }
                        else
                        {
                            MessageBox.Show("la Factura no ha sido eliminado Por favor revisar.", "!!!", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se actualizo el producto ,Por favor revisar.", "!!!", MessageBoxButtons.OK);
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar una Factura", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void FrmNewBilling_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }
    }
    }

