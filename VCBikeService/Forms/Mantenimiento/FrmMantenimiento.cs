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

        private List<ProductoAgregado> productosAgregados = new List<ProductoAgregado>();


        public FrmMantenimiento()
        {
            InitializeComponent();
            ListItem = new DataTable();
            MyItem = new Item();
            MyMaintenance = new Maintenance();
            MyUser = new User();
            MyCustomer = new Customer();
            
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
                    TxtPrecioUnitario.Text = Convert.ToString(MyItem.SellPrice);





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
            int stock = Convert.ToInt32(TxtCantidad.Value);
            decimal valorUnitario;

            if (decimal.TryParse(TxtPrecioUnitario.Text.Trim(), out valorUnitario))
            {
                decimal total = valorUnitario * stock;
                TxtPrecioFinal.Text = total.ToString();
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
                    

                        if (DgProduct.SelectedRows.Count > 0)
                        {
                            if (int.TryParse(TxtCantidad.Text, out int cantidadIngresada))
                            {
                                foreach (DataGridViewRow filaSeleccionada in DgProduct.SelectedRows)
                                {
                                    int stockProducto = Convert.ToInt32(filaSeleccionada.Cells["CStock"].Value); // Obtiene el stock actual del producto

                                    string nombre = filaSeleccionada.Cells["CItemName"].Value.ToString();
                                    int codigo = Convert.ToInt32( filaSeleccionada.Cells["CItemID"].Value.ToString());

                                    // Verificar si hay suficiente stock para restar

                                    if (stockProducto >= cantidadIngresada)
                                    {
                                        // Restar la cantidad ingresada del stock actual del producto
                                        stockProducto -= cantidadIngresada;

                                        // Actualizar el valor en la columna "CStock" del DataGridView DgProduct
                                        filaSeleccionada.Cells["CStock"].Value = stockProducto;

                                        // Crear una nueva fila en DgLista con los valores obtenidos
                                        DgLista.Rows.Add(nombre, codigo, cantidadIngresada, precioIngresado);

                                        // Agregar el producto a la lista de productos agregados
                                        productosAgregados.Add(new ProductoAgregado { Codigo=codigo , CantidadAgregada = cantidadIngresada });

                                        TxtPrecioUnitario.Clear();
                                        TxtPrecioFinal.Clear();
                                        ActualizarSubtotal();
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
                                MessageBox.Show("Por favor, ingrese una cantidad válida.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor, seleccione un producto y una cantidad m .");
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un precio válido.");
                }
            
             



        }
       



        private void cleaner(){
            txtCustomer.SelectedIndex = -1;
            TxtCustomerID.Clear();
            txtbrand.Clear();
            txttipo.SelectedIndex = -1;
            txtvalue.Clear();
            Txtnotes.Clear(); 
            TxtCantidad.Value = 0;
            TxtDescuento.Clear();
            TxtPrecioFinal.Clear();
            TxtPrecioUnitario.Clear();
            txttotal.Clear();
            DtpFechaFactura.Value = DateTime.Now;
         
            DgLista.Rows.Clear();
            

        }

        

        private void BtnClean_Click(object sender, EventArgs e)
        {
            cleaner();
        }

 

        private void buttonaddvalue_Click_1(object sender, EventArgs e)
        {
            // Obtener el valor del TextBox txtValue
            string inputValue = txtvalue.Text;

            // Verificar si el valor es un número válido (entero o decimal)
            if (decimal.TryParse(inputValue, out decimal valueToAdd))
            {
                // Agregar el valor como una nueva fila al DataGridView
                DgLista.Rows.Add("Extras",0,1, valueToAdd);
                ActualizarSubtotal();

                // Limpiar el contenido del TextBox
                txtvalue.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido.");
            }
        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            if (DgLista.SelectedRows.Count == 1)
            {
                DataGridViewRow filaSeleccionada = DgLista.SelectedRows[0];
                string codigo = filaSeleccionada.Cells["ItemName"].Value.ToString();
                int cantidad = Convert.ToInt32(filaSeleccionada.Cells["Cantidad"].Value);

                foreach (DataGridViewRow filaProducto in DgProduct.Rows)
                {
                    if (filaProducto.Cells["CItemID"].Value.ToString() == codigo)
                    {
                        int stockProducto = Convert.ToInt32(filaProducto.Cells["CStock"].Value);
                        stockProducto += cantidad;
                        filaProducto.Cells["CStock"].Value = stockProducto;
                        break; // Salir del bucle una vez que se haya encontrado el producto.
                    }
                }

                 
                DgLista.Rows.Remove(filaSeleccionada);

                // Recalcular el precio total
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
                    cleaner();
                }


            }
            else
            {
                MessageBox.Show("Faltan Datos , llenalos y vuelve a intentarlo");

            }
        }
    }

}

