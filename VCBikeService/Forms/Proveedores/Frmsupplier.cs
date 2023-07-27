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

            LoadSupplytype();
            LoadListsupply();


        }
        private void LoadListsupply()

        {
            listSupplier = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchSupplier.Text.Trim()) && TxtSearchSupplier.Text.Count() >= 3)
            {

                searchfilter = TxtSearchSupplier.Text.Trim();
            }


            if (checkBSupplier.Checked)
            {

                listSupplier = MySupplier.ListActive(searchfilter);
            }
            else
            {
                listSupplier = MySupplier.ListInactive(searchfilter);
            }
            DgSupplier.DataSource = listSupplier;
        }

        private void Checker()
        {
            if (checkBSupplier.Checked)
            {
                BtnAdd.Visible = true;
                BtnDelete.Visible = true;
                btnDeleteForEver.Visible = false;
                btnactivate.Visible = false;
                BtnClean.Visible = true;
                BtnEdit.Visible = true;
            }
            else
            {
                BtnAdd.Visible = false;
                BtnDelete.Visible = false;
                btnDeleteForEver.Visible = true;
                btnactivate.Visible = true;
                BtnClean.Visible = false;
                BtnEdit.Visible = false;
            }
        }
        private void LoadSupplytype()
        {
            Logic.Models.SupplierType Rol = new Logic.Models.SupplierType();

            DataTable dt = new DataTable();
            dt = Rol.list();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbSupplierType.ValueMember = "ID";
                CbSupplierType.DisplayMember = "Descrip";
                CbSupplierType.DataSource = dt;
                CbSupplierType.SelectedIndex = -1;

            }
        }


        private void CleanForm()
        {
            TxtCardID.Clear();
            TxtIDSupplier.Clear();
            TxtSupplierAddress.Clear();
            TxtSupplierEmail.Clear();
            TxtSupplierName.Clear();
            TxtSupplierPhone.Clear();

            CbSupplierType.SelectedIndex = -1;

        }

        private void checkBSupplier_CheckedChanged(object sender, EventArgs e)
        {
            LoadListsupply();
            Checker();

        }

        private void DgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgSupplier.SelectedRows.Count == 1)
            {
                 
                DataGridViewRow Mifila = DgSupplier.SelectedRows[0];

                
                int IdSuply = Convert.ToInt32(Mifila.Cells["CSupplierID"].Value);
       
                MySupplier = new Logic.Models.Supplier();

              
                MySupplier.SupplierID = IdSuply;

                  

                MySupplier = MySupplier.SearchIDReturnSupply();

                if (MySupplier != null && MySupplier.SupplierID > 0)
                {


                    TxtIDSupplier.Text = Convert.ToString(MySupplier.SupplierID);

                    TxtSupplierEmail.Text = MySupplier.SupplierEmail;
                    TxtSupplierName.Text = MySupplier.SupplierName;
                    TxtCardID.Text = Convert.ToString(MySupplier.SupplierCardID);
                    TxtSupplierPhone.Text = Convert.ToString(MySupplier.PhoneNumber);

                    TxtSupplierAddress.Text = MySupplier.Address;

                    //Combobox

                    CbSupplierType.SelectedValue = MySupplier.MyType.SupplierTypeID;


                }

            }
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtSupplierName.Text.Trim()) && !String.IsNullOrEmpty(TxtSupplierPhone.Text.Trim())
                && !String.IsNullOrEmpty(TxtCardID.Text.Trim()) && CbSupplierType.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al proveedor ?",
                                                                     "???",
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (MySupplier.Activate())
                    {
                        MessageBox.Show("El proveedor ha sido activado correctamente.", "!!!", MessageBoxButtons.OK);
                        CleanForm();
                        LoadListsupply();
                    }

                }


            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Proveedor.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteForEver_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtSupplierName.Text.Trim()) && !String.IsNullOrEmpty(TxtSupplierPhone.Text.Trim())
               && !String.IsNullOrEmpty(TxtCardID.Text.Trim()) && CbSupplierType.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de eliminar al proveedor para siempre ?",
                                                                     "???",
                                                                     MessageBoxButtons.YesNo,
                                                                     MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (MySupplier.DeleteForEver())
                    {
                        MessageBox.Show("El proveedor ha sido elimnado correctamente.", "!!!", MessageBoxButtons.OK);
                        
                    }
                    CleanForm();
                    LoadListsupply();

                }


            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Proveedor.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(TxtSupplierName.Text.Trim()) && !String.IsNullOrEmpty(TxtSupplierPhone.Text.Trim())
               && !String.IsNullOrEmpty(TxtCardID.Text.Trim()))
            {




                bool EmailOK;



                MySupplier = new Logic.Models.Supplier();

                MySupplier.SupplierName = TxtSupplierName.Text.Trim();
                MySupplier.SupplierCardID = Convert.ToInt32(TxtCardID.Text.Trim());
                MySupplier.PhoneNumber = Convert.ToInt32(TxtSupplierPhone.Text.Trim());
                MySupplier.SupplierEmail = TxtSupplierEmail.Text.Trim();
                MySupplier.Address = TxtSupplierAddress.Text.Trim();


                MySupplier.MyType.SupplierTypeID = Convert.ToInt32(CbSupplierType.SelectedValue);



                EmailOK = MySupplier.ConsultEmail();
                if (EmailOK == false)
                {


                    string msg = string.Format("¿Está seguro que desea agregar al Proveedor {0}?", MySupplier.SupplierName);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = MySupplier.AddSupply();

                        if (ok)
                        {
                            MessageBox.Show("Proveedor guardado correctamente!", ":)", MessageBoxButtons.OK);

                            CleanForm();

                            LoadListsupply();

                        }
                        else
                        {
                            MessageBox.Show("El proveedor no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }


                }
                else
                {


                    if (EmailOK)
                    {
                        MessageBox.Show("Ya existe un proveedor con el correo digitado", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Datos faltantes", "Error de Validación", MessageBoxButtons.OK , MessageBoxIcon.Warning);

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TxtSupplierName.Text.Trim()) && !String.IsNullOrEmpty(TxtSupplierPhone.Text.Trim())
                && !String.IsNullOrEmpty(TxtCardID.Text.Trim()) && CbSupplierType.SelectedIndex > -1)
            {
                if (MySupplier.SupplierID > 0 && MySupplier.ConsultEmail())
                {
                    if (checkBSupplier.Checked)
                    {

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Proveedor?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (MySupplier.Delete())
                            {
                                MessageBox.Show("El proveedor ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                CleanForm();
                                LoadListsupply();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un proveedor", "", MessageBoxButtons.OK , MessageBoxIcon.Warning);

            }
        }

        private void TxtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente letras.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtSupplierPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtCardID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            bool emailok;
            bool cardidok;
            if (!String.IsNullOrEmpty(TxtSupplierName.Text.Trim()) && !String.IsNullOrEmpty(TxtSupplierPhone.Text.Trim())
                && !String.IsNullOrEmpty(TxtCardID.Text.Trim()) && CbSupplierType.SelectedIndex > -1)
            {
                MySupplier.SupplierName = TxtSupplierName.Text.Trim();
                MySupplier.SupplierCardID = Convert.ToInt32(TxtCardID.Text.Trim());
                MySupplier.PhoneNumber = Convert.ToInt32(TxtSupplierPhone.Text.Trim());
                MySupplier.SupplierEmail = TxtSupplierEmail.Text.Trim();
                MySupplier.Address = TxtSupplierAddress.Text.Trim();


                MySupplier.MyType.SupplierTypeID = Convert.ToInt32(CbSupplierType.SelectedValue);

                emailok = MySupplier.ConsultEmail();
                cardidok = MySupplier.consultcardid();

                if (emailok==true && cardidok ==true )
                {
                    DialogResult Answer = MessageBox.Show("¿Este u otro  proveedor consta del mismo correo y cedula , aun deseas modificarlo?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (MySupplier.Update())
                        {
                            MessageBox.Show("El proovedor ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListsupply();
                        }
                    }
                }
                else
                {
                    DialogResult Answer = MessageBox.Show("¿Deseas modificar al Proveedor?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (MySupplier.Update())
                        {
                            MessageBox.Show("El proovedor ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListsupply();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Proveedor", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TxtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            LoadListsupply();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
