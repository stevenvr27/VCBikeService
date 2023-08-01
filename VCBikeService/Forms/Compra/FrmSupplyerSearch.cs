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

namespace VCBikeService.Forms.Compra
{
    public partial class FrmSupplyerSearch : Form
    {
        DataTable DTSupplier { get; set; }
          Logic.Models.Supplier MySupplier { get; set; }
        public FrmSupplyerSearch()
        {
            InitializeComponent();
            DTSupplier = new DataTable();
            MySupplier = new Logic.Models.Supplier();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FrmSupplyerSearch_Load(object sender, EventArgs e)
        {
            LoadListsupply();
        }


        private void LoadListsupply()

        {
            DTSupplier = new DataTable();
            DTSupplier = MySupplier.ListSupplier();

            DgSupplier.DataSource = DTSupplier;



        }

        private void FrmSupplyerSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }
    }
}
