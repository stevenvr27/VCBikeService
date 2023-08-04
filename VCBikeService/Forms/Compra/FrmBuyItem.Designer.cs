namespace VCBikeService.Forms.Productos
{
    partial class FrmBuyItem
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
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cdes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUnitaryPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtIDProduct = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSupplier = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmetpag = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbuytype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtPrecioFinal = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtSearchItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnfacturacliente = new System.Windows.Forms.Button();
            this.BtnDeleteproduct = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.91753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.08247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 609);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.CStock,
            this.Cventa,
            this.Cdes,
            this.CBarcode});
            this.DgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgProduct.Location = new System.Drawing.Point(4, 46);
            this.DgProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgProduct.MaximumSize = new System.Drawing.Size(1262, 613);
            this.DgProduct.MultiSelect = false;
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersVisible = false;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 28;
            this.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProduct.Size = new System.Drawing.Size(767, 266);
            this.DgProduct.TabIndex = 19;
            this.DgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgProduct_CellClick);
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Cod.Producto";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 125;
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre";
            this.CItemName.MinimumWidth = 6;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            this.CItemName.Width = 125;
            // 
            // CStock
            // 
            this.CStock.DataPropertyName = "Stock";
            this.CStock.HeaderText = "Stock";
            this.CStock.MinimumWidth = 6;
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Width = 125;
            // 
            // Cventa
            // 
            this.Cventa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cventa.DataPropertyName = "venta";
            this.Cventa.HeaderText = "Costo Unitario";
            this.Cventa.MinimumWidth = 6;
            this.Cventa.Name = "Cventa";
            this.Cventa.ReadOnly = true;
            // 
            // Cdes
            // 
            this.Cdes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cdes.DataPropertyName = "des";
            this.Cdes.HeaderText = "Ubicacion";
            this.Cdes.MinimumWidth = 6;
            this.Cdes.Name = "Cdes";
            this.Cdes.ReadOnly = true;
            // 
            // CBarcode
            // 
            this.CBarcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Codigo Barras";
            this.CBarcode.MinimumWidth = 6;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 200);
            this.panel1.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUnitaryPrice);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.TxtProductName);
            this.panel3.Controls.Add(this.TxtIDProduct);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TxtSupplier);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.TxtDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.TxtNotas);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtmetpag);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtbuytype);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.TxtPrecioFinal);
            this.panel3.Controls.Add(this.TxtCantidad);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 200);
            this.panel3.TabIndex = 0;
            // 
            // txtUnitaryPrice
            // 
            this.txtUnitaryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitaryPrice.Location = new System.Drawing.Point(186, 161);
            this.txtUnitaryPrice.Name = "txtUnitaryPrice";
            this.txtUnitaryPrice.Size = new System.Drawing.Size(119, 30);
            this.txtUnitaryPrice.TabIndex = 44;
            this.txtUnitaryPrice.Text = "0";
            this.txtUnitaryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitaryPrice.TextChanged += new System.EventHandler(this.txtUnitaryPrice_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(183, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 15);
            this.label11.TabIndex = 43;
            this.label11.Text = "Precio Costo Unitario";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtProductName.Location = new System.Drawing.Point(73, 40);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.ReadOnly = true;
            this.TxtProductName.Size = new System.Drawing.Size(232, 20);
            this.TxtProductName.TabIndex = 41;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIDProduct
            // 
            this.TxtIDProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtIDProduct.Location = new System.Drawing.Point(73, 8);
            this.TxtIDProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDProduct.Name = "TxtIDProduct";
            this.TxtIDProduct.ReadOnly = true;
            this.TxtIDProduct.Size = new System.Drawing.Size(113, 20);
            this.TxtIDProduct.TabIndex = 40;
            this.TxtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 8);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Codigo:";
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSupplier.BackColor = System.Drawing.Color.Moccasin;
            this.TxtSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSupplier.FormattingEnabled = true;
            this.TxtSupplier.Location = new System.Drawing.Point(477, 6);
            this.TxtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplier.MaximumSize = new System.Drawing.Size(229, 0);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(228, 21);
            this.TxtSupplier.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(392, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 36;
            this.label8.Text = "Proveedor:";
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(574, 161);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(60, 22);
            this.TxtDate.TabIndex = 35;
            this.TxtDate.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(452, 57);
            this.TxtNotas.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(311, 83);
            this.TxtNotas.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Metodo de pago:";
            // 
            // txtmetpag
            // 
            this.txtmetpag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmetpag.BackColor = System.Drawing.Color.Moccasin;
            this.txtmetpag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmetpag.FormattingEnabled = true;
            this.txtmetpag.Location = new System.Drawing.Point(134, 93);
            this.txtmetpag.Margin = new System.Windows.Forms.Padding(2);
            this.txtmetpag.MaximumSize = new System.Drawing.Size(229, 0);
            this.txtmetpag.Name = "txtmetpag";
            this.txtmetpag.Size = new System.Drawing.Size(228, 21);
            this.txtmetpag.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Tipo de Compra:";
            // 
            // txtbuytype
            // 
            this.txtbuytype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuytype.BackColor = System.Drawing.Color.Moccasin;
            this.txtbuytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbuytype.FormattingEnabled = true;
            this.txtbuytype.Location = new System.Drawing.Point(134, 64);
            this.txtbuytype.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuytype.MaximumSize = new System.Drawing.Size(229, 0);
            this.txtbuytype.Name = "txtbuytype";
            this.txtbuytype.Size = new System.Drawing.Size(228, 21);
            this.txtbuytype.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 15);
            this.label5.TabIndex = 28;
            this.label5.Text = "Precio Final";
            // 
            // TxtPrecioFinal
            // 
            this.TxtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioFinal.Location = new System.Drawing.Point(366, 161);
            this.TxtPrecioFinal.Name = "TxtPrecioFinal";
            this.TxtPrecioFinal.ReadOnly = true;
            this.TxtPrecioFinal.Size = new System.Drawing.Size(95, 30);
            this.TxtPrecioFinal.TabIndex = 27;
            this.TxtPrecioFinal.Text = "0";
            this.TxtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(21, 154);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(84, 41);
            this.TxtCantidad.TabIndex = 23;
            this.TxtCantidad.ValueChanged += new System.EventHandler(this.TxtCantidad_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cantidad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtSearchItem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 37);
            this.panel2.TabIndex = 18;
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchItem.Location = new System.Drawing.Point(103, 12);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(399, 20);
            this.TxtSearchItem.TabIndex = 4;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnfacturacliente);
            this.panel4.Controls.Add(this.BtnDeleteproduct);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 523);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 84);
            this.panel4.TabIndex = 20;
            // 
            // btnfacturacliente
            // 
            this.btnfacturacliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfacturacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturacliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfacturacliente.Location = new System.Drawing.Point(2, 20);
            this.btnfacturacliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnfacturacliente.Name = "btnfacturacliente";
            this.btnfacturacliente.Size = new System.Drawing.Size(183, 54);
            this.btnfacturacliente.TabIndex = 13;
            this.btnfacturacliente.Text = " + Facturar  ";
            this.btnfacturacliente.UseVisualStyleBackColor = false;
            this.btnfacturacliente.Click += new System.EventHandler(this.btnfacturacliente_Click);
            // 
            // BtnDeleteproduct
            // 
            this.BtnDeleteproduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteproduct.Location = new System.Drawing.Point(560, 20);
            this.BtnDeleteproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteproduct.Name = "BtnDeleteproduct";
            this.BtnDeleteproduct.Size = new System.Drawing.Size(170, 54);
            this.BtnDeleteproduct.TabIndex = 15;
            this.BtnDeleteproduct.Text = "Cancelar";
            this.BtnDeleteproduct.UseVisualStyleBackColor = false;
            this.BtnDeleteproduct.Click += new System.EventHandler(this.BtnDeleteproduct_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(283, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = " + Stock";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBuyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(775, 609);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmBuyItem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchProduct";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSearchProduct_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfacturacliente;
        private System.Windows.Forms.Button BtnDeleteproduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtPrecioFinal;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtmetpag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtbuytype;
        private System.Windows.Forms.Label TxtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.ComboBox TxtSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtIDProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUnitaryPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cdes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
    }
}