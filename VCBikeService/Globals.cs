using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService
{
    public static class Globals
    {
        public static Form Principal = new Forms.Central();

        public static Forms.Frmsupplier Frmsupplier = new Forms.Frmsupplier();
        public static Forms.Clientes.FrmClientes frmClientes = new Forms.Clientes.FrmClientes();
        public static Forms.FrmBillingSearch FrmBillingSearch = new Forms.FrmBillingSearch();
        public static Forms.FrmProductsAdd FrmProductsAdd = new Forms.FrmProductsAdd();
        public static Forms.Reportes.FrmSearchReport FrmSearchReport = new Forms.Reportes.FrmSearchReport();
        public static Forms.Nosotros.FrmWe FrmWe = new Forms.Nosotros.FrmWe();
        public static Forms.Reportes.FrmMont FrmMont = new Forms.Reportes.FrmMont();
        public static Forms.Reportes.FrmWeek FrmWeek = new Forms.Reportes.FrmWeek();
        public static Forms.Factura.FrmNewBilling FrmNewBilling = new Forms.Factura.FrmNewBilling();
        public static Forms.Factura.FrmEditBilling FrmEditBilling = new Forms.Factura.FrmEditBilling();
        public static Forms.Productos.FrmSearchProduct FrmSearchProduct = new Forms.Productos.FrmSearchProduct();
        public static Forms.FrmUsers FrmUsers = new Forms.FrmUsers();

        public static Logic.Models.User MyGlobalUser = new Logic.Models.User();




      
       
       
        


    }
}
