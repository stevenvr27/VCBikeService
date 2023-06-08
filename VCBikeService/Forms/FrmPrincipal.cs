using SolrNet.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        #region Funcionalidades del formulario
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        
        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (!Globals.Users.Visible)
            {
                Globals.Users = new FrmUsers();
                Globals.Users.Show();
            }
            
            
             
    }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (!Globals.Customer.Visible) { 
                Globals.Customer = new FrmCustomer();
             Globals.Customer.Show();
            }
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (!Globals.Productos.Visible)
            {
                Globals.Productos = new FrmProducts();
                Globals.Productos.Show();
                 
            }
        }

        private void BtnProveedores_Click(object sender, EventArgs e)
        {
            if (!Globals.supplier.Visible)
            {
                Globals.supplier = new Frmsupplier();
                Globals.supplier.Show();

            }
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            if (!Globals.Reports.Visible)
            {
                Globals.Reports = new FrmReports();
                Globals.Reports.Show();

            }
        }

        private void BtnFacturas_Click(object sender, EventArgs e)
        {
            if (!Globals.Billing.Visible)
            {
                Globals.Billing = new FrmBilling();
                Globals.Billing.Show();

            }

        }
        #region Caracteristicas del formulario
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.PanelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        private void PBLongOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int x, y;
        int sw, sh;
            

         
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            x = this.Location.X;
            y = this.Location.Y;
            sw= this.Size.Width;
            sh= this.Size.Height;
            BtnMaximizar.Visible= false;
            BtnRestaurar.Visible= true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        //capturar la posicion y tamaño de maximizar para restaurar
         


        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(x, y);
        }

        private void PanelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        #region formulario 
        //Metodo abrir formulario dentro del panel 
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = Panelformulario.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
                                                                                     //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                Panelformulario.Controls.Add(formulario);
                Panelformulario.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion


    }
}
