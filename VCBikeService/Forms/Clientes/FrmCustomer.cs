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

namespace VCBikeService.Forms
{
    public partial class FrmCustomer : Form
    {
        private Logic.Models.Customer MyCustomer { get; set; }
        private DataTable ListCustomer { get; set; }

        public FrmCustomer()
        {
            InitializeComponent();
            MyCustomer = new Logic.Models.Customer();
            ListCustomer = new DataTable();
        }



        private void loadlistCustomer()
        {
            ListCustomer = new DataTable();


            if (checkCustomer.Checked)
            {
                ListCustomer = MyCustomer.ListCustomerActive();

            }
            else
            {
                ListCustomer = MyCustomer.ListCustomerInactive();
            }
            DgCustomer.DataSource = ListCustomer;
        }


        private void LoadCustomerType()
        {
            Logic.Models.CustomerType Tipo = new Logic.Models.CustomerType();
            DataTable a = new DataTable();
            a = Tipo.ListCustomerType();

            if (a != null && a.Rows.Count > 0)
            {
                CbCustomerType.ValueMember = "ID";
                CbCustomerType.DisplayMember = "Descrip";
                CbCustomerType.DataSource = a;
                CbCustomerType.SelectedIndex = -1;
            }

        }
        private void CleanForm()
        {
            TxtCustomerAddress.Clear();
            TxtCustomerEmail.Clear();
            TxtNameCustomer.Clear();
            TxtCustomerPhoneNumber.Clear();
            TxtCustomerID.Clear();
            CbCustomerType.SelectedIndex = -1;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
            DgCustomer.ClearSelection();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

            FrmCustomer frmCustomer = new FrmCustomer();
            LoadCustomerType();
            loadlistCustomer();
        }



        private void DgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgCustomer.SelectedRows.Count == 1)
            {
                DataGridViewRow Fila = DgCustomer.SelectedRows[0];
                int IDCustomer = Convert.ToInt32(Fila.Cells["CCustomerID"].Value);
                MyCustomer = MyCustomer.SearchIDReturnCustumer();
                if (MyCustomer != null && MyCustomer.CustomerID > 0)
                {
                    TxtCustomerID.Text = Convert.ToString(MyCustomer.CustomerID);
                    TxtCustomerEmail.Text = MyCustomer.CustomerEmail;
                    TxtCustomerAddress.Text = MyCustomer.CustomerAdress;
                    TxtNameCustomer.Text = MyCustomer.CustomerName;
                    TxtCustomerPhoneNumber.Text = Convert.ToString(MyCustomer.CustomerPhone);
                    CbCustomerType.SelectedValue = MyCustomer.MyTypeCustomer;
                }
            }
        }
    }
}


