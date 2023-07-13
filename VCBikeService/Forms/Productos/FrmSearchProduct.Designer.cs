namespace VCBikeService.Forms.Productos
{
    partial class FrmSearchProduct
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgProduct = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearchItem = new System.Windows.Forms.TextBox();
            this.btnfacturacliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnDeleteproduct = new System.Windows.Forms.Button();
            this.checkProduct = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.DgProduct, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.526011F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.47399F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1254, 842);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 732);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1248, 107);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkProduct);
            this.panel2.Controls.Add(this.TxtSearchItem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1248, 56);
            this.panel2.TabIndex = 18;
            // 
            // DgProduct
            // 
            this.DgProduct.AllowUserToAddRows = false;
            this.DgProduct.AllowUserToDeleteRows = false;
            this.DgProduct.AllowUserToOrderColumns = true;
            this.DgProduct.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemID,
            this.CItemName,
            this.CBarcode,
            this.CStock,
            this.CUnitaryCost,
            this.CSellPrice,
            this.CDescription});
            this.DgProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgProduct.Location = new System.Drawing.Point(4, 65);
            this.DgProduct.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DgProduct.MultiSelect = false;
            this.DgProduct.Name = "DgProduct";
            this.DgProduct.ReadOnly = true;
            this.DgProduct.RowHeadersVisible = false;
            this.DgProduct.RowHeadersWidth = 62;
            this.DgProduct.RowTemplate.Height = 28;
            this.DgProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgProduct.Size = new System.Drawing.Size(1246, 661);
            this.DgProduct.TabIndex = 19;
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Cod.Item";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 200;
            // 
            // CItemName
            // 
            this.CItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre";
            this.CItemName.MinimumWidth = 200;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            // 
            // CBarcode
            // 
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Cod.Barras";
            this.CBarcode.MinimumWidth = 120;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            this.CBarcode.Width = 120;
            // 
            // CStock
            // 
            this.CStock.DataPropertyName = "Stock";
            this.CStock.HeaderText = "Stock";
            this.CStock.MinimumWidth = 6;
            this.CStock.Name = "CStock";
            this.CStock.ReadOnly = true;
            this.CStock.Width = 210;
            // 
            // CUnitaryCost
            // 
            this.CUnitaryCost.DataPropertyName = "UnitaryCost";
            this.CUnitaryCost.HeaderText = "Costo";
            this.CUnitaryCost.MinimumWidth = 6;
            this.CUnitaryCost.Name = "CUnitaryCost";
            this.CUnitaryCost.ReadOnly = true;
            this.CUnitaryCost.Width = 150;
            // 
            // CSellPrice
            // 
            this.CSellPrice.DataPropertyName = "SellPrice";
            this.CSellPrice.HeaderText = "Precio Venta";
            this.CSellPrice.MinimumWidth = 6;
            this.CSellPrice.Name = "CSellPrice";
            this.CSellPrice.ReadOnly = true;
            this.CSellPrice.Width = 125;
            // 
            // CDescription
            // 
            this.CDescription.DataPropertyName = "Description";
            this.CDescription.HeaderText = "Categoria";
            this.CDescription.MinimumWidth = 6;
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Width = 130;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnDeleteproduct);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btnfacturacliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1248, 107);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar";
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchItem.Location = new System.Drawing.Point(332, 13);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(663, 20);
            this.TxtSearchItem.TabIndex = 4;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSearchItem_KeyPress);
            // 
            // btnfacturacliente
            // 
            this.btnfacturacliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnfacturacliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturacliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnfacturacliente.Location = new System.Drawing.Point(7, 29);
            this.btnfacturacliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnfacturacliente.Name = "btnfacturacliente";
            this.btnfacturacliente.Size = new System.Drawing.Size(306, 54);
            this.btnfacturacliente.TabIndex = 13;
            this.btnfacturacliente.Text = " + Factura Cliente";
            this.btnfacturacliente.UseVisualStyleBackColor = false;
            this.btnfacturacliente.Click += new System.EventHandler(this.btnfacturacliente_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(454, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 54);
            this.button1.TabIndex = 14;
            this.button1.Text = "+ Factura Proveedor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDeleteproduct
            // 
            this.BtnDeleteproduct.BackColor = System.Drawing.Color.Red;
            this.BtnDeleteproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteproduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDeleteproduct.Location = new System.Drawing.Point(1029, 29);
            this.BtnDeleteproduct.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDeleteproduct.Name = "BtnDeleteproduct";
            this.BtnDeleteproduct.Size = new System.Drawing.Size(170, 54);
            this.BtnDeleteproduct.TabIndex = 15;
            this.BtnDeleteproduct.Text = "Cancelar";
            this.BtnDeleteproduct.UseVisualStyleBackColor = false;
            this.BtnDeleteproduct.Click += new System.EventHandler(this.BtnDeleteproduct_Click);
            // 
            // checkProduct
            // 
            this.checkProduct.AutoSize = true;
            this.checkProduct.Checked = true;
            this.checkProduct.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkProduct.Location = new System.Drawing.Point(1042, 14);
            this.checkProduct.Margin = new System.Windows.Forms.Padding(2);
            this.checkProduct.Name = "checkProduct";
            this.checkProduct.Size = new System.Drawing.Size(60, 19);
            this.checkProduct.TabIndex = 5;
            this.checkProduct.Text = "Activo";
            this.checkProduct.UseVisualStyleBackColor = true;
            // 
            // FrmSearchProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 848);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSearchProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSearchProduct";
            this.Load += new System.EventHandler(this.FrmSearchProduct_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView DgProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSearchItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnfacturacliente;
        private System.Windows.Forms.Button BtnDeleteproduct;
        private System.Windows.Forms.CheckBox checkProduct;
    }
}