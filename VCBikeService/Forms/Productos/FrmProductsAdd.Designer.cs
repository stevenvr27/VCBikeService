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
            this.checkProduct = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFinalPrice = new System.Windows.Forms.TextBox();
            this.txt140 = new System.Windows.Forms.RadioButton();
            this.txt120 = new System.Windows.Forms.RadioButton();
            this.txt100 = new System.Windows.Forms.RadioButton();
            this.txt80 = new System.Windows.Forms.RadioButton();
            this.txt60 = new System.Windows.Forms.RadioButton();
            this.txt40 = new System.Windows.Forms.RadioButton();
            this.txt20 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtSellPrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUnitaryCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalue = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.cbtax = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbUbication = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.CbCategory = new System.Windows.Forms.ComboBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtBarcode = new System.Windows.Forms.TextBox();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtIDProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchItem.Location = new System.Drawing.Point(82, 18);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(405, 20);
            this.TxtSearchItem.TabIndex = 3;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
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
            this.DgProduct.Location = new System.Drawing.Point(0, 0);
            this.DgProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgProduct.MultiSelect = false;
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersVisible = false;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 28;
            this.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProduct.Size = new System.Drawing.Size(805, 757);
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
            this.btnactivate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(0, 0);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(170, 51);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // BtnDeleteForEver
            // 
            this.BtnDeleteForEver.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteForEver.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteForEver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteForEver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteForEver.Location = new System.Drawing.Point(340, 0);
            this.BtnDeleteForEver.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteForEver.Name = "BtnDeleteForEver";
            this.BtnDeleteForEver.Size = new System.Drawing.Size(170, 51);
            this.BtnDeleteForEver.TabIndex = 14;
            this.BtnDeleteForEver.Text = "Eliminar";
            this.BtnDeleteForEver.UseVisualStyleBackColor = false;
            this.BtnDeleteForEver.Visible = false;
            this.BtnDeleteForEver.Click += new System.EventHandler(this.BtnDeleteForEver_Click);
            // 
            // BtnCancelproduct
            // 
            this.BtnCancelproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelproduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelproduct.Location = new System.Drawing.Point(1025, 0);
            this.BtnCancelproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelproduct.Name = "BtnCancelproduct";
            this.BtnCancelproduct.Size = new System.Drawing.Size(170, 51);
            this.BtnCancelproduct.TabIndex = 13;
            this.BtnCancelproduct.Text = "Cancel";
            this.BtnCancelproduct.UseVisualStyleBackColor = false;
            this.BtnCancelproduct.Click += new System.EventHandler(this.BtnCancelproduct_Click);
            // 
            // BtnAddproduct
            // 
            this.BtnAddproduct.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddproduct.Location = new System.Drawing.Point(680, 0);
            this.BtnAddproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddproduct.Name = "BtnAddproduct";
            this.BtnAddproduct.Size = new System.Drawing.Size(170, 51);
            this.BtnAddproduct.TabIndex = 9;
            this.BtnAddproduct.Text = "Agregar";
            this.BtnAddproduct.UseVisualStyleBackColor = false;
            this.BtnAddproduct.Click += new System.EventHandler(this.BtnAddproduct_Click);
            // 
            // BtnCleanproduct
            // 
            this.BtnCleanproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCleanproduct.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCleanproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanproduct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCleanproduct.Location = new System.Drawing.Point(1195, 0);
            this.BtnCleanproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCleanproduct.Name = "BtnCleanproduct";
            this.BtnCleanproduct.Size = new System.Drawing.Size(170, 51);
            this.BtnCleanproduct.TabIndex = 12;
            this.BtnCleanproduct.Text = "Limpiar";
            this.BtnCleanproduct.UseVisualStyleBackColor = false;
            this.BtnCleanproduct.Click += new System.EventHandler(this.BtnCleanproduct_Click);
            // 
            // BtnEditproduct
            // 
            this.BtnEditproduct.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditproduct.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEditproduct.Location = new System.Drawing.Point(170, 0);
            this.BtnEditproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditproduct.Name = "BtnEditproduct";
            this.BtnEditproduct.Size = new System.Drawing.Size(170, 51);
            this.BtnEditproduct.TabIndex = 10;
            this.BtnEditproduct.Text = "Modificar";
            this.BtnEditproduct.UseVisualStyleBackColor = false;
            this.BtnEditproduct.Click += new System.EventHandler(this.BtnEditproduct_Click);
            // 
            // BtnDeleteproduct
            // 
            this.BtnDeleteproduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteproduct.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteproduct.Location = new System.Drawing.Point(510, 0);
            this.BtnDeleteproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteproduct.Name = "BtnDeleteproduct";
            this.BtnDeleteproduct.Size = new System.Drawing.Size(170, 51);
            this.BtnDeleteproduct.TabIndex = 11;
            this.BtnDeleteproduct.Text = "Eliminar";
            this.BtnDeleteproduct.UseVisualStyleBackColor = false;
            this.BtnDeleteproduct.Click += new System.EventHandler(this.BtnDeleteproduct_Click);
            // 
            // checkProduct
            // 
            this.checkProduct.AutoSize = true;
            this.checkProduct.Checked = true;
            this.checkProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkProduct.Location = new System.Drawing.Point(493, 16);
            this.checkProduct.Margin = new System.Windows.Forms.Padding(2);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(67, 22);
            this.checkProduct.TabIndex = 16;
            this.checkProduct.Text = "Activo";
            this.checkProduct.UseVisualStyleBackColor = true;
            this.checkProduct.CheckedChanged += new System.EventHandler(this.checkProduct_CheckedChanged_1);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1371, 826);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnAddproduct);
            this.panel3.Controls.Add(this.BtnDeleteproduct);
            this.panel3.Controls.Add(this.BtnDeleteForEver);
            this.panel3.Controls.Add(this.BtnCancelproduct);
            this.panel3.Controls.Add(this.BtnCleanproduct);
            this.panel3.Controls.Add(this.BtnEditproduct);
            this.panel3.Controls.Add(this.btnactivate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 772);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1365, 51);
            this.panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 554F));
            this.tableLayoutPanel3.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1365, 763);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgProduct);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(805, 757);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(814, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(548, 757);
            this.panel5.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox2);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 56);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(548, 701);
            this.panel7.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.TxtStock);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtFinalPrice);
            this.groupBox2.Controls.Add(this.txt140);
            this.groupBox2.Controls.Add(this.txt120);
            this.groupBox2.Controls.Add(this.txt100);
            this.groupBox2.Controls.Add(this.txt80);
            this.groupBox2.Controls.Add(this.txt60);
            this.groupBox2.Controls.Add(this.txt40);
            this.groupBox2.Controls.Add(this.txt20);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtSellPrice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtUnitaryCost);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtvalue);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.cbtax);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(548, 378);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Numerico";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(114, 262);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 24);
            this.label12.TabIndex = 54;
            this.label12.Text = "Cantidad:";
            // 
            // TxtStock
            // 
            this.TxtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtStock.Location = new System.Drawing.Point(287, 255);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(183, 35);
            this.TxtStock.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 325);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 24);
            this.label11.TabIndex = 52;
            this.label11.Text = "Precio de Venta:";
            // 
            // txtFinalPrice
            // 
            this.txtFinalPrice.BackColor = System.Drawing.Color.YellowGreen;
            this.txtFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFinalPrice.Location = new System.Drawing.Point(220, 325);
            this.txtFinalPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtFinalPrice.Name = "txtFinalPrice";
            this.txtFinalPrice.Size = new System.Drawing.Size(328, 37);
            this.txtFinalPrice.TabIndex = 51;
            // 
            // txt140
            // 
            this.txt140.AutoSize = true;
            this.txt140.Location = new System.Drawing.Point(487, 201);
            this.txt140.Name = "txt140";
            this.txt140.Size = new System.Drawing.Size(58, 20);
            this.txt140.TabIndex = 50;
            this.txt140.TabStop = true;
            this.txt140.Text = "140%";
            this.txt140.UseVisualStyleBackColor = true;
            // 
            // txt120
            // 
            this.txt120.AutoSize = true;
            this.txt120.Location = new System.Drawing.Point(409, 201);
            this.txt120.Name = "txt120";
            this.txt120.Size = new System.Drawing.Size(58, 20);
            this.txt120.TabIndex = 49;
            this.txt120.TabStop = true;
            this.txt120.Text = "120%";
            this.txt120.UseVisualStyleBackColor = true;
            // 
            // txt100
            // 
            this.txt100.AutoSize = true;
            this.txt100.Location = new System.Drawing.Point(343, 201);
            this.txt100.Name = "txt100";
            this.txt100.Size = new System.Drawing.Size(58, 20);
            this.txt100.TabIndex = 48;
            this.txt100.TabStop = true;
            this.txt100.Text = "100%";
            this.txt100.UseVisualStyleBackColor = true;
            // 
            // txt80
            // 
            this.txt80.AutoSize = true;
            this.txt80.Location = new System.Drawing.Point(257, 201);
            this.txt80.Name = "txt80";
            this.txt80.Size = new System.Drawing.Size(51, 20);
            this.txt80.TabIndex = 47;
            this.txt80.TabStop = true;
            this.txt80.Text = "80%";
            this.txt80.UseVisualStyleBackColor = true;
            // 
            // txt60
            // 
            this.txt60.AutoSize = true;
            this.txt60.Location = new System.Drawing.Point(181, 201);
            this.txt60.Name = "txt60";
            this.txt60.Size = new System.Drawing.Size(51, 20);
            this.txt60.TabIndex = 46;
            this.txt60.TabStop = true;
            this.txt60.Text = "60%";
            this.txt60.UseVisualStyleBackColor = true;
            // 
            // txt40
            // 
            this.txt40.AutoSize = true;
            this.txt40.Location = new System.Drawing.Point(110, 201);
            this.txt40.Name = "txt40";
            this.txt40.Size = new System.Drawing.Size(51, 20);
            this.txt40.TabIndex = 45;
            this.txt40.TabStop = true;
            this.txt40.Text = "40%";
            this.txt40.UseVisualStyleBackColor = true;
            // 
            // txt20
            // 
            this.txt20.AutoSize = true;
            this.txt20.Location = new System.Drawing.Point(41, 201);
            this.txt20.Name = "txt20";
            this.txt20.Size = new System.Drawing.Size(51, 20);
            this.txt20.TabIndex = 44;
            this.txt20.TabStop = true;
            this.txt20.Text = "20%";
            this.txt20.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "(sin impuesto)";
            // 
            // TxtSellPrice
            // 
            this.TxtSellPrice.Location = new System.Drawing.Point(220, 160);
            this.TxtSellPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSellPrice.Name = "TxtSellPrice";
            this.TxtSellPrice.Size = new System.Drawing.Size(308, 22);
            this.TxtSellPrice.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 150);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Precio de venta ";
            // 
            // TxtUnitaryCost
            // 
            this.TxtUnitaryCost.Location = new System.Drawing.Point(220, 104);
            this.TxtUnitaryCost.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUnitaryCost.Name = "TxtUnitaryCost";
            this.TxtUnitaryCost.Size = new System.Drawing.Size(308, 22);
            this.TxtUnitaryCost.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Costo unitario:";
            // 
            // txtvalue
            // 
            this.txtvalue.Location = new System.Drawing.Point(287, 48);
            this.txtvalue.Margin = new System.Windows.Forms.Padding(2);
            this.txtvalue.Name = "txtvalue";
            this.txtvalue.ReadOnly = true;
            this.txtvalue.Size = new System.Drawing.Size(183, 22);
            this.txtvalue.TabIndex = 38;
            this.txtvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(88, 28);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 16);
            this.label.TabIndex = 37;
            this.label.Text = "Impuesto:";
            // 
            // cbtax
            // 
            this.cbtax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtax.FormattingEnabled = true;
            this.cbtax.Location = new System.Drawing.Point(220, 20);
            this.cbtax.Margin = new System.Windows.Forms.Padding(2);
            this.cbtax.Name = "cbtax";
            this.cbtax.Size = new System.Drawing.Size(301, 24);
            this.cbtax.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbUbication);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbUnit);
            this.groupBox1.Controls.Add(this.CbCategory);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.TxtBarcode);
            this.groupBox1.Controls.Add(this.TxtProductName);
            this.groupBox1.Controls.Add(this.TxtIDProduct);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Producto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 311);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 39;
            this.label13.Text = "Descripcion:";
            // 
            // cbUbication
            // 
            this.cbUbication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUbication.FormattingEnabled = true;
            this.cbUbication.Location = new System.Drawing.Point(220, 260);
            this.cbUbication.Margin = new System.Windows.Forms.Padding(2);
            this.cbUbication.Name = "cbUbication";
            this.cbUbication.Size = new System.Drawing.Size(301, 24);
            this.cbUbication.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 217);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Unidad.Medida:";
            // 
            // cbUnit
            // 
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(220, 217);
            this.cbUnit.Margin = new System.Windows.Forms.Padding(2);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(301, 24);
            this.cbUnit.TabIndex = 36;
            // 
            // CbCategory
            // 
            this.CbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCategory.FormattingEnabled = true;
            this.CbCategory.Location = new System.Drawing.Point(220, 168);
            this.CbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.CbCategory.Name = "CbCategory";
            this.CbCategory.Size = new System.Drawing.Size(301, 24);
            this.CbCategory.TabIndex = 35;
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(220, 296);
            this.TxtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDescription.Size = new System.Drawing.Size(301, 31);
            this.TxtDescription.TabIndex = 34;
            // 
            // TxtBarcode
            // 
            this.TxtBarcode.Location = new System.Drawing.Point(220, 119);
            this.TxtBarcode.Margin = new System.Windows.Forms.Padding(2);
            this.TxtBarcode.Name = "TxtBarcode";
            this.TxtBarcode.Size = new System.Drawing.Size(301, 22);
            this.TxtBarcode.TabIndex = 33;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(220, 72);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductName.MaximumSize = new System.Drawing.Size(301, 22);
            this.TxtProductName.MinimumSize = new System.Drawing.Size(294, 22);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(301, 24);
            this.TxtProductName.TabIndex = 32;
            // 
            // TxtIDProduct
            // 
            this.TxtIDProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtIDProduct.Location = new System.Drawing.Point(220, 31);
            this.TxtIDProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDProduct.Name = "TxtIDProduct";
            this.TxtIDProduct.ReadOnly = true;
            this.TxtIDProduct.Size = new System.Drawing.Size(301, 22);
            this.TxtIDProduct.TabIndex = 31;
            this.TxtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 168);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Categoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 268);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Ubicacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Codigo de barras:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Codigo:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.TxtSearchItem);
            this.panel6.Controls.Add(this.checkProduct);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(548, 56);
            this.panel6.TabIndex = 0;
            // 
            // FrmProductsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1371, 826);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmProductsAdd";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductsAdd_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmProductsAdd_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStock)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.CheckBox checkProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtSellPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUnitaryCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalue;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox cbtax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.ComboBox CbCategory;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtBarcode;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtIDProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton txt140;
        private System.Windows.Forms.RadioButton txt120;
        private System.Windows.Forms.RadioButton txt100;
        private System.Windows.Forms.RadioButton txt80;
        private System.Windows.Forms.RadioButton txt60;
        private System.Windows.Forms.RadioButton txt40;
        private System.Windows.Forms.RadioButton txt20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFinalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown TxtStock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbUbication;
    }
}