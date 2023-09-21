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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BtnClean = new System.Windows.Forms.Button();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.BtnCancelC = new System.Windows.Forms.Button();
            this.BtnDeleteC = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnEditC = new System.Windows.Forms.Button();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgCustList = new System.Windows.Forms.DataGridView();
            this.CCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCardID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.CheckCustomer = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 664);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1412, 71);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1412, 71);
            this.panel5.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BtnClean);
            this.panel6.Controls.Add(this.btnDeleteForever);
            this.panel6.Controls.Add(this.BtnCancelC);
            this.panel6.Controls.Add(this.BtnDeleteC);
            this.panel6.Controls.Add(this.btnactivate);
            this.panel6.Controls.Add(this.BtnEditC);
            this.panel6.Controls.Add(this.BtnAddCustomer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1412, 71);
            this.panel6.TabIndex = 0;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Image = ((System.Drawing.Image)(resources.GetObject("BtnClean.Image")));
            this.BtnClean.Location = new System.Drawing.Point(1072, 0);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(171, 71);
            this.BtnClean.TabIndex = 17;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteForever.Image")));
            this.btnDeleteForever.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteForever.Location = new System.Drawing.Point(722, 0);
            this.btnDeleteForever.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(203, 71);
            this.btnDeleteForever.TabIndex = 16;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            this.btnDeleteForever.Visible = false;
            this.btnDeleteForever.Click += new System.EventHandler(this.btnDeleteForever_Click);
            // 
            // BtnCancelC
            // 
            this.BtnCancelC.BackColor = System.Drawing.Color.Salmon;
            this.BtnCancelC.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCancelC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancelC.Location = new System.Drawing.Point(1243, 0);
            this.BtnCancelC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancelC.Name = "BtnCancelC";
            this.BtnCancelC.Size = new System.Drawing.Size(169, 71);
            this.BtnCancelC.TabIndex = 14;
            this.BtnCancelC.Text = "Cerrar ";
            this.BtnCancelC.UseVisualStyleBackColor = false;
            this.BtnCancelC.Click += new System.EventHandler(this.BtnCancelC_Click);
            // 
            // BtnDeleteC
            // 
            this.BtnDeleteC.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteC.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnDeleteC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteC.Location = new System.Drawing.Point(553, 0);
            this.BtnDeleteC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteC.Name = "BtnDeleteC";
            this.BtnDeleteC.Size = new System.Drawing.Size(169, 71);
            this.BtnDeleteC.TabIndex = 13;
            this.BtnDeleteC.Text = "Inactivar";
            this.BtnDeleteC.UseVisualStyleBackColor = false;
            this.BtnDeleteC.Click += new System.EventHandler(this.BtnDeleteC_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(384, 0);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(169, 71);
            this.btnactivate.TabIndex = 15;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // BtnEditC
            // 
            this.BtnEditC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEditC.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEditC.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditC.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEditC.Location = new System.Drawing.Point(215, 0);
            this.BtnEditC.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEditC.Name = "BtnEditC";
            this.BtnEditC.Size = new System.Drawing.Size(169, 71);
            this.BtnEditC.TabIndex = 12;
            this.BtnEditC.Text = "Modificar";
            this.BtnEditC.UseVisualStyleBackColor = false;
            this.BtnEditC.Click += new System.EventHandler(this.BtnEditC_Click);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAddCustomer.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddCustomer.Image")));
            this.BtnAddCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddCustomer.Location = new System.Drawing.Point(0, 0);
            this.BtnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(215, 71);
            this.BtnAddCustomer.TabIndex = 8;
            this.BtnAddCustomer.Text = "Agregar";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.02837F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.97163F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1410, 656);
            this.tableLayoutPanel2.TabIndex = 5;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgCustList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 650);
            this.panel1.TabIndex = 1;
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
            this.DgCustList.Size = new System.Drawing.Size(925, 650);
            this.DgCustList.TabIndex = 5;
            // 
            // CCustomerID
            // 
            this.CCustomerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerID.DataPropertyName = "CustomerID";
            this.CCustomerID.HeaderText = "Cod.Cliente";
            this.CCustomerID.MinimumWidth = 6;
            this.CCustomerID.Name = "CCustomerID";
            this.CCustomerID.ReadOnly = true;
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
            this.CCustomerEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerEmail.DataPropertyName = "CustomerEmail";
            this.CCustomerEmail.HeaderText = "Correo";
            this.CCustomerEmail.MinimumWidth = 6;
            this.CCustomerEmail.Name = "CCustomerEmail";
            this.CCustomerEmail.ReadOnly = true;
            // 
            // CCustomerPhone
            // 
            this.CCustomerPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerPhone.DataPropertyName = "CustomerPhone";
            this.CCustomerPhone.HeaderText = "Celular";
            this.CCustomerPhone.MinimumWidth = 6;
            this.CCustomerPhone.Name = "CCustomerPhone";
            this.CCustomerPhone.ReadOnly = true;
            // 
            // CCustomerAdress
            // 
            this.CCustomerAdress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CCustomerAdress.DataPropertyName = "CustomerAdress";
            this.CCustomerAdress.HeaderText = "Direccion";
            this.CCustomerAdress.MinimumWidth = 6;
            this.CCustomerAdress.Name = "CCustomerAdress";
            this.CCustomerAdress.ReadOnly = true;
            // 
            // CDescription
            // 
            this.CDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Tipo";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(934, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 650);
            this.panel3.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 42);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(473, 608);
            this.panel7.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.TxtCardID);
            this.groupBox1.Controls.Add(this.label17);
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
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(473, 608);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Cliente";
            // 
            // TxtCardID
            // 
            this.TxtCardID.Location = new System.Drawing.Point(155, 221);
            this.TxtCardID.Name = "TxtCardID";
            this.TxtCardID.Size = new System.Drawing.Size(329, 29);
            this.TxtCardID.TabIndex = 22;
            this.TxtCardID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(56, 221);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Cedula:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 342);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 283);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 407);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Direcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Telefono:";
            // 
            // CbTypeCustomer
            // 
            this.CbTypeCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTypeCustomer.FormattingEnabled = true;
            this.CbTypeCustomer.Location = new System.Drawing.Point(157, 339);
            this.CbTypeCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CbTypeCustomer.Name = "CbTypeCustomer";
            this.CbTypeCustomer.Size = new System.Drawing.Size(329, 32);
            this.CbTypeCustomer.TabIndex = 16;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(157, 283);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(329, 29);
            this.TxtCustomerEmail.TabIndex = 15;
            this.TxtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Location = new System.Drawing.Point(157, 403);
            this.TxtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(327, 29);
            this.TxtCustomerAddress.TabIndex = 14;
            this.TxtCustomerAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPhonesCustomer
            // 
            this.TxtPhonesCustomer.Location = new System.Drawing.Point(157, 156);
            this.TxtPhonesCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPhonesCustomer.Name = "TxtPhonesCustomer";
            this.TxtPhonesCustomer.Size = new System.Drawing.Size(327, 29);
            this.TxtPhonesCustomer.TabIndex = 13;
            this.TxtPhonesCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(155, 97);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(329, 29);
            this.TxtCustomerName.TabIndex = 12;
            this.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(58, 101);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 24);
            this.label18.TabIndex = 11;
            this.label18.Text = "Nombre:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(58, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 24);
            this.label19.TabIndex = 10;
            this.label19.Text = "Codigo:";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.TxtCustomerID.Location = new System.Drawing.Point(155, 53);
            this.TxtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.ReadOnly = true;
            this.TxtCustomerID.Size = new System.Drawing.Size(327, 29);
            this.TxtCustomerID.TabIndex = 9;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TxtSearchCustomer);
            this.panel4.Controls.Add(this.CheckCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(473, 42);
            this.panel4.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Buscar";
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchCustomer.Location = new System.Drawing.Point(73, 10);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(399, 26);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckCustomer
            // 
            this.CheckCustomer.AutoSize = true;
            this.CheckCustomer.Checked = true;
            this.CheckCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckCustomer.Location = new System.Drawing.Point(478, 13);
            this.CheckCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.CheckCustomer.Name = "CheckCustomer";
            this.CheckCustomer.Size = new System.Drawing.Size(71, 24);
            this.CheckCustomer.TabIndex = 13;
            this.CheckCustomer.Text = "Activo";
            this.CheckCustomer.UseVisualStyleBackColor = true;
            this.CheckCustomer.CheckedChanged += new System.EventHandler(this.CheckCustomer_CheckedChanged_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.9593F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.04071F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1416, 737);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1416, 737);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmClientes_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Button BtnCancelC;
        private System.Windows.Forms.Button BtnDeleteC;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.Button BtnEditC;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DgCustList;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.CheckBox CheckCustomer;
        private System.Windows.Forms.TextBox TxtCardID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
    }
}