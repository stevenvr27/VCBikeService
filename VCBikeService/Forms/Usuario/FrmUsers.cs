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
    public partial class FrmUsers : Form
    {
        private Logic.Models.User MyUser { get; set;}
        private DataTable ListUser { get; set;}



        public FrmUsers()
        {
            InitializeComponent();

            MyUser = new Logic.Models.User();
            ListUser = new DataTable(); 

        }

            




        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInsertDates())
            {



                bool CardIDok;
                bool EmailOK;



                MyUser = new Logic.Models.User();

                MyUser.UserName = TxtUserName.Text.Trim();
                MyUser.UserCardID = TxtCardID.Text.Trim();
                MyUser.PhoneNumber = TxtPhone.Text.Trim();
                MyUser.Email = TxtEmail.Text.Trim();
                MyUser.UserPassword = TxtPassword.Text.Trim();


                MyUser.MyRol.UserRoleID = Convert.ToInt32(CbRol.SelectedValue);
                MyUser.Address = TxtAddress.Text.Trim();

                CardIDok = MyUser.ConsultCardID();
                EmailOK = MyUser.ConsultEmail();
                if (CardIDok == false && EmailOK == false)
                {
                    //se puede agregar el usuario ya que no existe un usuario con la cedula y correo
                    //digitados. 

                    //se solicita al usuario confirmación de si queire agregar o no al usuario 

                    string msg = string.Format("¿Está seguro que desea agregar al usuario {0}?", MyUser.UserName);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MyUser.AddUser();

                        if (ok)
                        {
                            MessageBox.Show("Usuario guardado correctamente!", ":)", MessageBoxButtons.OK);

                            CleanForm();

                            LoadListUser();

                        }
                        else
                        {
                            MessageBox.Show("El Usuario no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }


                }
                else
                {
                    //indicar al usuari si falla alguna consulta

                    if (CardIDok)
                    {
                        MessageBox.Show("Ya existe un usuario con la cédula digitada", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }

                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un usuario con el correo digitado", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
        }

        private void DgListUsers_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
                            CleanForm();
                            LoadListUser();
                        }

            }
        }

        private void CheckUser_CheckedChanged(object sender, EventArgs e)
        {
            LoadListUser();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MyUser.UserID > 0 && MyUser.ConsultCardID())
            {
                if (CheckUser.Checked)
                {

                    DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Usuario?",
                                                     "???",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);

                    if (r == DialogResult.Yes)
                    {
                        if (MyUser.Delete())
                        {
                            MessageBox.Show("El usuario ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                            CleanForm();
                            LoadListUser();
                        }
                }

            }
        }
    }
}
