using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class User
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public int UserID { get; set; }
        public int UserCardID { get; set; }

        public int PhoneNumber { get; set; }
        public string Address { get; set; }

        public bool Active { get; set; }

    }
}
