namespace VCBikeService.Forms.Compra
{
    partial class FrmSupplyerSearch
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
            this.DgSupplier = new System.Windows.Forms.DataGridView();
            this.CSupplierID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSupplierEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.426987F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.57301F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(917, 587);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgSupplier);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 462);
            this.panel1.TabIndex = 0;
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
            this.DgSupplier.Location = new System.Drawing.Point(0, 0);
            this.DgSupplier.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgSupplier.MultiSelect = false;
            this.DgSupplier.Name = "DgSupplier";
            this.DgSupplier.ReadOnly = true;
            this.DgSupplier.RowHeadersVisible = false;
            this.DgSupplier.RowHeadersWidth = 62;
            this.DgSupplier.RowTemplate.Height = 28;
            this.DgSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSupplier.Size = new System.Drawing.Size(911, 462);
            this.DgSupplier.TabIndex = 6;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Moccasin;
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 42);
            this.panel2.TabIndex = 1;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(20, 7);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(869, 30);
            this.TxtBuscar.TabIndex = 5;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnSeleccionar);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 519);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 65);
            this.panel3.TabIndex = 2;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(639, -4);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(268, 69);
            this.BtnSeleccionar.TabIndex = 10;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(349, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 69);
            this.button1.TabIndex = 9;
            this.button1.Text = "Agregar nuevo Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(30, -5);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(209, 73);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmSupplyerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(913, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSupplyerSearch";
            this.Text = "FrmSupplyerSearch";
            this.Load += new System.EventHandler(this.FrmSupplyerSearch_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmSupplyerSearch_KeyUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridView DgSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSupplierEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
    }
}