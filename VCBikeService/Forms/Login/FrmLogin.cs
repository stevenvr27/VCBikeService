using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Logic.Models;

namespace VCBikeService.Forms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }



        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //to close the form
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Globals.Principal.Show();
            this.Hide();
            //try
            //{
              //  var username = TxtUserName.Text.Trim();
                //var password = TxtPassword.Text;

                
                    
                    }
             
    }
}
