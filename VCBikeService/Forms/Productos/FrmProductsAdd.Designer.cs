namespace VCBikeService.Forms
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkProduct = new System.Windows.Forms.CheckBox();
            this.TxtSearchItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnDeleteForEver = new System.Windows.Forms.Button();
            this.BtnCancelproduct = new System.Windows.Forms.Button();
            this.BtnAddproduct = new System.Windows.Forms.Button();
            this.BtnCleanproduct = new System.Windows.Forms.Button();
            this.BtnEditproduct = new System.Windows.Forms.Button();
            this.BtnDeleteproduct = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.43984F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.56016F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1192, 783);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkProduct);
            this.panel1.Controls.Add(this.TxtSearchItem);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1186, 52);
            this.panel1.TabIndex = 0;
            // 
            // checkProduct
            // 
            this.checkProduct.AutoSize = true;
            this.checkProduct.Checked = true;
            this.checkProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProduct.Location = new System.Drawing.Point(898, 15);
            this.checkProduct.Margin = new System.Windows.Forms.Padding(2);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(60, 19);
            this.checkProduct.TabIndex = 4;
            this.checkProduct.Text = "Activo";
            this.checkProduct.UseVisualStyleBackColor = true;
            this.checkProduct.CheckedChanged += new System.EventHandler(this.checkProduct_CheckedChanged);
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchItem.Location = new System.Drawing.Point(198, 15);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(663, 20);
            this.TxtSearchItem.TabIndex = 3;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 13);
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
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1186, 443);
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
            this.CUnitaryCost,
            this.CSellPrice,
            this.CDescription});
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
            this.DgProduct.Size = new System.Drawing.Size(1186, 443);
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
            this.CUnitaryCost.HeaderText = "Costo";
            this.CUnitaryCost.MinimumWidth = 6;
            this.CUnitaryCost.Name = "CUnitaryCost";
            this.CUnitaryCost.ReadOnly = true;
            this.CUnitaryCost.Width = 150;
            // 
            // CSellPrice
            // 
            this.CSellPrice.DataPropertyName = "SellPrice";
            this.CSellPrice.HeaderText = "Precio Venta";
            this.CSellPrice.MinimumWidth = 6;
            this.CSellPrice.Name = "CSellPrice";
            this.CSellPrice.ReadOnly = true;
            this.CSellPrice.Width = 125;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Categoria";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 130;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 510);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1186, 205);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtStock);
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
            this.groupBox1.Location = new System.Drawing.Point(-3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1087, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Productos";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(663, 50);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(362, 20);
            this.TxtStock.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Stock:";
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(94, 168);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(435, 21);
            this.CbCategory.TabIndex = 19;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(651, 120);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(401, 67);
            this.TxtDescription.TabIndex = 14;
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(663, 86);
            this.TxtSellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(362, 20);
            this.TxtSellPrice.TabIndex = 13;
            this.TxtSellPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSellPrice_KeyPress);
            // 
            // TxtUnitaryCost
            // 
            this.TxtUnitaryCost.Location = new System.Drawing.Point(663, 15);
            this.TxtUnitaryCost.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnitaryCost.Name = "TxtUnitaryCost";
            this.TxtUnitaryCost.Size = new System.Drawing.Size(362, 20);
            this.TxtUnitaryCost.TabIndex = 12;
            this.TxtUnitaryCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUnitaryCost_KeyPress);
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Location = new System.Drawing.Point(123, 129);
            this.TxtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(362, 20);
            this.TxtBarcode.TabIndex = 11;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Location = new System.Drawing.Point(94, 77);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(362, 20);
            this.TxtProductName.TabIndex = 10;
            this.TxtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductName_KeyPress);
            // 
            // TxtIDProduct
            // 
            this.TxtIDProduct.Location = new System.Drawing.Point(94, 36);
            this.TxtIDProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDProduct.Name = "TxtIDProduct";
            this.TxtIDProduct.ReadOnly = true;
            this.TxtIDProduct.Size = new System.Drawing.Size(235, 20);
            this.TxtIDProduct.TabIndex = 9;
            this.TxtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 130);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de venta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo unitario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Codigo de barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnactivate);
            this.panel4.Controls.Add(this.BtnDeleteForEver);
            this.panel4.Controls.Add(this.BtnCancelproduct);
            this.panel4.Controls.Add(this.BtnAddproduct);
            this.panel4.Controls.Add(this.BtnCleanproduct);
            this.panel4.Controls.Add(this.BtnEditproduct);
            this.panel4.Controls.Add(this.BtnDeleteproduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 721);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1186, 59);
            this.panel4.TabIndex = 3;
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(2, 2);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(170, 54);
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
            this.BtnDeleteForEver.Location = new System.Drawing.Point(244, 2);
            this.BtnDeleteForEver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteForEver.Name = "BtnDeleteForEver";
            this.BtnDeleteForEver.Size = new System.Drawing.Size(170, 54);
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
            this.BtnCancelproduct.Location = new System.Drawing.Point(858, 2);
            this.BtnCancelproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelproduct.Name = "BtnCancelproduct";
            this.BtnCancelproduct.Size = new System.Drawing.Size(170, 54);
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
            this.BtnAddproduct.Location = new System.Drawing.Point(2, 2);
            this.BtnAddproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddproduct.Name = "BtnAddproduct";
            this.BtnAddproduct.Size = new System.Drawing.Size(170, 54);
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
            this.BtnCleanproduct.Location = new System.Drawing.Point(636, 2);
            this.BtnCleanproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCleanproduct.Name = "BtnCleanproduct";
            this.BtnCleanproduct.Size = new System.Drawing.Size(170, 54);
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
            this.BtnEditproduct.Location = new System.Drawing.Point(203, 2);
            this.BtnEditproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditproduct.Name = "BtnEditproduct";
            this.BtnEditproduct.Size = new System.Drawing.Size(170, 54);
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
            this.BtnDeleteproduct.Location = new System.Drawing.Point(418, 2);
            this.BtnDeleteproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteproduct.Name = "BtnDeleteproduct";
            this.BtnDeleteproduct.Size = new System.Drawing.Size(170, 54);
            this.BtnDeleteproduct.TabIndex = 11;
            this.BtnDeleteproduct.Text = "Eliminar";
            this.BtnDeleteproduct.UseVisualStyleBackColor = false;
            this.BtnDeleteproduct.Click += new System.EventHandler(this.BtnDeleteproduct_Click);
            // 
            // FrmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1194, 797);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProductsAdd";
            this.Text = "Gestion Productos";
            this.Load += new System.EventHandler(this.FrmProductsAdd_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAddproduct;
        private System.Windows.Forms.Button BtnEditproduct;
        private System.Windows.Forms.Button BtnDeleteproduct;
        private System.Windows.Forms.Button BtnCleanproduct;
        private System.Windows.Forms.Button BtnCancelproduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchItem;
        private System.Windows.Forms.CheckBox checkProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtIDProduct;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.TextBox TxtUnitaryCost;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.DataGridView DgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnDeleteForEver;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Label label9;
    }
}