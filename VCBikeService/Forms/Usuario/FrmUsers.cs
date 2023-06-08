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
            MdiParent = (Form)Globals.Principal.Parent;
            // cargar la lista de usuarios mediante el evento load 
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
                CbRol.DisplayMember = "Desc";
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
    }
}
