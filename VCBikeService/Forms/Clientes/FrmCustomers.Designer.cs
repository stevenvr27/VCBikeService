namespace VCBikeService.Forms.Clientes
{
    partial class h
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(h));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgCustomerList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtCustomerAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCustomerPhone = new System.Windows.Forms.TextBox();
            this.CbCustomerType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCUtomerEmail = new System.Windows.Forms.TextBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.CheckCustomer = new System.Windows.Forms.CheckBox();
            this.TxtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomerList)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1283, 757);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.60694F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.39307F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1283, 682);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgCustomerList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1277, 313);
            this.panel2.TabIndex = 0;
            // 
            // DgCustomerList
            // 
            this.DgCustomerList.AllowUserToAddRows = false;
            this.DgCustomerList.AllowUserToDeleteRows = false;
            this.DgCustomerList.AllowUserToOrderColumns = true;
            this.DgCustomerList.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCustomerID,
            this.CCustomerName,
            this.CCustomerPhone,
            this.CCustomerEmail,
            this.CDescription});
            this.DgCustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgCustomerList.Location = new System.Drawing.Point(0, 0);
            this.DgCustomerList.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgCustomerList.MultiSelect = false;
            this.DgCustomerList.Name = "DgCustomerList";
            this.DgCustomerList.ReadOnly = true;
            this.DgCustomerList.RowHeadersVisible = false;
            this.DgCustomerList.RowHeadersWidth = 62;
            this.DgCustomerList.RowTemplate.Height = 28;
            this.DgCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustomerList.Size = new System.Drawing.Size(1277, 313);
            this.DgCustomerList.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1277, 222);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.TxtCustomerAdress);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCustomerPhone);
            this.groupBox1.Controls.Add(this.CbCustomerType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TxtCUtomerEmail);
            this.groupBox1.Controls.Add(this.TxtCustomerName);
            this.groupBox1.Controls.Add(this.TxtCustomerID);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(2, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(1273, 220);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle  Cliente";
            // 
            // TxtCustomerAdress
            // 
            this.TxtCustomerAdress.Location = new System.Drawing.Point(735, 105);
            this.TxtCustomerAdress.Name = "TxtCustomerAdress";
            this.TxtCustomerAdress.Size = new System.Drawing.Size(454, 28);
            this.TxtCustomerAdress.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Dirrecion:";
            // 
            // TxtCustomerPhone
            // 
            this.TxtCustomerPhone.Location = new System.Drawing.Point(132, 137);
            this.TxtCustomerPhone.Name = "TxtCustomerPhone";
            this.TxtCustomerPhone.Size = new System.Drawing.Size(454, 28);
            this.TxtCustomerPhone.TabIndex = 19;
            // 
            // CbCustomerType
            // 
            this.CbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCustomerType.FormattingEnabled = true;
            this.CbCustomerType.Location = new System.Drawing.Point(735, 44);
            this.CbCustomerType.Name = "CbCustomerType";
            this.CbCustomerType.Size = new System.Drawing.Size(456, 30);
            this.CbCustomerType.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 15;
            this.label12.Text = "Tipo:";
            // 
            // TxtCUtomerEmail
            // 
            this.TxtCUtomerEmail.Location = new System.Drawing.Point(104, 176);
            this.TxtCUtomerEmail.Name = "TxtCUtomerEmail";
            this.TxtCUtomerEmail.Size = new System.Drawing.Size(482, 28);
            this.TxtCUtomerEmail.TabIndex = 10;
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(132, 80);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(454, 28);
            this.TxtCustomerName.TabIndex = 9;
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.Location = new System.Drawing.Point(114, 41);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.ReadOnly = true;
            this.TxtCustomerID.Size = new System.Drawing.Size(216, 28);
            this.TxtCustomerID.TabIndex = 8;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 90);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 22);
            this.label13.TabIndex = 6;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 140);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 22);
            this.label16.TabIndex = 3;
            this.label16.Text = "Telefono:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 179);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 22);
            this.label17.TabIndex = 2;
            this.label17.Text = "Correo:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 90);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 22);
            this.label18.TabIndex = 1;
            this.label18.Text = "Nombre:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 41);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(79, 22);
            this.label19.TabIndex = 0;
            this.label19.Text = "Codigo:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCancel);
            this.panel4.Controls.Add(this.BtnClean);
            this.panel4.Controls.Add(this.BtnDelete);
            this.panel4.Controls.Add(this.BtnEdit);
            this.panel4.Controls.Add(this.BtnAdd);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 608);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1277, 71);
            this.panel4.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(1023, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(226, 66);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Location = new System.Drawing.Point(258, 3);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(226, 66);
            this.BtnClean.TabIndex = 11;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(769, 5);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(226, 66);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(518, 5);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(226, 66);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Modificar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(15, 3);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(226, 66);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.CheckCustomer);
            this.panel5.Controls.Add(this.TxtSearchCustomer);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1277, 52);
            this.panel5.TabIndex = 3;
            // 
            // CheckCustomer
            // 
            this.CheckCustomer.AutoSize = true;
            this.CheckCustomer.Checked = true;
            this.CheckCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCustomer.Location = new System.Drawing.Point(1063, 12);
            this.CheckCustomer.Name = "CheckCustomer";
            this.CheckCustomer.Size = new System.Drawing.Size(130, 26);
            this.CheckCustomer.TabIndex = 13;
            this.CheckCustomer.Text = " Ver Activo";
            this.CheckCustomer.UseVisualStyleBackColor = true;
            this.CheckCustomer.CheckedChanged += new System.EventHandler(this.CheckCustomer_CheckedChanged);
            // 
            // TxtSearchCustomer
            // 
            this.TxtSearchCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchCustomer.Location = new System.Drawing.Point(172, 10);
            this.TxtSearchCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearchCustomer.Name = "TxtSearchCustomer";
            this.TxtSearchCustomer.Size = new System.Drawing.Size(883, 28);
            this.TxtSearchCustomer.TabIndex = 2;
            this.TxtSearchCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
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
            // CCustomerPhone
            // 
            this.CCustomerPhone.DataPropertyName = "CustomerPhone";
            this.CCustomerPhone.HeaderText = "Telefono";
            this.CCustomerPhone.MinimumWidth = 6;
            this.CCustomerPhone.Name = "CCustomerPhone";
            this.CCustomerPhone.ReadOnly = true;
            this.CCustomerPhone.Width = 200;
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
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Rol";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 130;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1283, 757);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Clientes";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomerList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchCustomer;
        private System.Windows.Forms.CheckBox CheckCustomer;
        private System.Windows.Forms.DataGridView DgCustomerList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCustomerPhone;
        private System.Windows.Forms.ComboBox CbCustomerType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCUtomerEmail;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox TxtCustomerAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
    }
}