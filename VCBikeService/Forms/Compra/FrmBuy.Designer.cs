namespace VCBikeService.Forms.Compra
{
    partial class FrmBuy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuy));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cvMethodp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.TxtClienteID = new System.Windows.Forms.TextBox();
            this.LblClienteNombre = new System.Windows.Forms.Label();
            this.BtnClienteBuscar = new System.Windows.Forms.Button();
            this.TxtNotes = new System.Windows.Forms.TextBox();
            this.CbBuyType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.CItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSellPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTasaImpuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPorcentajeDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescuentoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestosTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLinea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnProductoAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnProductoEliminar = new System.Windows.Forms.ToolStripButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnCrearCompra = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.50174F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.49826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1136, 774);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 245);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cvMethodp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.TxtClienteID);
            this.groupBox1.Controls.Add(this.LblClienteNombre);
            this.groupBox1.Controls.Add(this.BtnClienteBuscar);
            this.groupBox1.Controls.Add(this.TxtNotes);
            this.groupBox1.Controls.Add(this.CbBuyType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(1088, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle de Compra";
            // 
            // cvMethodp
            // 
            this.cvMethodp.BackColor = System.Drawing.Color.Moccasin;
            this.cvMethodp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvMethodp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cvMethodp.FormattingEnabled = true;
            this.cvMethodp.Location = new System.Drawing.Point(547, 69);
            this.cvMethodp.Name = "cvMethodp";
            this.cvMethodp.Size = new System.Drawing.Size(346, 33);
            this.cvMethodp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Metodo de Pago:";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(9, 35);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(179, 25);
            this.nombre.TabIndex = 11;
            this.nombre.Text = "Nombre del cliente:";
            this.nombre.Visible = false;
            // 
            // TxtClienteID
            // 
            this.TxtClienteID.BackColor = System.Drawing.Color.Moccasin;
            this.TxtClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtClienteID.Location = new System.Drawing.Point(510, 23);
            this.TxtClienteID.Name = "TxtClienteID";
            this.TxtClienteID.Size = new System.Drawing.Size(410, 26);
            this.TxtClienteID.TabIndex = 10;
            this.TxtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LblClienteNombre
            // 
            this.LblClienteNombre.AutoSize = true;
            this.LblClienteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClienteNombre.Location = new System.Drawing.Point(101, 69);
            this.LblClienteNombre.Name = "LblClienteNombre";
            this.LblClienteNombre.Size = new System.Drawing.Size(139, 20);
            this.LblClienteNombre.TabIndex = 9;
            this.LblClienteNombre.Text = "Nombre Cliente";
            this.LblClienteNombre.Visible = false;
            // 
            // BtnClienteBuscar
            // 
            this.BtnClienteBuscar.Location = new System.Drawing.Point(964, 17);
            this.BtnClienteBuscar.Name = "BtnClienteBuscar";
            this.BtnClienteBuscar.Size = new System.Drawing.Size(95, 34);
            this.BtnClienteBuscar.TabIndex = 8;
            this.BtnClienteBuscar.Text = "Buscar...";
            this.BtnClienteBuscar.UseVisualStyleBackColor = true;
            this.BtnClienteBuscar.Click += new System.EventHandler(this.BtnClienteBuscar_Click);
            // 
            // TxtNotes
            // 
            this.TxtNotes.BackColor = System.Drawing.Color.Moccasin;
            this.TxtNotes.Location = new System.Drawing.Point(493, 121);
            this.TxtNotes.Multiline = true;
            this.TxtNotes.Name = "TxtNotes";
            this.TxtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotes.Size = new System.Drawing.Size(590, 89);
            this.TxtNotes.TabIndex = 7;
            // 
            // CbBuyType
            // 
            this.CbBuyType.BackColor = System.Drawing.Color.Moccasin;
            this.CbBuyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbBuyType.FormattingEnabled = true;
            this.CbBuyType.Location = new System.Drawing.Point(12, 166);
            this.CbBuyType.Name = "CbBuyType";
            this.CbBuyType.Size = new System.Drawing.Size(346, 33);
            this.CbBuyType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Compra:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(430, 24);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(79, 25);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 394);
            this.panel2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DgvLista);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(3, -7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1082, 366);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
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
            this.CSellPrice,
            this.CCantidad,
            this.CBarcode,
            this.CTasaImpuesto,
            this.CPorcentajeDescuento,
            this.CSubTotal,
            this.CDescuentoTotal,
            this.CSubTotal2,
            this.CImpuestosTotal,
            this.CTotalLinea});
            this.DgvLista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvLista.Location = new System.Drawing.Point(3, 43);
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1076, 320);
            this.DgvLista.TabIndex = 2;
            this.DgvLista.VirtualMode = true;
            // 
            // CItemID
            // 
            this.CItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CItemID.DataPropertyName = "ItemID";
            this.CItemID.HeaderText = "COD";
            this.CItemID.MinimumWidth = 6;
            this.CItemID.Name = "CItemID";
            this.CItemID.ReadOnly = true;
            this.CItemID.Width = 70;
            // 
            // CItemName
            // 
            this.CItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CItemName.DataPropertyName = "ItemName";
            this.CItemName.HeaderText = "ITEM";
            this.CItemName.MinimumWidth = 6;
            this.CItemName.Name = "CItemName";
            this.CItemName.ReadOnly = true;
            // 
            // CSellPrice
            // 
            this.CSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CSellPrice.DataPropertyName = "SellPrice";
            this.CSellPrice.HeaderText = "PRECIO";
            this.CSellPrice.MinimumWidth = 6;
            this.CSellPrice.Name = "CSellPrice";
            this.CSellPrice.ReadOnly = true;
            this.CSellPrice.Width = 80;
            // 
            // CCantidad
            // 
            this.CCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCantidad.DataPropertyName = "Cantidad";
            this.CCantidad.HeaderText = "CANTIDAD";
            this.CCantidad.MinimumWidth = 6;
            this.CCantidad.Name = "CCantidad";
            this.CCantidad.ReadOnly = true;
            this.CCantidad.Width = 75;
            // 
            // CBarcode
            // 
            this.CBarcode.DataPropertyName = "Barcode";
            this.CBarcode.HeaderText = "Codigo barras";
            this.CBarcode.MinimumWidth = 6;
            this.CBarcode.Name = "CBarcode";
            this.CBarcode.ReadOnly = true;
            this.CBarcode.Width = 125;
            // 
            // CTasaImpuesto
            // 
            this.CTasaImpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTasaImpuesto.DataPropertyName = "TasaImpuesto";
            this.CTasaImpuesto.HeaderText = "% IVA";
            this.CTasaImpuesto.MinimumWidth = 6;
            this.CTasaImpuesto.Name = "CTasaImpuesto";
            this.CTasaImpuesto.ReadOnly = true;
            this.CTasaImpuesto.Width = 50;
            // 
            // CPorcentajeDescuento
            // 
            this.CPorcentajeDescuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPorcentajeDescuento.DataPropertyName = "PorcentajeDescuento";
            this.CPorcentajeDescuento.HeaderText = "% DESC";
            this.CPorcentajeDescuento.MinimumWidth = 6;
            this.CPorcentajeDescuento.Name = "CPorcentajeDescuento";
            this.CPorcentajeDescuento.ReadOnly = true;
            this.CPorcentajeDescuento.Width = 50;
            // 
            // CSubTotal
            // 
            this.CSubTotal.DataPropertyName = "SubTotal";
            this.CSubTotal.HeaderText = "SubTotal";
            this.CSubTotal.MinimumWidth = 6;
            this.CSubTotal.Name = "CSubTotal";
            this.CSubTotal.ReadOnly = true;
            this.CSubTotal.Visible = false;
            this.CSubTotal.Width = 125;
            // 
            // CDescuentoTotal
            // 
            this.CDescuentoTotal.DataPropertyName = "DescuentoTotal";
            this.CDescuentoTotal.HeaderText = "Desc Total";
            this.CDescuentoTotal.MinimumWidth = 6;
            this.CDescuentoTotal.Name = "CDescuentoTotal";
            this.CDescuentoTotal.ReadOnly = true;
            this.CDescuentoTotal.Visible = false;
            this.CDescuentoTotal.Width = 125;
            // 
            // CSubTotal2
            // 
            this.CSubTotal2.DataPropertyName = "SubTotal2";
            this.CSubTotal2.HeaderText = "SubTotal2";
            this.CSubTotal2.MinimumWidth = 6;
            this.CSubTotal2.Name = "CSubTotal2";
            this.CSubTotal2.ReadOnly = true;
            this.CSubTotal2.Visible = false;
            this.CSubTotal2.Width = 125;
            // 
            // CImpuestosTotal
            // 
            this.CImpuestosTotal.DataPropertyName = "ImpuestosTotal";
            this.CImpuestosTotal.HeaderText = "Total IVA";
            this.CImpuestosTotal.MinimumWidth = 6;
            this.CImpuestosTotal.Name = "CImpuestosTotal";
            this.CImpuestosTotal.ReadOnly = true;
            this.CImpuestosTotal.Visible = false;
            this.CImpuestosTotal.Width = 125;
            // 
            // CTotalLinea
            // 
            this.CTotalLinea.DataPropertyName = "TotalLinea";
            this.CTotalLinea.HeaderText = "TOTAL";
            this.CTotalLinea.MinimumWidth = 6;
            this.CTotalLinea.Name = "CTotalLinea";
            this.CTotalLinea.ReadOnly = true;
            this.CTotalLinea.Visible = false;
            this.CTotalLinea.Width = 125;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnProductoAgregar,
            this.BtnProductoEditar,
            this.BtnProductoEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1076, 27);
            this.toolStrip1.TabIndex = 0;
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
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1130, 67);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtTotal);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TxtTotalCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(2, -3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1092, 78);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "TOTALES";
            // 
            // TxtTotal
            // 
            this.TxtTotal.BackColor = System.Drawing.Color.Black;
            this.TxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TxtTotal.Location = new System.Drawing.Point(723, 43);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.ReadOnly = true;
            this.TxtTotal.Size = new System.Drawing.Size(220, 34);
            this.TxtTotal.TabIndex = 3;
            this.TxtTotal.Text = "0";
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(785, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "TOTAL";
            // 
            // TxtTotalCantidad
            // 
            this.TxtTotalCantidad.BackColor = System.Drawing.Color.DimGray;
            this.TxtTotalCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalCantidad.ForeColor = System.Drawing.Color.White;
            this.TxtTotalCantidad.Location = new System.Drawing.Point(60, 43);
            this.TxtTotalCantidad.Name = "TxtTotalCantidad";
            this.TxtTotalCantidad.ReadOnly = true;
            this.TxtTotalCantidad.Size = new System.Drawing.Size(180, 34);
            this.TxtTotalCantidad.TabIndex = 1;
            this.TxtTotalCantidad.Text = "0";
            this.TxtTotalCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "CANTIDAD ITEMS";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BtnCrearCompra);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 726);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1132, 46);
            this.panel4.TabIndex = 3;
            // 
            // BtnCrearCompra
            // 
            this.BtnCrearCompra.BackColor = System.Drawing.Color.Green;
            this.BtnCrearCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCrearCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCompra.ForeColor = System.Drawing.Color.White;
            this.BtnCrearCompra.Location = new System.Drawing.Point(327, 1);
            this.BtnCrearCompra.Name = "BtnCrearCompra";
            this.BtnCrearCompra.Size = new System.Drawing.Size(391, 47);
            this.BtnCrearCompra.TabIndex = 4;
            this.BtnCrearCompra.Text = "Crear Compra";
            this.BtnCrearCompra.UseVisualStyleBackColor = false;
            // 
            // FrmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1135, 784);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBuy";
            this.Text = "Registro de Compras";
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnProductoAgregar;
        private System.Windows.Forms.ToolStripButton BtnProductoEditar;
        private System.Windows.Forms.ToolStripButton BtnProductoEliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BtnCrearCompra;
        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox TxtClienteID;
        private System.Windows.Forms.Label LblClienteNombre;
        private System.Windows.Forms.Button BtnClienteBuscar;
        private System.Windows.Forms.TextBox TxtNotes;
        private System.Windows.Forms.ComboBox CbBuyType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSellPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn CBarcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTasaImpuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPorcentajeDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescuentoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotal2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestosTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLinea;
        private System.Windows.Forms.ComboBox cvMethodp;
        private System.Windows.Forms.Label label1;
    }
}