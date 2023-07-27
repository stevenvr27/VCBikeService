using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace VCBikeService.Forms
{
    public partial class FrmUsers : Form
    {
        private Logic.Models.User MyUser { get; set; }
        private DataTable ListUser { get; set; }



        public FrmUsers()
        {
            InitializeComponent();

            MyUser = new Logic.Models.User();
            ListUser = new DataTable();

        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            CleanForm();
            Checker();


            LoadRoleUsers();
            LoadListUser();

        }
        private void LoadListUser()

        {
            ListUser = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 3)
            {

                searchfilter = TxtSearch.Text.Trim();
            }


            if (CheckUser.Checked)
            {

                ListUser = MyUser.ListActive(searchfilter);
            }
            else
            {
                ListUser = MyUser.ListInactive(searchfilter);
            }
            DgListUsers.DataSource = ListUser;
        }


        private void Checker()
        {
            if (CheckUser.Checked)
            {
                BtnAdd.Visible = true;
                BtnDelete.Visible = true;
                btnDeleteForever.Visible = false;
                btnActivate.Visible = false;
                BtnEdit.Visible = true;
                BtnClean.Visible = true;
            }
            else
            {
                BtnAdd.Visible = false;
                BtnDelete.Visible = false;
                btnDeleteForever.Visible = true;
                btnActivate.Visible = true;
                BtnEdit.Visible = false;
                BtnClean.Visible = false;
            }
        }



        // encapsular el codigo por cada instancia 

        private void LoadRoleUsers()
        {
            Logic.Models.UserRole Rol = new Logic.Models.UserRole();

            DataTable dt = new DataTable();
            dt = Rol.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbRol.ValueMember = "ID";
                CbRol.DisplayMember = "Descrip";
                CbRol.DataSource = dt;
                CbRol.SelectedIndex = -1;

            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
            DgListUsers.ClearSelection();
        }
        private bool ValidateInsertDates(bool SkipPassword = false)
        {
            //Validar datos ingresados}
            bool R = false;

            if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) && !string.IsNullOrEmpty(TxtCardID.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPhone.Text.Trim()) && !string.IsNullOrEmpty(TxtEmail.Text.Trim())
                     && CbRol.SelectedIndex > -1)
            {

                if (SkipPassword)
                {
                    R = true;

                }
                else
                {
                    if (!string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                    {
                        R = true;
                    }
                    else
                    {
                        MessageBox.Show("Debe digitar una contraseña para el usuario", "Error de validación", MessageBoxButtons.OK);
                        TxtPassword.Focus();
                        return false;
                    }
                }
            }
            else
            {

                //Name
                if (string.IsNullOrEmpty(TxtUserName.Text.Trim()))
                {
                    MessageBox.Show("Debes digitar un nombre para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtUserName.Focus();
                    return false;
                }
                //CardID
                if (string.IsNullOrEmpty(TxtCardID.Text.Trim()))
                {
                    MessageBox.Show("Debes digitar una Cedula  para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtCardID.Focus();
                    return false;
                }
                //Phone
                if (string.IsNullOrEmpty(TxtPhone.Text.Trim()))
                {
                    MessageBox.Show("Debes digitar un numero de telefono  para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPhone.Focus();
                    return false;
                }
                //Email
                if (string.IsNullOrEmpty(TxtAddress.Text.Trim()))
                {
                    MessageBox.Show("Debes digitar un Correo para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEmail.Focus();
                    return false;
                }
                //password
                if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
                {
                    MessageBox.Show("Debes digitar una contraseña para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtPassword.Focus();
                    return false;
                }
                //Email
                if (CbRol.SelectedIndex == -1)
                {
                    MessageBox.Show("Debes seleccion un rol para el usuario", "Error de Validacion ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TxtEmail.Focus();
                    return false;
                }
            }




            return R;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateInsertDates())
            {



                bool CardIDok;
                bool EmailOK;



                MyUser = new Logic.Models.User();

                MyUser.UserName = TxtUserName.Text.Trim();
                MyUser.UserCardID =  Convert.ToInt32(TxtCardID.Text.Trim());
                MyUser.PhoneNumber = Convert.ToInt32(TxtPhone.Text.Trim());
                MyUser.Email = TxtEmail.Text.Trim();
                MyUser.UserPassword = TxtPassword.Text.Trim();


                MyUser.MyRol.UserRoleID = Convert.ToInt32(CbRol.SelectedValue);
                MyUser.Address = TxtAddress.Text.Trim();

                CardIDok = MyUser.ConsultCardID();
                EmailOK = MyUser.ConsultEmail();
                if (CardIDok == false && EmailOK == false)
                {
                    

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

        private void DgListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            if (DgListUsers.SelectedRows.Count == 1)
            {
                
                DataGridViewRow Mifila = DgListUsers.SelectedRows[0];

            
                int Idusuario = Convert.ToInt32(Mifila.Cells["CUserID"].Value);
               
                MyUser = new Logic.Models.User();

                 
                MyUser.UserID = Idusuario;
                 
                MyUser = MyUser.SearchCardIDReturnUser();

                if (MyUser != null && MyUser.UserID > 0)
                {
                   

                    TxtUserID.Text = Convert.ToString(MyUser.UserID);

                    TxtEmail.Text = MyUser.Email;
                    TxtUserName.Text = MyUser.UserName;
                    TxtCardID.Text = Convert.ToString(MyUser.UserCardID);
                    TxtPhone.Text = Convert.ToString(MyUser.PhoneNumber);

                    TxtAddress.Text = MyUser.Address;

                    //Combobox

                    CbRol.SelectedValue = MyUser.MyRol.UserRoleID;


                }
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
           bool CardIDok;
                bool EmailOK;


                if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) && !string.IsNullOrEmpty(TxtCardID.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPhone.Text.Trim()) && !string.IsNullOrEmpty(TxtEmail.Text.Trim())
                     && CbRol.SelectedIndex > -1)
            {
                

                MyUser.UserName = TxtUserName.Text.Trim();
                MyUser.UserCardID =  Convert.ToInt32(TxtCardID.Text.Trim());
                MyUser.PhoneNumber = Convert.ToInt32(TxtPhone.Text.Trim());
                MyUser.Email = TxtEmail.Text.Trim();
                MyUser.Address = TxtAddress.Text.Trim();
                MyUser.UserPassword = TxtPassword.Text.Trim();
                MyUser.MyRol.UserRoleID = Convert.ToInt32(CbRol.SelectedValue);

                 CardIDok = MyUser.ConsultCardID();

                 EmailOK = MyUser.ConsultEmail();
                if (CardIDok == true && EmailOK == true)
                {


                    DialogResult Answer = MessageBox.Show("¿Este u otro usuario tienen la misma cedula , aun deseas modificarlo?", "???",
                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (MyUser.Update())
                        {
                            MessageBox.Show("El Usuario ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListUser();
                        }
                    }
                }
                else
                {
                    DialogResult Answer = MessageBox.Show("¿Está seguro de modificar el usuario?", "???",
                                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (MyUser.Update())
                        {
                            MessageBox.Show("El Usuario ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListUser();
                        }
                    }
                   
                }

            }
            else
            {
                MessageBox.Show("Debes de seleccionar un usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CheckUser_CheckedChanged(object sender, EventArgs e)
        {
            LoadListUser();
            Checker();
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
            else
            {
                MessageBox.Show("Debes de seleccionar un Usuario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void CleanForm()
        {
            TxtAddress.Clear();
            TxtUserName.Clear();
            TxtCardID.Clear();
            TxtPhone.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();
            TxtUserID.Clear();
            CbRol.SelectedIndex = -1;
        }

        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadListUser();
        }

        private void TxtCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK ,MessageBoxIcon.Stop);

            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente letras.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void Activate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) && !string.IsNullOrEmpty(TxtCardID.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPhone.Text.Trim()) && !string.IsNullOrEmpty(TxtEmail.Text.Trim())
                     && CbRol.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al Usuario ?",
                                                                     "???",
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (MyUser.Activate())
                    {
                        MessageBox.Show("El usuario ha sido activado correctamente.", "!!!", MessageBoxButtons.OK);
                        CleanForm();
                        LoadListUser();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un usuario.", "!!!", MessageBoxButtons.OK , MessageBoxIcon.Information);
            }   
            
        }

        private void DeleteForever_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtUserName.Text.Trim()) && !string.IsNullOrEmpty(TxtCardID.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtPhone.Text.Trim()) && !string.IsNullOrEmpty(TxtEmail.Text.Trim())
                     && CbRol.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al Usuario para siempre?",
                                                                     "???",
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (MyUser.DeleteForEver())
                    {
                        MessageBox.Show("El usuario ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);                      
                    }
                    CleanForm();
                    LoadListUser();

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un usuario.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


