using Logic;
using System.Data;
using System.Windows.Forms;
 

namespace VCBikeService
{
    public static class Globals
    {
        public static Form Principal = new Forms.Central();
        public static Forms.Compra.FrmEditBuyItem GetFrmEditBuyItem(DataTable localdetailist, int cantidadActual)
        {
            // Crear una nueva instancia del formulario de edición y pasar el DataTable y la cantidad actual
            Forms.Compra.FrmEditBuyItem frmEditBuyItem = new Forms.Compra.FrmEditBuyItem(localdetailist, cantidadActual);

            return frmEditBuyItem;
        }


        // formularios y sus distitos nombres para poder ser ejecutados 
        public static Forms.FrmLogin login = new Forms.FrmLogin();

        public static Forms.Compra.FrmBuysearch FrmBuysearch = new Forms.Compra.FrmBuysearch();
        public static Forms.Mantenimiento.FrmMantenimiento FrmMantenimiento = new Forms.Mantenimiento.FrmMantenimiento();
        public static Forms.Productos.FrmBuyItem FrmSearchProduct = new Forms.Productos.FrmBuyItem();
        public static Forms.Compra.FrmSearchCustomer CustomerSearch = new Forms.Compra.FrmSearchCustomer();
        public static Forms.Frmsupplier Frmsupplier = new Forms.Frmsupplier();
        public static Forms.Compra.FrmFacturar Frmfactura = new Forms.Compra.FrmFacturar();
        public static Forms.Compra.FrmAddSearchProduct FrmAddSearchProduct = new Forms.Compra.FrmAddSearchProduct();
        public static Forms.Clientes.FrmClientes frmClientes = new Forms.Clientes.FrmClientes();
        public static Forms.FrmProductsAdd FrmProductsAdd = new Forms.FrmProductsAdd();
        public static Forms.Nosotros.FrmWe FrmWe = new Forms.Nosotros.FrmWe();
        public static Forms.Factura.FrmNewBilling FrmNewBilling = new Forms.Factura.FrmNewBilling();
        public static Forms.FrmUsers FrmUsers = new Forms.FrmUsers();
        public static Logic.Models.User MyGlobalUser = new Logic.Models.User();
        public static Reportiador repor = new Reportiador();
         
    }
}
