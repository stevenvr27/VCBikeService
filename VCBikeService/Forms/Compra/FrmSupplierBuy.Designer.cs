namespace VCBikeService.Forms.Compra
{
    partial class FrmSupplierBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSupplierBuy));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cvMethodp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClienteBuscar = new System.Windows.Forms.Button();
            this.TxtSupplierD = new System.Windows.Forms.TextBox();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.CbBuyType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnProductoAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCrearCompra = new System.Windows.Forms.Button();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelCodigo = new System.Windows.Forms.Label();
            this.lblNameSupply = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.TxtSupplyName = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.45238F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.54762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1036, 706);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 251);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUserName);
            this.groupBox1.Controls.Add(this.TxtSupplyName);
            this.groupBox1.Controls.Add(this.lblNameUser);
            this.groupBox1.Controls.Add(this.lblNameSupply);
            this.groupBox1.Controls.Add(this.LabelCodigo);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cvMethodp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnClienteBuscar);
            this.groupBox1.Controls.Add(this.TxtSupplierD);
            this.groupBox1.Controls.Add(this.labelProveedor);
            this.groupBox1.Controls.Add(this.CbBuyType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(5, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1029, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle compra";
            // 
            // TxtNotes
            // 
            this.TxtNotes.BackColor = System.Drawing.Color.Moccasin;
            this.TxtNotes.Location = new System.Drawing.Point(694, 156);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotes.Size = new System.Drawing.Size(308, 56);
            this.TxtNotes.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nota:";
            // 
            // cvMethodp
            // 
            this.cvMethodp.BackColor = System.Drawing.Color.Moccasin;
            this.cvMethodp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvMethodp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cvMethodp.FormattingEnabled = true;
            this.cvMethodp.Location = new System.Drawing.Point(670, 28);
            this.cvMethodp.Name = "cvMethodp";
            this.cvMethodp.Size = new System.Drawing.Size(332, 21);
            this.cvMethodp.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Metodo de Pago:";
            // 
            // BtnClienteBuscar
            // 
            this.BtnClienteBuscar.Location = new System.Drawing.Point(431, 23);
            this.BtnClienteBuscar.Name = "BtnClienteBuscar";
            this.BtnClienteBuscar.Size = new System.Drawing.Size(83, 34);
            this.BtnClienteBuscar.TabIndex = 12;
            this.BtnClienteBuscar.Text = "Buscar...";
            this.BtnClienteBuscar.UseVisualStyleBackColor = true;
            this.BtnClienteBuscar.Click += new System.EventHandler(this.BtnClienteBuscar_Click);
            // 
            // TxtSupplierD
            // 
            this.TxtSupplierD.BackColor = System.Drawing.Color.Moccasin;
            this.TxtSupplierD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplierD.Location = new System.Drawing.Point(128, 28);
            this.TxtSupplierD.Name = "TxtSupplierD";
            this.TxtSupplierD.Size = new System.Drawing.Size(293, 26);
            this.TxtSupplierD.TabIndex = 11;
            this.TxtSupplierD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedor.Location = new System.Drawing.Point(15, 29);
            this.labelProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(108, 25);
            this.labelProveedor.TabIndex = 7;
            this.labelProveedor.Text = "Proovedor:";
            // 
            // CbBuyType
            // 
            this.CbBuyType.BackColor = System.Drawing.Color.Moccasin;
            this.CbBuyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBuyType.FormattingEnabled = true;
            this.CbBuyType.Location = new System.Drawing.Point(670, 84);
            this.CbBuyType.Name = "CbBuyType";
            this.CbBuyType.Size = new System.Drawing.Size(332, 21);
            this.CbBuyType.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(541, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Compra:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvLista);
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 257);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1032, 327);
            this.panel2.TabIndex = 1;
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemID,
            this.CItemName,
            this.CBarcode,
            this.CUnitaryCost,
            this.CCantidad});
            this.DgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLista.Location = new System.Drawing.Point(0, 27);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1032, 300);
            this.DgvLista.TabIndex = 3;
            this.DgvLista.VirtualMode = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProductoAgregar,
            this.BtnProductoEditar,
            this.BtnProductoEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnProductoAgregar
            // 
            this.BtnProductoAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnProductoAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnProductoAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoAgregar.Name = "BtnProductoAgregar";
            this.BtnProductoAgregar.Size = new System.Drawing.Size(131, 24);
            this.BtnProductoAgregar.Text = "Agregar Producto";
            this.BtnProductoAgregar.Click += new System.EventHandler(this.BtnProductoAgregar_Click);
            // 
            // BtnProductoEditar
            // 
            this.BtnProductoEditar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnProductoEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoEditar.Name = "BtnProductoEditar";
            this.BtnProductoEditar.Size = new System.Drawing.Size(141, 24);
            this.BtnProductoEditar.Text = "Modificar Producto";
            // 
            // BtnProductoEliminar
            // 
            this.BtnProductoEliminar.BackColor = System.Drawing.Color.Brown;
            this.BtnProductoEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnProductoEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnProductoEliminar.Name = "BtnProductoEliminar";
            this.BtnProductoEliminar.Size = new System.Drawing.Size(131, 24);
            this.BtnProductoEliminar.Text = "Eliminar Producto";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 588);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 116);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCrearCompra);
            this.panel4.Controls.Add(this.TxtTotal);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TxtTotalCantidad);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1032, 116);
            this.panel4.TabIndex = 0;
            // 
            // BtnCrearCompra
            // 
            this.BtnCrearCompra.BackColor = System.Drawing.Color.Green;
            this.BtnCrearCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCompra.Location = new System.Drawing.Point(791, 50);
            this.BtnCrearCompra.Name = "BtnCrearCompra";
            this.BtnCrearCompra.Size = new System.Drawing.Size(180, 39);
            this.BtnCrearCompra.TabIndex = 5;
            this.BtnCrearCompra.Text = "Crear Compra";
            this.BtnCrearCompra.UseVisualStyleBackColor = false;
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.Black;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtTotal.Location = new System.Drawing.Point(414, 68);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(220, 34);
            this.TxtTotal.TabIndex = 4;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(459, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "TOTAL";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.Color.DimGray;
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.ForeColor = System.Drawing.Color.White;
            this.TxtTotalCantidad.Location = new System.Drawing.Point(41, 68);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(180, 34);
            this.TxtTotalCantidad.TabIndex = 2;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "CANTIDAD ITEMS";
            // 
            // LabelCodigo
            // 
            this.LabelCodigo.AutoSize = true;
            this.LabelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCodigo.Location = new System.Drawing.Point(29, 32);
            this.LabelCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelCodigo.Name = "LabelCodigo";
            this.LabelCodigo.Size = new System.Drawing.Size(81, 25);
            this.LabelCodigo.TabIndex = 17;
            this.LabelCodigo.Text = "Codigo:";
            this.LabelCodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelCodigo.Visible = false;
            // 
            // lblNameSupply
            // 
            this.lblNameSupply.AutoSize = true;
            this.lblNameSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSupply.Location = new System.Drawing.Point(29, 105);
            this.lblNameSupply.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameSupply.Name = "lblNameSupply";
            this.lblNameSupply.Size = new System.Drawing.Size(87, 25);
            this.lblNameSupply.TabIndex = 18;
            this.lblNameSupply.Text = "Nombre:";
            this.lblNameSupply.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNameSupply.Visible = false;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(29, 187);
            this.lblNameUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(90, 25);
            this.lblNameUser.TabIndex = 19;
            this.lblNameUser.Text = " Usuario:";
            this.lblNameUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNameUser.Visible = false;
            // 
            // TxtSupplyName
            // 
            this.TxtSupplyName.BackColor = System.Drawing.Color.Moccasin;
            this.TxtSupplyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplyName.Location = new System.Drawing.Point(137, 106);
            this.TxtSupplyName.Name = "TxtSupplyName";
            this.TxtSupplyName.Size = new System.Drawing.Size(293, 26);
            this.TxtSupplyName.TabIndex = 20;
            this.TxtSupplyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSupplyName.Visible = false;
            // 
            // textUserName
            // 
            this.textUserName.BackColor = System.Drawing.Color.Moccasin;
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(137, 186);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(293, 26);
            this.textUserName.TabIndex = 21;
            this.textUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUserName.Visible = false;
            // 
            // CItemID
            // 
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "Cod.Producto";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 125;
            // 
            // CItemName
            // 
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "Nombre";
            this.CItemName.MinimumWidth = 6;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            this.CItemName.Width = 125;
            // 
            // CBarcode
            // 
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Codigo de Barras";
            this.CBarcode.MinimumWidth = 6;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            this.CBarcode.Width = 125;
            // 
            // CUnitaryCost
            // 
            this.CUnitaryCost.DataPropertyName = "UnitaryCost";
            this.CUnitaryCost.HeaderText = "Precio";
            this.CUnitaryCost.MinimumWidth = 6;
            this.CUnitaryCost.Name = "CUnitaryCost";
            this.CUnitaryCost.ReadOnly = true;
            this.CUnitaryCost.Width = 125;
            // 
            // CCantidad
            // 
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "Cantidad";
            this.CCantidad.MinimumWidth = 6;
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 125;
            // 
            // FrmSupplierBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 703);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSupplierBuy";
            this.Text = "Registro Compra Proveedor";
            this.Load += new System.EventHandler(this.FrmSupplierBuy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbBuyType;
        private System.Windows.Forms.Label labelProveedor;
        public System.Windows.Forms.TextBox TxtSupplierD;
        private System.Windows.Forms.Button BtnClienteBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cvMethodp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Button BtnCrearCompra;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnProductoAgregar;
        private System.Windows.Forms.ToolStripButton BtnProductoEditar;
        private System.Windows.Forms.ToolStripButton BtnProductoEliminar;
        private System.Windows.Forms.Label LabelCodigo;
        private System.Windows.Forms.Label lblNameSupply;
        public System.Windows.Forms.TextBox textUserName;
        public System.Windows.Forms.TextBox TxtSupplyName;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
    }
}