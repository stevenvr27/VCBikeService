namespace VCBikeService.Forms.Clientes
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.CheckCustomer = new System.Windows.Forms.CheckBox();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DgCustList = new System.Windows.Forms.DataGridView();
            this.CCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTypeCustomer = new System.Windows.Forms.ComboBox();
            this.TxtCustomerEmail = new System.Windows.Forms.TextBox();
            this.TxtCustomerAddress = new System.Windows.Forms.TextBox();
            this.TxtPhonesCustomer = new System.Windows.Forms.TextBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.BtnDeleteC = new System.Windows.Forms.Button();
            this.BtnEditC = new System.Windows.Forms.Button();
            this.BtnCleanC = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.55556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1033, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 49);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.CheckCustomer);
            this.panel7.Controls.Add(this.TxtSearchCustomer);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1029, 49);
            this.panel7.TabIndex = 0;
            // 
            // CheckCustomer
            // 
            this.CheckCustomer.AutoSize = true;
            this.CheckCustomer.Checked = true;
            this.CheckCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCustomer.Location = new System.Drawing.Point(814, 14);
            this.CheckCustomer.Margin = new System.Windows.Forms.Padding(2);
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
            this.panel2.Location = new System.Drawing.Point(2, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 289);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DgCustList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1029, 289);
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
            this.CCustomerID,
            this.CCustomerName,
            this.CCustomerEmail,
            this.CCustomerPhone,
            this.CCustomerAdress,
            this.CDescription});
            this.DgCustList.Location = new System.Drawing.Point(9, 0);
            this.DgCustList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgCustList.MultiSelect = false;
            this.DgCustList.Name = "DgCustList";
            this.DgCustList.ReadOnly = true;
            this.DgCustList.RowHeadersVisible = false;
            this.DgCustList.RowHeadersWidth = 62;
            this.DgCustList.RowTemplate.Height = 28;
            this.DgCustList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustList.Size = new System.Drawing.Size(1019, 289);
            this.DgCustList.TabIndex = 4;
            this.DgCustList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCustList_CellClick);
            // 
            // CCustomerID
            // 
            this.CCustomerID.DataPropertyName = "CustomerID";
            this.CCustomerID.HeaderText = "Cod.Cliente";
            this.CCustomerID.MinimumWidth = 6;
            this.CCustomerID.Name = "CCustomerID";
            this.CCustomerID.ReadOnly = true;
            this.CCustomerID.Width = 200;
            // 
            // CCustomerName
            // 
            this.CCustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerName.DataPropertyName = "CustomerName";
            this.CCustomerName.HeaderText = "Nombre";
            this.CCustomerName.MinimumWidth = 6;
            this.CCustomerName.Name = "CCustomerName";
            this.CCustomerName.ReadOnly = true;
            // 
            // CCustomerEmail
            // 
            this.CCustomerEmail.DataPropertyName = "CustomerEmail";
            this.CCustomerEmail.HeaderText = "Correo";
            this.CCustomerEmail.MinimumWidth = 6;
            this.CCustomerEmail.Name = "CCustomerEmail";
            this.CCustomerEmail.ReadOnly = true;
            this.CCustomerEmail.Width = 210;
            // 
            // CCustomerPhone
            // 
            this.CCustomerPhone.DataPropertyName = "CustomerPhone";
            this.CCustomerPhone.HeaderText = "Celular";
            this.CCustomerPhone.MinimumWidth = 6;
            this.CCustomerPhone.Name = "CCustomerPhone";
            this.CCustomerPhone.ReadOnly = true;
            this.CCustomerPhone.Width = 150;
            // 
            // CCustomerAdress
            // 
            this.CCustomerAdress.DataPropertyName = "CustomerAdress";
            this.CCustomerAdress.HeaderText = "Direccion";
            this.CCustomerAdress.MinimumWidth = 6;
            this.CCustomerAdress.Name = "CCustomerAdress";
            this.CCustomerAdress.ReadOnly = true;
            this.CCustomerAdress.Width = 125;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Tipo";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 130;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 348);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 178);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.groupBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1029, 178);
            this.panel6.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CbTypeCustomer);
            this.groupBox1.Controls.Add(this.TxtCustomerEmail);
            this.groupBox1.Controls.Add(this.TxtCustomerAddress);
            this.groupBox1.Controls.Add(this.TxtPhonesCustomer);
            this.groupBox1.Controls.Add(this.TxtCustomerName);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.TxtCustomerID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(998, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(585, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(585, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Direcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 124);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefono:";
            // 
            // CbTypeCustomer
            // 
            this.CbTypeCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTypeCustomer.FormattingEnabled = true;
            this.CbTypeCustomer.Location = new System.Drawing.Point(694, 124);
            this.CbTypeCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CbTypeCustomer.Name = "CbTypeCustomer";
            this.CbTypeCustomer.Size = new System.Drawing.Size(294, 37);
            this.CbTypeCustomer.TabIndex = 16;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(694, 76);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(294, 34);
            this.TxtCustomerEmail.TabIndex = 15;
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Location = new System.Drawing.Point(694, 23);
            this.TxtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(294, 34);
            this.TxtCustomerAddress.TabIndex = 14;
            // 
            // TxtPhonesCustomer
            // 
            this.TxtPhonesCustomer.Location = new System.Drawing.Point(166, 121);
            this.TxtPhonesCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPhonesCustomer.Name = "TxtPhonesCustomer";
            this.TxtPhonesCustomer.Size = new System.Drawing.Size(342, 34);
            this.TxtPhonesCustomer.TabIndex = 13;
            this.TxtPhonesCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhonesCustomer_KeyPress);
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(134, 77);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(342, 34);
            this.TxtCustomerName.TabIndex = 12;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(29, 76);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 29);
            this.label18.TabIndex = 11;
            this.label18.Text = "Nombre:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 36);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 29);
            this.label19.TabIndex = 10;
            this.label19.Text = "Codigo Cliente:";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.Location = new System.Drawing.Point(215, 31);
            this.TxtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.ReadOnly = true;
            this.TxtCustomerID.Size = new System.Drawing.Size(163, 34);
            this.TxtCustomerID.TabIndex = 9;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDeleteForever);
            this.panel4.Controls.Add(this.btnactivate);
            this.panel4.Controls.Add(this.BtnCancelC);
            this.panel4.Controls.Add(this.BtnDeleteC);
            this.panel4.Controls.Add(this.BtnEditC);
            this.panel4.Controls.Add(this.BtnCleanC);
            this.panel4.Controls.Add(this.BtnAddCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 530);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1029, 62);
            this.panel4.TabIndex = 3;
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Location = new System.Drawing.Point(208, 5);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(169, 54);
            this.btnDeleteForever.TabIndex = 16;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            this.btnDeleteForever.Visible = false;
            this.btnDeleteForever.Click += new System.EventHandler(this.btnDeleteForever_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(8, 2);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(169, 54);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // BtnCancelC
            // 
            this.BtnCancelC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelC.Location = new System.Drawing.Point(826, 6);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(169, 54);
            this.BtnCancelC.TabIndex = 14;
            this.BtnCancelC.Text = "Cancel";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            this.BtnCancelC.Click += new System.EventHandler(this.BtnCancelC_Click);
            // 
            // BtnDeleteC
            // 
            this.BtnDeleteC.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteC.Location = new System.Drawing.Point(616, 6);
            this.BtnDeleteC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteC.Name = "BtnDeleteC";
            this.BtnDeleteC.Size = new System.Drawing.Size(169, 54);
            this.BtnDeleteC.TabIndex = 13;
            this.BtnDeleteC.Text = "Eliminar";
            this.BtnDeleteC.UseVisualStyleBackColor = false;
            this.BtnDeleteC.Click += new System.EventHandler(this.BtnDeleteC_Click);
            // 
            // BtnEditC
            // 
            this.BtnEditC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditC.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEditC.Location = new System.Drawing.Point(404, 5);
            this.BtnEditC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditC.Name = "BtnEditC";
            this.BtnEditC.Size = new System.Drawing.Size(169, 54);
            this.BtnEditC.TabIndex = 12;
            this.BtnEditC.Text = "Modificar";
            this.BtnEditC.UseVisualStyleBackColor = false;
            this.BtnEditC.Click += new System.EventHandler(this.BtnEditC_Click);
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
            this.BtnCleanC.Click += new System.EventHandler(this.BtnCleanC_Click);
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
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1034, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1052, 641);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1052, 641);
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Clientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyUp);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnCleanC;
        private System.Windows.Forms.Button BtnEditC;
        private System.Windows.Forms.Button BtnDeleteC;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbTypeCustomer;
        private System.Windows.Forms.TextBox TxtCustomerEmail;
        private System.Windows.Forms.TextBox TxtCustomerAddress;
        private System.Windows.Forms.TextBox TxtPhonesCustomer;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.CheckBox CheckCustomer;
        private System.Windows.Forms.DataGridView DgCustList;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
    }
}