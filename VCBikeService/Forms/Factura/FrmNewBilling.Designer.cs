namespace VCBikeService.Forms.Factura
{
    partial class FrmNewBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewBilling));
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DgCustList = new System.Windows.Forms.DataGridView();
            this.CBillingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPercentageDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CExpr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIDproduct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtnameproduct = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtTypeBilling = new System.Windows.Forms.TextBox();
            this.TxtMethodPague = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtIDBilling = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCustomer.Location = new System.Drawing.Point(109, 16);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(311, 26);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar";
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
            this.DgCustList.Size = new System.Drawing.Size(936, 648);
            this.DgCustList.TabIndex = 4;
            this.DgCustList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCustList_CellClick);
            // 
            // CBillingID
            // 
            this.CBillingID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CBillingID.DataPropertyName = "BillingID";
            this.CBillingID.HeaderText = "Cod.Factura";
            this.CBillingID.MinimumWidth = 6;
            this.CBillingID.Name = "CBillingID";
            this.CBillingID.ReadOnly = true;
            // 
            // CCustomerName
            // 
            this.CCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerName.DataPropertyName = "CustomerName";
            this.CCustomerName.HeaderText = "Nombre Cliente";
            this.CCustomerName.MinimumWidth = 6;
            this.CCustomerName.Name = "CCustomerName";
            this.CCustomerName.ReadOnly = true;
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
            this.CDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Tipo de Factura";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
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
            this.CAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CAmount.DataPropertyName = "Amount";
            this.CAmount.HeaderText = "Cant.Productos";
            this.CAmount.MinimumWidth = 6;
            this.CAmount.Name = "CAmount";
            this.CAmount.ReadOnly = true;
            // 
            // CPercentageDiscount
            // 
            this.CPercentageDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CPercentageDiscount.DataPropertyName = "PercentageDiscount";
            this.CPercentageDiscount.HeaderText = "Descuento";
            this.CPercentageDiscount.MinimumWidth = 6;
            this.CPercentageDiscount.Name = "CPercentageDiscount";
            this.CPercentageDiscount.ReadOnly = true;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.TxtCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(443, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Participantes";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(176, 76);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.ReadOnly = true;
            this.TxtUser.Size = new System.Drawing.Size(252, 26);
            this.TxtUser.TabIndex = 28;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(176, 27);
            this.TxtCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.ReadOnly = true;
            this.TxtCustomer.Size = new System.Drawing.Size(252, 26);
            this.TxtCustomer.TabIndex = 27;
            this.TxtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente:";
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(-441, -27);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(169, 54);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddCustomer.Location = new System.Drawing.Point(-441, -27);
            this.BtnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(169, 54);
            this.BtnAddCustomer.TabIndex = 8;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = false; 
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1403, 730);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 455F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1397, 654);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel10, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(945, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.871244F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.12875F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(449, 648);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Controls.Add(this.TxtSearchCustomer);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(443, 57);
            this.panel9.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.groupBox4);
            this.panel10.Controls.Add(this.groupBox3);
            this.panel10.Controls.Add(this.groupBox2);
            this.panel10.Controls.Add(this.groupBox1);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(3, 66);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(443, 579);
            this.panel10.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.TxtTotal);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 480);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(443, 133);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Totalidad";
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(176, 39);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(252, 35);
            this.TxtTotal.TabIndex = 29;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtIDproduct);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.txtnameproduct);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 347);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(443, 133);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos";
            // 
            // txtIDproduct
            // 
            this.txtIDproduct.Location = new System.Drawing.Point(176, 63);
            this.txtIDproduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDproduct.Name = "txtIDproduct";
            this.txtIDproduct.ReadOnly = true;
            this.txtIDproduct.Size = new System.Drawing.Size(252, 26);
            this.txtIDproduct.TabIndex = 43;
            this.txtIDproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "ID:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(176, 107);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.ReadOnly = true;
            this.txtCantidad.Size = new System.Drawing.Size(252, 26);
            this.txtCantidad.TabIndex = 38;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnameproduct
            // 
            this.txtnameproduct.Location = new System.Drawing.Point(176, 25);
            this.txtnameproduct.Margin = new System.Windows.Forms.Padding(2);
            this.txtnameproduct.Name = "txtnameproduct";
            this.txtnameproduct.ReadOnly = true;
            this.txtnameproduct.Size = new System.Drawing.Size(252, 26);
            this.txtnameproduct.TabIndex = 41;
            this.txtnameproduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Productos Facturados:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Nombre Producto:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.TxtDate);
            this.groupBox2.Controls.Add(this.TxtTypeBilling);
            this.groupBox2.Controls.Add(this.TxtMethodPague);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.TxtIDBilling);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(443, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Factura";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(176, 76);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(252, 26);
            this.TxtDate.TabIndex = 32;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTypeBilling
            // 
            this.TxtTypeBilling.Location = new System.Drawing.Point(176, 168);
            this.TxtTypeBilling.Margin = new System.Windows.Forms.Padding(2);
            this.TxtTypeBilling.Name = "TxtTypeBilling";
            this.TxtTypeBilling.ReadOnly = true;
            this.TxtTypeBilling.Size = new System.Drawing.Size(252, 26);
            this.TxtTypeBilling.TabIndex = 31;
            this.TxtTypeBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtMethodPague
            // 
            this.TxtMethodPague.Location = new System.Drawing.Point(176, 126);
            this.TxtMethodPague.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMethodPague.Name = "TxtMethodPague";
            this.TxtMethodPague.ReadOnly = true;
            this.TxtMethodPague.Size = new System.Drawing.Size(252, 26);
            this.TxtMethodPague.TabIndex = 30;
            this.TxtMethodPague.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Tipo de Factura:";
            // 
            // TxtIDBilling
            // 
            this.TxtIDBilling.Location = new System.Drawing.Point(176, 25);
            this.TxtIDBilling.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDBilling.Name = "TxtIDBilling";
            this.TxtIDBilling.ReadOnly = true;
            this.TxtIDBilling.Size = new System.Drawing.Size(252, 26);
            this.TxtIDBilling.TabIndex = 22;
            this.TxtIDBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 126);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Metodo de Pago:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 35);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Codigo:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 76);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Fecha:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.DgCustList);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(936, 648);
            this.panel8.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.BtnClean);
            this.panel12.Controls.Add(this.BtnCancelC);
            this.panel12.Controls.Add(this.btnDeleteForever);
            this.panel12.Controls.Add(this.btnactivate);
            this.panel12.Controls.Add(this.BtnAddCustomer);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 663);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1397, 64);
            this.panel12.TabIndex = 1;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Image = ((System.Drawing.Image)(resources.GetObject("BtnClean.Image")));
            this.BtnClean.Location = new System.Drawing.Point(1057, 0);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(171, 64);
            this.BtnClean.TabIndex = 19;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnClean.UseVisualStyleBackColor = false;
            // 
            // BtnCancelC
            // 
            this.BtnCancelC.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelC.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelC.Location = new System.Drawing.Point(1228, 0);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(169, 64);
            this.BtnCancelC.TabIndex = 18;
            this.BtnCancelC.Text = "Cancel";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(169, 64);
            this.btnDeleteForever.TabIndex = 17;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            // 
            // FrmNewBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 730);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewBilling";
            this.Text = "Buscar Factura ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmNewBilling_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmNewBilling_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DgCustList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtTypeBilling;
        private System.Windows.Forms.TextBox TxtMethodPague;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtIDBilling;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBillingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPercentageDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CExpr1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDproduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtnameproduct;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.TextBox TxtDate;
    }
}