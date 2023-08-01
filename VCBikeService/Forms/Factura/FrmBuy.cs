﻿using Logic.Models;
using Logic.Services;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Productos;
using VCBikeService.Forms.Reportes;

namespace VCBikeService.Forms.Compra
{
    public partial class FrmBuy : Form
    {

        public Billing MyBilling { get; set; }

        public DataTable Localdetailist { get; set; }
        public DataTable Listitems { get; set; }

   




        public FrmBuy()
        {
            InitializeComponent(); 

            MyBilling = new Billing();
            Localdetailist = new DataTable();

            Listitems = new DataTable();
             
        }


        private void user()
        {
            string Username = Globals.MyGlobalUser.UserName; ;
            TxtUSer.Text = Username;
        }

        private void Totalizar()
        {
            if (Localdetailist != null && Localdetailist.Rows.Count > 0)
            {

                decimal Subt = 0;
                decimal Descuentos = 0;
                decimal Impuestos = 0;
                decimal Total = 0;


                foreach (DataRow item in Localdetailist.Rows)
                {

                    Subt += Convert.ToDecimal(item["Amount"]) * Convert.ToDecimal(item["UnitaryPrice"]);

                    Descuentos += Subt * Convert.ToDecimal(item["PercentageDiscount"]) / 100;

                    Impuestos += Convert.ToDecimal(item["ImpuestoLine"]);

                    Total += Convert.ToDecimal(item["TotalLine"]);
                }


                LblSubTotal.Text = string.Format("{0:C2}", Subt);
                LblDescuentos.Text = string.Format("{0:C2}", Descuentos);
                LblImpuestos.Text = string.Format("{0:C2}", Impuestos);
                LblTotal.Text = string.Format("{0:C2}", Total);

            }
        }

        private void LoadBillingType()
        {
            Logic.Models.BillingType type = new Logic.Models.BillingType();

            DataTable dt = new DataTable();
            dt = type.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                CbBuyType.ValueMember = "ID";
                CbBuyType.DisplayMember = "Descrip";
                CbBuyType.DataSource = dt;
                CbBuyType.SelectedIndex = -1;

            }
        }

        private void LoadMethodPayment()
        {
            Logic.Models.MethodPayment type = new Logic.Models.MethodPayment();

            DataTable i = new DataTable();
            i = type.List();

            if (i != null && i.Rows.Count > 0)
            {
                cvMethodp.ValueMember = "ID";
                cvMethodp.DisplayMember = "Descrip";
                cvMethodp.DataSource = i;
                cvMethodp.SelectedIndex = -1;

            }
        }

         


        private void FrmBuy_Load(object sender, EventArgs e)
        {
            user();


            LoadBillingType();
            LoadMethodPayment();
            clean();
        }
        private void clean()
        {
            CbBuyType.SelectedIndex = -1;
            cvMethodp.SelectedIndex = -1;


            DtpFechaFactura.Value = DateTime.Now.Date;

            DtpFechaFactura.Value = DateTime.Now.Date;

            TxtNotas.Clear();
            TxtUSer.Clear();

            LblSubTotal.Text = "0";
            LblDescuentos.Text = "0";
            LblImpuestos.Text = "0";
            LblTotal.Text = "0";

            MyBilling = new Logic.Models.Billing();
            Localdetailist = new DataTable();
            Localdetailist = MyBilling.Detailsummary();


            DgvListaItems.DataSource = Localdetailist;


            Localdetailist.Clear(); // Clear the Localdetailist DataTable
            DgvListaItems.DataSource = Localdetailist; // Update the DataGridView with the cleared data

            LblNombreCliente.Text = "0";


            TxtCustomerID.Clear();
            LblNombreCliente.Text = "";
        }

        private void LoadListBillingDetail()
        {
            // cargar en la composición los detalles a partir del datatable de detalles local

            foreach (DataRow item in Localdetailist.Rows)
            {
                Logic.Models.BillingDetail detail = new Logic.Models.BillingDetail();

                detail.Amount = Convert.ToDecimal(item["Amount"]);
                detail.ImpuestoLine = Convert.ToDecimal(item["ImpuestoLine"]);
                detail.MyItem.ItemID = Convert.ToInt32(item["ItemItemID"]);
                detail.PercentageDiscount = Convert.ToDecimal(item["PercentageDiscount"]);
                detail.UnitaryPrice = Convert.ToDecimal(item["UnitaryPrice"]);
                detail.SubTotalLine = Convert.ToDecimal(item["SubTotalLine"]);
                detail.TotalLine = Convert.ToDecimal(item["TotalLine"]);

                // Don't include the identity column (if it exists) in the insert statement
                // The identity column value will be generated automatically by SQL Server
                // Remove the line below if there's no identity column in the BillingDetail table
                // detail.BillingDetailID = 0; // <- Remove this line

                MyBilling.DetailItems.Add(detail);
            }
        }

        private void BtnClienteBuscar_Click_1(object sender, EventArgs e)
        {
            Form FormSearchCustomer = new FrmSearchCustomer();
            DialogResult resp = FormSearchCustomer.ShowDialog();

            if (resp == DialogResult.OK)
            {

                if (!string.IsNullOrEmpty(TxtCustomerID.Text.Trim()))
                {
                    int IdCliente = Convert.ToInt32(TxtCustomerID.Text.Trim());

                    //se incluyen los datos en la composición del cliente
                    if (true)
                    {
                        TxtCustomerID.Visible = true;

                        MyBilling.MyCustomer = MyBilling.MyCustomer.SearchID(IdCliente);
                        LblNombreCliente.Text = MyBilling.MyCustomer.CustomerName;
                        LblNombreCliente.Visible = true;


                    }



                }

            }
        }



        private void Cancel_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new FrmAddSearchProduct();

            DialogResult resp = form.ShowDialog();

            if (resp == DialogResult.OK)
            {
                //se ha seleccionado correctamente un item

                DgvListaItems.DataSource = Localdetailist;

                Totalizar();
            }
        }



        private void RecalcularValorTotalFactura()
        {
            decimal valorTotalFactura = 0;
            decimal valorSubtotalFactura = 0;
            decimal valorDescuentoFactura = 0;
            decimal valorImpuestoFactura = 0;

            foreach (DataRow row in Globals.Frmfactura.Localdetailist.Rows)
            {

                decimal precioFinalProducto = Convert.ToDecimal(row["TotalLine"]);
                decimal subtotalProducto = Convert.ToDecimal(row["SubTotalLine"]);
                decimal descuentoProducto = Convert.ToDecimal(row["PercentageDiscount"]);
                decimal impuestoProducto = Convert.ToDecimal(row["ImpuestoLine"]);
                int cantidadInicial = Convert.ToInt32(row["Amount"]);

                valorTotalFactura += precioFinalProducto;
                valorSubtotalFactura += subtotalProducto;
                valorDescuentoFactura += (subtotalProducto * descuentoProducto) / 100;
                valorImpuestoFactura += impuestoProducto;
                RecalcularLinea(DgvListaItems.SelectedRows[0], cantidadInicial);
            }

            // Actualizar los valores en donde corresponda (por ejemplo, en TextBox o Label)
            LblTotal.Text = valorTotalFactura.ToString();
            // Actualiza el subtotal, descuento e impuesto de la factura en sus respectivos controles
            // Ejemplo:
            LblSubTotal.Text = valorSubtotalFactura.ToString();
            LblDescuentos.Text = valorDescuentoFactura.ToString();
            LblImpuestos.Text = valorImpuestoFactura.ToString();
        }
        private void RecalcularLinea(DataGridViewRow row, int cantidadInicial)
        {
            int cantidad = Convert.ToInt32(row.Cells["CAmount"].Value);
            decimal unitaryPrice = Convert.ToDecimal(row.Cells["CUnitaryPrice"].Value);
            decimal impuestoPorProducto = Convert.ToDecimal(row.Cells["CImpuestoLine"].Value);

            decimal subtotalProducto = unitaryPrice * cantidad;
            decimal impuestoLinea = impuestoPorProducto * (cantidad - cantidadInicial); // Calculate the tax adjustment based on the difference in quantity
            decimal totalLinea = subtotalProducto + impuestoLinea;

            row.Cells["CSubTotalLine"].Value = subtotalProducto;
            row.Cells["CImpuestoLine"].Value = impuestoLinea;
            row.Cells["CTotalLine"].Value = totalLinea;
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (DgvListaItems.SelectedRows.Count > 0)
            {
                int cantidadActual = Convert.ToInt32(DgvListaItems.SelectedRows[0].Cells["CAmount"].Value);

                // Llamar al método GetFrmEditBuyItem en Globals.cs y pasar el DataTable y la cantidad actual
                Forms.Compra.FrmEditBuyItem frmEditItem = Globals.GetFrmEditBuyItem(Localdetailist, cantidadActual);

                // Mostrar el formulario de edición como un cuadro de diálogo

                DialogResult result = frmEditItem.ShowDialog();

                // Si el usuario hizo clic en el botón "Aceptar" en el formulario de edición, actualizar la cantidad
                if (result == DialogResult.OK)
                {

                    int nuevaCantidad = frmEditItem.CantidadEditada;


                    // Actualizar la cantidad en el DataGridView
                    DgvListaItems.SelectedRows[0].Cells["CAmount"].Value = nuevaCantidad;

                    if (cantidadActual > nuevaCantidad)
                    {
                        RecalcularLineas(DgvListaItems.SelectedRows[0]);

                    }
                    else
                    {
                        RecalcularLinea(DgvListaItems.SelectedRows[0]);



                    }

                    RecalcularValorTotalFactura();
                }
            }
        }
        private void RecalcularLinea(DataGridViewRow row)
        {
            {
                int cantidad = Convert.ToInt32(row.Cells["CAmount"].Value);
                decimal unitaryPrice = Convert.ToDecimal(row.Cells["CUnitaryPrice"].Value);
                decimal impuestoPorProducto = Convert.ToDecimal(row.Cells["CImpuestoLine"].Value);

                decimal subtotalProducto = unitaryPrice * cantidad;
                decimal impuestoLinea = impuestoPorProducto * cantidad; // Calculate the tax adjustment based on the difference in quantity
                decimal totalLinea = subtotalProducto + impuestoLinea;

                row.Cells["CSubTotalLine"].Value = subtotalProducto;
                row.Cells["CImpuestoLine"].Value = impuestoLinea;
                row.Cells["CTotalLine"].Value = totalLinea;
            }
        }
        private void RecalcularLineas(DataGridViewRow row)
        {
            {
                int cantidad = Convert.ToInt32(row.Cells["CAmount"].Value);
                decimal unitaryPrice = Convert.ToDecimal(row.Cells["CUnitaryPrice"].Value);
                decimal impuestoPorProducto = Convert.ToDecimal(row.Cells["CImpuestoLine"].Value);

                decimal subtotalProducto = unitaryPrice * cantidad;
                decimal impuestoLinea = impuestoPorProducto * cantidad; // Calculate the tax adjustment based on the difference in quantity
                decimal totalLinea = subtotalProducto + impuestoLinea;

                row.Cells["CSubTotalLine"].Value = subtotalProducto;
                row.Cells["CImpuestoLine"].Value = impuestoLinea;
                row.Cells["CTotalLine"].Value = totalLinea;
            }
        }


        private void CalcularTotalLine()
        {
            decimal valorTotalFactura = 0;
            decimal valorSubtotalFactura = 0;
            decimal valorDescuentoFactura = 0;
            decimal valorImpuestoFactura = 0;

            foreach (DataRow row in Localdetailist.Rows)
            {
                int cantidad = Convert.ToInt32(row["CAmount"]);
                decimal unitaryPrice = Convert.ToDecimal(row["CUnitaryPrice"]);
                decimal impuestoPorProducto = Convert.ToDecimal(row["CImpuestoLine"]);

                decimal subtotalProducto = unitaryPrice * cantidad;
                decimal impuestoLinea = impuestoPorProducto * cantidad; // Calculate the tax for each product based on its quantity
                decimal totalLinea = subtotalProducto + impuestoLinea;

                row["SubTotalLine"] = subtotalProducto;
                row["ImpuestoLine"] = impuestoLinea;
                row["TotalLine"] = totalLinea;

                // Update the invoice totals
                valorTotalFactura += totalLinea;
                valorSubtotalFactura += subtotalProducto;
                valorImpuestoFactura += impuestoLinea;
            }

            // Calculate the discount for the entire invoice based on the subtotal
            valorDescuentoFactura = valorSubtotalFactura * Convert.ToDecimal(LblDescuentos.Text) / 100;

            // Actualizar los valores en donde corresponda (por ejemplo, en TextBox o Label)
            LblTotal.Text = valorTotalFactura.ToString();
            // Actualiza el subtotal, descuento e impuesto de la factura en sus respectivos controles
            // Ejemplo:
            LblSubTotal.Text = valorSubtotalFactura.ToString();
            LblDescuentos.Text = valorDescuentoFactura.ToString();
            LblImpuestos.Text = valorImpuestoFactura.ToString();

        }

        private void Facturar_Click(object sender, EventArgs e)

        {
            if (!string.IsNullOrEmpty(TxtCustomerID.Text.Trim()) && Localdetailist != null && Localdetailist.Rows.Count > 0 && CbBuyType.SelectedIndex > -1 && cvMethodp.SelectedIndex > -1)
            {
                //TO DO: efectuar las validaciones correpondientes ej, que la fecha no sea mayor a la actual y que
                //se haya seleccionado datos mínimos como cliente, usuario, etc.

                // Obtener los IDs de usuario y cliente antes de entrar al ciclo foreach

                int customerId = MyBilling.MyCustomer.CustomerID;

                TxtCustomerID.Text = Convert.ToString(customerId);
                MyBilling.MyUser.UserID = Globals.MyGlobalUser.UserID;
                MyBilling.MYMethodPayment.MethodPaymentID = Convert.ToInt32(cvMethodp.SelectedValue);
                MyBilling.billingType.BillingTypeID = Convert.ToInt32(CbBuyType.SelectedValue);

                foreach (DataRow item in Localdetailist.Rows)
                {
                    BillingDetail newdetail = new BillingDetail();

                    newdetail.MyItem.ItemID = Convert.ToInt32(item["ItemItemID"]);
                    newdetail.MyItem.Description = Convert.ToString(item["DescripcionItem"]);
                    newdetail.Amount = Convert.ToDecimal(item["Amount"]);
                    newdetail.UnitaryPrice = Convert.ToDecimal(item["UnitaryPrice"]);
                    newdetail.PercentageDiscount = Convert.ToDecimal(item["PercentageDiscount"]);
                    newdetail.SubTotalLine = Convert.ToDecimal(item["SubTotalLine"]);
                    newdetail.ImpuestoLine = Convert.ToDecimal(item["ImpuestoLine"]);
                    newdetail.TotalLine = Convert.ToDecimal(item["TotalLine"]);

                    MyBilling.DetailItems.Add(newdetail);
                }

                List<Item> productosFacturados = new List<Item>();

                foreach (DataRow item in Localdetailist.Rows)
                {
                    // Obtener los datos del detalle de factura
                    int itemId = Convert.ToInt32(item["ItemItemID"]);
                    int cantidadFacturar = Convert.ToInt32(item["Amount"]);

                    // Obtener el producto desde la base de datos
                    Item producto = new Item();
                    producto.ItemID = itemId;
                    producto = producto.ConsultarPorID(itemId);

                    // Validar que la cantidad a facturar no exceda el stock disponible
                    if (producto.Stock < cantidadFacturar)
                    {
                        MessageBox.Show($"La cantidad a facturar del producto '{producto.ItemName}' excede el stock disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Actualizar el stock en la base de datos restando la cantidad facturada
                    producto.Stock -= cantidadFacturar;
                    producto.Update(); // Este método debe actualizar el stock en la base de datos

                    // Agregar el producto a la lista de productos facturados
                    productosFacturados.Add(producto);
                }






                // Once all sales and stock updates are done, proceed to add the billing record

 

                if (MyBilling.Add())
                {
                    MessageBox.Show("Factura guardada correctamente", ":)", MessageBoxButtons.OK);
                    // TO DO: llamado a reporte
                    MyBilling.UpdateProductStock();
                    Localdetailist.Clear();
                    clean();
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos", ":C", MessageBoxButtons.OK);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un item de la lista", "Error de validación", MessageBoxButtons.OK);
                return;
            }

            DialogResult r = MessageBox.Show("¿Está seguro de eliminar este producto?",
                                             "Confirmar Eliminación",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                // Obtener el índice de la fila seleccionada en el DataGridView
                int rowIndex = DgvListaItems.SelectedRows[0].Index;

                // Eliminar la fila correspondiente del DataTable
                Globals.Frmfactura.Localdetailist.Rows.RemoveAt(rowIndex);

                // Recalcular el valor total de la factura y actualizar los controles correspondientes
                RecalcularValorTotalFactura();
            }
        }

        private void DtpFechaFactura_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaSeleccionada = DtpFechaFactura.Value;
            DateTime fechaActual = DateTime.Now;

            if (fechaSeleccionada < fechaActual)
            {
                // Mostrar una alerta al usuario
                MessageBox.Show("La fecha seleccionada es anterior al día de hoy. No se puede generar una factura con una fecha pasada.", "Fecha inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Puedes resetear la fecha seleccionada a la fecha actual si lo deseas
                DtpFechaFactura.Value = fechaActual;
            }
        }
    }
}

