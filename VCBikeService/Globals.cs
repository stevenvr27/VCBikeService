using Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Origen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        private static Crypto crypto = new Crypto();

        public static FrmRecoveryPassword recuperar = new FrmRecoveryPassword(crypto);


    

        public static Forms.Compra.FrmSupplyerSearch FrmSupplyerSearch = new Forms.Compra.FrmSupplyerSearch();
        public static Forms.Compra.FrmSupplyAddProduct FrmSupplyAddProduct = new Forms.Compra.FrmSupplyAddProduct();
        public static Forms.Compra.FrmSupplierBuy frmSupplierBuy = new Forms.Compra.FrmSupplierBuy();
        public static Forms.Productos.FrmSearchProduct FrmSearchProduct = new Forms.Productos.FrmSearchProduct();
        public static Forms.Compra.FrmSearchCustomer CustomerSearch = new Forms.Compra.FrmSearchCustomer();
        public static Forms.Frmsupplier Frmsupplier = new Forms.Frmsupplier();
        public static Forms.Compra.FrmBuy Frmfactura = new Forms.Compra.FrmBuy();
        public static Forms.Compra.FrmAddSearchProduct FrmAddSearchProduct = new Forms.Compra.FrmAddSearchProduct();
        public static Forms.Clientes.FrmClientes frmClientes = new Forms.Clientes.FrmClientes();
        public static Forms.FrmProductsAdd FrmProductsAdd = new Forms.FrmProductsAdd();
        public static Forms.Reportes.FrmSearchReport FrmSearchReport = new Forms.Reportes.FrmSearchReport();
        public static Forms.Nosotros.FrmWe FrmWe = new Forms.Nosotros.FrmWe();
        public static Forms.Reportes.FrmReportBilling FrmReportBilling = new Forms.Reportes.FrmReportBilling();
        public static Forms.Reportes.FrmWeek FrmWeek = new Forms.Reportes.FrmWeek();
        public static Forms.Factura.FrmNewBilling FrmNewBilling = new Forms.Factura.FrmNewBilling();

        public static Forms.FrmUsers FrmUsers = new Forms.FrmUsers();

        public static Logic.Models.User MyGlobalUser = new Logic.Models.User();










    }
}
