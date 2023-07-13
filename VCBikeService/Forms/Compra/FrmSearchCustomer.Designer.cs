namespace VCBikeService.Forms.Compra
{
    partial class FrmSearchCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSearchCustomer));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CCustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCustomerAdress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(32, 2);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(157, 59);
            this.BtnCancelar.TabIndex = 7;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.BackColor = System.Drawing.Color.Green;
            this.BtnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.BtnSeleccionar.Location = new System.Drawing.Point(807, 6);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(201, 56);
            this.BtnSeleccionar.TabIndex = 6;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.Location = new System.Drawing.Point(254, 10);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(653, 30);
            this.TxtBuscar.TabIndex = 4;
            this.TxtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 602F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1148, 732);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DgvLista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 596);
            this.panel1.TabIndex = 0;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvLista.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCustomerID,
            this.CCustomerName,
            this.CCustomerEmail,
            this.CCustomerPhone,
            this.CCustomerAdress});
            this.DgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLista.Location = new System.Drawing.Point(0, 0);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1142, 596);
            this.DgvLista.TabIndex = 5;
            this.DgvLista.VirtualMode = true;
            // 
            // CCustomerID
            // 
            this.CCustomerID.DataPropertyName = "CustomerID";
            this.CCustomerID.HeaderText = "Código Cliente";
            this.CCustomerID.MinimumWidth = 6;
            this.CCustomerID.Name = "CCustomerID";
            this.CCustomerID.ReadOnly = true;
            this.CCustomerID.Width = 125;
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
            this.CCustomerEmail.Width = 125;
            // 
            // CCustomerPhone
            // 
            this.CCustomerPhone.DataPropertyName = "CustomerPhone";
            this.CCustomerPhone.HeaderText = "Teléfono";
            this.CCustomerPhone.MinimumWidth = 6;
            this.CCustomerPhone.Name = "CCustomerPhone";
            this.CCustomerPhone.ReadOnly = true;
            this.CCustomerPhone.Width = 125;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.TxtBuscar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 53);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.BtnCancelar);
            this.panel3.Controls.Add(this.BtnSeleccionar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 664);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1142, 65);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Ivory;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(445, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(268, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Agregar nuevo cliente";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSearchCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 728);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSearchCustomer";
            this.Text = "Buscador de Clientes";
            this.Load += new System.EventHandler(this.FrmSearchCustomer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCustomerAdress;
    }
}