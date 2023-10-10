namespace VCBikeService.Forms.Factura
{
    partial class FrmBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilling));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtDescuento = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrecioFinal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnadd = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.DgLista = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCrear = new WindowsFormsAero.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.txtCustomer = new WindowsFormsAero.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtUSer = new System.Windows.Forms.TextBox();
            this.cvMethodp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CbBuyType = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 548F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1226, 798);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1220, 542);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.DgvListaItems, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.88889F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.11111F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(604, 536);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemID,
            this.CItemName,
            this.CDescription,
            this.CStock,
            this.CSellPrice,
            this.CBarcode});
            this.DgvListaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaItems.Location = new System.Drawing.Point(3, 48);
            this.DgvListaItems.MultiSelect = false;
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.RowHeadersWidth = 51;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(598, 276);
            this.DgvListaItems.TabIndex = 9;
            this.DgvListaItems.VirtualMode = true;
            this.DgvListaItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaItems_CellClick);
            this.DgvListaItems.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvListaItems_DataBindingComplete);
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Código";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 125;
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre";
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            // 
            // CDescription
            // 
            this.CDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Descripción";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
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
            // CSellPrice
            // 
            this.CSellPrice.DataPropertyName = "SellPrice";
            this.CSellPrice.HeaderText = "Precio Unitario";
            this.CSellPrice.MinimumWidth = 6;
            this.CSellPrice.Name = "CSellPrice";
            this.CSellPrice.ReadOnly = true;
            this.CSellPrice.Width = 125;
            // 
            // CBarcode
            // 
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Código de barras";
            this.CBarcode.MinimumWidth = 6;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            this.CBarcode.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TxtSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 39);
            this.panel1.TabIndex = 0;
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearch.Location = new System.Drawing.Point(119, 7);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(467, 20);
            this.TxtSearch.TabIndex = 3;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.TxtDescuento);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TxtPrecioFinal);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.TxtIva);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.TxtPrecioUnitario);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.TxtCantidad);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(3, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(598, 133);
            this.panel2.TabIndex = 10;
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(116, 51);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(92, 31);
            this.TxtDescuento.TabIndex = 22;
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDescuento.ValueChanged += new System.EventHandler(this.TxtDescuento_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Precio Final";
            // 
            // TxtPrecioFinal
            // 
            this.TxtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioFinal.Location = new System.Drawing.Point(472, 52);
            this.TxtPrecioFinal.Name = "TxtPrecioFinal";
            this.TxtPrecioFinal.ReadOnly = true;
            this.TxtPrecioFinal.Size = new System.Drawing.Size(114, 31);
            this.TxtPrecioFinal.TabIndex = 19;
            this.TxtPrecioFinal.Text = "0";
            this.TxtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(382, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "% IVA";
            // 
            // TxtIva
            // 
            this.TxtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIva.Location = new System.Drawing.Point(373, 51);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.ReadOnly = true;
            this.TxtIva.Size = new System.Drawing.Size(93, 31);
            this.TxtIva.TabIndex = 17;
            this.TxtIva.Text = "0";
            this.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(238, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Precio Unitario";
            // 
            // TxtPrecioUnitario
            // 
            this.TxtPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioUnitario.Location = new System.Drawing.Point(242, 51);
            this.TxtPrecioUnitario.Name = "TxtPrecioUnitario";
            this.TxtPrecioUnitario.ReadOnly = true;
            this.TxtPrecioUnitario.Size = new System.Drawing.Size(113, 31);
            this.TxtPrecioUnitario.TabIndex = 15;
            this.TxtPrecioUnitario.Text = "0";
            this.TxtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "% Descuento";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(17, 51);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(66, 31);
            this.TxtCantidad.TabIndex = 12;
            this.TxtCantidad.ValueChanged += new System.EventHandler(this.TxtCantidad_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 469);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 64);
            this.panel3.TabIndex = 11;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.OliveDrab;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadd.Location = new System.Drawing.Point(202, 12);
            this.btnadd.Margin = new System.Windows.Forms.Padding(2);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(166, 46);
            this.btnadd.TabIndex = 23;
            this.btnadd.Text = "Agregar";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel5, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(613, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.6972F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.3028F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(604, 536);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 396);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(598, 67);
            this.panel5.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.YellowGreen;
            this.panel9.Controls.Add(this.LblTotal);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(598, 67);
            this.panel9.TabIndex = 1;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTotal.Location = new System.Drawing.Point(268, 40);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(24, 27);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(245, 13);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "TOTAL";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.DgLista);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(598, 319);
            this.panel6.TabIndex = 9;
            // 
            // DgLista
            // 
            this.DgLista.AllowUserToAddRows = false;
            this.DgLista.AllowUserToDeleteRows = false;
            this.DgLista.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DgLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemID,
            this.Cantidad,
            this.PrecioUnitario,
            this.Discount,
            this.Impuesto,
            this.precioFinal});
            this.DgLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgLista.Location = new System.Drawing.Point(0, 0);
            this.DgLista.MultiSelect = false;
            this.DgLista.Name = "DgLista";
            this.DgLista.ReadOnly = true;
            this.DgLista.RowHeadersVisible = false;
            this.DgLista.RowHeadersWidth = 51;
            this.DgLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLista.Size = new System.Drawing.Size(598, 319);
            this.DgLista.TabIndex = 21;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Nombre  ";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Codigo";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.DataPropertyName = "PrecioUnitario";
            this.PrecioUnitario.HeaderText = "PrecioUnitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "Descuento";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Impuesto
            // 
            this.Impuesto.DataPropertyName = "Impuesto";
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            // 
            // precioFinal
            // 
            this.precioFinal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precioFinal.DataPropertyName = "precioFinal";
            this.precioFinal.HeaderText = "Precio";
            this.precioFinal.Name = "precioFinal";
            this.precioFinal.ReadOnly = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel5.Controls.Add(this.BtnClean, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnCrear, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BtnCancel, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnDeleteForever, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 469);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(598, 64);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Image = ((System.Drawing.Image)(resources.GetObject("BtnClean.Image")));
            this.BtnClean.Location = new System.Drawing.Point(202, 3);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(177, 58);
            this.BtnClean.TabIndex = 28;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnClean.UseVisualStyleBackColor = false;
            // 
            // BtnCrear
            // 
            this.BtnCrear.BackColor = System.Drawing.Color.YellowGreen;
            this.BtnCrear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCrear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Image = ((System.Drawing.Image)(resources.GetObject("BtnCrear.Image")));
            this.BtnCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCrear.Location = new System.Drawing.Point(3, 3);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(193, 58);
            this.BtnCrear.TabIndex = 27;
            this.BtnCrear.Text = "Facturar";
            this.BtnCrear.UseVisualStyleBackColor = false;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(511, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 58);
            this.BtnCancel.TabIndex = 30;
            this.BtnCancel.Text = "Cerrar";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteForever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteForever.Image")));
            this.btnDeleteForever.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteForever.Location = new System.Drawing.Point(385, 3);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(120, 58);
            this.btnDeleteForever.TabIndex = 29;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanel6.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 328);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(598, 62);
            this.tableLayoutPanel6.TabIndex = 11;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.Controls.Add(this.LblImpuestos);
            this.panel8.Controls.Add(this.label14);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(415, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 56);
            this.panel8.TabIndex = 2;
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.AutoSize = true;
            this.LblImpuestos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImpuestos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblImpuestos.Location = new System.Drawing.Point(77, 34);
            this.LblImpuestos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(19, 21);
            this.LblImpuestos.TabIndex = 4;
            this.LblImpuestos.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(48, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 21);
            this.label14.TabIndex = 1;
            this.label14.Text = "Impuestos";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.Controls.Add(this.LblDescuentos);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(212, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 56);
            this.panel7.TabIndex = 1;
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.AutoSize = true;
            this.LblDescuentos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescuentos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDescuentos.Location = new System.Drawing.Point(92, 30);
            this.LblDescuentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(19, 21);
            this.LblDescuentos.TabIndex = 3;
            this.LblDescuentos.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(57, 9);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Descuentos";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.LblSubTotal);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(203, 56);
            this.panel4.TabIndex = 0;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.LblSubTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblSubTotal.Location = new System.Drawing.Point(91, 30);
            this.LblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(19, 21);
            this.LblSubTotal.TabIndex = 3;
            this.LblSubTotal.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(58, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 2;
            this.label12.Text = "Sub Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtUserID);
            this.groupBox1.Controls.Add(this.txtCustomer);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.TxtCustomerID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DtpFechaFactura);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtUSer);
            this.groupBox1.Controls.Add(this.cvMethodp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CbBuyType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1220, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles de la factura";
            // 
            // TxtUserID
            // 
            this.TxtUserID.BackColor = System.Drawing.Color.White;
            this.TxtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserID.Location = new System.Drawing.Point(155, 39);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.ReadOnly = true;
            this.TxtUserID.Size = new System.Drawing.Size(76, 29);
            this.TxtUserID.TabIndex = 36;
            this.TxtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCustomer
            // 
            this.txtCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCustomer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtCustomer.FormattingEnabled = true;
            this.txtCustomer.Location = new System.Drawing.Point(256, 92);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(256, 32);
            this.txtCustomer.TabIndex = 35;
            this.txtCustomer.SelectedIndexChanged += new System.EventHandler(this.txtCustomer_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(43, 92);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 24);
            this.label16.TabIndex = 34;
            this.label16.Text = "Cliente:";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.BackColor = System.Drawing.Color.White;
            this.TxtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerID.Location = new System.Drawing.Point(155, 92);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.ReadOnly = true;
            this.TxtCustomerID.Size = new System.Drawing.Size(76, 29);
            this.TxtCustomerID.TabIndex = 33;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fecha:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaFactura.Location = new System.Drawing.Point(663, 28);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(452, 29);
            this.DtpFechaFactura.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(563, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(638, 106);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(544, 85);
            this.TxtNotas.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Usuario:";
            // 
            // TxtUSer
            // 
            this.TxtUSer.BackColor = System.Drawing.Color.White;
            this.TxtUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUSer.Location = new System.Drawing.Point(256, 42);
            this.TxtUSer.Name = "TxtUSer";
            this.TxtUSer.ReadOnly = true;
            this.TxtUSer.Size = new System.Drawing.Size(256, 22);
            this.TxtUSer.TabIndex = 27;
            this.TxtUSer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cvMethodp
            // 
            this.cvMethodp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvMethodp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvMethodp.FormattingEnabled = true;
            this.cvMethodp.Location = new System.Drawing.Point(208, 203);
            this.cvMethodp.MaximumSize = new System.Drawing.Size(304, 0);
            this.cvMethodp.Name = "cvMethodp";
            this.cvMethodp.Size = new System.Drawing.Size(304, 32);
            this.cvMethodp.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Metodo de pago:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Tipo de Compra:";
            // 
            // CbBuyType
            // 
            this.CbBuyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbBuyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuyType.FormattingEnabled = true;
            this.CbBuyType.Location = new System.Drawing.Point(208, 145);
            this.CbBuyType.MaximumSize = new System.Drawing.Size(304, 0);
            this.CbBuyType.Name = "CbBuyType";
            this.CbBuyType.Size = new System.Drawing.Size(304, 32);
            this.CbBuyType.TabIndex = 23;
            // 
            // FrmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 798);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBilling";
            this.Load += new System.EventHandler(this.FrmBilling_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmBilling_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgLista)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox TxtUSer;
        private System.Windows.Forms.ComboBox cvMethodp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBuyType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrecioFinal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPrecioUnitario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Panel panel5;
        private WindowsFormsAero.ComboBox txtCustomer;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.NumericUpDown TxtDescuento;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridView DgLista;
        public System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioFinal;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button BtnClean;
        private WindowsFormsAero.Button BtnCrear;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LblImpuestos;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label label13;
    }
}