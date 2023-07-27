using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmEditBuyItem : Form
    {
        private DataTable localdetailist;

        public int CantidadEditada { get; private set; }

        public FrmEditBuyItem(DataTable localdetailist, int cantidadActual)
        {
            InitializeComponent();

            this.localdetailist = localdetailist;

            // Establecer la cantidad actual en el campo numérico
            numericUpDownCantidad.Value = cantidadActual;
        }


        private void BtnCancelarCantidad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad modificada del campo numérico
            CantidadEditada = Convert.ToInt32(numericUpDownCantidad.Value);

            // Cerrar el formulario de edición
            DialogResult = DialogResult.OK;
        }
    }   
}
