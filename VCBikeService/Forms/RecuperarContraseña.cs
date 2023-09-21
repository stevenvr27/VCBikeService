using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace VCBikeService.Forms
{
    public partial class RecuperarContraseña : Form
    {
        public RecuperarContraseña(Form login)
        {
            InitializeComponent();
            this.MaximumSize = login.MaximumSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            Globals.login.Show();
        }
    }
}
