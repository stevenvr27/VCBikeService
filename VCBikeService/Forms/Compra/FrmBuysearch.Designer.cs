namespace VCBikeService.Forms.Compra
{
    partial class FrmBuysearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuysearch));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgCustList = new System.Windows.Forms.DataGridView();
            this.CBillingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPercentageDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CExpr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.BtnCleanC = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtPrecioFinal = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1113, 679);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1109, 52);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtSearchCustomer);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1109, 52);
            this.panel7.TabIndex = 0;
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCustomer.Location = new System.Drawing.Point(122, 14);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(663, 30);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 58);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 302);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DgCustList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1109, 302);
            this.panel5.TabIndex = 0;
            // 
            // DgCustList
            // 
            this.DgCustList.AllowUserToAddRows = false;
            this.DgCustList.AllowUserToDeleteRows = false;
            this.DgCustList.AllowUserToOrderColumns = true;
            this.DgCustList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgCustList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBillingID,
            this.CCustomerName,
            this.CUserName,
            this.CDescription,
            this.CTotalLine,
            this.CAmount,
            this.CPercentageDiscount,
            this.CExpr1});
            this.DgCustList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgCustList.Location = new System.Drawing.Point(0, 0);
            this.DgCustList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgCustList.MultiSelect = false;
            this.DgCustList.Name = "DgCustList";
            this.DgCustList.ReadOnly = true;
            this.DgCustList.RowHeadersVisible = false;
            this.DgCustList.RowHeadersWidth = 62;
            this.DgCustList.RowTemplate.Height = 28;
            this.DgCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustList.Size = new System.Drawing.Size(1109, 302);
            this.DgCustList.TabIndex = 4;
            // 
            // CBillingID
            // 
            this.CBillingID.DataPropertyName = "BillingID";
            this.CBillingID.HeaderText = "Cod.Factura";
            this.CBillingID.MinimumWidth = 6;
            this.CBillingID.Name = "CBillingID";
            this.CBillingID.ReadOnly = true;
            this.CBillingID.Width = 125;
            // 
            // CCustomerName
            // 
            this.CCustomerName.DataPropertyName = "CustomerName";
            this.CCustomerName.HeaderText = "Nombre Cliente";
            this.CCustomerName.MinimumWidth = 6;
            this.CCustomerName.Name = "CCustomerName";
            this.CCustomerName.ReadOnly = true;
            this.CCustomerName.Width = 125;
            // 
            // CUserName
            // 
            this.CUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUserName.DataPropertyName = "UserName";
            this.CUserName.HeaderText = "Nombre Usuario";
            this.CUserName.MinimumWidth = 6;
            this.CUserName.Name = "CUserName";
            this.CUserName.ReadOnly = true;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Tipo de Factura";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 125;
            // 
            // CTotalLine
            // 
            this.CTotalLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTotalLine.DataPropertyName = "TotalLine";
            this.CTotalLine.HeaderText = "Total";
            this.CTotalLine.MinimumWidth = 6;
            this.CTotalLine.Name = "CTotalLine";
            this.CTotalLine.ReadOnly = true;
            // 
            // CAmount
            // 
            this.CAmount.DataPropertyName = "Amount";
            this.CAmount.HeaderText = "Cant.Productos";
            this.CAmount.MinimumWidth = 6;
            this.CAmount.Name = "CAmount";
            this.CAmount.ReadOnly = true;
            this.CAmount.Width = 125;
            // 
            // CPercentageDiscount
            // 
            this.CPercentageDiscount.DataPropertyName = "PercentageDiscount";
            this.CPercentageDiscount.HeaderText = "Descuento";
            this.CPercentageDiscount.MinimumWidth = 6;
            this.CPercentageDiscount.Name = "CPercentageDiscount";
            this.CPercentageDiscount.ReadOnly = true;
            this.CPercentageDiscount.Width = 125;
            // 
            // CExpr1
            // 
            this.CExpr1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CExpr1.DataPropertyName = "Expr1";
            this.CExpr1.HeaderText = "Metodo de Pago";
            this.CExpr1.MinimumWidth = 6;
            this.CExpr1.Name = "CExpr1";
            this.CExpr1.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 364);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1109, 247);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1109, 247);
            this.panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtUnitaryPrice);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.TxtProductName);
            this.groupBox1.Controls.Add(this.TxtIDProduct);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TxtSupplier);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TxtDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmetpag);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtbuytype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtPrecioFinal);
            this.groupBox1.Controls.Add(this.TxtCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1094, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Factura";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteForever);
            this.panel4.Controls.Add(this.btnactivate);
            this.panel4.Controls.Add(this.BtnCancelC);
            this.panel4.Controls.Add(this.BtnCleanC);
            this.panel4.Controls.Add(this.BtnAddCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 615);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1109, 62);
            this.panel4.TabIndex = 3;
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Location = new System.Drawing.Point(410, 5);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(169, 54);
            this.btnDeleteForever.TabIndex = 16;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(7, 2);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(169, 54);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            // 
            // BtnCancelC
            // 
            this.BtnCancelC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelC.Location = new System.Drawing.Point(664, 6);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(169, 54);
            this.BtnCancelC.TabIndex = 14;
            this.BtnCancelC.Text = "Cancel";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            // 
            // BtnCleanC
            // 
            this.BtnCleanC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCleanC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCleanC.Location = new System.Drawing.Point(208, 5);
            this.BtnCleanC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCleanC.Name = "BtnCleanC";
            this.BtnCleanC.Size = new System.Drawing.Size(169, 54);
            this.BtnCleanC.TabIndex = 11;
            this.BtnCleanC.Text = "Limpiar";
            this.BtnCleanC.UseVisualStyleBackColor = false;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddCustomer.Location = new System.Drawing.Point(7, 2);
            this.BtnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(169, 54);
            this.BtnAddCustomer.TabIndex = 8;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            // 
            // txtUnitaryPrice
            // 
            this.txtUnitaryPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitaryPrice.Location = new System.Drawing.Point(351, 174);
            this.txtUnitaryPrice.Name = "txtUnitaryPrice";
            this.txtUnitaryPrice.Size = new System.Drawing.Size(119, 30);
            this.txtUnitaryPrice.TabIndex = 63;
            this.txtUnitaryPrice.Text = "0";
            this.txtUnitaryPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(348, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "Precio Costo Unitario";
            // 
            // TxtProductName
            // 
            this.TxtProductName.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtProductName.Location = new System.Drawing.Point(238, 53);
            this.TxtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.ReadOnly = true;
            this.TxtProductName.Size = new System.Drawing.Size(232, 30);
            this.TxtProductName.TabIndex = 61;
            this.TxtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtIDProduct
            // 
            this.TxtIDProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtIDProduct.Location = new System.Drawing.Point(238, 21);
            this.TxtIDProduct.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDProduct.Name = "TxtIDProduct";
            this.TxtIDProduct.ReadOnly = true;
            this.TxtIDProduct.Size = new System.Drawing.Size(113, 30);
            this.TxtIDProduct.TabIndex = 60;
            this.TxtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 59;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(170, 21);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Codigo:";
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSupplier.BackColor = System.Drawing.Color.Moccasin;
            this.TxtSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSupplier.FormattingEnabled = true;
            this.TxtSupplier.Location = new System.Drawing.Point(708, 27);
            this.TxtSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplier.MaximumSize = new System.Drawing.Size(229, 0);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Size = new System.Drawing.Size(228, 33);
            this.TxtSupplier.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(557, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Proveedor:";
            // 
            // TxtDate
            // 
            this.TxtDate.AutoSize = true;
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(812, 182);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(60, 22);
            this.TxtDate.TabIndex = 55;
            this.TxtDate.Text = "Fecha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(585, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 54;
            this.label7.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(708, 77);
            this.TxtNotas.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(311, 83);
            this.TxtNotas.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 112);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "Metodo de pago:";
            // 
            // txtmetpag
            // 
            this.txtmetpag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmetpag.BackColor = System.Drawing.Color.Moccasin;
            this.txtmetpag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtmetpag.FormattingEnabled = true;
            this.txtmetpag.Location = new System.Drawing.Point(299, 106);
            this.txtmetpag.Margin = new System.Windows.Forms.Padding(2);
            this.txtmetpag.MaximumSize = new System.Drawing.Size(229, 0);
            this.txtmetpag.Name = "txtmetpag";
            this.txtmetpag.Size = new System.Drawing.Size(228, 33);
            this.txtmetpag.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tipo de Compra:";
            // 
            // txtbuytype
            // 
            this.txtbuytype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbuytype.BackColor = System.Drawing.Color.Moccasin;
            this.txtbuytype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbuytype.FormattingEnabled = true;
            this.txtbuytype.Location = new System.Drawing.Point(299, 77);
            this.txtbuytype.Margin = new System.Windows.Forms.Padding(2);
            this.txtbuytype.MaximumSize = new System.Drawing.Size(229, 0);
            this.txtbuytype.Name = "txtbuytype";
            this.txtbuytype.Size = new System.Drawing.Size(228, 33);
            this.txtbuytype.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 48;
            this.label1.Text = "Precio Final";
            // 
            // TxtPrecioFinal
            // 
            this.TxtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioFinal.Location = new System.Drawing.Point(531, 174);
            this.TxtPrecioFinal.Name = "TxtPrecioFinal";
            this.TxtPrecioFinal.ReadOnly = true;
            this.TxtPrecioFinal.Size = new System.Drawing.Size(95, 30);
            this.TxtPrecioFinal.TabIndex = 47;
            this.TxtPrecioFinal.Text = "0";
            this.TxtPrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(186, 167);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(84, 41);
            this.TxtCantidad.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cantidad";
            // 
            // FrmBuysearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmBuysearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Compra";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DgCustList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBillingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPercentageDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CExpr1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Button BtnCleanC;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.TextBox txtUnitaryPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtIDProduct;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox TxtSupplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TxtDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtmetpag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtbuytype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPrecioFinal;
        private System.Windows.Forms.NumericUpDown TxtCantidad;
        private System.Windows.Forms.Label label6;
    }
}