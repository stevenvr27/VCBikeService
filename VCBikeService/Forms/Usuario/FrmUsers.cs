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


 

 
 
                ListUser = Miusuario.ListActive(searchfilter);
            }
            }


                CardIDok = MyUser.ConsultCardID();
                EmailOK = MyUser.ConsultEmail();
                if (CardIDok == false && EmailOK == false)
                {
                    //se puede agregar el usuario ya que no existe un usuario con la cedula y correo
                    //digitados. 



                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MyUser.AddUser();

                        if (ok)
                        {

                    }



            }
        }


