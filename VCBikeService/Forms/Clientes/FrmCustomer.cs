using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms
{
    public partial class FrmCustomer : Form
    {
        private Logic.Models.Customer customer { get;set; }
        private DataTable ListCusto { get; set; }

        public FrmCustomer()
        {
            InitializeComponent();
            customer = new Logic.Models.Customer();
            ListCusto = new DataTable();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            MdiParent = (Form)Globals.Principal.Parent;
            LoadCustomerType();
        }

        private void loadlistCustomer()
        {
            ListCusto = new DataTable();
            
        }


        private void LoadCustomerType()
        {
            Logic.Models.CustomerType Tipo = new Logic.Models.CustomerType();
            DataTable a = new DataTable();
            a = Tipo.ListCustomerType();

            if (a != null && a.Rows.Count>0)
            {
                CbCustomerType.ValueMember = "ID";
                CbCustomerType.DisplayMember = "Desc";
                CbCustomerType.DataSource = a;
                CbCustomerType.SelectedIndex = -1;
            }

        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         
    }
}
