﻿using Logic.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VCBikeService.Forms.Nosotros;
using VCBikeService.Forms.Productos;
using VCBikeService.Forms.Reportes;

namespace VCBikeService.Forms
{
    public partial class Central : Form
    {
        public Central()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!Globals.FrmUsers.Visible)
            {
                Globals.FrmUsers = new FrmUsers();
                Globals.FrmUsers.Show();
            }
        }

        //private void Central_Load(object sender, EventArgs e)
        //{
        //    string InfoUsuario = string.Format("{0}-{1}({2})",
        //                                        Globals.MyGlobalUser.UserName,
        //                                        Globals.MyGlobalUser.Email,
        //                                        Globals.MyGlobalUser.MyRol.Description);


                     

        private void Central_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

       

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        

        private void nosotrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmCompra.Visible)
            {
                Globals.FrmCompra = new Compra.FrmBuy();
                Globals.FrmCompra.Show();
            }
        }

       

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct= new FrmSearchProduct();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void semanalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmWeek.Visible)
            {
                Globals.FrmWeek = new FrmWeek();
                Globals.FrmWeek.Show();
            }
        }

        private void mensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmMont.Visible)
            {
                Globals.FrmMont = new FrmMont();
                Globals.FrmMont.Show();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmBillingSearch.Visible)
            {
                Globals.FrmBillingSearch = new FrmBillingSearch();
                Globals.FrmBillingSearch.Show();
            }
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmCompra.Visible)
            {
                Globals.FrmCompra = new Compra.FrmBuy();
                Globals.FrmCompra.Show();
            }
        }

        private void modificarOEliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmEditBilling.Visible)
            {
                Globals.FrmEditBilling = new Factura.FrmEditBilling();
                Globals.FrmEditBilling.Show();
            }
        }

        

        private void Central_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToString("hh:mm:ss");
            Fecha.Text = DateTime.Now.ToLongDateString();
        }

             

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmCompra.Visible)
            {
                Globals.FrmCompra = new Compra.FrmBuy();
                Globals.FrmCompra.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
             if (!Globals.FrmNewBilling.Visible)
            {
                Globals.FrmNewBilling = new Factura.FrmNewBilling();
                Globals.FrmNewBilling.Show();
            }
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchReport.Visible)
            {
                Globals.FrmSearchReport = new FrmSearchReport();
                Globals.FrmSearchReport.Show();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                if (!Globals.frmClientes.Visible)
                {
                    Globals.frmClientes = new Clientes.FrmClientes();
                    Globals.frmClientes.Show();
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Globals.frmClientes.Visible)
            {
                Globals.frmClientes = new Clientes.FrmClientes();
                Globals.frmClientes.Show();
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void nosotrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmWe.Visible)
            {
                Globals.FrmWe = new FrmWe();
                Globals.FrmWe.Show();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!Globals.frmClientes.Visible)
            {
                Globals.frmClientes = new Clientes.FrmClientes();
                Globals.frmClientes.Show();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmNewBilling.Visible)
            {
                Globals.FrmNewBilling = new Factura.FrmNewBilling();
                Globals.FrmNewBilling.Show();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchReport.Visible)
            {
                Globals.FrmSearchReport = new FrmSearchReport();
                Globals.FrmSearchReport.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!Globals.MyUser.Visible)
            {
                Globals.MyUser = new Usuario.FrmMyUser();
                Globals.MyUser.Show();  
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmCompra.Visible)
            {
                Globals.FrmCompra = new Compra.FrmBuy();
                Globals.FrmCompra.Show();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!Globals.frmSupplierBuy.Visible)
            {
                Globals.frmSupplierBuy = new Compra.FrmSupplierBuy();
                Globals.frmSupplierBuy.Show();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmSearchProduct.Visible)
            {
                Globals.FrmSearchProduct = new Productos.FrmSearchProduct();
                Globals.FrmSearchProduct.Show();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!Globals.FrmProductsAdd.Visible)
            {
                Globals.FrmProductsAdd = new FrmProductsAdd();
                Globals.FrmProductsAdd.Show();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!Globals.MyUser.Visible)
            {
                Globals.MyUser = new Usuario.FrmMyUser();
                Globals.MyUser.Show();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!Globals.Frmsupplier.Visible)
            {
                Globals.Frmsupplier = new Frmsupplier();
                Globals.Frmsupplier.Show();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!Globals.frmSupplierBuy.Visible)
            {
                Globals.frmSupplierBuy = new Compra.FrmSupplierBuy();
                Globals.frmSupplierBuy.Show();
            }
        }
    }
    }

