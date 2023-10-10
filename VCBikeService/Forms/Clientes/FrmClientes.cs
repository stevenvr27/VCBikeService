using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace VCBikeService.Forms.Clientes
{
    public partial class FrmClientes : Form
    {
        private Logic.Models.Customer newcustomer { get; set; }
        private DataTable CustomerList { get; set; }

        public FrmClientes()
        {
          //  this.KeyPreview = true;
            InitializeComponent();
            CustomerList = new DataTable();
            newcustomer = new Logic.Models.Customer();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            LoadTypeCustomer();
            LoadListCustomer();
        }
        private void LoadListCustomer()

        {
            // trae la lista de los clientes y especificando si es de tipo activo o inactivo 

            CustomerList = new DataTable();

            string searchfilter = "";
            if (!string.IsNullOrEmpty(TxtSearchCustomer.Text.Trim()) && TxtSearchCustomer.Text.Count() >= 3)
            {

                searchfilter = TxtSearchCustomer.Text.Trim();
            }


            if (CheckCustomer.Checked)
            {

                CustomerList = newcustomer.ListCustomerActive(searchfilter);
            }
            else
            {
                CustomerList = newcustomer.ListCustomerInactive(searchfilter);
            }
            DgCustList.DataSource = CustomerList;
        }

        private void LoadTypeCustomer()
        {
            //trae la lista de los tipos de clientes que tenemos y llena el respectivo combo box 

            Logic.Models.CustomerType customerType = new Logic.Models.CustomerType();
            DataTable a = new DataTable();
            a = customerType.ListCustomerType();

            if (a != null && a.Rows.Count > 0)
            {
                CbTypeCustomer.ValueMember = "ID";
                CbTypeCustomer.DisplayMember = "Descrip";
                CbTypeCustomer.DataSource = a;
                CbTypeCustomer.SelectedIndex = -1;
            }
        }

        private void BtnCancelC_Click(object sender, EventArgs e)
        {
            //cierra el formulario 
            this.Hide();
        }



        private void CleanForm()
        {
            // codigo para limpiar cada campo o combo box del formulario 
            TxtCustomerAddress.Clear();
            TxtCustomerEmail.Clear();
            TxtCustomerID.Clear();
            TxtCustomerName.Clear();
            TxtPhonesCustomer.Clear();
            TxtSearchCustomer.Clear();
            
            CbTypeCustomer.SelectedIndex = -1;
        }



        private void DgCustList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //me permite llenar los campos respecivos para cada uno los atrbutos , si el usuario realiza click en algun cliente 
            if (DgCustList.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgCustList.SelectedRows[0];


                int IdCustomer = Convert.ToInt32(Mifila.Cells["CCustomerID"].Value);

                newcustomer = new Logic.Models.Customer();


                newcustomer.CustomerID = IdCustomer;



                newcustomer = newcustomer.SearchIDReturnCustumer();

                if (newcustomer != null && newcustomer.CustomerID > 0)
                {


                    TxtCustomerID.Text = Convert.ToString(newcustomer.CustomerID);

                    TxtCustomerEmail.Text = newcustomer.CustomerEmail;
                    TxtCustomerName.Text = newcustomer.CustomerName;

                    TxtPhonesCustomer.Text = Convert.ToString(newcustomer.CustomerPhone);

                    TxtCustomerAddress.Text = newcustomer.CustomerAdress;
                

                    //Combobox

                    CbTypeCustomer.SelectedValue = newcustomer.MyTypeCustomer.CustomerTypeID;


                }
            }
        }
         

        private void CheckCustomer_CheckedChanged(object sender, EventArgs e)
        {
            //llama a ciertas clases que dependen de si esta el check o no dentro del cuadro 
            LoadListCustomer();
             CleanForm();
        }

        private void BtnCleanC_Click(object sender, EventArgs e)
        {
            //boton que me limpia el formulario 
            CleanForm();
        }

        private void btnactivate_Click(object sender, EventArgs e)
        {
            // al seleccionar el boton me permita activar a un cliente inactivo
            if (!string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
               && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                DialogResult r = MessageBox.Show("¿Está seguro de Activar al Cliente ?",
                                                                    "???",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);

                if (r == DialogResult.Yes)
                {
                    if (newcustomer.Activate())
                    {
                        MessageBox.Show("El Cliente ha sido activado correctamente.", "!!!", MessageBoxButtons.OK);
                        CleanForm();
                        LoadListCustomer();
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente.", "!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnEditC_Click(object sender, EventArgs e)
        {      
           // boton al darle click me permite editar la informacion del cliente, respetando ciertos atributos 
               
            bool phoneok;

            if ( !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
              && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                newcustomer.CustomerName = TxtCustomerName.Text.Trim();
                newcustomer.CustomerPhone = Convert.ToInt32(TxtPhonesCustomer.Text.Trim());
                newcustomer.CustomerEmail = TxtCustomerEmail.Text.Trim();
                newcustomer.CustomerAdress = TxtCustomerAddress.Text.Trim();


              
                phoneok = newcustomer.ConsultPhone();

                newcustomer.MyTypeCustomer.CustomerTypeID = Convert.ToInt32(CbTypeCustomer.SelectedValue);

                if ( phoneok == true)
                {
                    DialogResult Answer = MessageBox.Show("¿Este u otro usuario tiene registrado este numero, aun deseas modificarlo?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (newcustomer.Update())
                        {
                            MessageBox.Show("El Cliente ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListCustomer();
                        }
                        else
                        {
                            MessageBox.Show("El Cliente no ha sido modificado correctamente", ":C", MessageBoxButtons.OK);
                            CleanForm();
                            LoadListCustomer();
                        }
                    }

                }
            
                else
                { DialogResult Answer = MessageBox.Show("¿Está seguro de modificar el Cliente?", "???",
                                                             MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (Answer == DialogResult.Yes)
                    {

                        if (newcustomer.Update())
                        {
                            MessageBox.Show("El Cliente ha sido modificado correctamente", ":)", MessageBoxButtons.OK);

                            CleanForm();
                            LoadListCustomer();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            //boton me permite agregar un nuevo cliente ,validando se llene la mayoria de informacion necesaria y si no alertando en diferentes escenarios 
            if (valedateinsertdates())
            {
                bool EmailOK;
                bool phoneok;



                newcustomer = new Logic.Models.Customer();

                newcustomer.CustomerName = TxtCustomerName.Text.Trim();
                newcustomer.CustomerPhone = Convert.ToInt32(TxtPhonesCustomer.Text.Trim()) ;
                newcustomer.CustomerEmail = TxtCustomerEmail.Text.Trim();
                newcustomer.CustomerAdress = TxtCustomerAddress.Text.Trim();


                newcustomer.MyTypeCustomer.CustomerTypeID = Convert.ToInt32(CbTypeCustomer.SelectedValue); ;



                EmailOK = newcustomer.ConsultEmail();
                phoneok= newcustomer.ConsultPhone();
                if (EmailOK == false && phoneok == false )
                {


                    string msg = string.Format("¿Está seguro que desea agregar al Cliente {0}?", newcustomer.CustomerName);

                    DialogResult respuesta = MessageBox.Show(msg, "???", MessageBoxButtons.YesNo);

                    if (respuesta == DialogResult.Yes)
                    {

                        bool ok = newcustomer.Add();

                        if (ok)
                        {
                            MessageBox.Show("Cliente guardado correctamente!", ":)", MessageBoxButtons.OK);

                            CleanForm();

                            LoadListCustomer();

                        }
                        else
                        {
                            MessageBox.Show("El proveedor no se pudo guardar!", ":/", MessageBoxButtons.OK);
                        }



                    }
                }
                else
                {
                    MessageBox.Show("Correo o  telefono ya existente", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                {
                    MessageBox.Show("Faltan Datos para Ingresar el Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtnDeleteC_Click(object sender, EventArgs e)
        {
            //me permite desactivar al cliente 
            if (!string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
             && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                if (newcustomer.CustomerID > 0 && newcustomer.ConsultPhone())
                {
                    if (CheckCustomer.Checked)
                    {

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Cliente?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (newcustomer.Delete())
                            {
                                MessageBox.Show("El Cliente ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                CleanForm();
                                LoadListCustomer();
                            }

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteForever_Click(object sender, EventArgs e)
        {
            //me permite eliminar por completo al cliente en la bd 
            if ( !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())
            && !string.IsNullOrEmpty(TxtCustomerName.Text.Trim()) && CbTypeCustomer.SelectedIndex > -1)
            {
                

                        DialogResult r = MessageBox.Show("¿Está seguro de Eliminar al Cliente?",
                                                         "???",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Question);

                        if (r == DialogResult.Yes)
                        {
                            if (newcustomer.DeleteForEver())
                            {
                                MessageBox.Show("El Cliente ha sido eliminado correctamente.", "!!!", MessageBoxButtons.OK);
                                
                            }
                                CleanForm();
                                LoadListCustomer();

                        }
                    
            }
            else
            {
                MessageBox.Show("Debes de seleccionar un Cliente", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtPhonesCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo deja incierta numeros en el campo del telefono del cliente 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }

        

        private bool valedateinsertdates()
        {
            // me permite validar datos insertados 
             bool R = false;
            if (!string.IsNullOrEmpty(TxtCustomerName.Text.Trim())    && 
                !string.IsNullOrEmpty(TxtPhonesCustomer.Text.Trim())  && CbTypeCustomer.SelectedIndex>-1)
            {
                R = true; 

            }
             
             
             return R;
        }

        private void FrmClientes_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
            {
                // Cierra el formulario si se presiona Escape
                this.Close();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                // Realiza el clic en el botón "add" si se presiona Enter
                BtnAddCustomer.PerformClick();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CheckCustomer_CheckedChanged_1(object sender, EventArgs e)
        {
            CleanForm();
            if (CheckCustomer.Checked)
            {
                BtnDeleteC.Visible = true;
                btnactivate.Visible = false;

            }
            else
            {
                BtnDeleteC.Visible= false;
                btnactivate.Visible = true;

            }
            LoadListCustomer();
        }

        private void DgCustList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (DgCustList.SelectedRows.Count == 1)
            {

                DataGridViewRow Mifila = DgCustList.SelectedRows[0];


                int IdCustomer = Convert.ToInt32(Mifila.Cells["CCustomerID"].Value);

                newcustomer = new Logic.Models.Customer();


                newcustomer.CustomerID = IdCustomer;



                newcustomer = newcustomer.SearchIDReturnCustumer();

                if (newcustomer != null && newcustomer.CustomerID > 0)
                {


                    TxtCustomerID.Text = Convert.ToString(newcustomer.CustomerID);

                    TxtCustomerEmail.Text = newcustomer.CustomerEmail;
                    TxtCustomerName.Text = newcustomer.CustomerName;

                    TxtPhonesCustomer.Text = Convert.ToString(newcustomer.CustomerPhone);

                    TxtCustomerAddress.Text = newcustomer.CustomerAdress;

                    //Combobox

                    CbTypeCustomer.SelectedValue = newcustomer.MyTypeCustomer.CustomerTypeID;


                }
            }
        }

        private void TxtPhonesCustomer_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // solo deja incierta numeros en el campo del telefono del cliente 
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Debes Digitar unicamente numeros.", "!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }
        }
    }
}
