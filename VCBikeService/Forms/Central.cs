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
            if (!Globals.Users.Visible)
            {
                Globals.Users = new FrmUsers();
                Globals.Users.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.Customer.Visible)
            {
                Globals.Customer = new FrmCustomer();
                Globals.Customer.Show();
            }
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.ProductosAgregar.Visible)
            {
                Globals.ProductosAgregar = new FrmProductsAdd();
                Globals.ProductosAgregar.Show();
            }
        }
    }
}
