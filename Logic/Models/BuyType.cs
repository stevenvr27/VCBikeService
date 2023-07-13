﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class BuyType
    {
        public int BuyTypeID { get; set; }
        public string Description { get; set; }

        public DataTable list()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPBuyTypeList");
            return R;
        }

    }
}
