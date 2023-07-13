using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Billing
    { 
        public int BillingID { get; set; }
        public DateTime Date { get; set; }

        public Customer MyCustomer { get; set; }
        public Supplier MySupplier { get; set; }

        public Item myitem { get; set; }

        public User MyUser { get; set; }
        public BillingDetail MyBillingDetail { get; set; }    

        public List <BuyDetail> Details { get; set; }

        public Billing()
        {
            MyCustomer = new Customer();
            MyUser = new User();
            MySupplier = new Supplier();
            MyBillingDetail = new BillingDetail();  
            Details = new List<BuyDetail>();
            Date = DateTime.Now;
            myitem = new Item();

        }







    }
}
