using CrystalDecisions.Web;
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

namespace VCBikeService.Forms.Factura
{
    public partial class FrmBilling : Form
    {
        public DataTable listitem { get; set; }

        Logic.Models.Item MyItem { get; set; }
        public Billing MyBilling { get; set; }

        public DataTable Localdetailist { get; set; }
        public DataTable Listitems { get; set; }
        public User MyUser { get; set; }

        public Customer MyCustomer { get; set; }

        private List<ProductoAgregado> productosAgregados = new List<ProductoAgregado>();

        public FrmBilling()
        {
            this.KeyPreview = true;
            InitializeComponent();
            listitem = new DataTable();
            MyItem = new Logic.Models.Item();
            MyUser = new Logic.Models.User();
            MyCustomer = new Logic.Models.Customer();
            MyBilling = new Logic.Models.Billing();
            loaduser();
           
        }
        private void Cleaner()
        {
            TxtCustomerID.Clear();
            txtCustomer.SelectedIndex = -1;
            CbBuyType.SelectedIndex = -1;
            cvMethodp.SelectedIndex = -1;
            TxtCantidad.Value = 0;
            TxtDescuento.Value = 0;
            TxtPrecioUnitario.Text= 0.ToString();
            TxtIva.Text= 0.ToString();
            TxtPrecioFinal.Text = 0.ToString();
            TxtNotas.Clear();
            DgLista.ClearSelection();
            LblTotal.Text = 0.ToString();


        }
        private void loaduser()
        {
            if (Globals.MyGlobalUser != null && Globals.MyGlobalUser.UserName != null)
            {
                string MyUser = Globals.MyGlobalUser.UserName;
                TxtUSer.Text = MyUser;
                int UerID = Globals.MyGlobalUser.UserID;
                TxtUserID.Text = UerID.ToString();
            }
            
        }
        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (DgvListaItems.Rows.Count > 0)
            {
                foreach (DataGridViewRow filaLista in DgLista.Rows)
                {
                    int codigoProducto = Convert.ToInt32(filaLista.Cells["ItemID"].Value);
                    int cantidadSeleccionada = Convert.ToInt32(filaLista.Cells["Cantidad"].Value);

              
                    foreach (DataGridViewRow filaProducto in DgvListaItems.Rows)
                    {
                        int codigoProductoEnProduct = Convert.ToInt32(filaProducto.Cells["CItemID"].Value);

                        if (codigoProductoEnProduct == codigoProducto)
                        {
                            int stockActual = Convert.ToInt32(filaProducto.Cells["CStock"].Value);

                            // Restaura la cantidad en stock
                            stockActual += cantidadSeleccionada;

                            // Actualiza la fila correspondiente en el DgProduct
                            filaProducto.Cells["CStock"].Value = stockActual;

                            break; // Salir del bucle una vez que se haya encontrado el producto.
                        }
                    }
                }
                Cleaner();



                // Recalcula el precio total
                ActualizarSubtotal();
            }
            else
            {
                MessageBox.Show("No hay productos en el mantenimiento para limpiar.");
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
        private void LoadCustomer()
        {
            Logic.Models.Customer customers = new Logic.Models.Customer();

            DataTable dt = new DataTable();
            dt = customers.List();

            if (dt != null && dt.Rows.Count > 0)
            {
                txtCustomer.ValueMember = "ID";
                txtCustomer.DisplayMember = "name";
                txtCustomer.DataSource = dt;
                txtCustomer.SelectedIndex = -1;

            } 
        }

        private void FrmBilling_Load(object sender, EventArgs e)
        {
            LoadBillingType();
            LoadMethodPayment();
            LoadCustomer();
            LlenarLista();
            TxtUSer.Text  = Globals.MyGlobalUser.UserName;

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void LlenarLista()
        {
            listitem = MyItem.newbuy();

            DgvListaItems.DataSource = listitem;
            DgvListaItems.ClearSelection();

        }

        private void DgvListaItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvListaItems.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgvListaItems.SelectedRows[0];


                int Idusuario = Convert.ToInt32(Mifila.Cells["CItemID"].Value);

                MyItem = new Logic.Models.Item();

                MyItem.ItemID = Idusuario;

                MyItem = MyItem.ConsultarPorID(Idusuario);

                if (MyItem != null && MyItem.ItemID > 0)
                {
                    
                    TxtPrecioUnitario.Text = MyItem.SellPrice.ToString();

                    //calcular el monto del precio final (tomando en cuenta el % de descuento)
                    CalcularPrecioFinal(MyItem, Convert.ToDecimal(TxtDescuento.Text.Trim()));




                }
            }
        }

        private void CalcularPrecioFinal(Logic.Models.Item pProducto, decimal PorcentajeDescuento)
        {


            decimal PrecioConDescuento = pProducto.SellPrice - ((pProducto.SellPrice * PorcentajeDescuento) / 100);

            decimal PrecioConImpuesto = PrecioConDescuento + ((PrecioConDescuento * pProducto.Tax.AmountTax) / 100);

            TxtPrecioFinal.Text = PrecioConImpuesto.ToString();
        }

        private void FrmBilling_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario si se presiona Escape
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // Realiza el clic en el botón "Facturar" si se presiona Enter
                btnadd.PerformClick();
            }
        }

        private void DgvListaItems_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DgvListaItems.ClearSelection();
        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        
            private void calcular()
            {
                decimal descuento = Convert.ToDecimal(TxtDescuento.Value) / 100;
                int stock = Convert.ToInt32(TxtCantidad.Value);
                decimal valorUnitario;
                decimal iva = 13m / 100m;

                if (decimal.TryParse(TxtPrecioUnitario.Text.Trim(), out valorUnitario))
                {
                    decimal Precioporcantidad = valorUnitario * stock;
                    decimal Impuesto = Precioporcantidad * iva;
                    decimal Preciosindescuento = Precioporcantidad + Impuesto;

                    TxtIva.Text = Impuesto.ToString("0.00");

                    if (descuento > 0)
                    {
                        decimal DescuentoGlobal = Preciosindescuento * descuento;
                        decimal PrecioConDescuento = Preciosindescuento - DescuentoGlobal;

                        TxtPrecioFinal.Text = PrecioConDescuento.ToString("0.00");
                    }
                    else
                    {
                        TxtPrecioFinal.Text = Preciosindescuento.ToString("0.00");
                    }
                }
            }

        

        private void TxtDescuento_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            {
                if (DgvListaItems.SelectedRows.Count > 0)
                {
                    if (decimal.TryParse(TxtPrecioFinal.Text.Trim(), out decimal precioIngresado) && precioIngresado > 0)
                    {
                        if (int.TryParse(TxtCantidad.Text, out int cantidadIngresada) && cantidadIngresada > 0)
                        {
                            DataGridViewRow filaSeleccionada = DgvListaItems.SelectedRows[0];
                            int codigo = Convert.ToInt32(filaSeleccionada.Cells["CItemID"].Value);
                            string nombre = filaSeleccionada.Cells["CItemName"].Value.ToString();
                            decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());
                            decimal unitaryPrice = Convert.ToDecimal(TxtPrecioUnitario.Text.Trim());
                            decimal impuesto = Convert.ToDecimal(TxtIva.Text.Trim());
                            decimal cantidades = (PorcentajeDescuento / 100) * unitaryPrice;
                            decimal descuento = unitaryPrice - cantidades;
                            decimal total = Convert.ToDecimal(TxtPrecioFinal.Text.Trim());

                            // Obtener el valor del stock del producto seleccionado
                            int stockProducto = (int)filaSeleccionada.Cells["CStock"].Value;

                            if (stockProducto >= cantidadIngresada)
                            {
                                // Restar la cantidad ingresada del stock actual del producto
                                stockProducto -= cantidadIngresada;

                                // Actualizar el valor en la columna "CStock" del DataGridView DgListaItems
                                filaSeleccionada.Cells["CStock"].Value = stockProducto;

                                // Verificar si el producto ya existe en la tabla DgLista
                                bool productoExistente = false;
                                foreach (DataGridViewRow filaLista in DgLista.Rows)
                                {
                                    if ((int)filaLista.Cells["ItemID"].Value == codigo)
                                    {
                                        // Producto ya existe, actualizar cantidad, descuento, impuesto y precio total
                                        int cantidadExistente = (int)filaLista.Cells["Cantidad"].Value;
                                        decimal descuentoExistente = (decimal)filaLista.Cells["Discount"].Value;
                                        decimal impuestoExistente = (decimal)filaLista.Cells["Impuesto"].Value;
                                        decimal precioTotalExistente = (decimal)filaLista.Cells["precioFinal"].Value;

                                        filaLista.Cells["Cantidad"].Value = cantidadExistente + cantidadIngresada;
                                        filaLista.Cells["Discount"].Value = descuentoExistente + cantidades;
                                        filaLista.Cells["Impuesto"].Value = impuestoExistente + impuesto;
                                        filaLista.Cells["precioFinal"].Value = precioTotalExistente + total;
                                        productoExistente = true;
                                        break;
                                    }
                                    
    
                                }

                                if (!productoExistente)
                                {
                                    // Producto no existe, agregar nueva fila a DgListaI
                                    DgLista.Rows.Add(nombre, codigo, cantidadIngresada, unitaryPrice, cantidades, impuesto, total);
                                }
                                









                                TxtPrecioUnitario.Text = 0.ToString(); 
                                TxtIva.Text = 0.ToString();
                                TxtPrecioFinal.Text = 0.ToString();
                                ActualizarSubtotal();
                                TxtDescuento.Value = 0;
                                TxtCantidad.Value = 0;
                            }
                            else
                            {
                                MessageBox.Show("No hay suficiente stock disponible para este producto.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad debe ser mayor que 0.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese un precio válido.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto.");
                }
            }
        }

            private void ActualizarSubtotal()
        {
            int subtotal = 0;

            foreach (DataGridViewRow fila in DgLista.Rows)
            {
                int precio = Convert.ToInt32(fila.Cells["precioFinal"].Value);
                subtotal += precio;
            }

            LblTotal.Text = subtotal.ToString();



        }
        private bool ValidarItem()
        {
            bool R = false;

            if (DgvListaItems.SelectedRows.Count == 1 && TxtCantidad.Value > 0)
            {
                //validación correcta
                R = true;
            }
            else
            {
                if (DgvListaItems.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Debe seleccionar un item de la lista", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }

                if (TxtCantidad.Value == 0)
                {
                    MessageBox.Show("La cantidad no puede ser cero", "Error de validación", MessageBoxButtons.OK);
                    return false;
                }
            }
            return R;

        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = DgLista.SelectedRows[0];
                string codigo = filaSeleccionada.Cells["ItemID"].Value.ToString();
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);

                // Busca el producto en el DgProduct por su código
                foreach (DataGridViewRow filaProducto in DgvListaItems.Rows)
                {
                    int codigoProductoEnProduct = Convert.ToInt32(filaProducto.Cells["CItemID"].Value);

                    if (codigoProductoEnProduct == int.Parse(codigo))
                    {
                        int stockProducto = Convert.ToInt32(filaProducto.Cells["CStock"].Value);

                        // Restaura la cantidad eliminada al stock
                        stockProducto += cantidad;

                        // Actualiza la fila correspondiente en el DgProduct
                        filaProducto.Cells["CStock"].Value = stockProducto;

                        break; // Salir del bucle una vez que se haya encontrado el producto.
                    }
                }

                // Elimina la fila seleccionada en DgLista
                DgLista.Rows.Remove(filaSeleccionada);

                // Recalcula el precio total
                ActualizarSubtotal();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.");
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtCustomerID.Text.Trim()) && !string.IsNullOrEmpty(TxtUSer.Text.Trim()) && CbBuyType.SelectedIndex > -1 && cvMethodp.SelectedIndex > -1)
            {
                int customerId = Convert.ToInt32( TxtCustomerID.Text.Trim());
                int userId = Convert.ToInt32(TxtUserID.Text.Trim());

                TxtCustomerID.Text = Convert.ToString(customerId);
                TxtUserID.Text = Convert.ToString(userId);
                MyBilling.MYMethodPayment.MethodPaymentID = Convert.ToInt32(cvMethodp.SelectedValue);
                MyBilling.billingType.BillingTypeID = Convert.ToInt32(CbBuyType.SelectedValue);

                foreach (DataRow item in Localdetailist.Rows)
                {
                    BillingDetail newdetail = new BillingDetail();

                    newdetail.MyItem.ItemID = Convert.ToInt32(item["ItemItemID"]);
                    newdetail.MyItem.Description = Convert.ToString(item["DescripcionItem"]);
                    newdetail.Amount = Convert.ToInt32(item["Amount"]);
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
                    producto.Updates(); // Este método debe actualizar el stock en la base de datos

                    // Agregar el producto a la lista de productos facturados
                    productosFacturados.Add(producto);
                }
                decimal totalValue = 0;
                decimal subTotalValue = 0;
                decimal descuentosValue = 0;
                decimal impuestosValue = 0;

                // Calculate the total value from the Localdetailist DataTable
                foreach (DataRow item in Localdetailist.Rows)
                {
                    decimal itemTotal = Convert.ToDecimal(item["TotalLine"]);
                    totalValue += itemTotal;

                    decimal itemSubTotal = Convert.ToDecimal(item["SubTotalLine"]);
                    subTotalValue += itemSubTotal;

                    decimal itemDescuentos = Convert.ToDecimal(item["PercentageDiscount"]);
                    descuentosValue += (itemSubTotal * itemDescuentos) / 100;

                    decimal itemImpuestos = Convert.ToDecimal(item["ImpuestoLine"]);
                    impuestosValue += itemImpuestos;
                }

                LblTotal.Text = totalValue.ToString();
                MyBilling.Total = Convert.ToDecimal(LblTotal.Text);

                

                MyBilling.Notes = TxtNotas.Text;

                if (MyBilling.Add())
                {
                    MessageBox.Show("Factura guardada correctamente", ":)", MessageBoxButtons.OK);

                    //ReportDocument MiReporteCompra = new ReportDocument();

                    //MiReporteCompra = new Reportes.RptFactura();

                    //MiReporteCompra = MyBilling.Imprimir(MiReporteCompra);

                    ////se asigna este documento al visulizador de reportes (se usa para TODOS los reportes) 
                    //MiFormCRV = new FrmVisualizadorReportes();

                    //MiFormCRV.CrvVisualizador.ReportSource = MiReporteCompra;

                    //MiFormCRV.Show();

                    ////para visualizar la página completa
                    //MiFormCRV.CrvVisualizador.Zoom(1);


                    MyBilling.UpdateProductStock();
                    Localdetailist.Clear();
                    Cleaner();
                }
            }
            else
            {
                MessageBox.Show("Faltan Datos", ":C", MessageBoxButtons.OK);
            }
        }

        private void txtCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCustomer.SelectedIndex >= 0)
            {
                // Obtiene el ID del cliente seleccionado en el combo box
                int customerID = Convert.ToInt32(txtCustomer.SelectedValue);

                // Asigna el ID del cliente al campo de texto
                TxtCustomerID.Text = customerID.ToString();
            }
            else
            {
                // Si no hay un cliente seleccionado, puedes manejarlo según tus necesidades
                TxtCustomerID.Text = string.Empty; // O cualquier otro valor predeterminado que desees
            }
        }

        
    }
    
}
