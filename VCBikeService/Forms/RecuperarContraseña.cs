using Logic.Models;
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
        public User MyUser { get; set; }
        public RecuperarContraseña(Form login)
        {
            MyUser = new User();
            InitializeComponent();
            this.MaximumSize = login.MaximumSize;
        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            Globals.login.Show();
        }

        private void RecuperarContraseña_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text.Trim()) && !string.IsNullOrEmpty(TxtUserName.Text.Trim()))
            {
                string user = TxtUserName.Text.Trim();
                string email = TxtEmail.Text.Trim();

                User userObj = new User
                {
                    UserName = user,
                    Email = email
                };

                bool isValidUser = userObj.ValidateCredentials();

                if (isValidUser)
                {
                    // El usuario y el correo son válidos
                    // Puedes realizar las acciones que necesites aquí
                }
                else
                {
                    MessageBox.Show("El Correo y Nombre de Usuario no son correctos,vuelvelo a intentar  ");
                    TxtUserName.Focus();
                    TxtEmail.Focus();

                }
            }
            else
            {
                MessageBox.Show("Necesitas ingresar el Nombre del Usuario y el Correo Electrónico");
                TxtUserName.Focus();
                TxtEmail.Focus();
            }


        }
        
    }
}
