using Logic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
 
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace VCBikeService.Forms.Origen
{
    public partial class FrmRecoveryPassword : Form
    {
        private Crypto crypto;
        private Logic.Models.User MyUser { get; set; }

        public FrmRecoveryPassword(Crypto crypto)
        {
            InitializeComponent();
            this.crypto = crypto;
            MyUser = new Logic.Models.User();
        }

        private void FrmRecoveryPassword_Load(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnActivate_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtCardID.Text.Trim()))
            {
                string name = TxtName.Text.Trim();
                string email = TxtEmail.Text.Trim();
                string userCardID = TxtCardID.Text.Trim();

                DialogResult Answer = MessageBox.Show("¿Seguro de Cambiar la contraseña?", "???",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Answer == DialogResult.Yes)
                {
                    if (MyUser.ValidateUserCredentials(name, email, userCardID))
                    {
                        string newPass = Txtss1.Text.Trim();

                        if (!string.IsNullOrEmpty(newPass)) // Asegurarse de que la nueva contraseña no sea nula o vacía
                        {
                            if (MyUser.UpdatePAssword(newPass))
                            {
                                MessageBox.Show("El Usuario ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                                this.Close();
                                FrmLogin login = new FrmLogin();
                                login.Show();
                            }
                            else
                            {
                                MessageBox.Show("Algo salió mal", "=(");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La nueva contraseña no puede ser nula o vacía", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre, email o ID de tarjeta del usuario no son válidos", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Faltan datos requeridos!", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}