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
            {
                if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    string user = TxtUserName.Text.Trim();
                    string password = TxtPassword.Text.Trim();

                    Globals.MyGlobalUser = Globals.MyGlobalUser.ValidateUser(user, password);

                    if (Globals.MyGlobalUser.UserID > 0)
                    {
                        if (Globals.MyGlobalUser.Active)
                        {
                            Globals.Principal.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Intentas ingresar con un usuario inactivo, actívalo antes de entrar...", "Error de validación", MessageBoxButtons.OK);
                        }
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
        }


        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            Globals.Principal.Show();
            this.Hide();
        }

        private void BtnVerContrasennia_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
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

        private void FrmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificar si las teclas "Alt" y "Control" se han presionado al mismo tiempo.
            if (e.Alt && e.Control)
            {
                // Verificar qué tecla específica se presionó junto con "Alt" y "Control" (por ejemplo, "M" para el menú).
                if (e.KeyCode == Keys.M)
                {
                    BtnIngresoDirecto.Visible = true;

                }
            }


            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }

        private void BtnIngresoDirecto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control)
            {
                // Verificar qué tecla específica se presionó junto con "Alt" y "Control" (por ejemplo, "M" para el menú).
                if (e.KeyCode == Keys.M)
                {
                     
                }
            }

            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario
                this.Close();
            }
        }
    
    
    }
}
 