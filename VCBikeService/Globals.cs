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
        public static Forms.FrmCustomer FrmCustomer = new Forms.FrmCustomer();
        public static Forms.FrmBillingSearch FrmBillingSearch = new Forms.FrmBillingSearch();
        public static Forms.FrmProductsAdd FrmProductsAdd = new Forms.FrmProductsAdd();

        public static Forms.FrmUsers FrmUsers = new Forms.FrmUsers();

        public static Logic.Models.User MyGlobalUser = new Logic.Models.User();




      
       
       
        


    }
}
