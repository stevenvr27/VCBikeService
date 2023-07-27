namespace VCBikeService.Forms.Compra
{
    partial class FrmSupplyAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearchSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxAgregarMasCantidad = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtIVA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDescuento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.61224F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.38776F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1087, 777);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSearchSupplier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 39);
            this.panel1.TabIndex = 0;
            // 
            // TxtSearchSupplier
            // 
            this.TxtSearchSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchSupplier.Location = new System.Drawing.Point(260, 9);
            this.TxtSearchSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchSupplier.Name = "TxtSearchSupplier";
            this.TxtSearchSupplier.Size = new System.Drawing.Size(663, 20);
            this.TxtSearchSupplier.TabIndex = 3;
            this.TxtSearchSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 381);
            this.panel2.TabIndex = 1;
            // 
            // DgProduct
            // 
            this.DgProduct.AllowUserToAddRows = false;
            this.DgProduct.AllowUserToDeleteRows = false;
            this.DgProduct.AllowUserToOrderColumns = true;
            this.DgProduct.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemID,
            this.CItemName,
            this.CBarcode,
            this.CStock,
            this.CUnitaryCost});
            this.DgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgProduct.Location = new System.Drawing.Point(0, 0);
            this.DgProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgProduct.MultiSelect = false;
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersVisible = false;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 28;
            this.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProduct.Size = new System.Drawing.Size(1081, 381);
            this.DgProduct.TabIndex = 7;
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Cod.Item";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 200;
            // 
            // CItemName
            // 
            this.CItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre";
            this.CItemName.MinimumWidth = 200;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            // 
            // CBarcode
            // 
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Cod.Barras";
            this.CBarcode.MinimumWidth = 120;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            this.CBarcode.Width = 120;
            // 
            // CStock
            // 
            this.CStock.DataPropertyName = "Stock";
            this.CStock.HeaderText = "Stock";
            this.CStock.MinimumWidth = 6;
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Width = 210;
            // 
            // CUnitaryCost
            // 
            this.CUnitaryCost.DataPropertyName = "UnitaryCost";
            this.CUnitaryCost.HeaderText = "Precio";
            this.CUnitaryCost.MinimumWidth = 6;
            this.CUnitaryCost.Name = "CUnitaryCost";
            this.CUnitaryCost.ReadOnly = true;
            this.CUnitaryCost.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 435);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 250);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAgregarMasCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtPrecioFinal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtIVA);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtPrecioUnitario);
            this.groupBox1.Controls.Add(this.TxtDescuento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1074, 246);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Productos";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCancelar);
            this.panel4.Controls.Add(this.BtnSeleccionar);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 691);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 83);
            this.panel4.TabIndex = 3;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(67, 13);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(157, 59);
            this.BtnCancelar.TabIndex = 11;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(800, 13);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(201, 56);
            this.BtnSeleccionar.TabIndex = 10;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(406, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar nuevo Item";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxAgregarMasCantidad
            // 
            this.checkBoxAgregarMasCantidad.AutoSize = true;
            this.checkBoxAgregarMasCantidad.Location = new System.Drawing.Point(26, 177);
            this.checkBoxAgregarMasCantidad.Name = "checkBoxAgregarMasCantidad";
            this.checkBoxAgregarMasCantidad.Size = new System.Drawing.Size(430, 29);
            this.checkBoxAgregarMasCantidad.TabIndex = 22;
            this.checkBoxAgregarMasCantidad.Text = "Sumar Cantidad si producto ya está en la lista";
            this.checkBoxAgregarMasCantidad.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(861, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Precio Final";
            // 
            // TxtPrecioFinal
            // 
            this.TxtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioFinal.Location = new System.Drawing.Point(866, 91);
            this.TxtPrecioFinal.Name = "TxtPrecioFinal";
            this.TxtPrecioFinal.ReadOnly = true;
            this.TxtPrecioFinal.Size = new System.Drawing.Size(95, 30);
            this.TxtPrecioFinal.TabIndex = 20;
            this.TxtPrecioFinal.Text = "0";
            this.TxtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(662, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "% IVA";
            // 
            // TxtIVA
            // 
            this.TxtIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIVA.Location = new System.Drawing.Point(667, 91);
            this.TxtIVA.Name = "TxtIVA";
            this.TxtIVA.ReadOnly = true;
            this.TxtIVA.Size = new System.Drawing.Size(80, 30);
            this.TxtIVA.TabIndex = 18;
            this.TxtIVA.Text = "0";
            this.TxtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio Unitario";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(476, 88);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.ReadOnly = true;
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(95, 30);
            this.TxtPrecioUnitario.TabIndex = 16;
            this.TxtPrecioUnitario.Text = "0";
            this.TxtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(91, 80);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(84, 41);
            this.TxtCantidad.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(270, 88);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(80, 30);
            this.TxtDescuento.TabIndex = 15;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "% Descuento";
            // 
            // FrmSupplyAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 781);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSupplyAddProduct";
            this.Text = "FrmSupplyAddProduct";
            this.Load += new System.EventHandler(this.FrmSupplyAddProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.DataGridView DgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.CheckBox checkBoxAgregarMasCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecioFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtIVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDescuento;
        private System.Windows.Forms.Label label2;
    }
}