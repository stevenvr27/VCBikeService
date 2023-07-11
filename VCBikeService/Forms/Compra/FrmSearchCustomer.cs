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
    public partial class FrmSearchCustomer : Form
    {
        DataTable DtList { get; set; }

        Logic.Models.Customer MyCustomer { get; set; }


        public FrmSearchCustomer()
        {
            InitializeComponent();
            DtList = new DataTable();
            MyCustomer = new Logic.Models.Customer();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {

            if (TxtBuscar.Text.Count() > 2 ||
                string.IsNullOrEmpty(TxtBuscar.Text.Trim()))
            {
                LoadList();
            }
        }

        private void LoadList()
        {
            DtList = new DataTable();

            DtList = MyCustomer.ListCustomer(true, TxtBuscar.Text.Trim());

            DgvLista.DataSource = DtList;
        }

        private void FrmSearchCustomer_Load(object sender, EventArgs e)
        {
            LoadList();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (DgvLista.SelectedRows.Count == 1)
            {
                DataGridViewRow FilaSeleccionada = DgvLista.SelectedRows[0];
                int IDCLIENTE;
                IDCLIENTE = Convert.ToInt32(FilaSeleccionada.Cells["CCustomerID"].Value);

                Globals.FrmCompra.TxtClienteID.Text = Convert.ToString(IDCLIENTE);

                this.DialogResult = DialogResult.OK;

            }
        }
    }
}
