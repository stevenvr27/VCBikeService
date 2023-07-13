namespace VCBikeService.Forms
{
    partial class Frmsupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsupplier));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DgSupplier = new System.Windows.Forms.DataGridView();
            this.CSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDetail = new System.Windows.Forms.GroupBox();
            this.TxtCardID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSupplierPhone = new System.Windows.Forms.TextBox();
            this.CbSupplierType = new System.Windows.Forms.ComboBox();
            this.TxtSupplierAddress = new System.Windows.Forms.TextBox();
            this.TxtSupplierEmail = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.TxtIDSupplier = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBSupplier = new System.Windows.Forms.CheckBox();
            this.TxtSearchSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteForEver = new System.Windows.Forms.Button();
            this.btnactivate = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).BeginInit();
            this.userDetail.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgSupplier, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.userDetail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1108, 730);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DgSupplier
            // 
            this.DgSupplier.AllowUserToAddRows = false;
            this.DgSupplier.AllowUserToDeleteRows = false;
            this.DgSupplier.AllowUserToOrderColumns = true;
            this.DgSupplier.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CSupplierID,
            this.CSupplierName,
            this.CSupplierCardID,
            this.CSupplierEmail,
            this.CPhoneNumber,
            this.CAddress,
            this.CDescription});
            this.DgSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgSupplier.Location = new System.Drawing.Point(4, 59);
            this.DgSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgSupplier.MultiSelect = false;
            this.DgSupplier.Name = "DgSupplier";
            this.DgSupplier.ReadOnly = true;
            this.DgSupplier.RowHeadersVisible = false;
            this.DgSupplier.RowHeadersWidth = 62;
            this.DgSupplier.RowTemplate.Height = 28;
            this.DgSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSupplier.Size = new System.Drawing.Size(1100, 381);
            this.DgSupplier.TabIndex = 5;
            this.DgSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgSupplier_CellClick);
            // 
            // CSupplierID
            // 
            this.CSupplierID.DataPropertyName = "SupplierID";
            this.CSupplierID.HeaderText = "Cod.Proveedor";
            this.CSupplierID.MinimumWidth = 6;
            this.CSupplierID.Name = "CSupplierID";
            this.CSupplierID.ReadOnly = true;
            this.CSupplierID.Width = 200;
            // 
            // CSupplierName
            // 
            this.CSupplierName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CSupplierName.DataPropertyName = "SupplierName";
            this.CSupplierName.HeaderText = "Nombre";
            this.CSupplierName.MinimumWidth = 200;
            this.CSupplierName.Name = "CSupplierName";
            this.CSupplierName.ReadOnly = true;
            // 
            // CSupplierCardID
            // 
            this.CSupplierCardID.DataPropertyName = "SupplierCardID";
            this.CSupplierCardID.HeaderText = "Cedula";
            this.CSupplierCardID.MinimumWidth = 120;
            this.CSupplierCardID.Name = "CSupplierCardID";
            this.CSupplierCardID.ReadOnly = true;
            this.CSupplierCardID.Width = 120;
            // 
            // CSupplierEmail
            // 
            this.CSupplierEmail.DataPropertyName = "SupplierEmail";
            this.CSupplierEmail.HeaderText = "Correo";
            this.CSupplierEmail.MinimumWidth = 6;
            this.CSupplierEmail.Name = "CSupplierEmail";
            this.CSupplierEmail.ReadOnly = true;
            this.CSupplierEmail.Width = 210;
            // 
            // CPhoneNumber
            // 
            this.CPhoneNumber.DataPropertyName = "PhoneNumber";
            this.CPhoneNumber.HeaderText = "Celular";
            this.CPhoneNumber.MinimumWidth = 6;
            this.CPhoneNumber.Name = "CPhoneNumber";
            this.CPhoneNumber.ReadOnly = true;
            this.CPhoneNumber.Width = 150;
            // 
            // CAddress
            // 
            this.CAddress.DataPropertyName = "Address";
            this.CAddress.HeaderText = "Direccion";
            this.CAddress.MinimumWidth = 6;
            this.CAddress.Name = "CAddress";
            this.CAddress.ReadOnly = true;
            this.CAddress.Width = 125;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Rol";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 130;
            // 
            // userDetail
            // 
            this.userDetail.Controls.Add(this.TxtCardID);
            this.userDetail.Controls.Add(this.label4);
            this.userDetail.Controls.Add(this.label8);
            this.userDetail.Controls.Add(this.TxtSupplierPhone);
            this.userDetail.Controls.Add(this.CbSupplierType);
            this.userDetail.Controls.Add(this.TxtSupplierAddress);
            this.userDetail.Controls.Add(this.TxtSupplierEmail);
            this.userDetail.Controls.Add(this.TxtSupplierName);
            this.userDetail.Controls.Add(this.TxtIDSupplier);
            this.userDetail.Controls.Add(this.label7);
            this.userDetail.Controls.Add(this.label6);
            this.userDetail.Controls.Add(this.label5);
            this.userDetail.Controls.Add(this.label3);
            this.userDetail.Controls.Add(this.label2);
            this.userDetail.Location = new System.Drawing.Point(4, 446);
            this.userDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.userDetail.Size = new System.Drawing.Size(1100, 215);
            this.userDetail.TabIndex = 4;
            this.userDetail.TabStop = false;
            this.userDetail.Text = "Detalle Proveedor";
            // 
            // TxtCardID
            // 
            this.TxtCardID.Location = new System.Drawing.Point(651, 67);
            this.TxtCardID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCardID.Name = "TxtCardID";
            this.TxtCardID.Size = new System.Drawing.Size(401, 20);
            this.TxtCardID.TabIndex = 22;
            this.TxtCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardID_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cedula:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 33);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo:";
            // 
            // TxtSupplierPhone
            // 
            this.TxtSupplierPhone.Location = new System.Drawing.Point(94, 153);
            this.TxtSupplierPhone.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplierPhone.Name = "TxtSupplierPhone";
            this.TxtSupplierPhone.Size = new System.Drawing.Size(381, 20);
            this.TxtSupplierPhone.TabIndex = 19;
            this.TxtSupplierPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSupplierPhone_KeyPress);
            // 
            // CbSupplierType
            // 
            this.CbSupplierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSupplierType.FormattingEnabled = true;
            this.CbSupplierType.Location = new System.Drawing.Point(600, 27);
            this.CbSupplierType.Margin = new System.Windows.Forms.Padding(2);
            this.CbSupplierType.Name = "CbSupplierType";
            this.CbSupplierType.Size = new System.Drawing.Size(452, 21);
            this.CbSupplierType.TabIndex = 18;
            // 
            // TxtSupplierAddress
            // 
            this.TxtSupplierAddress.Location = new System.Drawing.Point(651, 123);
            this.TxtSupplierAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplierAddress.Multiline = true;
            this.TxtSupplierAddress.Name = "TxtSupplierAddress";
            this.TxtSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSupplierAddress.Size = new System.Drawing.Size(401, 67);
            this.TxtSupplierAddress.TabIndex = 12;
            // 
            // TxtSupplierEmail
            // 
            this.TxtSupplierEmail.Location = new System.Drawing.Point(148, 107);
            this.TxtSupplierEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplierEmail.Name = "TxtSupplierEmail";
            this.TxtSupplierEmail.Size = new System.Drawing.Size(327, 20);
            this.TxtSupplierEmail.TabIndex = 11;
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(81, 70);
            this.TxtSupplierName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(394, 20);
            this.TxtSupplierName.TabIndex = 9;
            this.TxtSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSupplierName_KeyPress);
            // 
            // TxtIDSupplier
            // 
            this.TxtIDSupplier.Location = new System.Drawing.Point(130, 39);
            this.TxtIDSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIDSupplier.Name = "TxtIDSupplier";
            this.TxtIDSupplier.ReadOnly = true;
            this.TxtIDSupplier.Size = new System.Drawing.Size(163, 20);
            this.TxtIDSupplier.TabIndex = 8;
            this.TxtIDSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(571, 123);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo Electronico:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Proveedor:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBSupplier);
            this.panel1.Controls.Add(this.TxtSearchSupplier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 52);
            this.panel1.TabIndex = 0;
            // 
            // checkBSupplier
            // 
            this.checkBSupplier.AutoSize = true;
            this.checkBSupplier.Checked = true;
            this.checkBSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBSupplier.Location = new System.Drawing.Point(776, 16);
            this.checkBSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.checkBSupplier.Name = "checkBSupplier";
            this.checkBSupplier.Size = new System.Drawing.Size(60, 19);
            this.checkBSupplier.TabIndex = 3;
            this.checkBSupplier.Text = "Activo";
            this.checkBSupplier.UseVisualStyleBackColor = true;
            this.checkBSupplier.CheckedChanged += new System.EventHandler(this.checkBSupplier_CheckedChanged);
            // 
            // TxtSearchSupplier
            // 
            this.TxtSearchSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchSupplier.Location = new System.Drawing.Point(96, 15);
            this.TxtSearchSupplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchSupplier.Name = "TxtSearchSupplier";
            this.TxtSearchSupplier.Size = new System.Drawing.Size(663, 20);
            this.TxtSearchSupplier.TabIndex = 2;
            this.TxtSearchSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchSupplier.TextChanged += new System.EventHandler(this.TxtSearchSupplier_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteForEver);
            this.panel2.Controls.Add(this.btnactivate);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnClean);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnEdit);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 667);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1104, 61);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteForEver
            // 
            this.btnDeleteForEver.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForEver.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForEver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForEver.Location = new System.Drawing.Point(436, 2);
            this.btnDeleteForEver.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteForEver.Name = "btnDeleteForEver";
            this.btnDeleteForEver.Size = new System.Drawing.Size(170, 54);
            this.btnDeleteForEver.TabIndex = 23;
            this.btnDeleteForEver.Text = "Eliminar";
            this.btnDeleteForEver.UseVisualStyleBackColor = false;
            this.btnDeleteForEver.Visible = false;
            this.btnDeleteForEver.Click += new System.EventHandler(this.btnDeleteForEver_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnactivate.Location = new System.Drawing.Point(11, 2);
            this.btnactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.Size = new System.Drawing.Size(170, 54);
            this.btnactivate.TabIndex = 23;
            this.btnactivate.Text = "Activar";
            this.btnactivate.UseVisualStyleBackColor = false;
            this.btnactivate.Visible = false;
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(870, 5);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 54);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Location = new System.Drawing.Point(639, 2);
            this.BtnClean.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(170, 54);
            this.BtnClean.TabIndex = 11;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(436, 2);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(170, 54);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(228, 2);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(170, 54);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Modificar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(14, 0);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(170, 54);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Frmsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 730);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frmsupplier";
            this.Text = "Gestion Proveedor";
            this.Load += new System.EventHandler(this.Frmsupplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).EndInit();
            this.userDetail.ResumeLayout(false);
            this.userDetail.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchSupplier;
        private System.Windows.Forms.CheckBox checkBSupplier;
        private System.Windows.Forms.DataGridView DgSupplier;
        private System.Windows.Forms.GroupBox userDetail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSupplierPhone;
        private System.Windows.Forms.ComboBox CbSupplierType;
        private System.Windows.Forms.TextBox TxtSupplierAddress;
        private System.Windows.Forms.TextBox TxtSupplierEmail;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.TextBox TxtIDSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.TextBox TxtCardID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteForEver;
        private System.Windows.Forms.Button btnactivate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
    }
}