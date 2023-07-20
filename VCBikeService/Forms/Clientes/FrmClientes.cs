using Logic.Models;
using SolrNet.Mapping.Validation.Rules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms.Clientes
{
    public partial class FrmClientes : Form
    {
        private Logic.Models.Customer newcustomer { get; set; }
        private DataTable CustomerList { get; set; }

        public FrmClientes()
        {
            InitializeComponent();
            CustomerList = new DataTable();
            newcustomer = new Logic.Models.Customer();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            LoadTypeCustomer();
            LoadListCustomer();
        }
        private void LoadListCustomer()

        {
            CustomerList = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchCustomer.Text.Trim()) && TxtSearchCustomer.Text.Count() >= 3)
            {

                searchfilter = TxtSearchCustomer.Text.Trim();
            }


            if (CheckCustomer.Checked)
            {

                CustomerList = newcustomer.ListCustomerActive(searchfilter);
            }
            else
            {
                CustomerList = newcustomer.ListCustomerInactive(searchfilter);
            }
            DgCustList.DataSource = CustomerList;
        }

        private void LoadTypeCustomer()
        {
            Logic.Models.CustomerType customerType = new Logic.Models.CustomerType();
            DataTable a = new DataTable();
            a = customerType.ListCustomerType();

            if (a != null && a.Rows.Count > 0)
            {
                CbTypeCustomer.ValueMember = "ID";
                CbTypeCustomer.DisplayMember = "Descrip";
                CbTypeCustomer.DataSource = a;
                CbTypeCustomer.SelectedIndex = -1;
            }
        }

        private void BtnCancelC_Click(object sender, EventArgs e)
        {
            this.Hide();
        }



        private void CleanForm()
        {
            TxtCustomerAddress.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerID.Clear();
            TxtCustomerName.Clear();
            TxtPhonesCustomer.Clear();
            CbTypeCustomer.SelectedIndex = -1;
        }



        private void DgCustList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgCustList.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgCustList.SelectedRows[0];


                int IdCustomer = Convert.ToInt32(Mifila.Cells["CCustomerID"].Value);

                newcustomer = new Logic.Models.Customer();


                newcustomer.CustomerID = IdCustomer;



                newcustomer = newcustomer.SearchIDReturnCustumer();

                if (newcustomer != null && newcustomer.CustomerID > 0)
                {


                    TxtCustomerID.Text = Convert.ToString(newcustomer.CustomerID);

                    TxtCustomerEmail.Text = newcustomer.CustomerEmail;
                    TxtCustomerName.Text = newcustomer.CustomerName;

                    TxtPhonesCustomer.Text = Convert.ToString(newcustomer.CustomerPhone);

                    TxtCustomerAddress.Text = newcustomer.CustomerAdress;

                    //Combobox

                    CbTypeCustomer.SelectedValue = newcustomer.MyTypeCustomer.CustomerTypeID;


                }
            }
        }
        private void Checker()
        {
            if (CheckCustomer.Checked)
            {
                BtnAddCustomer.Visible = true;
                BtnCleanC.Visible = true;
                BtnEditC.Visible = true;
                btnactivate.Visible = false;
                BtnDeleteC.Visible = true;
                btnDeleteForever.Visible = false;
            }
            else
            {
                BtnAddCustomer.Visible = false;
                BtnCleanC.Visible = false;
                BtnEditC.Visible = false;
                btnactivate.Visible = true;
                btnDeleteForever.Visible = true;
                BtnDeleteC.Visible = false;
            }
        }

        private void CheckCustomer_CheckedChanged(object sender, EventArgs e)
        {
            LoadListCustomer();
            Checker();
        }

        private void BtnCleanC_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerAddress.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
               && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al Cliente ?",
                                                                    "???",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (newcustomer.Activate())
                    {
                        MessageBox.Show("El Cliente ha sido activado correctamente.", "!!!", MessageBoxButtons.OK);
                        CleanForm();
                        LoadListCustomer();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditC_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(TxtCustomerAddress.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
              && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                newcustomer.CustomerName = TxtCustomerName.Text.Trim();
                newcustomer.CustomerPhone = TxtPhonesCustomer.Text.Length;
                newcustomer.CustomerEmail = TxtCustomerEmail.Text.Trim();
                newcustomer.CustomerAdress = TxtCustomerAddress.Text.Trim();
                 


                newcustomer.MyTypeCustomer.CustomerTypeID = Convert.ToInt32(CbTypeCustomer.SelectedValue);

                if (newcustomer.ConsultEmail())
                {
                    DialogResult Answer = MessageBox.Show("¿Está seguro de modificar el Cliente?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (newcustomer.Update())
                        {
                            MessageBox.Show("El Cliente ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListCustomer();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerAddress.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
             && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                bool EmailOK;



                newcustomer = new Logic.Models.Customer();

                newcustomer.CustomerName = TxtCustomerName.Text.Trim();
                newcustomer.CustomerPhone = TxtPhonesCustomer.Text.Length;
                newcustomer.CustomerEmail = TxtCustomerEmail.Text.Trim();
                newcustomer.CustomerAdress = TxtCustomerAddress.Text.Trim();


                newcustomer.MyTypeCustomer.CustomerTypeID = Convert.ToInt32(CbTypeCustomer.SelectedValue); ;



                EmailOK = newcustomer.ConsultEmail();
                if (EmailOK == false)
                {


                    string msg = string.Format("¿Está seguro que desea agregar al Cliente {0}?", newcustomer.CustomerName);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = newcustomer.Add();

                        if (ok)
                        {
                            MessageBox.Show("Cliente guardado correctamente!", ":)", MessageBoxButtons.OK);

                            CleanForm();

                            LoadListCustomer();

                        }
                        else
                        {
                            MessageBox.Show("El proveedor no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Datos faltantes", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void BtnDeleteC_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerAddress.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
             && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                if (newcustomer.CustomerID > 0 && newcustomer.ConsultEmail())
                {
                    if (CheckCustomer.Checked)
                    {

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Cliente?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (newcustomer.Delete())
                            {
                                MessageBox.Show("El Cliente ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                CleanForm();
                                LoadListCustomer();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerAddress.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
            && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Cliente?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (newcustomer.DeleteForEver())
                            {
                                MessageBox.Show("El Cliente ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                CleanForm();
                                LoadListCustomer();

                        }
                    
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPhonesCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente letras.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
