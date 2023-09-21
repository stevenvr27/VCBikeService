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
using VCBikeService.Forms.Clientes;
using VCBikeService.Forms.Compra;
using VCBikeService.Forms.Factura;
using VCBikeService.Forms.Mantenimiento;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
       


        private void button7_Click(object sender, EventArgs e)
        {

            FrmFacturar frmFacturar = new FrmFacturar();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmFacturar.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmFacturar.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmFacturar al Panel principal
            PanelPrincipal.Controls.Add(frmFacturar);

            // Mostrar el formulario dentro del Panel
            frmFacturar.Show();

        }

        private void btnprod_Click(object sender, EventArgs e)
        {
            FrmProductsAdd item = new FrmProductsAdd();

            // Establecer TopLevel en false para que pueda agregarse como un control
            item.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            item.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmFacturar al Panel principal
            PanelPrincipal.Controls.Add(item);

            // Mostrar el formulario
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Frmsupplier prove = new Frmsupplier();

            // Establecer TopLevel en false para que pueda agregarse como un control
            prove.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            prove.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmFacturar al Panel principal
            PanelPrincipal.Controls.Add(prove);

            // Mostrar el formulario
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmClientes.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmClientes.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmClientes al Panel principal
            PanelPrincipal.Controls.Add(frmClientes);

            // Mostrar el formulario dentro del Panel
            frmClientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmBuyItem frmBuyItem = new FrmBuyItem();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmBuyItem.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmBuyItem.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(frmBuyItem);

            // Mostrar el formulario dentro del Panel
            frmBuyItem.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmBuysearch frmSearchBuyItem = new FrmBuysearch();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmSearchBuyItem.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmSearchBuyItem.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(frmSearchBuyItem);

            // Mostrar el formulario dentro del Panel
            frmSearchBuyItem.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmNewBilling FrmNewBilling = new FrmNewBilling();

            // Establecer TopLevel en false para que pueda agregarse como un control
            FrmNewBilling.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            FrmNewBilling.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(FrmNewBilling);

            // Mostrar el formulario dentro del Panel
            FrmNewBilling.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmProductsAdd ProductsAdd = new FrmProductsAdd();

            // Establecer TopLevel en false para que pueda agregarse como un control
            ProductsAdd.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            ProductsAdd.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(ProductsAdd);

            // Mostrar el formulario dentro del Panel
            ProductsAdd.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FrmUsers user = new FrmUsers();

            // Establecer TopLevel en false para que pueda agregarse como un control
            user.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            user.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(user);

            // Mostrar el formulario dentro del Panel
            user.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmsupplier Supply = new Frmsupplier();

            // Establecer TopLevel en false para que pueda agregarse como un control
            Supply.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            Supply.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(Supply);

            // Mostrar el formulario dentro del Panel
            Supply.Show();
        }

        private void buscarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewBilling FrmNewBilling = new FrmNewBilling();

            // Establecer TopLevel en false para que pueda agregarse como un control
            FrmNewBilling.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            FrmNewBilling.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(FrmNewBilling);

            // Mostrar el formulario dentro del Panel
            FrmNewBilling.Show();
        }

        private void buscarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuysearch frmSearchBuyItem = new FrmBuysearch();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmSearchBuyItem.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmSearchBuyItem.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(frmSearchBuyItem);

            // Mostrar el formulario dentro del Panel
            frmSearchBuyItem.Show();
        }

        private void gestiónDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmClientes.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmClientes.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmClientes al Panel principal
            PanelPrincipal.Controls.Add(frmClientes);

            // Mostrar el formulario dentro del Panel
            frmClientes.Show();
        }

        private void MnuEmpresaGestion_Click(object sender, EventArgs e)
        {
            Frmsupplier Supply = new Frmsupplier();

            // Establecer TopLevel en false para que pueda agregarse como un control
            Supply.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            Supply.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(Supply);

            // Mostrar el formulario dentro del Panel
            Supply.Show();
        }

        private void MnuUsuariosGestion_Click(object sender, EventArgs e)
        {
            FrmUsers user = new FrmUsers();

            // Establecer TopLevel en false para que pueda agregarse como un control
            user.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            user.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(user);

            // Mostrar el formulario dentro del Panel
            user.Show();
        }

        private void MnuProductosGestion_Click(object sender, EventArgs e)
        {
            FrmProductsAdd ProductsAdd = new FrmProductsAdd();

            // Establecer TopLevel en false para que pueda agregarse como un control
            ProductsAdd.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            ProductsAdd.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(ProductsAdd);

            // Mostrar el formulario dentro del Panel
            ProductsAdd.Show();
        }

        private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductsAdd ProductsAdd = new FrmProductsAdd();

            // Establecer TopLevel en false para que pueda agregarse como un control
            ProductsAdd.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            ProductsAdd.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(ProductsAdd);

            // Mostrar el formulario dentro del Panel
            ProductsAdd.Show();

        }

        private void MnuFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturar frmFacturar = new FrmFacturar();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmFacturar.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmFacturar.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmFacturar al Panel principal
            PanelPrincipal.Controls.Add(frmFacturar);

            // Mostrar el formulario dentro del Panel
            frmFacturar.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuyItem frmBuyItem = new FrmBuyItem();

            // Establecer TopLevel en false para que pueda agregarse como un control
            frmBuyItem.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            frmBuyItem.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(frmBuyItem);

            // Mostrar el formulario dentro del Panel
            frmBuyItem.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FrmMantenimiento mantenimiento = new FrmMantenimiento();

            // Establecer TopLevel en false para que pueda agregarse como un control
            mantenimiento.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            mantenimiento.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(mantenimiento);

            // Mostrar el formulario dentro del Panel
            mantenimiento.Show();
        }

        private void Central_Load(object sender, EventArgs e)
        {
            Fecha1.Text = DateTime.Now.ToString("hh:mm tt");
            Fecha.Text = DateTime.Now.ToLongDateString();
            lbluser.Text = Globals.MyGlobalUser.UserName;
            lblusuario.Text = Globals.MyGlobalUser.MyRol.Description;

           
        }

        private void Central_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.D)
            {
                FrmFacturar frmFacturar = new FrmFacturar();

                // Establecer TopLevel en false para que pueda agregarse como un control
                frmFacturar.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                frmFacturar.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmFacturar al Panel principal
                PanelPrincipal.Controls.Add(frmFacturar);

                // Mostrar el formulario dentro del Panel
                frmFacturar.Show();


            }
            if (e.Control && e.KeyCode == Keys.S)
            {

                FrmBuyItem frmBuyItem = new FrmBuyItem();

                // Establecer TopLevel en false para que pueda agregarse como un control
                frmBuyItem.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                frmBuyItem.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmBuyItem al Panel principal
                PanelPrincipal.Controls.Add(frmBuyItem);

                // Mostrar el formulario dentro del Panel
                frmBuyItem.Show();


            }

            if (e.Control && e.KeyCode == Keys.F)
            {

                FrmMantenimiento mantenimiento = new FrmMantenimiento();

                // Establecer TopLevel en false para que pueda agregarse como un control
                mantenimiento.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                mantenimiento.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmBuyItem al Panel principal
                PanelPrincipal.Controls.Add(mantenimiento);

                // Mostrar el formulario dentro del Panel
                mantenimiento.Show();


            }
            if (e.Control && e.KeyCode == Keys.Q)
            {
                FrmNewBilling FrmNewBilling = new FrmNewBilling();

                // Establecer TopLevel en false para que pueda agregarse como un control
                FrmNewBilling.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                FrmNewBilling.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmBuyItem al Panel principal
                PanelPrincipal.Controls.Add(FrmNewBilling);

                // Mostrar el formulario dentro del Panel
                FrmNewBilling.Show();
            }
            if (e.Control && e.KeyCode == Keys.W)
            {
                FrmBuysearch frmSearchBuyItem = new FrmBuysearch();

                // Establecer TopLevel en false para que pueda agregarse como un control
                frmSearchBuyItem.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                frmSearchBuyItem.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmBuyItem al Panel principal
                PanelPrincipal.Controls.Add(frmSearchBuyItem);

                // Mostrar el formulario dentro del Panel
                frmSearchBuyItem.Show();

            }
            if (e.Control && e.KeyCode == Keys.E)
            {
                FrmProductsAdd ProductsAdd = new FrmProductsAdd();

                // Establecer TopLevel en false para que pueda agregarse como un control
                ProductsAdd.TopLevel = false;

                // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
                ProductsAdd.Size = PanelPrincipal.Size;

                // Limpiar el Panel principal (si es necesario)
                PanelPrincipal.Controls.Clear();

                // Agregar el formulario FrmBuyItem al Panel principal
                PanelPrincipal.Controls.Add(ProductsAdd);

                // Mostrar el formulario dentro del Panel
                ProductsAdd.Show();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmListMantenimiento listMantenimiento = new FrmListMantenimiento();

            // Establecer TopLevel en false para que pueda agregarse como un control
            listMantenimiento.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            listMantenimiento.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(listMantenimiento);

            // Mostrar el formulario dentro del Panel
            listMantenimiento.Show();
        }
    }
}
