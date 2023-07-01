namespace VCBikeService.Forms
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkCustomer = new System.Windows.Forms.CheckBox();
            this.CustomerDetail = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.TxtCustomerEmail = new System.Windows.Forms.TextBox();
            this.TxtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbCustomerType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtNameCustomer = new System.Windows.Forms.TextBox();
            this.TxtCustomerAddress = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DgCustomer = new System.Windows.Forms.DataGridView();
            this.CCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.CustomerDetail.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 570);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1204, 88);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnCancel);
            this.panel3.Controls.Add(this.BtnClean);
            this.panel3.Controls.Add(this.BtnDelete);
            this.panel3.Controls.Add(this.BtnEdit);
            this.panel3.Controls.Add(this.BtnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1204, 88);
            this.panel3.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(7, 2);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(170, 54);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(205, 2);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(170, 54);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Modificar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Red;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDelete.Location = new System.Drawing.Point(391, 4);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(170, 54);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Location = new System.Drawing.Point(580, 4);
            this.BtnClean.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(170, 54);
            this.BtnClean.TabIndex = 11;
            this.BtnClean.Text = "Limpiar";
            this.BtnClean.UseVisualStyleBackColor = false;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Orange;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(775, 4);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(170, 54);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkCustomer);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1204, 28);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 8);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 20);
            this.textBox1.TabIndex = 1;
            // 
            // checkCustomer
            // 
            this.checkCustomer.AutoSize = true;
            this.checkCustomer.Checked = true;
            this.checkCustomer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkCustomer.Location = new System.Drawing.Point(510, 10);
            this.checkCustomer.Name = "checkCustomer";
            this.checkCustomer.Size = new System.Drawing.Size(60, 19);
            this.checkCustomer.TabIndex = 2;
            this.checkCustomer.Text = "Activo";
            this.checkCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerDetail
            // 
            this.CustomerDetail.Controls.Add(this.TxtCustomerAddress);
            this.CustomerDetail.Controls.Add(this.TxtNameCustomer);
            this.CustomerDetail.Controls.Add(this.label7);
            this.CustomerDetail.Controls.Add(this.CbCustomerType);
            this.CustomerDetail.Controls.Add(this.label10);
            this.CustomerDetail.Controls.Add(this.TxtCustomerPhoneNumber);
            this.CustomerDetail.Controls.Add(this.TxtCustomerEmail);
            this.CustomerDetail.Controls.Add(this.TxtCustomerID);
            this.CustomerDetail.Controls.Add(this.label8);
            this.CustomerDetail.Controls.Add(this.label4);
            this.CustomerDetail.Controls.Add(this.label3);
            this.CustomerDetail.Controls.Add(this.label2);
            this.CustomerDetail.Location = new System.Drawing.Point(4, 383);
            this.CustomerDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerDetail.Name = "CustomerDetail";
            this.CustomerDetail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CustomerDetail.Size = new System.Drawing.Size(1040, 182);
            this.CustomerDetail.TabIndex = 4;
            this.CustomerDetail.TabStop = false;
            this.CustomerDetail.Text = "Detalle Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Numero de telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nombre";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.Location = new System.Drawing.Point(116, 26);
            this.TxtCustomerID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.ReadOnly = true;
            this.TxtCustomerID.Size = new System.Drawing.Size(163, 20);
            this.TxtCustomerID.TabIndex = 8;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.Location = new System.Drawing.Point(531, 131);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(409, 20);
            this.TxtCustomerEmail.TabIndex = 9;
            // 
            // TxtCustomerPhoneNumber
            // 
            this.TxtCustomerPhoneNumber.Location = new System.Drawing.Point(7, 134);
            this.TxtCustomerPhoneNumber.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerPhoneNumber.Name = "TxtCustomerPhoneNumber";
            this.TxtCustomerPhoneNumber.Size = new System.Drawing.Size(362, 20);
            this.TxtCustomerPhoneNumber.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(414, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tipo de Cliente:";
            // 
            // CbCustomerType
            // 
            this.CbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbCustomerType.FormattingEnabled = true;
            this.CbCustomerType.Location = new System.Drawing.Point(536, 26);
            this.CbCustomerType.Margin = new System.Windows.Forms.Padding(2);
            this.CbCustomerType.Name = "CbCustomerType";
            this.CbCustomerType.Size = new System.Drawing.Size(342, 21);
            this.CbCustomerType.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(422, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Dirección:";
            // 
            // TxtNameCustomer
            // 
            this.TxtNameCustomer.Location = new System.Drawing.Point(7, 76);
            this.TxtNameCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNameCustomer.Name = "TxtNameCustomer";
            this.TxtNameCustomer.Size = new System.Drawing.Size(362, 20);
            this.TxtNameCustomer.TabIndex = 22;
            // 
            // TxtCustomerAddress
            // 
            this.TxtCustomerAddress.Location = new System.Drawing.Point(531, 79);
            this.TxtCustomerAddress.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCustomerAddress.Name = "TxtCustomerAddress";
            this.TxtCustomerAddress.Size = new System.Drawing.Size(362, 20);
            this.TxtCustomerAddress.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CustomerDetail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.536586F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.46342F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1208, 660);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.DgCustomer);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1202, 342);
            this.panel4.TabIndex = 6;
            // 
            // DgCustomer
            // 
            this.DgCustomer.AllowUserToAddRows = false;
            this.DgCustomer.AllowUserToDeleteRows = false;
            this.DgCustomer.AllowUserToOrderColumns = true;
            this.DgCustomer.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCustomerID,
            this.CCustomerName,
            this.CCustomerEmail,
            this.CCustomerPhone,
            this.CCustomerAdress,
            this.dataGridViewTextBoxColumn7});
            this.DgCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgCustomer.Location = new System.Drawing.Point(0, 0);
            this.DgCustomer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgCustomer.MultiSelect = false;
            this.DgCustomer.Name = "DgCustomer";
            this.DgCustomer.ReadOnly = true;
            this.DgCustomer.RowHeadersVisible = false;
            this.DgCustomer.RowHeadersWidth = 62;
            this.DgCustomer.RowTemplate.Height = 28;
            this.DgCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgCustomer.Size = new System.Drawing.Size(1202, 342);
            this.DgCustomer.TabIndex = 4;
            this.DgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgCustomer_CellClick);
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 130;
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 632);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCustomer";
            this.Text = "Gestion Clientes";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.CustomerDetail.ResumeLayout(false);
            this.CustomerDetail.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkCustomer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox CustomerDetail;
        private System.Windows.Forms.TextBox TxtCustomerAddress;
        private System.Windows.Forms.TextBox TxtNameCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CbCustomerType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtCustomerPhoneNumber;
        private System.Windows.Forms.TextBox TxtCustomerEmail;
        private System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DgCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerAdress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}