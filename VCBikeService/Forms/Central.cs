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
    }
}
