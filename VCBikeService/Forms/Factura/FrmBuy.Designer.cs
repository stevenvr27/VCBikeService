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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBuy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Encabezado = new System.Windows.Forms.Panel();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.TxtCustomerID = new System.Windows.Forms.TextBox();
            this.BtnClienteBuscar = new System.Windows.Forms.Button();
            this.cvMethodp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtNotas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbBuyType = new System.Windows.Forms.ComboBox();
            this.LblNombreCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DgvListaItems = new System.Windows.Forms.DataGridView();
            this.CItemItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescripcionItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUnitaryPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPercentageDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSubTotalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CImpuestoLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTotalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.LblDescuentos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.LblImpuestos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.Facturar = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.TxtUSer = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Encabezado.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).BeginInit();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 540);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.22768F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.77232F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.6056F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.3944F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Encabezado);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(782, 143);
            this.panel2.TabIndex = 0;
            // 
            // Encabezado
            // 
            this.Encabezado.BackColor = System.Drawing.Color.Moccasin;
            this.Encabezado.Controls.Add(this.TxtUSer);
            this.Encabezado.Controls.Add(this.txtUsuario);
            this.Encabezado.Controls.Add(this.TxtCustomerID);
            this.Encabezado.Controls.Add(this.BtnClienteBuscar);
            this.Encabezado.Controls.Add(this.cvMethodp);
            this.Encabezado.Controls.Add(this.label7);
            this.Encabezado.Controls.Add(this.label6);
            this.Encabezado.Controls.Add(this.TxtNotas);
            this.Encabezado.Controls.Add(this.label5);
            this.Encabezado.Controls.Add(this.CbBuyType);
            this.Encabezado.Controls.Add(this.LblNombreCliente);
            this.Encabezado.Controls.Add(this.label4);
            this.Encabezado.Controls.Add(this.label3);
            this.Encabezado.Controls.Add(this.label2);
            this.Encabezado.Controls.Add(this.DtpFechaFactura);
            this.Encabezado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Encabezado.Location = new System.Drawing.Point(0, 0);
            this.Encabezado.Name = "Encabezado";
            this.Encabezado.Size = new System.Drawing.Size(782, 143);
            this.Encabezado.TabIndex = 2;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(84, 20);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(10, 15);
            this.txtUsuario.TabIndex = 18;
            this.txtUsuario.Text = " ";
            // 
            // TxtCustomerID
            // 
            this.TxtCustomerID.BackColor = System.Drawing.Color.Moccasin;
            this.TxtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerID.Location = new System.Drawing.Point(296, 48);
            this.TxtCustomerID.Name = "TxtCustomerID";
            this.TxtCustomerID.Size = new System.Drawing.Size(76, 26);
            this.TxtCustomerID.TabIndex = 17;
            this.TxtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCustomerID.Visible = false;
            // 
            // BtnClienteBuscar
            // 
            this.BtnClienteBuscar.Location = new System.Drawing.Point(62, 50);
            this.BtnClienteBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnClienteBuscar.Name = "BtnClienteBuscar";
            this.BtnClienteBuscar.Size = new System.Drawing.Size(64, 24);
            this.BtnClienteBuscar.TabIndex = 15;
            this.BtnClienteBuscar.Text = "Buscar";
            this.BtnClienteBuscar.UseVisualStyleBackColor = true;
            this.BtnClienteBuscar.Click += new System.EventHandler(this.BtnClienteBuscar_Click_1);
            // 
            // cvMethodp
            // 
            this.cvMethodp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cvMethodp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cvMethodp.FormattingEnabled = true;
            this.cvMethodp.Location = new System.Drawing.Point(115, 120);
            this.cvMethodp.MaximumSize = new System.Drawing.Size(304, 0);
            this.cvMethodp.Name = "cvMethodp";
            this.cvMethodp.Size = new System.Drawing.Size(292, 21);
            this.cvMethodp.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Metodo de pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Notas:";
            // 
            // TxtNotas
            // 
            this.TxtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtNotas.Location = new System.Drawing.Point(442, 35);
            this.TxtNotas.Multiline = true;
            this.TxtNotas.Name = "TxtNotas";
            this.TxtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtNotas.Size = new System.Drawing.Size(325, 102);
            this.TxtNotas.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo de Compra:";
            // 
            // CbBuyType
            // 
            this.CbBuyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbBuyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbBuyType.FormattingEnabled = true;
            this.CbBuyType.Location = new System.Drawing.Point(113, 80);
            this.CbBuyType.MaximumSize = new System.Drawing.Size(304, 0);
            this.CbBuyType.Name = "CbBuyType";
            this.CbBuyType.Size = new System.Drawing.Size(292, 21);
            this.CbBuyType.TabIndex = 9;
            // 
            // LblNombreCliente
            // 
            this.LblNombreCliente.AutoSize = true;
            this.LblNombreCliente.Location = new System.Drawing.Point(143, 55);
            this.LblNombreCliente.Name = "LblNombreCliente";
            this.LblNombreCliente.Size = new System.Drawing.Size(108, 15);
            this.LblNombreCliente.TabIndex = 8;
            this.LblNombreCliente.Text = "Nombre de cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // DtpFechaFactura
            // 
            this.DtpFechaFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpFechaFactura.Location = new System.Drawing.Point(442, 3);
            this.DtpFechaFactura.Name = "DtpFechaFactura";
            this.DtpFechaFactura.Size = new System.Drawing.Size(325, 20);
            this.DtpFechaFactura.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DgvListaItems);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(2, 149);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 273);
            this.panel3.TabIndex = 1;
            // 
            // DgvListaItems
            // 
            this.DgvListaItems.AllowUserToAddRows = false;
            this.DgvListaItems.AllowUserToDeleteRows = false;
            this.DgvListaItems.AllowUserToOrderColumns = true;
            this.DgvListaItems.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DgvListaItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CItemItemID,
            this.CDescripcionItem,
            this.CAmount,
            this.CUnitaryPrice,
            this.CPercentageDiscount,
            this.CSubTotalLine,
            this.CImpuestoLine,
            this.CTotalLine});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvListaItems.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvListaItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvListaItems.Location = new System.Drawing.Point(0, 0);
            this.DgvListaItems.Name = "DgvListaItems";
            this.DgvListaItems.ReadOnly = true;
            this.DgvListaItems.RowHeadersVisible = false;
            this.DgvListaItems.RowHeadersWidth = 51;
            this.DgvListaItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaItems.Size = new System.Drawing.Size(782, 273);
            this.DgvListaItems.TabIndex = 5;
            this.DgvListaItems.VirtualMode = true;
            // 
            // CItemItemID
            // 
            this.CItemItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CItemItemID.DataPropertyName = "ItemItemID";
            this.CItemItemID.HeaderText = "Código item";
            this.CItemItemID.MinimumWidth = 6;
            this.CItemItemID.Name = "CItemItemID";
            this.CItemItemID.ReadOnly = true;
            // 
            // CDescripcionItem
            // 
            this.CDescripcionItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CDescripcionItem.DataPropertyName = "DescripcionItem";
            this.CDescripcionItem.HeaderText = "Descripción";
            this.CDescripcionItem.MinimumWidth = 6;
            this.CDescripcionItem.Name = "CDescripcionItem";
            this.CDescripcionItem.ReadOnly = true;
            // 
            // CAmount
            // 
            this.CAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CAmount.DataPropertyName = "Amount";
            this.CAmount.HeaderText = "Cantidad";
            this.CAmount.MinimumWidth = 6;
            this.CAmount.Name = "CAmount";
            this.CAmount.ReadOnly = true;
            this.CAmount.Width = 70;
            // 
            // CUnitaryPrice
            // 
            this.CUnitaryPrice.DataPropertyName = "UnitaryPrice";
            this.CUnitaryPrice.HeaderText = "Precio unit";
            this.CUnitaryPrice.MinimumWidth = 6;
            this.CUnitaryPrice.Name = "CUnitaryPrice";
            this.CUnitaryPrice.ReadOnly = true;
            this.CUnitaryPrice.Width = 125;
            // 
            // CPercentageDiscount
            // 
            this.CPercentageDiscount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CPercentageDiscount.DataPropertyName = "PercentageDiscount";
            this.CPercentageDiscount.HeaderText = "% Desc";
            this.CPercentageDiscount.MinimumWidth = 6;
            this.CPercentageDiscount.Name = "CPercentageDiscount";
            this.CPercentageDiscount.ReadOnly = true;
            this.CPercentageDiscount.Width = 50;
            // 
            // CSubTotalLine
            // 
            this.CSubTotalLine.DataPropertyName = "SubTotalLine";
            this.CSubTotalLine.HeaderText = "Sub Total";
            this.CSubTotalLine.MinimumWidth = 6;
            this.CSubTotalLine.Name = "CSubTotalLine";
            this.CSubTotalLine.ReadOnly = true;
            this.CSubTotalLine.Width = 125;
            // 
            // CImpuestoLine
            // 
            this.CImpuestoLine.DataPropertyName = "ImpuestoLine";
            this.CImpuestoLine.HeaderText = "Impuestos";
            this.CImpuestoLine.MinimumWidth = 6;
            this.CImpuestoLine.Name = "CImpuestoLine";
            this.CImpuestoLine.ReadOnly = true;
            this.CImpuestoLine.Width = 125;
            // 
            // CTotalLine
            // 
            this.CTotalLine.DataPropertyName = "TotalLine";
            this.CTotalLine.HeaderText = "TOTAL";
            this.CTotalLine.MinimumWidth = 6;
            this.CTotalLine.Name = "CTotalLine";
            this.CTotalLine.ReadOnly = true;
            this.CTotalLine.Width = 125;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(2, 426);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(782, 112);
            this.panel4.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.82267F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.17733F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel3.Controls.Add(this.panel12, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel13, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel14, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel11, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(780, 114);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel15);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(196, 2);
            this.panel12.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(183, 110);
            this.panel12.TabIndex = 1;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel15.Controls.Add(this.LblDescuentos);
            this.panel15.Controls.Add(this.label8);
            this.panel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel15.Location = new System.Drawing.Point(-4, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(189, 109);
            this.panel15.TabIndex = 5;
            // 
            // LblDescuentos
            // 
            this.LblDescuentos.AutoSize = true;
            this.LblDescuentos.Location = new System.Drawing.Point(84, 58);
            this.LblDescuentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblDescuentos.Name = "LblDescuentos";
            this.LblDescuentos.Size = new System.Drawing.Size(31, 32);
            this.LblDescuentos.TabIndex = 2;
            this.LblDescuentos.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Descuentos";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(383, 2);
            this.panel13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(180, 110);
            this.panel13.TabIndex = 2;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel16.Controls.Add(this.LblImpuestos);
            this.panel16.Controls.Add(this.label9);
            this.panel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel16.Location = new System.Drawing.Point(5, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(172, 109);
            this.panel16.TabIndex = 5;
            // 
            // LblImpuestos
            // 
            this.LblImpuestos.AutoSize = true;
            this.LblImpuestos.Location = new System.Drawing.Point(76, 58);
            this.LblImpuestos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblImpuestos.Name = "LblImpuestos";
            this.LblImpuestos.Size = new System.Drawing.Size(31, 32);
            this.LblImpuestos.TabIndex = 3;
            this.LblImpuestos.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Impuestos";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel17);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(567, 2);
            this.panel14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(211, 110);
            this.panel14.TabIndex = 3;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel17.Controls.Add(this.LblTotal);
            this.panel17.Controls.Add(this.label10);
            this.panel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel17.Location = new System.Drawing.Point(-1, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(204, 109);
            this.panel17.TabIndex = 5;
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.ForeColor = System.Drawing.Color.Yellow;
            this.LblTotal.Location = new System.Drawing.Point(75, 58);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(31, 32);
            this.LblTotal.TabIndex = 3;
            this.LblTotal.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 32);
            this.label10.TabIndex = 0;
            this.label10.Text = "TOTAL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel11.Controls.Add(this.LblSubTotal);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel11.Location = new System.Drawing.Point(2, 2);
            this.panel11.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(190, 109);
            this.panel11.TabIndex = 4;
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.AutoSize = true;
            this.LblSubTotal.Location = new System.Drawing.Point(80, 58);
            this.LblSubTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(31, 32);
            this.LblSubTotal.TabIndex = 1;
            this.LblSubTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sub Total";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(788, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(167, 143);
            this.panel5.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tableLayoutPanel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(788, 149);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(167, 273);
            this.panel6.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel10, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.35135F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.64865F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(163, 272);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(2, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(159, 88);
            this.panel8.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(-3, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.button2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 94);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(159, 84);
            this.panel9.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 2);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 84);
            this.button2.TabIndex = 0;
            this.button2.Text = "Editar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.button3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(2, 182);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(159, 88);
            this.panel10.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 82);
            this.button3.TabIndex = 0;
            this.button3.Text = "Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(788, 426);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(167, 112);
            this.panel7.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.Facturar, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.Cancel, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 5);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(165, 106);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // Facturar
            // 
            this.Facturar.BackColor = System.Drawing.Color.YellowGreen;
            this.Facturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facturar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Facturar.Location = new System.Drawing.Point(2, 2);
            this.Facturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Facturar.Name = "Facturar";
            this.Facturar.Size = new System.Drawing.Size(160, 48);
            this.Facturar.TabIndex = 0;
            this.Facturar.Text = "Facturar";
            this.Facturar.UseVisualStyleBackColor = false;
            this.Facturar.Click += new System.EventHandler(this.Facturar_Click);
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Red;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Cancel.Location = new System.Drawing.Point(2, 55);
            this.Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(160, 49);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancelar";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // TxtUSer
            // 
            this.TxtUSer.BackColor = System.Drawing.Color.Moccasin;
            this.TxtUSer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUSer.Location = new System.Drawing.Point(87, 12);
            this.TxtUSer.Name = "TxtUSer";
            this.TxtUSer.Size = new System.Drawing.Size(118, 26);
            this.TxtUSer.TabIndex = 19;
            this.TxtUSer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(957, 540);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmBuy";
            this.Text = "Registro de Compras";
            this.Load += new System.EventHandler(this.FrmBuy_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.Encabezado.ResumeLayout(false);
            this.Encabezado.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaItems)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel Encabezado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtNotas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbBuyType;
        private System.Windows.Forms.Label LblNombreCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DtpFechaFactura;
        private System.Windows.Forms.DataGridView DgvListaItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button Facturar;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.ComboBox cvMethodp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnClienteBuscar;
        private System.Windows.Forms.Label txtUsuario;
        public System.Windows.Forms.TextBox TxtCustomerID;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblDescuentos;
        private System.Windows.Forms.Label LblImpuestos;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CItemItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescripcionItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUnitaryPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPercentageDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSubTotalLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn CImpuestoLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTotalLine;
        public System.Windows.Forms.TextBox TxtUSer;
    }
}