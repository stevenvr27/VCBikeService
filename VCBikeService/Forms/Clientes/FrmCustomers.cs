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
    public partial class h : Form
    {
        private Logic.Models.Customer customer { get; set; }
        private DataTable ListCusto { get; set; }

        public h()
        {
            InitializeComponent();
            customer = new Logic.Models.Customer();
            ListCusto = new DataTable();



        }

        private void FrmCustomers_Load(object sender, EventArgs e)
        {
     
            LoadListCustomer();
            LoadTypeCustomers();
        }

        private void LoadListCustomer()
        {
            ListCusto = new DataTable();
            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchCustomer.Text.Trim()) && TxtSearchCustomer.Text.Count() >= 3)
            {

                searchfilter = TxtSearchCustomer.Text.Trim();
            }
            if (CheckCustomer.Checked)
            {
                ListCusto =customer.ListCustomerActive(searchfilter);
            }
            else
            {
                ListCusto = customer.ListCustomerInactive(searchfilter);
            }
        }

        private void LoadTypeCustomers()
        {
            Logic.Models.CustomerType c = new Logic.Models.CustomerType();

            DataTable dt = new DataTable();
            dt = c.ListCustomerType();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbCustomerType.ValueMember = "ID";
                CbCustomerType.DisplayMember = "Descrip";
                CbCustomerType.DataSource = dt;
                CbCustomerType.SelectedIndex = -1;

            }
        }

        private void CheckCustomer_CheckedChanged(object sender, EventArgs e)
        {
            LoadListCustomer();
        }
    }
}
