﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VCBikeService.Forms.Reportes
{
    public partial class FrmReportBilling : Form
    {
        

        public FrmReportBilling()
        {
            InitializeComponent();
        }

        private void FrmReportBilling_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }
    }
}
