﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public  class Ubication
    {
        public int UbicationID { get; set; }    
        public string Description { get; set; }

        public DataTable List()
        {
            DataTable R = new DataTable();
            Services.Connection connection = new Services.Connection();
            R = connection.EjecutarSELECT("SPUbicationList");
            return R;
        }
    }
}
