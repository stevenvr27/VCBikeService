using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using VCBikeService.Forms.Compra;

namespace VCBikeService.Forms.Mantenimiento
{
   
    public partial class FrmMantenimiento : Form
    {
        public Maintenance MyMaintenance { get; set; }
        private DataTable ListItem { get; set; }
        public User MyUser { get; set; }
        public Customer MyCustomer { get; set; }
        private Item MyItem { get; set; }
        public DataTable Listitems { get; set; }
        private List<decimal> valoresAdicionales = new List<decimal>();


        private List<ProductoAgregado> productosAgregados = new List<ProductoAgregado>();


        public FrmMantenimiento()
        {
            InitializeComponent();
            ListItem = new DataTable();
            MyItem = new Item();
            MyMaintenance = new Maintenance();
            MyUser = new User();
            MyCustomer = new Customer();
            ListItem= new DataTable();
            valoresAdicionales= new List<decimal>();
            
            LoadCustomer();
            Loadbicitype();
            loadlistproduct();
        }

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            TxtUserName.Text = Globals.MyGlobalUser.UserName;
            TxtUSerID.Text =Convert.ToString( Globals.MyGlobalUser.UserID);
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
        private void Loadbicitype()
        {
            Logic.Models.BiciType type = new Logic.Models.BiciType();

            DataTable dt = new DataTable();
            dt = type.list();

            if (dt != null && dt.Rows.Count > 0)
            {
                txttipo.ValueMember = "ID";
                txttipo.DisplayMember = "Descrip";
                txttipo.DataSource = dt;
                txttipo.SelectedIndex = -1;

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
            ListItem = MyItem.Listar(searchfilter);

            DgProduct.DataSource = ListItem;
        }

        private void DgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgProduct.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgProduct.SelectedRows[0];


                int IdProduct = Convert.ToInt32(Mifila.Cells["CItemID"].Value);

                MyItem = new Logic.Models.Item();

                MyItem.ItemID = IdProduct;

                MyItem = MyItem.SearchIDReturnitem();

                if (MyItem != null && MyItem.ItemID > 0)
                {
                    TxtPrecioUnitario.Text = Convert.ToString(MyItem.SellPrice.ToString("0.00"));
                     
                }
            }
        }

        private void TxtCantidad_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void TxtPrecioUnitario_TextChanged(object sender, EventArgs e)
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


        private void ActualizarSubtotal()
        {
            int subtotal = 0;

            foreach (DataGridViewRow fila in DgLista.Rows)
            {
                int precio = Convert.ToInt32(fila.Cells["precioFinal"].Value);
                subtotal += precio;
            }

            txttotal.Text = subtotal.ToString();
           

             
        }



        private void btnadd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TxtPrecioFinal.Text.Trim(), out decimal precioIngresado))
            {
                if (precioIngresado > 0)
                {
                    if (int.TryParse(TxtCantidad.Text, out int cantidadIngresada))
                    {
                        if (cantidadIngresada > 0) // Verificar si la cantidad es mayor que 0
                        {
                            foreach (DataGridViewRow filaSeleccionada in DgProduct.SelectedRows)
                            {
                                int stockProducto = Convert.ToInt32(filaSeleccionada.Cells["CStock"].Value); // Obtiene el stock actual del producto

                                string nombre = filaSeleccionada.Cells["CItemName"].Value.ToString();
                                int codigo = Convert.ToInt32(filaSeleccionada.Cells["CItemID"].Value.ToString());
                                decimal PorcentajeDescuento = Convert.ToDecimal(TxtDescuento.Text.Trim());
                                decimal unitaryPrice = Convert.ToDecimal(TxtPrecioUnitario.Text.Trim());

                                decimal impuesto = Convert.ToDecimal(TxtIva.Text.Trim());
                                decimal cantidades = (PorcentajeDescuento / 100) * unitaryPrice;
                                decimal descuento = unitaryPrice - cantidades;
                                decimal total = Convert.ToDecimal(TxtPrecioFinal.Text.Trim());

                                // Verificar si hay suficiente stock para restar
                                if (stockProducto >= cantidadIngresada)
                                {
                                    // Restar la cantidad ingresada del stock actual del producto
                                    stockProducto -= cantidadIngresada;

                                    // Actualizar el valor en la columna "CStock" del DataGridView DgProduct
                                    filaSeleccionada.Cells["CStock"].Value = stockProducto;

                                    // Crear una nueva fila en DgLista con los valores obtenidos
                                    DgLista.Rows.Add(nombre, codigo, cantidadIngresada, cantidades, impuesto, total);

                                    // Agregar el producto a la lista de productos agregados
                                    productosAgregados.Add(new ProductoAgregado { Codigo = codigo, CantidadAgregada = cantidadIngresada, Descuento = cantidades, Impuesto = impuesto });

                                    TxtPrecioUnitario.Clear();
                                    TxtIva.Clear();
                                    TxtPrecioFinal.Clear();
                                    ActualizarSubtotal();
                                    TxtDescuento.Value = 0;
                                    TxtCantidad.Value = 0;
                                }
                                else
                                {
                                    MessageBox.Show("No hay suficiente stock para realizar esta operación.");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("La cantidad debe ser mayor que 0.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un producto y una cantidad.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un precio válido.");
            }
        }

        private void cleaner() {
            txtCustomer.SelectedIndex = -1;
            TxtCustomerID.Clear();
            txtvalue.Clear();
            Txtvaluefinal.Clear();
            txtbrand.Clear();
            txttipo.SelectedIndex = -1;
            txtvalue.Clear();
            TxtIva.Clear();
            Txtnotes.Clear(); 
            TxtCantidad.Value = 0;
            TxtDescuento.Value = 0;
            TxtPrecioFinal.Clear();
            TxtPrecioUnitario.Clear();
            txttotal.Clear();
            DtpFechaFactura.Value = DateTime.Now;
            Txtvaluefinal.Clear();
            TxtSearchItem.Clear();
            DgLista.Rows.Clear();
            

        }

        

         

        private void ActualizarTxtValueFinal()
        {
            decimal valorFinal = valoresAdicionales.Sum();
            Txtvaluefinal.Text = valorFinal.ToString();
        }

        private void ActualizarTxtTotal()
        {
            if (decimal.TryParse(txttotal.Text.Trim(), out decimal totalActual))
            {
                decimal total = valoresAdicionales.Sum() + totalActual;
                txttotal.Text = total.ToString();
            }
           
        }

        private void buttonaddvalue_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtvalue.Text.Trim(), out decimal valorIngresado))
            {
                valoresAdicionales.Add(valorIngresado);
                ActualizarTxtValueFinal();
                ActualizarTxtTotal();
                txtvalue.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un valor válido.");
            }
        }
    
        

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = DgLista.SelectedRows[0];
                string codigo = filaSeleccionada.Cells["ItemID"].Value.ToString();
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);

                // Busca el producto en el DgProduct por su código
                foreach (DataGridViewRow filaProducto in DgProduct.Rows)
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

        private void txtCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCustomer.SelectedIndex != -1)
            {
                // Obtener el valor del campo "ID" del elemento seleccionado
                string idValue = txtCustomer.SelectedValue.ToString();

                // Asignar el valor a txtIDcustomer
                TxtCustomerID.Text = idValue;
            }
            else
            {
                // Si no hay elemento seleccionado, puedes limpiar el TextBox
                TxtCustomerID.Clear();
            }
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txttotal.Text.Trim()) && !string.IsNullOrEmpty(txtbrand.Text.Trim()) && !string.IsNullOrEmpty(TxtCustomerID.Text.Trim()) &&
               !string.IsNullOrEmpty(TxtUSerID.Text.Trim()) && txttipo.SelectedIndex > -1)
            {
                MyMaintenance = new Logic.Models.Maintenance();
                MyMaintenance.MyCustomer.CustomerID = Convert.ToInt32(txtCustomer.SelectedValue);
                MyMaintenance.Myuser.UserID = Convert.ToInt32(TxtUSerID.Text.Trim());
                MyMaintenance.Total = Convert.ToDecimal(txttotal.Text.Trim());
                MyMaintenance.Date = Convert.ToDateTime(DtpFechaFactura.Text.Trim());
                MyMaintenance.MybiciType.BiciTypeID = Convert.ToInt32(txttipo.SelectedValue);
                MyMaintenance.Notas = Txtnotes.Text.Trim();
                MyMaintenance.Brand = txtbrand.Text.Trim();


                DialogResult answer = MessageBox.Show("¿Esta seguro de Crear este mantenimiento?", "???", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    foreach (var productoAgregado in productosAgregados)
                    {
                        int codigo = productoAgregado.Codigo;

                        int cantidad = productoAgregado.CantidadAgregada;

                       // Cambia este valor según tu lógica

                             MyItem.ItemID = codigo;
                            int stockActual = MyItem.ObtenerStock(MyItem.ItemID);
                            

                            int nuevoStock =   stockActual-cantidad; 
                            


                            MyItem.ActualizarStock(codigo, nuevoStock);
                         
                    }


                    foreach (DataGridViewRow fila in DgLista.Rows)
                    {
                        MaintenanceDetail newdetail = new MaintenanceDetail();
                        newdetail.Myitem = new Item();
                        if (fila.Cells["ItemID"].Value != null && fila.Cells["precioFinal"].Value != null && fila.Cells["Discount"].Value != null)
                        {
                            newdetail.Myitem.ItemID = Convert.ToInt32(fila.Cells["ItemID"].Value);
                            newdetail.UnitaryPrice = Convert.ToDecimal(fila.Cells["precioFinal"].Value);
                            newdetail.Discount = Convert.ToDecimal(fila.Cells["Discount"].Value);

                            MyMaintenance.productosAgregados.Add(newdetail);
                        }
                    }



                    if (MyMaintenance.Add())
                    {
                        MessageBox.Show("El Mantenimiento se creó correctamente", ":)", MessageBoxButtons.OK);

                        // Limpiar la lista de productos agregados
                        productosAgregados.Clear();












                        cleaner();
                        //crear factura mantenimiento 
                    }
                    else
                    {
                        MessageBox.Show("algo fallo", ":)", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show("El Mantenimiento no se realizo", ":)", MessageBoxButtons.OK);
                    DataGridViewRow filaSeleccionada = DgLista.SelectedRows[0];
                    string codigo = filaSeleccionada.Cells["ItemID"].Value.ToString();
                    int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);
                    foreach (DataGridViewRow filaProducto in DgProduct.Rows)
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

                    cleaner();
                }


            }
            else
            {
                MessageBox.Show("Faltan Datos , llenalos y vuelve a intentarlo");

            }
        }

        private void btnEliminarExtra_Click(object sender, EventArgs e)
        {
            if (valoresAdicionales.Count > 0)
            {
                // Resta el último valor adicional del total
                decimal valorEliminado = valoresAdicionales[valoresAdicionales.Count - 1];
                valoresAdicionales.RemoveAt(valoresAdicionales.Count - 1);
                ActualizarTxtValueFinal();

                // Calcula el nuevo total teniendo en cuenta los productos en DgLista
                decimal nuevoTotal = CalcularTotalConProductos();

                // Actualiza el campo de total
                txttotal.Text = nuevoTotal.ToString();
            }
            else
            {
                MessageBox.Show("No hay valores adicionales para eliminar.");
            }

        }
        private decimal CalcularTotalConProductos()
        {
            decimal total = 0;

            // Suma los valores de los productos en DgLista al total
            foreach (DataGridViewRow fila in DgLista.Rows)
            {
                if (fila.Cells["precioFinal"].Value != null)
                {
                    decimal valorProducto = decimal.Parse(fila.Cells["precioFinal"].Value.ToString());
                    total += valorProducto;
                }
            }

            return total;
        }

        private void TxtDescuento_ValueChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            if (DgLista.Rows.Count > 0)
            {
                foreach (DataGridViewRow filaLista in DgLista.Rows)
                {
                    int codigoProducto = Convert.ToInt32(filaLista.Cells["ItemID"].Value);
                    int cantidadSeleccionada = Convert.ToInt32(filaLista.Cells["Cantidad"].Value);

                    // Busca el producto en el DgProduct por su código
                    foreach (DataGridViewRow filaProducto in DgProduct.Rows)
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
                cleaner();
                 
                 

                // Recalcula el precio total
                ActualizarSubtotal();
            }
            else
            {
                MessageBox.Show("No hay productos en el mantenimiento para limpiar.");
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

}

