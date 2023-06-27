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
        private Logic.Models.User Miusuario {get; set;}
        private DataTable ListUser { get; set;}



        public FrmUsers()
        {
            InitializeComponent();

            Miusuario = new Logic.Models.User();
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

            if (CheckUser.Checked) {

                ListUser = Miusuario.ListActive();
            }
            else
            {
                ListUser = Miusuario.ListInactive();
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
            this.Close();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {

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
                Miusuario = new Logic.Models.User();    

               // ahora le agregamos el alor obtenido por la fila 
                Miusuario.UserID = Idusuario;

                //Ahora puedo consultar el usuario y id para llenar el resto de atributos 

                Miusuario = Miusuario.SearchCardIDReturnUser();

                if(Miusuario != null && Miusuario.UserID >0)
                {
                    // si cargamos correctamente el usuario llenamos los controles 

                    TxtUserID.Text = Convert.ToString(Miusuario.UserID);
                    TxtUserName.Text = Miusuario.UserName;
                    TxtCardID.Text = Miusuario.UserCardID;
                    TxtPhone.Text = Miusuario.PhoneNumber;
                    TxtAddress.Text = Miusuario.Address;

                    //Combobox

                    CbRol.SelectedValue = Miusuario.MyRol.UserRoleID;
                }

            }
        }

        private void FrmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
