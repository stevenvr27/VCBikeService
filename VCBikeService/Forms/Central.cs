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
using VCBikeService.Forms.Compra;
using VCBikeService.Forms.Nosotros;
using VCBikeService.Forms.Productos;
 

namespace VCBikeService.Forms
{
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }






        private void Central_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }









        private void nosotrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();
                Globals.Frmfactura.Show();
            }
        }



        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct = new FrmBuyItem();
                Globals.FrmSearchProduct.Show();
            }
        }

       

       

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();
                Globals.Frmfactura.Show();
            }
        }

      



        private void Central_Load(object sender, EventArgs e)
        {
            LblUsuarioLogueado.Text = Globals.MyGlobalUser.UserName;
          lblfecha.Text =  DateTime.Now.ToString("hh:mm");
            LblFechaHora.Text = DateTime.Now.ToLongDateString();
          
            

            string InfoUsuario = string.Format("{0}-{1}({2})",
                                            Globals.MyGlobalUser.UserName,
                                            Globals.MyGlobalUser.Email,
                                            Globals.MyGlobalUser.MyRol.Description);



            switch (Globals.MyGlobalUser.MyRol.UserRoleID)
            {
                case 1:
                    //sería admin, no se oculta nada
                    break;
                case 2:
                     
                    Usuario.Visible = false;
                    MnuUsuariosGestion.Visible = false;

                    break;
            }
        }

        private void Usuario_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmUsers.Visible)
            {
                Globals.FrmUsers = new Forms.FrmUsers();
                Globals.FrmUsers.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        private void MnuEmpresaGestion_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        private void MnuUsuariosGestion_Click(object sender, EventArgs e)
        {

            if (!Globals.FrmUsers.Visible)
            {
                Globals.FrmUsers = new Forms.FrmUsers();
                Globals.FrmUsers.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.frmClientes.Visible)
            {
                Globals.frmClientes = new Clientes.FrmClientes();
                Globals.frmClientes.Show();
            }
        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.frmClientes.Visible)
            {
                Globals.frmClientes = new Clientes.FrmClientes();
                Globals.frmClientes.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void MnuProductosGestion_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();
                Globals.Frmfactura.Show();
            }
        }

        private void MnuFacturar_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmfactura.Visible)
            {
                Globals.Frmfactura = new Compra.FrmFacturar();
                Globals.Frmfactura.Show();
            }
        }

         

        

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct = new Productos.FrmBuyItem();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct = new Productos.FrmBuyItem();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmNewBilling.Visible)
            {
                Globals.FrmNewBilling = new Factura.FrmNewBilling();
                Globals.FrmNewBilling.Show();
            }
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmNewBilling.Visible)
            {
                Globals.FrmNewBilling = new Factura.FrmNewBilling();
                Globals.FrmNewBilling.Show();
            }
        }

       

        private void button9_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Central_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmBuysearch.Visible)
            {
                Globals.FrmBuysearch = new FrmBuysearch();
                Globals.FrmBuysearch.Show();
            }
        }

         
    }
}

       

             

        