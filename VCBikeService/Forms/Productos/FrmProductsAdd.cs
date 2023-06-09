﻿using Logic.Models;
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
        }

        private void TxtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente letras.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
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



                //Combobox

                CbCategory.SelectedValue = Myitem.MyType.ItemCategoryID;
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
        private void CleanForm()
        {
            TxtBarcode.Clear();
            TxtDescription.Clear();
            TxtIDProduct.Clear();
            TxtProductName.Clear();
            TxtStock.Clear();
            TxtSellPrice.Clear();
            TxtUnitaryCost.Clear();
            CbCategory.SelectedIndex = -1;
        }

        private void BtnAddproduct_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtProductName.Text.Trim()) && !string.IsNullOrEmpty(TxtBarcode.Text.Trim())
                && !string.IsNullOrEmpty(TxtUnitaryCost.Text.Trim()) && !string.IsNullOrEmpty(TxtSellPrice.Text.Trim()))
            {
                bool IDOK;



                Myitem = new Logic.Models.Item();

                Myitem.ItemName = TxtProductName.Text.Trim();
                Myitem.UnitaryCost = TxtUnitaryCost.Text.Length;
                Myitem.SellPrice = TxtSellPrice.Text.Length;
                Myitem.Description = TxtDescription.Text.Trim();
                Myitem.Barcode = TxtBarcode.Text.Trim();
                Myitem.Stock = TxtStock.Text.Length;


                Myitem.MyType.ItemCategoryID = Convert.ToInt32(CbCategory.SelectedValue);



                IDOK = Myitem.ConsultID();
                if (IDOK == false)
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
                                CleanForm();
                                loadlistproduct();
                            }

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

        }
    }
}
