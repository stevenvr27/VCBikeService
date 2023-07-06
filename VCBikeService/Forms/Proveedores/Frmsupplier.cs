using Logic.Models;
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
    public partial class Frmsupplier : Form
    {
        private Logic.Models.Supplier MySupplier { get; set; }
        private DataTable listSupplier { get; set; }
        public Frmsupplier()
        {
            InitializeComponent();

            //LoadListSupplier();
           // LoadSupplierListType();

            MySupplier = new Logic.Models.Supplier();
            listSupplier = new DataTable();
        }

        private void Frmsupplier_Load(object sender, EventArgs e)
        {
            Frmsupplier frmsupplier = Globals.Frmsupplier;
        }

            





    }
}
