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
            //Filtrar lista de busqueda si hay 3 o mas caracteres 
           // string searchfilter = "";
           // if (!string.IsNullOrEmpty(TxtSearch.Text.Trim()) && TxtSearch.Text.Count() >=3){

           //     searchfilter = TxtSearch.Text.Trim();
            //}


            if (CheckUser.Checked) {

                ListUser = MyUser.ListActive( );
            }
            else
            {
                ListUser = MyUser.ListInactive( );
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

        private void DgListUsers_CellClick(object sender, DataGridViewCellEventArgs e)
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

                if(MyUser != null && MyUser.UserID >0)
                {
                    // si cargamos correctamente el usuario llenamos los controles 

                    TxtUserID.Text = Convert.ToString(MyUser.UserID);
                    
                    TxtEmail.Text = MyUser.Email;
                    TxtUserName.Text = MyUser.UserName;
                    TxtCardID.Text = MyUser.UserCardID;
                    TxtPhone.Text = MyUser.PhoneNumber;
                    TxtAddress.Text = MyUser.Address;
                        
                    //Combobox

                    CbRol.SelectedValue = MyUser.MyRol.UserRoleID;

                }

            }
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            bool CardIDok;
            bool EmailOK;



          MyUser = new Logic.Models.User();

           MyUser.UserName = TxtUserName.Text.Trim();
            MyUser.UserCardID = TxtCardID.Text.Trim();
            MyUser.PhoneNumber = TxtPhone.Text.Trim();
            MyUser.Email = TxtEmail.Text.Trim();
            MyUser.UserPassword= TxtPassword.Text.Trim();

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

                    bool ok = MyUser.add();

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
}
