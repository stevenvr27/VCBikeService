using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Logic.Models;

namespace VCBikeService.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //to close the form
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) &&
                !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                string user = TxtUserName.Text.Trim();
                string password = TxtPassword.Text.Trim();

                Globals.MyGlobalUser = Globals.MyGlobalUser.ValidateUser(user, password);

                if (Globals.MyGlobalUser.UserID > 0)
                {
                    Globals.Principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña Incorrectas...", "Error de validación", MessageBoxButtons.OK);

                    TxtPassword.Focus();
                    TxtPassword.SelectAll();
                }

            }
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK);

            }



        }
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift & e.Alt & e.KeyCode == Keys.A)
            {
                //si presionamos shift + tab + a
                BtnIngresoDirecto.Visible = true;
            }
        }

        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globals.Principal.Show();
            this.Hide();
        }

        private void BtnVerContrasennia_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            { 
                TxtPassword.UseSystemPasswordChar = false;
                return;
                
            }
            else
            {
                
                TxtPassword.UseSystemPasswordChar = true;
                MessageBox.Show("Debes Escribir una Contraseña!", "Error de validación", MessageBoxButtons.OK);
            }
            
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
 