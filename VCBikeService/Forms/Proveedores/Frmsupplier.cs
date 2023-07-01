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
    public partial class Frmsupplier : Form
    {
        private Logic.Models.Supplier MySupplier { get; set; }
        private DataTable listSupplier { get; set; }
        public Frmsupplier()
        {
            InitializeComponent();

            //LoadListSupplier();
            LoadSupplierListType();

            MySupplier = new Logic.Models.Supplier();
            listSupplier = new DataTable();
        }

        private void Frmsupplier_Load(object sender, EventArgs e)
        {
            Frmsupplier frmsupplier = Globals.Frmsupplier;
        }

        //private void LoadListSupplier()
        //{
        //    listSupplier = new DataTable();
            


        //    if (checkBSupplier.Checked)
        //    {

        //        listSupplier = MySupplier.ListActive();
        //    }
        //    else
        //    {
        //        listSupplier = MySupplier.ListInactive();
        //    }
        //    DgSupplier.DataSource = listSupplier;
        //}
        private void LoadSupplierListType()
        {
            Logic.Models.SupplierType Type = new Logic.Models.SupplierType();

            DataTable dt = new DataTable();
            dt = Type.list();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbSupplierType.ValueMember = "ID";
                CbSupplierType.DisplayMember = "Descrip";
                CbSupplierType.DataSource = dt;
                CbSupplierType.SelectedIndex = -1;

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void CleanForm()
        {
            TxtIDSupplier.Clear();
            TxtSupplierAddress.Clear();
            TxtSupplierName.Clear();
            TxtSupplierPhone.Clear();
            TxtSupplierEmail.Clear();
            TxtSupplierCardID.Clear();
            TxtSupplierActive.Clear();

            CbSupplierType.SelectedIndex = -1;

        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
            DgSupplier.ClearSelection();
        }
    }
}
