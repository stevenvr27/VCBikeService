using System;
using System.Windows.Forms;

namespace VCBikeService.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            this.KeyPreview = true;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //para cerrar la aplicacion 
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            {
                // Primero busca que los campos esten llenos , luego guarda la informacion para validar que existan en la bd y si no su respectiva alerta

                if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) &&
                    !string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    string user = TxtUserName.Text.Trim();
                    string password = TxtPassword.Text.Trim();


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


        private void BtnIngresoDirecto_Click(object sender, EventArgs e)
        {
            //boton para el ingrso directo al formulario principal 
            Globals.Principal.Show();
            this.Hide();
        }

        private void BtnVerContrasennia_Click(object sender, EventArgs e)
        {
            //boton para ver lo digitado en el campo de la contraseña 
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
            //cierra la aplicacion 
            Application.Exit();
        }


        private void FrmLogin_KeyUp(object sender, KeyEventArgs e)
        {
            // Verificar si las teclas "Alt" + "Control" + M  se han presionado al mismo tiempo y si es afirmativo se muestra un boton
            if (e.Alt && e.Control)
            {


                if (e.KeyCode == Keys.M)
                {
                    BtnIngresoDirecto.Visible = true;

                }
            }
           

            if (e.KeyCode == Keys.Escape)
                if (e.KeyCode == Keys.Escape)
                {
                    // Cierra el formulario si se presiona Escape
                    this.Close();
                }
                else if (e.KeyCode == Keys.Enter)
                {
                    // Realiza el clic en el botón  si se presiona Enter
                    BtnLogin.PerformClick();
                }
        }
    }
}
