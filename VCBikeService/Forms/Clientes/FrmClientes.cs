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
        private Logic.Models.Customer newcustomer {get; set;}
        private DataTable CustomerList { get; set;}

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
        }

        private void LoadTypeCustomer()
        {
            Logic.Models.CustomerType customerType = new Logic.Models.CustomerType();
            DataTable a = new DataTable();
            a = customerType.ListCustomerType();

            if (a != null && a.Rows.Count>0)
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

        private void BtnEditC_Click(object sender, EventArgs e)
        {
            CleanForm();
            DgCustList.ClearSelection();
        }
    }
}
