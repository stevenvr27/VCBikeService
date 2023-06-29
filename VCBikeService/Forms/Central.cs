using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Nosotros;
using VCBikeService.Forms.Productos;
using VCBikeService.Forms.Reportes;

namespace VCBikeService.Forms
{
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Globals.FrmUsers.Visible)
            {
                Globals.FrmUsers = new FrmUsers();
                Globals.FrmUsers.Show();
            }
        }

        //private void Central_Load(object sender, EventArgs e)
        //{
        //    string InfoUsuario = string.Format("{0}-{1}({2})",
        //                                        Globals.MyGlobalUser.UserName,
        //                                        Globals.MyGlobalUser.Email,
        //                                        Globals.MyGlobalUser.MyRol.Description);

        //    LblUser.Text = InfoUsuario;

        //    switch (Globals.MyGlobalUser.MyRol.UserRoleID)
        //    {
        //        case 1:
        //            //sería admin, no se oculta nada
        //            break;
        //        case 2:
        //            //sería usuario normal, se deben ocultar algunas opciones de menú 
        //            usuariosToolStripMenuItem.Visible = false;
        //            clientesToolStripMenuItem.Visible = false;
        //            productosToolStripMenuItem.Visible = false;
        //            facturasToolStripMenuItem.Visible = false;
        //            cajaToolStripMenuItem.Visible = false;
        //            ReportesToolStripMenuItem.Visible = false;
                     
        //            break;
        //    }
        //}

        private void Central_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmCustomer.Visible)
            {
                Globals.FrmCustomer = new FrmCustomer();
                Globals.FrmCustomer.Show();
            }
        }

       

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        

        private void nosotrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmWe.Visible)
            {
                Globals.FrmWe = new FrmWe();
                Globals.FrmWe.Show();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct= new FrmSearchProduct();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void semanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmWeek.Visible)
            {
                Globals.FrmWeek = new FrmWeek();
                Globals.FrmWeek.Show();
            }
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmMont.Visible)
            {
                Globals.FrmMont = new FrmMont();
                Globals.FrmMont.Show();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmBillingSearch.Visible)
            {
                Globals.FrmBillingSearch = new FrmBillingSearch();
                Globals.FrmBillingSearch.Show();
            }
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmNewBilling.Visible)
            {
                Globals.FrmNewBilling = new Factura.FrmNewBilling();
                Globals.FrmNewBilling.Show();
            }
        }

        private void modificarOEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmEditBilling.Visible)
            {
                Globals.FrmEditBilling = new Factura.FrmEditBilling();
                Globals.FrmEditBilling.Show();
            }
        }
    }
}
