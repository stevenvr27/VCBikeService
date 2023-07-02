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

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            FrmUsers frmUsers = Globals.FrmUsers;
             
          
            LoadRoleUsers();
            LoadListUser();


           




        }

       //Metodo para cargar la lista de los usuarios
       private void LoadListUser()

        {
            ListUser = new DataTable();
           
            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >= 3)
            {

                searchfilter = TxtSearch.Text.Trim( );
            }


            if (CheckUser.Checked) {

                ListUser = MyUser.ListActive(searchfilter);
            }
            else
            {
                ListUser = MyUser.ListInactive(searchfilter);
            }
            DgListUsers.DataSource = ListUser;
        } 






        // encapsular el codigo por cada instancia 

        private void LoadRoleUsers()
        {
            Logic.Models.UserRole Rol = new Logic.Models.UserRole();

            DataTable dt = new DataTable();
            dt = Rol.List();

            if (dt != null && dt.Rows.Count>0)
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

        

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private bool ValidateInsertDates(bool SkipPassword = false )
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
            //seleccionar un campo en dicha carga de usuarios para dibujar info en los controles graficos 
            if (DgListUsers.SelectedRows.Count == 1)
            {
                // Limpiar el formulario 

                // Seleccionar la fila indice 0 , osea la primera en la lista
                DataGridViewRow Mifila = DgListUsers.SelectedRows[0];

                //necesito el valor del id para realizar la consulta y traer los datos que le pertenecen 
                int Idusuario = Convert.ToInt32(Mifila.Cells["CUserID"].Value);
                //re instanciar el usuario local 
                MyUser = new Logic.Models.User();

                // ahora le agregamos el alor obtenido por la fila 
                MyUser.UserID = Idusuario;

                //Ahora puedo consultar el usuario y id para llenar el resto de atributos 

                MyUser = MyUser.SearchCardIDReturnUser();

                if (MyUser != null && MyUser.UserID > 0)
                {
                    // si cargamos correctamente el usuario llenamos los controles 

                    TxtUserID.Text = Convert.ToString(MyUser.UserID);

                    TxtEmail.Text = MyUser.Email;
                    TxtUserName.Text = MyUser.UserName;
                    TxtCardID.Text = MyUser.UserCardID;
                    TxtPhone.Text = Convert.ToString(MyUser.PhoneNumber);

                    TxtAddress.Text = MyUser.Address;

                    //Combobox

                    CbRol.SelectedValue = MyUser.MyRol.UserRoleID;

                }
            }

        }


        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (ValidateInsertDates(true))
            {
                MyUser.UserName= TxtUserName.Text.Trim();
                MyUser.UserCardID = TxtCardID.Text.Trim();
                MyUser.PhoneNumber = TxtPhone.Text.Trim();
                MyUser.Email = TxtAddress.Text.Trim();
                MyUser.Address = TxtAddress.Text.Trim();
                MyUser.UserPassword = TxtPassword.Text.Trim();
                MyUser.MyRol.UserRoleID = Convert.ToInt32(CbRol.SelectedValue);
              
                if (MyUser.ConsultCardID())
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
                else
                {

                }

            }
        }
    }
}
