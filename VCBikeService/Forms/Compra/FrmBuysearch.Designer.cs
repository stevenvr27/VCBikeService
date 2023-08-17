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
            this.CheckCustomer = new System.Windows.Forms.CheckBox();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgBuys = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtitemname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIDbuy = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.BtnCleanC = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.CBuyID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNuevoArticulos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgBuys)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 836);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CheckCustomer);
            this.panel7.Controls.Add(this.TxtSearchCustomer);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1478, 65);
            this.panel7.TabIndex = 0;
            // 
            // CheckCustomer
            // 
            this.CheckCustomer.AutoSize = true;
            this.CheckCustomer.Checked = true;
            this.CheckCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCustomer.Location = new System.Drawing.Point(1088, 19);
            this.CheckCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckCustomer.Name = "CheckCustomer";
            this.CheckCustomer.Size = new System.Drawing.Size(129, 29);
            this.CheckCustomer.TabIndex = 14;
            this.CheckCustomer.Text = " Ver Activo";
            this.CheckCustomer.UseVisualStyleBackColor = true;
            this.CheckCustomer.CheckedChanged += new System.EventHandler(this.CheckCustomer_CheckedChanged_1);
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCustomer.Location = new System.Drawing.Point(163, 17);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(883, 30);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1478, 373);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DgBuys);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1478, 373);
            this.panel5.TabIndex = 0;
            // 
            // DgBuys
            // 
            this.DgBuys.AllowUserToAddRows = false;
            this.DgBuys.AllowUserToDeleteRows = false;
            this.DgBuys.AllowUserToOrderColumns = true;
            this.DgBuys.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgBuys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgBuys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CBuyID,
            this.CItemName,
            this.CItemID,
            this.CUnitaryPrice,
            this.CTotal,
            this.CNuevoArticulos,
            this.CStock});
            this.DgBuys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgBuys.Location = new System.Drawing.Point(0, 0);
            this.DgBuys.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgBuys.MultiSelect = false;
            this.DgBuys.Name = "DgBuys";
            this.DgBuys.ReadOnly = true;
            this.DgBuys.RowHeadersVisible = false;
            this.DgBuys.RowHeadersWidth = 62;
            this.DgBuys.RowTemplate.Height = 28;
            this.DgBuys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgBuys.Size = new System.Drawing.Size(1478, 373);
            this.DgBuys.TabIndex = 4;
            this.DgBuys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgBuys_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 448);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1478, 305);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1478, 305);
            this.panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtitemname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtDate);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtsupplier);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtIDbuy);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1459, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 22);
            this.label4.TabIndex = 89;
            this.label4.Text = "En Stock:";
            // 
            // txtstock
            // 
            this.txtstock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtstock.Location = new System.Drawing.Point(650, 175);
            this.txtstock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtstock.Name = "txtstock";
            this.txtstock.ReadOnly = true;
            this.txtstock.Size = new System.Drawing.Size(136, 30);
            this.txtstock.TabIndex = 88;
            this.txtstock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtcantidad.Location = new System.Drawing.Point(742, 89);
            this.txtcantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.ReadOnly = true;
            this.txtcantidad.Size = new System.Drawing.Size(136, 30);
            this.txtcantidad.TabIndex = 87;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Producto:";
            // 
            // txtitemname
            // 
            this.txtitemname.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtitemname.Location = new System.Drawing.Point(143, 187);
            this.txtitemname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtitemname.Name = "txtitemname";
            this.txtitemname.ReadOnly = true;
            this.txtitemname.Size = new System.Drawing.Size(308, 30);
            this.txtitemname.TabIndex = 83;
            this.txtitemname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Cantidad Agregada:";
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(717, 28);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(404, 30);
            this.TxtDate.TabIndex = 80;
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtUser.Location = new System.Drawing.Point(154, 128);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.ReadOnly = true;
            this.TxtUser.Size = new System.Drawing.Size(308, 30);
            this.TxtUser.TabIndex = 79;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 78;
            this.label3.Text = "Usuario:";
            // 
            // txtsupplier
            // 
            this.txtsupplier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtsupplier.Location = new System.Drawing.Point(154, 81);
            this.txtsupplier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.ReadOnly = true;
            this.txtsupplier.Size = new System.Drawing.Size(308, 30);
            this.txtsupplier.TabIndex = 77;
            this.txtsupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(528, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 75;
            this.label6.Text = "Fecha de Compra:";
            // 
            // TxtIDbuy
            // 
            this.TxtIDbuy.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtIDbuy.Location = new System.Drawing.Point(179, 36);
            this.TxtIDbuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIDbuy.Name = "TxtIDbuy";
            this.TxtIDbuy.ReadOnly = true;
            this.TxtIDbuy.Size = new System.Drawing.Size(149, 30);
            this.TxtIDbuy.TabIndex = 60;
            this.TxtIDbuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 25);
            this.label10.TabIndex = 58;
            this.label10.Text = "Codigo Compra:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 25);
            this.label8.TabIndex = 56;
            this.label8.Text = "Proveedor:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteForever);
            this.panel4.Controls.Add(this.BtnCancelC);
            this.panel4.Controls.Add(this.BtnCleanC);
            this.panel4.Controls.Add(this.Agregar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 757);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1478, 77);
            this.panel4.TabIndex = 3;
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Location = new System.Drawing.Point(700, 0);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(225, 66);
            this.btnDeleteForever.TabIndex = 16;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            this.btnDeleteForever.Click += new System.EventHandler(this.btnDeleteForever_Click);
            // 
            // BtnCancelC
            // 
            this.BtnCancelC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelC.Location = new System.Drawing.Point(1069, 9);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(225, 66);
            this.BtnCancelC.TabIndex = 14;
            this.BtnCancelC.Text = "Cancel";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            this.BtnCancelC.Click += new System.EventHandler(this.BtnCancelC_Click);
            // 
            // BtnCleanC
            // 
            this.BtnCleanC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCleanC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCleanC.Location = new System.Drawing.Point(328, 6);
            this.BtnCleanC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCleanC.Name = "BtnCleanC";
            this.BtnCleanC.Size = new System.Drawing.Size(225, 66);
            this.BtnCleanC.TabIndex = 11;
            this.BtnCleanC.Text = "Limpiar";
            this.BtnCleanC.UseVisualStyleBackColor = false;
            this.BtnCleanC.Click += new System.EventHandler(this.BtnCleanC_Click);
            // 
            // Agregar
            // 
            this.Agregar.BackColor = System.Drawing.Color.Cyan;
            this.Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Agregar.Location = new System.Drawing.Point(22, 6);
            this.Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(225, 66);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = false;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(873, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 90;
            this.label7.Text = "Total:";
            // 
            // txttotal
            // 
            this.txttotal.BackColor = System.Drawing.Color.Lime;
            this.txttotal.Location = new System.Drawing.Point(957, 226);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(195, 30);
            this.txttotal.TabIndex = 91;
            this.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 25);
            this.label9.TabIndex = 92;
            this.label9.Text = "Codigo Producto:";
            // 
            // txtcode
            // 
            this.txtcode.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtcode.Location = new System.Drawing.Point(196, 239);
            this.txtcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtcode.Name = "txtcode";
            this.txtcode.ReadOnly = true;
            this.txtcode.Size = new System.Drawing.Size(308, 30);
            this.txtcode.TabIndex = 93;
            this.txtcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CBuyID
            // 
            this.CBuyID.DataPropertyName = "BuyID";
            this.CBuyID.HeaderText = "Cod.Compra";
            this.CBuyID.MinimumWidth = 6;
            this.CBuyID.Name = "CBuyID";
            this.CBuyID.ReadOnly = true;
            this.CBuyID.Width = 125;
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre.Item";
            this.CItemName.MinimumWidth = 6;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            this.CItemName.Width = 125;
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Cod.item";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 125;
            // 
            // CUnitaryPrice
            // 
            this.CUnitaryPrice.DataPropertyName = "UnitaryPrice";
            this.CUnitaryPrice.HeaderText = "Precio de articulo";
            this.CUnitaryPrice.MinimumWidth = 6;
            this.CUnitaryPrice.Name = "CUnitaryPrice";
            this.CUnitaryPrice.ReadOnly = true;
            this.CUnitaryPrice.Width = 125;
            // 
            // CTotal
            // 
            this.CTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CTotal.DataPropertyName = "Total";
            this.CTotal.HeaderText = "Total";
            this.CTotal.MinimumWidth = 6;
            this.CTotal.Name = "CTotal";
            this.CTotal.ReadOnly = true;
            // 
            // CNuevoArticulos
            // 
            this.CNuevoArticulos.DataPropertyName = "NuevoArticulos";
            this.CNuevoArticulos.HeaderText = "Cantidad Agregada";
            this.CNuevoArticulos.MinimumWidth = 6;
            this.CNuevoArticulos.Name = "CNuevoArticulos";
            this.CNuevoArticulos.ReadOnly = true;
            this.CNuevoArticulos.Width = 125;
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
            // FrmBuysearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 843);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1493, 890);
            this.Name = "FrmBuysearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Compra";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmBuysearch_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgBuys)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.DataGridView DgBuys;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Button BtnCleanC;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.TextBox TxtIDbuy;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CheckCustomer;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtitemname;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBuyID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNuevoArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
    }
}