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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CheckCustomer = new System.Windows.Forms.CheckBox();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgCustList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtCustomer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtIDBilling = new System.Windows.Forms.TextBox();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.BtnDeleteC = new System.Windows.Forms.Button();
            this.BtnCleanC = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.CBillingID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPercentageDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CExpr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtMethodPague = new System.Windows.Forms.TextBox();
            this.TxtTypeBilling = new System.Windows.Forms.TextBox();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, -2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 309F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1484, 836);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.CheckCustomer.Location = new System.Drawing.Point(1085, 17);
            this.CheckCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckCustomer.Name = "CheckCustomer";
            this.CheckCustomer.Size = new System.Drawing.Size(129, 29);
            this.CheckCustomer.TabIndex = 13;
            this.CheckCustomer.Text = " Ver Activo";
            this.CheckCustomer.UseVisualStyleBackColor = true;
            this.CheckCustomer.CheckedChanged += new System.EventHandler(this.CheckCustomer_CheckedChanged);
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
            this.panel5.Controls.Add(this.DgCustList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1478, 373);
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
            this.DgCustList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgCustList.MultiSelect = false;
            this.DgCustList.Name = "DgCustList";
            this.DgCustList.ReadOnly = true;
            this.DgCustList.RowHeadersVisible = false;
            this.DgCustList.RowHeadersWidth = 62;
            this.DgCustList.RowTemplate.Height = 28;
            this.DgCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustList.Size = new System.Drawing.Size(1478, 373);
            this.DgCustList.TabIndex = 4;
            this.DgCustList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCustList_CellClick);
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
            this.groupBox1.Controls.Add(this.TxtTypeBilling);
            this.groupBox1.Controls.Add(this.TxtMethodPague);
            this.groupBox1.Controls.Add(this.TxtTotal);
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.TxtCustomer);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtIDBilling);
            this.groupBox1.Controls.Add(this.TxtDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1459, 299);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Factura";
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(179, 231);
            this.TxtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.ReadOnly = true;
            this.TxtUser.Size = new System.Drawing.Size(349, 30);
            this.TxtUser.TabIndex = 28;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomer
            // 
            this.TxtCustomer.Location = new System.Drawing.Point(179, 171);
            this.TxtCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtCustomer.Name = "TxtCustomer";
            this.TxtCustomer.ReadOnly = true;
            this.TxtCustomer.Size = new System.Drawing.Size(349, 30);
            this.TxtCustomer.TabIndex = 27;
            this.TxtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(681, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo de Factura:";
            // 
            // TxtIDBilling
            // 
            this.TxtIDBilling.Location = new System.Drawing.Point(268, 100);
            this.TxtIDBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtIDBilling.Name = "TxtIDBilling";
            this.TxtIDBilling.ReadOnly = true;
            this.TxtIDBilling.Size = new System.Drawing.Size(349, 30);
            this.TxtIDBilling.TabIndex = 22;
            this.TxtIDBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtDate
            // 
            this.TxtDate.Location = new System.Drawing.Point(179, 44);
            this.TxtDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.ReadOnly = true;
            this.TxtDate.Size = new System.Drawing.Size(349, 30);
            this.TxtDate.TabIndex = 21;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(681, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Metodo de Pago:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(843, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 103);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(152, 25);
            this.label18.TabIndex = 11;
            this.label18.Text = "Codigo Factura:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(39, 44);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(73, 25);
            this.label19.TabIndex = 10;
            this.label19.Text = "Fecha:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteForever);
            this.panel4.Controls.Add(this.btnactivate);
            this.panel4.Controls.Add(this.BtnCancelC);
            this.panel4.Controls.Add(this.BtnDeleteC);
            this.panel4.Controls.Add(this.BtnCleanC);
            this.panel4.Controls.Add(this.BtnAddCustomer);
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
            this.btnDeleteForever.Location = new System.Drawing.Point(547, 6);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(225, 66);
            this.btnDeleteForever.TabIndex = 16;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            this.btnDeleteForever.Click += new System.EventHandler(this.btnDeleteForever_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(9, 2);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(225, 66);
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
            this.BtnCancelC.Location = new System.Drawing.Point(1221, 2);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(225, 66);
            this.BtnCancelC.TabIndex = 14;
            this.BtnCancelC.Text = "Cancel";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            this.BtnCancelC.Click += new System.EventHandler(this.BtnCancelC_Click);
            // 
            // BtnDeleteC
            // 
            this.BtnDeleteC.BackColor = System.Drawing.Color.Goldenrod;
            this.BtnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteC.Location = new System.Drawing.Point(947, 2);
            this.BtnDeleteC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDeleteC.Name = "BtnDeleteC";
            this.BtnDeleteC.Size = new System.Drawing.Size(225, 66);
            this.BtnDeleteC.TabIndex = 13;
            this.BtnDeleteC.Text = "Desactivar";
            this.BtnDeleteC.UseVisualStyleBackColor = false;
            this.BtnDeleteC.Click += new System.EventHandler(this.BtnDeleteC_Click);
            // 
            // BtnCleanC
            // 
            this.BtnCleanC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCleanC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCleanC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCleanC.Location = new System.Drawing.Point(277, 6);
            this.BtnCleanC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCleanC.Name = "BtnCleanC";
            this.BtnCleanC.Size = new System.Drawing.Size(225, 66);
            this.BtnCleanC.TabIndex = 11;
            this.BtnCleanC.Text = "Limpiar";
            this.BtnCleanC.UseVisualStyleBackColor = false;
            this.BtnCleanC.Click += new System.EventHandler(this.BtnCleanC_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddCustomer.Location = new System.Drawing.Point(9, 2);
            this.BtnAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(225, 66);
            this.BtnAddCustomer.TabIndex = 8;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(938, 200);
            this.TxtTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(349, 41);
            this.TxtTotal.TabIndex = 29;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // TxtMethodPague
            // 
            this.TxtMethodPague.Location = new System.Drawing.Point(922, 31);
            this.TxtMethodPague.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtMethodPague.Name = "TxtMethodPague";
            this.TxtMethodPague.ReadOnly = true;
            this.TxtMethodPague.Size = new System.Drawing.Size(349, 30);
            this.TxtMethodPague.TabIndex = 30;
            this.TxtMethodPague.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTypeBilling
            // 
            this.TxtTypeBilling.Location = new System.Drawing.Point(922, 82);
            this.TxtTypeBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TxtTypeBilling.Name = "TxtTypeBilling";
            this.TxtTypeBilling.ReadOnly = true;
            this.TxtTypeBilling.Size = new System.Drawing.Size(349, 30);
            this.TxtTypeBilling.TabIndex = 31;
            this.TxtTypeBilling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmNewBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 833);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNewBilling";
            this.Text = "FrmNewBilling";
            this.Load += new System.EventHandler(this.FrmNewBilling_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox CheckCustomer;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DgCustList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Button BtnDeleteC;
        private System.Windows.Forms.Button BtnCleanC;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtIDBilling;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBillingID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPercentageDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CExpr1;
        private System.Windows.Forms.TextBox TxtTypeBilling;
        private System.Windows.Forms.TextBox TxtMethodPague;
    }
}