using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class BillingDetail
    {
        public decimal Amount { get; set; }
        public decimal Price  { get; set; }

        public  MethodPayment MethodPayment { get; set; }
    }
}
