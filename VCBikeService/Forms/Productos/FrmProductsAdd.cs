using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms
{
    public partial class FrmProductsAdd : Form
    {

        private Logic.Models.Item Myitem { get; set; }
        private DataTable ListItem { get; set; }

        public FrmProductsAdd()
        {
            InitializeComponent();
            Myitem = new Logic.Models.Item();
            ListItem = new DataTable();
            Checker();
            this.KeyPreview = true;
        }

       

        private void TxtUnitaryCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        private void TxtSellPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                

            }
        }

        private void FrmProductsAdd_Load(object sender, EventArgs e)
        {
            FrmProductsAdd frmProductsAdd = new FrmProductsAdd();
            loadlistproduct();
            LoadItemtype();
            LoadTaxes();
             
            LoadUbicaction();
            loadunit();
        }

        private void DgSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            DataGridViewRow Mifila = DgProduct.SelectedRows[0];


            int Iditem = Convert.ToInt32(Mifila.Cells["CItemID"].Value);

            Myitem = new Logic.Models.Item();


            Myitem.ItemID = Iditem;
            Myitem = Myitem.SearchIDReturnItem();
            if (Myitem != null && Myitem.ItemID > 0)
            {
               

                TxtIDProduct.Text = Convert.ToString(Myitem.ItemID);

                TxtBarcode.Text = Myitem.Barcode;
                TxtProductName.Text = Myitem.ItemName;
                TxtSellPrice.Text = Convert.ToString(Myitem.SellPrice);
                TxtUnitaryCost.Text = Convert.ToString(Myitem.UnitaryCost);
                TxtStock.Text = Convert.ToString(Myitem.Stock);
                TxtDescription.Text = Myitem.Description;
                txtvalue.Text = Convert.ToString(Myitem.Tax.AmountTax);
                

                Calculate();



                //Combobox
                cbtax.SelectedValue = Myitem.Tax.TaxID;
                cbUnit.SelectedValue = Myitem.Unit.IDUnit;
                CbCategory.SelectedValue = Myitem.MyType.ItemCategoryID;
                cbUbication.SelectedValue = Myitem.Ubication.UbicationID;
            }
        }
        
        private void loadlistproduct()
        {
            ListItem = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchItem.Text.Trim()) && TxtSearchItem.Text.Count() >= 3)
            {

                searchfilter = TxtSearchItem.Text.Trim();
            }


            if (checkProduct.Checked)
            {

                ListItem = Myitem.ListActive(searchfilter);
            }
            else
            {
                ListItem = Myitem.ListInactive(searchfilter);
            }
            DgProduct.DataSource = ListItem;
        }
        private void LoadItemtype()
        {
            Logic.Models.ItemCategory Rol = new Logic.Models.ItemCategory();

            DataTable dt = new DataTable();
            dt = Rol.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbCategory.ValueMember = "ID";
                CbCategory.DisplayMember = "Descrip";
                CbCategory.DataSource = dt;
                CbCategory.SelectedIndex = -1;

            }
        }
        private void LoadUbicaction()
        {
            Logic.Models.Ubication ubi = new Logic.Models.Ubication();

            DataTable dt = new DataTable();
            dt = ubi.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                cbUbication.ValueMember = "ID";
                cbUbication.DisplayMember = "Descrip";
                cbUbication.DataSource = dt;
                cbUbication.SelectedIndex = -1;

            }
        }
        private void loadunit()
        {
            Logic.Models.Unit unit = new Logic.Models.Unit();

            DataTable dt = new DataTable();
            dt = unit.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                cbUnit.ValueMember = "ID";
                cbUnit.DisplayMember = "Descrip";
                cbUnit.DataSource = dt;
                cbUnit.SelectedIndex = -1;

            }
        }
        private void LoadTaxes()
        {
            Logic.Models.Tax tax = new Logic.Models.Tax();

            DataTable dt = new DataTable();
            dt = tax.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                cbtax.ValueMember = "ID";
                cbtax.DisplayMember = "Descrip";
                cbtax.DataSource = dt;
                cbtax.SelectedIndex = -1;
            }
        }
        private void CleanForm()
        {
            TxtBarcode.Clear();
            TxtDescription.Clear();
            TxtIDProduct.Clear();
            TxtProductName.Clear();
            TxtStock.Value = 0;
            TxtSellPrice.Clear();
            TxtUnitaryCost.Clear();
            cbtax.SelectedIndex = -1;
            CbCategory.SelectedIndex = -1;
            cbUnit.SelectedIndex = -1;
            cbUbication.SelectedIndex = -1;
            txtFinalPrice.Clear();
            txt20.Checked = false;
            txt40.Checked = false;
            txt60.Checked = false;
            txt80.Checked = false;
            txt100.Checked = false;
            txt120.Checked = false;
            txt140.Checked = false;
            
            
        }



        private void BtnAddproduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
                && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()))
            {
                bool IDOK;
                bool BarcodeOk;



                Myitem = new Logic.Models.Item();

                Myitem.ItemName = TxtProductName.Text.Trim();
                Myitem.UnitaryCost = Convert.ToDecimal(TxtUnitaryCost.Text.Trim());
                Myitem.SellPrice = Convert.ToDecimal(TxtSellPrice.Text.Trim());
                Myitem.Description = TxtDescription.Text.Trim();
                Myitem.Barcode = TxtBarcode.Text.Trim();
                Myitem.Stock = Convert.ToInt32(TxtStock.Text.Trim());
                Myitem.Tax.TaxID = Convert.ToInt32(cbtax.SelectedValue);
                Myitem.Unit.IDUnit = Convert.ToInt32(cbUnit.SelectedValue);
                Myitem.Ubication.UbicationID = Convert.ToInt32(cbUbication.SelectedValue);


                Myitem.MyType.ItemCategoryID = Convert.ToInt32(CbCategory.SelectedValue);



                IDOK = Myitem.ConsultID();
                BarcodeOk = Myitem.ConsultBarcode();
                if (IDOK == false && BarcodeOk == false)
                {


                    string msg = string.Format("¿Está seguro que desea agregar este producto {0}?", Myitem.ItemName);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = Myitem.Add();

                        if (ok)
                        {
                            MessageBox.Show("Producto guardado correctamente!", ":)", MessageBoxButtons.OK);

                            CleanForm();

                            loadlistproduct();

                        }
                        else
                        {
                            MessageBox.Show("El producto no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }


                }
                else
                {


                    if (IDOK)
                    {
                        MessageBox.Show("Ya existe un producto con el Mismo ID", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }
                    if (BarcodeOk)
                    {
                        MessageBox.Show("Ya existe un producto con el Mismo Codigo de Barras", "Error de Validación", MessageBoxButtons.OK);
                        return;
                    }


                }

            }

            else
            {
                MessageBox.Show("Datos faltantes", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void BtnCleanproduct_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void BtnCancelproduct_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void Checker()
        {
            if (checkProduct.Checked)
            {
                BtnDeleteproduct.Visible = true;
                btnactivate.Visible = false;
                BtnDeleteForEver.Visible = false;
                BtnAddproduct.Visible = true;
                BtnEditproduct.Visible = true;
                BtnCleanproduct.Visible = true;
            }
            else
            {
                btnactivate.Visible = true;
                BtnDeleteForEver.Visible = true;
                BtnAddproduct.Visible = false;
                BtnEditproduct.Visible = false;
                BtnCleanproduct.Visible = false;
                BtnDeleteproduct.Visible = false;
            }
        }

        private void BtnDeleteproduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
                && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()))
            {
                if (Myitem.ItemID > 0 && Myitem.ConsultID())
                {
                    if (checkProduct.Checked)
                    {

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Producto?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (Myitem.Delete())
                            {
                                MessageBox.Show("El Producto ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                CleanForm();
                                loadlistproduct();
                            }

                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnDeleteForEver_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
               && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()))
            {


                DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Producto?",
                                                 "???",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (Myitem.DeleteForEver())
                    {
                        MessageBox.Show("El Producto ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);

                    }
                    CleanForm();
                    loadlistproduct();

                }




            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void checkProduct_CheckedChanged(object sender, EventArgs e)
        {
            loadlistproduct();
            Checker();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
              && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()))
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al Producto ?",
                                                                   "???",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (Myitem.Activate())
                    {
                        MessageBox.Show("El producto  ha sido activado correctamente.", "!!!", MessageBoxButtons.OK);
                        CleanForm();
                        loadlistproduct();
                    }

                }

            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Producto.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditproduct_Click(object sender, EventArgs e)
        {
            bool IDOK;
            bool BarcodeOk;
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
              && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()) &&
              CbCategory.SelectedIndex > -1)
            {
                Myitem.ItemName = TxtProductName.Text.Trim();
                Myitem.Barcode = TxtBarcode.Text.Trim();
                Myitem.UnitaryCost = Convert.ToDecimal(TxtUnitaryCost.Text.Trim());
                Myitem.SellPrice = Convert.ToDecimal(TxtSellPrice.Text.Trim());
                Myitem.Stock = Convert.ToInt32(TxtStock.Text.Trim());
                Myitem.Description = TxtDescription.Text.Trim();

                Myitem.Tax.TaxID = Convert.ToInt32(cbtax.SelectedValue);
                Myitem.Unit.IDUnit = Convert.ToInt32(cbUnit.SelectedValue);
                Myitem.Ubication.UbicationID = Convert.ToInt32(cbUbication.SelectedValue);


              



                Myitem.MyType.ItemCategoryID = Convert.ToInt32(CbCategory.SelectedValue);
                IDOK = Myitem.ConsultID();
                BarcodeOk = Myitem.ConsultBarcode();
                if (IDOK == true && BarcodeOk == true)
                {
                    DialogResult Answer = MessageBox.Show("¿Este u otro Producto Contiene el mismo codigo de barras, aun deseas modificarlo?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (Myitem.Update())
                        {
                            MessageBox.Show("El producto ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            loadlistproduct();
                        }
                        else
                        {
                            MessageBox.Show("El producto no ha sido modificado correctamente", ":C", MessageBoxButtons.OK);
                            CleanForm();
                            loadlistproduct();
                        }
                    }


                }
                else
                {
                    DialogResult Answer = MessageBox.Show("¿Está seguro de modificar el Producto Seleccionado?", "???",
                                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (Myitem.Update())
                        {
                            MessageBox.Show("El Producto ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                        }

                        CleanForm();
                        loadlistproduct();

                    }
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void TxtSearchItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadlistproduct();
        }

        private void CalculatePercentage(decimal porcentaje)
        {
            if (!string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()))
            {
                decimal costo = Convert.ToDecimal(TxtUnitaryCost.Text.Trim());
                decimal total = costo + (costo * porcentaje);

                 
                total = Math.Round(total, 2);
                TxtSellPrice.Text = total.ToString();
                Calculate();
            }
            else
            {
                MessageBox.Show("Primero debes agregar un costo unitario", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CleanForm();
            }
        }

        private void txt20_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(0.20m);
        }

        private void txt40_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(0.40m);
        }

        private void txt60_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(0.60m);
        }

        private void txt80_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(0.80m);
        }

        private void txt100_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(1.0m);
        }

        private void txt120_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(1.20m);
        }

        private void txt140_CheckedChanged(object sender, EventArgs e)
        {
            CalculatePercentage(1.40m);
        }
        private void Calculate()
        {
            if (!string.IsNullOrEmpty(TxtSellPrice.Text.Trim()) && cbtax.SelectedIndex >-1)
            {
                decimal impuesto = (0.13m);
                decimal TotalEntero = Convert.ToDecimal(TxtSellPrice.Text.Trim());
                decimal total = TotalEntero + (TotalEntero*impuesto);
                total = Math.Round(total, 2);
                txtFinalPrice.Text = total.ToString();

            }
             
        }

        private void cbtax_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbtax.SelectedIndex > -1)
            {
                // Get the selected DataRowView
                DataRowView selectedRow = (DataRowView)cbtax.SelectedItem;

                // Get the value of the 'AmountTax' column
                if (selectedRow.Row["value"] is decimal impuestoValor)
                {
                    txtvalue.Text = impuestoValor.ToString("F2"); // Format the value as "18.2" decimal
                }
                else
                {
                    // Handle the case when the value cannot be converted to decimal
                    txtvalue.Text = "0";
                }
            }
            else
            {
                // If no item is selected, you can set the default value for textBox1
                txtvalue.Text = "0";
            }

            // Recalculate the price with the new tax value
            Calculate();
        }

        private void checkProduct_CheckedChanged_1(object sender, EventArgs e)
        {
            Checker();
            loadlistproduct();
            
        }

        private void FrmProductsAdd_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario si se presiona Escape
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // Realiza el clic en el botón "add" si se presiona Enter
                BtnAddproduct.PerformClick();
            }
        }
    }
    }

 















        