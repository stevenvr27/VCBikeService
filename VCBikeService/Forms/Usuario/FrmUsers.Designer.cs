﻿namespace VCBikeService.Forms
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPhone = new System.Windows.Forms.TextBox();
            this.CbRol = new System.Windows.Forms.ComboBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCardID = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtUserID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgListUsers = new System.Windows.Forms.DataGridView();
            this.CUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.CheckUser = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnActivate = new System.Windows.Forms.Button();
            this.btnDeleteForever = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgListUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearch.Location = new System.Drawing.Point(200, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(883, 30);
            this.TxtSearch.TabIndex = 1;
            this.TxtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearch_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1296, 699);
            this.panel1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, -3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1521, 702);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPhone);
            this.groupBox1.Controls.Add(this.CbRol);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtEmail);
            this.groupBox1.Controls.Add(this.TxtCardID);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Controls.Add(this.TxtUserID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(5, 398);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1312, 300);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle Usuario";
            // 
            // TxtPhone
            // 
            this.TxtPhone.Location = new System.Drawing.Point(807, 87);
            this.TxtPhone.Name = "TxtPhone";
            this.TxtPhone.Size = new System.Drawing.Size(482, 30);
            this.TxtPhone.TabIndex = 19;
            this.TxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhone_KeyPress);
            // 
            // CbRol
            // 
            this.CbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbRol.FormattingEnabled = true;
            this.CbRol.Location = new System.Drawing.Point(807, 20);
            this.CbRol.Name = "CbRol";
            this.CbRol.Size = new System.Drawing.Size(481, 33);
            this.CbRol.TabIndex = 18;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(152, 184);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(513, 30);
            this.TxtPassword.TabIndex = 17;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 25);
            this.label9.TabIndex = 16;
            this.label9.Text = "Contraseña:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(704, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Rol:";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(758, 181);
            this.TxtAddress.Multiline = true;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtAddress.Size = new System.Drawing.Size(533, 100);
            this.TxtAddress.TabIndex = 12;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(218, 251);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(390, 30);
            this.TxtEmail.TabIndex = 11;
            // 
            // TxtCardID
            // 
            this.TxtCardID.Location = new System.Drawing.Point(132, 131);
            this.TxtCardID.Name = "TxtCardID";
            this.TxtCardID.Size = new System.Drawing.Size(482, 30);
            this.TxtCardID.TabIndex = 10;
            this.TxtCardID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCardID_KeyPress);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(132, 71);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(514, 30);
            this.TxtUserName.TabIndex = 9;
            // 
            // TxtUserID
            // 
            this.TxtUserID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtUserID.Location = new System.Drawing.Point(201, 28);
            this.TxtUserID.Name = "TxtUserID";
            this.TxtUserID.ReadOnly = true;
            this.TxtUserID.Size = new System.Drawing.Size(216, 30);
            this.TxtUserID.TabIndex = 8;
            this.TxtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 25);
            this.label13.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(704, 136);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 25);
            this.label14.TabIndex = 5;
            this.label14.Text = "Dirección:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 251);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(179, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Correo Electronico:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(704, 90);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 25);
            this.label16.TabIndex = 3;
            this.label16.Text = "Telefono:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 131);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 25);
            this.label17.TabIndex = 2;
            this.label17.Text = "Cedula:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 71);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nombre:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 28);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Codigo Usuario:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgListUsers);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1515, 388);
            this.panel3.TabIndex = 5;
            // 
            // DgListUsers
            // 
            this.DgListUsers.AllowUserToAddRows = false;
            this.DgListUsers.AllowUserToDeleteRows = false;
            this.DgListUsers.AllowUserToOrderColumns = true;
            this.DgListUsers.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgListUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgListUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUserID,
            this.CUserName,
            this.CUserCardID,
            this.CEmail,
            this.CPhoneNumber,
            this.CAddress,
            this.CDescription});
            this.DgListUsers.Location = new System.Drawing.Point(8, 4);
            this.DgListUsers.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgListUsers.MultiSelect = false;
            this.DgListUsers.Name = "DgListUsers";
            this.DgListUsers.ReadOnly = true;
            this.DgListUsers.RowHeadersVisible = false;
            this.DgListUsers.RowHeadersWidth = 62;
            this.DgListUsers.RowTemplate.Height = 28;
            this.DgListUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgListUsers.Size = new System.Drawing.Size(1286, 380);
            this.DgListUsers.TabIndex = 3;
            this.DgListUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgListUsers_CellClick);
            // 
            // CUserID
            // 
            this.CUserID.DataPropertyName = "UserID";
            this.CUserID.HeaderText = "Cod.Usuario";
            this.CUserID.MinimumWidth = 6;
            this.CUserID.Name = "CUserID";
            this.CUserID.ReadOnly = true;
            this.CUserID.Width = 200;
            // 
            // CUserName
            // 
            this.CUserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CUserName.DataPropertyName = "UserName";
            this.CUserName.HeaderText = "Nombre";
            this.CUserName.MinimumWidth = 6;
            this.CUserName.Name = "CUserName";
            this.CUserName.ReadOnly = true;
            // 
            // CUserCardID
            // 
            this.CUserCardID.DataPropertyName = "UserCardID";
            this.CUserCardID.HeaderText = "Cedula";
            this.CUserCardID.MinimumWidth = 6;
            this.CUserCardID.Name = "CUserCardID";
            this.CUserCardID.ReadOnly = true;
            this.CUserCardID.Width = 200;
            // 
            // CEmail
            // 
            this.CEmail.DataPropertyName = "Email";
            this.CEmail.HeaderText = "Correo";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            this.CEmail.Width = 210;
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
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(15, 22);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(226, 66);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(543, 22);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(226, 66);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "Modificar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(807, 22);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(226, 66);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Location = new System.Drawing.Point(268, 22);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(226, 66);
            this.BtnClean.TabIndex = 10;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(1062, 22);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(226, 66);
            this.BtnCancel.TabIndex = 11;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CheckUser
            // 
            this.CheckUser.AutoSize = true;
            this.CheckUser.Checked = true;
            this.CheckUser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckUser.Location = new System.Drawing.Point(1102, 8);
            this.CheckUser.Name = "CheckUser";
            this.CheckUser.Size = new System.Drawing.Size(129, 29);
            this.CheckUser.TabIndex = 12;
            this.CheckUser.Text = " Ver Activo";
            this.CheckUser.UseVisualStyleBackColor = true;
            this.CheckUser.CheckedChanged += new System.EventHandler(this.CheckUser_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnActivate);
            this.panel2.Controls.Add(this.btnDeleteForever);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Controls.Add(this.BtnEdit);
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnClean);
            this.panel2.Location = new System.Drawing.Point(8, 748);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 100);
            this.panel2.TabIndex = 13;
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActivate.Location = new System.Drawing.Point(15, 22);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(226, 66);
            this.btnActivate.TabIndex = 21;
            this.btnActivate.Text = "Activar";
            this.btnActivate.UseVisualStyleBackColor = false;
            this.btnActivate.Visible = false;
            this.btnActivate.Click += new System.EventHandler(this.Activate_Click);
            // 
            // btnDeleteForever
            // 
            this.btnDeleteForever.BackColor = System.Drawing.Color.Red;
            this.btnDeleteForever.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteForever.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForever.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteForever.Location = new System.Drawing.Point(268, 22);
            this.btnDeleteForever.Name = "btnDeleteForever";
            this.btnDeleteForever.Size = new System.Drawing.Size(247, 66);
            this.btnDeleteForever.TabIndex = 20;
            this.btnDeleteForever.Text = "Eliminar";
            this.btnDeleteForever.UseVisualStyleBackColor = false;
            this.btnDeleteForever.Visible = false;
            this.btnDeleteForever.Click += new System.EventHandler(this.DeleteForever_Click);
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1321, 848);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CheckUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1339, 895);
            this.MinimumSize = new System.Drawing.Size(1339, 895);
            this.Name = "FrmUsers";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Usuarios";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmUsers_KeyUp);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgListUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox CheckUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtPhone;
        private System.Windows.Forms.ComboBox CbRol;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtCardID;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtUserID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView DgListUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.Button btnDeleteForever;
        private System.Windows.Forms.Panel panel3;
    }
}