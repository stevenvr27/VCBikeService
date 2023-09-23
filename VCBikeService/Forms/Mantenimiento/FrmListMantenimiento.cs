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

namespace VCBikeService.Forms.Mantenimiento
{
    public partial class FrmListMantenimiento : Form
    {
        private DataTable MaintenanceList {get;set;}
        private Maintenance MyMaintenance { get;set;}


        public FrmListMantenimiento()
        {
            InitializeComponent();
            MaintenanceList = new DataTable();
            MyMaintenance = new Maintenance();
        }

        private void DgProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cleaner()
        {
            txtbrand.Clear();
            TxtCustomerID.Clear();
            txtCustomerName.Clear();
            TxtUSerID.Clear();
            TxtUserName.Clear();
            txttotal.Clear();
            DgProduct.Rows.Clear();
            TxtDate.Clear();
            Txtnotes.Clear();

        }

        private void LoadListMaintenance()

        {
             

            MaintenanceList = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchMaintenance.Text.Trim()) && TxtSearchMaintenance.Text.Count() >= 3)
            {

                searchfilter = TxtSearchMaintenance.Text.Trim();
            }


            if (CheckCustomer.Checked)
            {

                MaintenanceList = MyMaintenance.ListMaintenanceActive(searchfilter);
            }
            else
            {
                MaintenanceList = MyMaintenance.ListMaintenanceActive(searchfilter);
            }
           DgProduct.DataSource = MaintenanceList;
        }

        private void FrmListMantenimiento_Load(object sender, EventArgs e)
        {
            FrmListMantenimiento frmListMantenimiento = new FrmListMantenimiento();
            LoadListMaintenance();
        }
    }
}
