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
        private int formCount = 0; // Inicializa el contador de formularios abiertos
        private int maxFormCount = 3; // Establece el límite máximo de formularios abiertos

        public Central()
        {
            InitializeComponent();
            this.KeyPreview = true;

        }

        

        private void CerrarFormularioMasAntiguo()
        {
            // Encuentra el formulario más antiguo y ciérralo
            foreach (Form form in this.MdiChildren)
            {
                if (!form.Visible)
                {
                    // Cierra el formulario desactivado más antiguo
                    form.Close();
                    return;
                }
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }

           FrmBilling frmFacturar = new FrmBilling();

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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
            FrmBilling frmFacturar = new FrmBilling();

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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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
        private Timer timer;

        private void Central_Load(object sender, EventArgs e)
        {
            
            lbluser.Text = Globals.MyGlobalUser.UserName;
            lblusuario.Text = Globals.MyGlobalUser.MyRol.Description;
            Fecha.Text = DateTime.Now.ToLongDateString();
            lbluser.Text = Globals.MyGlobalUser.UserName;
            lblusuario.Text = Globals.MyGlobalUser.MyRol.Description;

            // Configura el temporizador
            timer = new Timer();
            timer.Interval = 60000; // Intervalo en milisegundos (1 minuto = 60000 ms)
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

            // Actualiza la etiqueta Fecha1 al cargar el formulario
            ActualizarFecha1();


        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Llama a la función para actualizar Fecha1 cada vez que el temporizador hace tick
            ActualizarFecha1();
        }

        private void ActualizarFecha1()
        {
            Fecha1.Text = DateTime.Now.ToString("hh:mm tt");
        }

        private void Central_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
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

        private void btnlogoInicio_Click(object sender, EventArgs e)
        {
            if (formCount >= maxFormCount)
            {
                CerrarFormularioMasAntiguo();
            }
            Central Centrals = new Central();

            // Establecer TopLevel en false para que pueda agregarse como un control
            Centrals.TopLevel = false;

            // Establecer el tamaño del formulario para que coincida con el tamaño del Panel
            Centrals.Size = PanelPrincipal.Size;

            // Limpiar el Panel principal (si es necesario)
            PanelPrincipal.Controls.Clear();

            // Agregar el formulario FrmBuyItem al Panel principal
            PanelPrincipal.Controls.Add(Centrals);

            // Mostrar el formulario dentro del Panel
            Centrals.Show();
        }
    }
}
