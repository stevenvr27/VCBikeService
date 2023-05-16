using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }

        public string SupplierCardID { get; set; }
        public string SupplierEmail { get; set; }

        public string SupplierAddress { get; set;}
        public string SupplierNotes { get; set; }

        public bool Active { get; set; }




    }
}
