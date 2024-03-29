﻿namespace VCBikeService.Forms
{
    partial class FrmProductsAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductsAdd));
            this.TxtSearchItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnDeleteForEver = new System.Windows.Forms.Button();
            this.BtnCancelproduct = new System.Windows.Forms.Button();
            this.BtnAddproduct = new System.Windows.Forms.Button();
            this.BtnCleanproduct = new System.Windows.Forms.Button();
            this.BtnEditproduct = new System.Windows.Forms.Button();
            this.BtnDeleteproduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtStock = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txt140 = new System.Windows.Forms.RadioButton();
            this.txt120 = new System.Windows.Forms.RadioButton();
            this.txt100 = new System.Windows.Forms.RadioButton();
            this.txt80 = new System.Windows.Forms.RadioButton();
            this.txt60 = new System.Windows.Forms.RadioButton();
            this.txt40 = new System.Windows.Forms.RadioButton();
            this.txt20 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.cbtax = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.TxtUnitaryCost = new System.Windows.Forms.TextBox();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtIDProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkProduct = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchItem.Location = new System.Drawing.Point(420, 2);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(791, 22);
            this.TxtSearchItem.TabIndex = 3;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
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
            this.CUnitaryCost,
            this.CSellPrice,
            this.Cdes,
            this.CDescription});
            this.DgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgProduct.Location = new System.Drawing.Point(5, 43);
            this.DgProduct.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgProduct.MultiSelect = false;
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersVisible = false;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 28;
            this.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProduct.Size = new System.Drawing.Size(1590, 248);
            this.DgProduct.TabIndex = 6;
            this.DgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSupplier_CellClick);
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
            this.CStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CStock.DataPropertyName = "Stock";
            this.CStock.HeaderText = "Stock";
            this.CStock.MinimumWidth = 6;
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            // 
            // CUnitaryCost
            // 
            this.CUnitaryCost.DataPropertyName = "UnitaryCost";
            this.CUnitaryCost.HeaderText = "Precio Costo";
            this.CUnitaryCost.MinimumWidth = 6;
            this.CUnitaryCost.Name = "CUnitaryCost";
            this.CUnitaryCost.ReadOnly = true;
            this.CUnitaryCost.Width = 150;
            // 
            // CSellPrice
            // 
            this.CSellPrice.DataPropertyName = "SellPrice";
            this.CSellPrice.HeaderText = "Precio Sin impuesto";
            this.CSellPrice.MinimumWidth = 6;
            this.CSellPrice.Name = "CSellPrice";
            this.CSellPrice.ReadOnly = true;
            this.CSellPrice.Width = 125;
            // 
            // Cdes
            // 
            this.Cdes.DataPropertyName = "des";
            this.Cdes.HeaderText = "Ubicacion";
            this.Cdes.MinimumWidth = 6;
            this.Cdes.Name = "Cdes";
            this.Cdes.ReadOnly = true;
            this.Cdes.Width = 130;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Descripcion";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 125;
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(51, 433);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(227, 66);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // BtnDeleteForEver
            // 
            this.BtnDeleteForEver.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteForEver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteForEver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteForEver.Location = new System.Drawing.Point(643, 433);
            this.BtnDeleteForEver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteForEver.Name = "BtnDeleteForEver";
            this.BtnDeleteForEver.Size = new System.Drawing.Size(227, 66);
            this.BtnDeleteForEver.TabIndex = 14;
            this.BtnDeleteForEver.Text = "Eliminar";
            this.BtnDeleteForEver.UseVisualStyleBackColor = false;
            this.BtnDeleteForEver.Visible = false;
            this.BtnDeleteForEver.Click += new System.EventHandler(this.BtnDeleteForEver_Click);
            // 
            // BtnCancelproduct
            // 
            this.BtnCancelproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelproduct.Location = new System.Drawing.Point(1305, 455);
            this.BtnCancelproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelproduct.Name = "BtnCancelproduct";
            this.BtnCancelproduct.Size = new System.Drawing.Size(227, 66);
            this.BtnCancelproduct.TabIndex = 13;
            this.BtnCancelproduct.Text = "Cancel";
            this.BtnCancelproduct.UseVisualStyleBackColor = false;
            this.BtnCancelproduct.Click += new System.EventHandler(this.BtnCancelproduct_Click);
            // 
            // BtnAddproduct
            // 
            this.BtnAddproduct.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddproduct.Location = new System.Drawing.Point(51, 433);
            this.BtnAddproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddproduct.Name = "BtnAddproduct";
            this.BtnAddproduct.Size = new System.Drawing.Size(227, 66);
            this.BtnAddproduct.TabIndex = 9;
            this.BtnAddproduct.Text = "Agregar";
            this.BtnAddproduct.UseVisualStyleBackColor = false;
            this.BtnAddproduct.Click += new System.EventHandler(this.BtnAddproduct_Click);
            // 
            // BtnCleanproduct
            // 
            this.BtnCleanproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCleanproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCleanproduct.Location = new System.Drawing.Point(638, 433);
            this.BtnCleanproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCleanproduct.Name = "BtnCleanproduct";
            this.BtnCleanproduct.Size = new System.Drawing.Size(227, 66);
            this.BtnCleanproduct.TabIndex = 12;
            this.BtnCleanproduct.Text = "Limpiar";
            this.BtnCleanproduct.UseVisualStyleBackColor = false;
            this.BtnCleanproduct.Click += new System.EventHandler(this.BtnCleanproduct_Click);
            // 
            // BtnEditproduct
            // 
            this.BtnEditproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditproduct.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEditproduct.Location = new System.Drawing.Point(347, 433);
            this.BtnEditproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEditproduct.Name = "BtnEditproduct";
            this.BtnEditproduct.Size = new System.Drawing.Size(227, 66);
            this.BtnEditproduct.TabIndex = 10;
            this.BtnEditproduct.Text = "Modificar";
            this.BtnEditproduct.UseVisualStyleBackColor = false;
            this.BtnEditproduct.Click += new System.EventHandler(this.BtnEditproduct_Click);
            // 
            // BtnDeleteproduct
            // 
            this.BtnDeleteproduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteproduct.Location = new System.Drawing.Point(965, 433);
            this.BtnDeleteproduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteproduct.Name = "BtnDeleteproduct";
            this.BtnDeleteproduct.Size = new System.Drawing.Size(227, 66);
            this.BtnDeleteproduct.TabIndex = 11;
            this.BtnDeleteproduct.Text = "Eliminar";
            this.BtnDeleteproduct.UseVisualStyleBackColor = false;
            this.BtnDeleteproduct.Click += new System.EventHandler(this.BtnDeleteproduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAddproduct);
            this.groupBox1.Controls.Add(this.btnactivate);
            this.groupBox1.Controls.Add(this.TxtStock);
            this.groupBox1.Controls.Add(this.BtnEditproduct);
            this.groupBox1.Controls.Add(this.BtnCancelproduct);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtnDeleteproduct);
            this.groupBox1.Controls.Add(this.txtFinalPrice);
            this.groupBox1.Controls.Add(this.BtnDeleteForEver);
            this.groupBox1.Controls.Add(this.BtnCleanproduct);
            this.groupBox1.Controls.Add(this.txt140);
            this.groupBox1.Controls.Add(this.txt120);
            this.groupBox1.Controls.Add(this.txt100);
            this.groupBox1.Controls.Add(this.txt80);
            this.groupBox1.Controls.Add(this.txt60);
            this.groupBox1.Controls.Add(this.txt40);
            this.groupBox1.Controls.Add(this.txt20);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.cbtax);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.CbCategory);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.TxtSellPrice);
            this.groupBox1.Controls.Add(this.TxtUnitaryCost);
            this.groupBox1.Controls.Add(this.TxtBarcode);
            this.groupBox1.Controls.Add(this.TxtProductName);
            this.groupBox1.Controls.Add(this.TxtIDProduct);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1553, 529);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Productos";
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(759, 212);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(4);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(132, 41);
            this.TxtStock.TabIndex = 36;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(556, 330);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(161, 30);
            this.textBox1.TabIndex = 35;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(730, 377);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 29);
            this.label11.TabIndex = 34;
            this.label11.Text = "Precio de Venta:";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.BackColor = System.Drawing.Color.YellowGreen;
            this.txtFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalPrice.Location = new System.Drawing.Point(1014, 377);
            this.txtFinalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(471, 45);
            this.txtFinalPrice.TabIndex = 33;
            // 
            // txt140
            // 
            this.txt140.AutoSize = true;
            this.txt140.Location = new System.Drawing.Point(1238, 137);
            this.txt140.Margin = new System.Windows.Forms.Padding(4);
            this.txt140.Name = "txt140";
            this.txt140.Size = new System.Drawing.Size(84, 29);
            this.txt140.TabIndex = 32;
            this.txt140.TabStop = true;
            this.txt140.Text = "140%";
            this.txt140.UseVisualStyleBackColor = true;
            this.txt140.CheckedChanged += new System.EventHandler(this.txt140_CheckedChanged);
            // 
            // txt120
            // 
            this.txt120.AutoSize = true;
            this.txt120.Location = new System.Drawing.Point(1134, 137);
            this.txt120.Margin = new System.Windows.Forms.Padding(4);
            this.txt120.Name = "txt120";
            this.txt120.Size = new System.Drawing.Size(84, 29);
            this.txt120.TabIndex = 31;
            this.txt120.TabStop = true;
            this.txt120.Text = "120%";
            this.txt120.UseVisualStyleBackColor = true;
            this.txt120.CheckedChanged += new System.EventHandler(this.txt120_CheckedChanged);
            // 
            // txt100
            // 
            this.txt100.AutoSize = true;
            this.txt100.Location = new System.Drawing.Point(1046, 137);
            this.txt100.Margin = new System.Windows.Forms.Padding(4);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(84, 29);
            this.txt100.TabIndex = 30;
            this.txt100.TabStop = true;
            this.txt100.Text = "100%";
            this.txt100.UseVisualStyleBackColor = true;
            this.txt100.CheckedChanged += new System.EventHandler(this.txt100_CheckedChanged);
            // 
            // txt80
            // 
            this.txt80.AutoSize = true;
            this.txt80.Location = new System.Drawing.Point(931, 137);
            this.txt80.Margin = new System.Windows.Forms.Padding(4);
            this.txt80.Name = "txt80";
            this.txt80.Size = new System.Drawing.Size(73, 29);
            this.txt80.TabIndex = 29;
            this.txt80.TabStop = true;
            this.txt80.Text = "80%";
            this.txt80.UseVisualStyleBackColor = true;
            this.txt80.CheckedChanged += new System.EventHandler(this.txt80_CheckedChanged);
            // 
            // txt60
            // 
            this.txt60.AutoSize = true;
            this.txt60.Location = new System.Drawing.Point(830, 137);
            this.txt60.Margin = new System.Windows.Forms.Padding(4);
            this.txt60.Name = "txt60";
            this.txt60.Size = new System.Drawing.Size(73, 29);
            this.txt60.TabIndex = 28;
            this.txt60.TabStop = true;
            this.txt60.Text = "60%";
            this.txt60.UseVisualStyleBackColor = true;
            this.txt60.CheckedChanged += new System.EventHandler(this.txt60_CheckedChanged);
            // 
            // txt40
            // 
            this.txt40.AutoSize = true;
            this.txt40.Location = new System.Drawing.Point(735, 137);
            this.txt40.Margin = new System.Windows.Forms.Padding(4);
            this.txt40.Name = "txt40";
            this.txt40.Size = new System.Drawing.Size(73, 29);
            this.txt40.TabIndex = 27;
            this.txt40.TabStop = true;
            this.txt40.Text = "40%";
            this.txt40.UseVisualStyleBackColor = true;
            this.txt40.CheckedChanged += new System.EventHandler(this.txt40_CheckedChanged);
            // 
            // txt20
            // 
            this.txt20.AutoSize = true;
            this.txt20.Location = new System.Drawing.Point(643, 137);
            this.txt20.Margin = new System.Windows.Forms.Padding(4);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(73, 29);
            this.txt20.TabIndex = 26;
            this.txt20.TabStop = true;
            this.txt20.Text = "20%";
            this.txt20.UseVisualStyleBackColor = true;
            this.txt20.CheckedChanged += new System.EventHandler(this.txt20_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 268);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 25);
            this.label10.TabIndex = 25;
            this.label10.Text = "Unidad.Medida:";
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(239, 260);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(346, 33);
            this.cbUnit.TabIndex = 24;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(36, 335);
            this.label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 25);
            this.label.TabIndex = 23;
            this.label.Text = "Impuesto:";
            // 
            // cbtax
            // 
            this.cbtax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtax.FormattingEnabled = true;
            this.cbtax.Location = new System.Drawing.Point(207, 332);
            this.cbtax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbtax.Name = "cbtax";
            this.cbtax.Size = new System.Drawing.Size(288, 33);
            this.cbtax.TabIndex = 22;
            this.cbtax.SelectedIndexChanged += new System.EventHandler(this.cbtax_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(649, 212);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Stock:";
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(239, 212);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(346, 33);
            this.CbCategory.TabIndex = 19;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(965, 260);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(567, 79);
            this.TxtDescription.TabIndex = 14;
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(938, 79);
            this.TxtSellPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(455, 30);
            this.TxtSellPrice.TabIndex = 13;
            this.TxtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSellPrice_KeyPress);
            // 
            // TxtUnitaryCost
            // 
            this.TxtUnitaryCost.Location = new System.Drawing.Point(869, 38);
            this.TxtUnitaryCost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUnitaryCost.Name = "TxtUnitaryCost";
            this.TxtUnitaryCost.Size = new System.Drawing.Size(410, 30);
            this.TxtUnitaryCost.TabIndex = 12;
            this.TxtUnitaryCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnitaryCost_KeyPress);
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Location = new System.Drawing.Point(239, 161);
            this.TxtBarcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(335, 30);
            this.TxtBarcode.TabIndex = 11;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(163, 103);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtProductName.MaximumSize = new System.Drawing.Size(400, 22);
            this.TxtProductName.MinimumSize = new System.Drawing.Size(391, 22);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(400, 28);
            this.TxtProductName.TabIndex = 10;
            // 
            // TxtIDProduct
            // 
            this.TxtIDProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtIDProduct.Location = new System.Drawing.Point(153, 34);
            this.TxtIDProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIDProduct.Name = "TxtIDProduct";
            this.TxtIDProduct.ReadOnly = true;
            this.TxtIDProduct.Size = new System.Drawing.Size(149, 30);
            this.TxtIDProduct.TabIndex = 9;
            this.TxtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 220);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(975, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(636, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de venta sin impuesto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo de barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // checkProduct
            // 
            this.checkProduct.AutoSize = true;
            this.checkProduct.Checked = true;
            this.checkProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProduct.Location = new System.Drawing.Point(1219, 2);
            this.checkProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(81, 26);
            this.checkProduct.TabIndex = 16;
            this.checkProduct.Text = "Activo";
            this.checkProduct.UseVisualStyleBackColor = true;
            this.checkProduct.CheckedChanged += new System.EventHandler(this.checkProduct_CheckedChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(1600, 1020);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(1600, 1020);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.28125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.71875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 676F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1600, 1020);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkProduct);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1594, 35);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 297);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1594, 672);
            this.panel2.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1598, 837);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // FrmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1598, 837);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmProductsAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Productos";
            this.Load += new System.EventHandler(this.FrmProductsAdd_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProductsAdd_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnAddproduct;
        private System.Windows.Forms.Button BtnEditproduct;
        private System.Windows.Forms.Button BtnDeleteproduct;
        private System.Windows.Forms.Button BtnCleanproduct;
        private System.Windows.Forms.Button BtnCancelproduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchItem;
        private System.Windows.Forms.DataGridView DgProduct;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnDeleteForEver;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.RadioButton txt140;
        private System.Windows.Forms.RadioButton txt120;
        private System.Windows.Forms.RadioButton txt100;
        private System.Windows.Forms.RadioButton txt80;
        private System.Windows.Forms.RadioButton txt60;
        private System.Windows.Forms.RadioButton txt40;
        private System.Windows.Forms.RadioButton txt20;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbtax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.TextBox TxtUnitaryCost;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtIDProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.NumericUpDown TxtStock;
    }
}