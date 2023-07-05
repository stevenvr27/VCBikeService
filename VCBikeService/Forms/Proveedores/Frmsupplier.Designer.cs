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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBSupplier = new System.Windows.Forms.CheckBox();
            this.TxtSearchSupplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtIDSupplier = new System.Windows.Forms.TextBox();
            this.TxtSupplierName = new System.Windows.Forms.TextBox();
            this.TxtSupplierCardID = new System.Windows.Forms.TextBox();
            this.TxtSupplierEmail = new System.Windows.Forms.TextBox();
            this.TxtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CbSupplierType = new System.Windows.Forms.ComboBox();
            this.TxtSupplierPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtSupplierActive = new System.Windows.Forms.TextBox();
            this.userDetail = new System.Windows.Forms.GroupBox();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DgSupplier = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.userDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 341F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1318, 765);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBSupplier);
            this.panel1.Controls.Add(this.TxtSearchSupplier);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 65);
            this.panel1.TabIndex = 0;
            // 
            // checkBSupplier
            // 
            this.checkBSupplier.AutoSize = true;
            this.checkBSupplier.Checked = true;
            this.checkBSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBSupplier.Location = new System.Drawing.Point(1035, 20);
            this.checkBSupplier.Name = "checkBSupplier";
            this.checkBSupplier.Size = new System.Drawing.Size(66, 20);
            this.checkBSupplier.TabIndex = 3;
            this.checkBSupplier.Text = "Activo";
            this.checkBSupplier.UseVisualStyleBackColor = true;
            // 
            // TxtSearchSupplier
            // 
            this.TxtSearchSupplier.BackColor = System.Drawing.SystemColors.Window;
            this.TxtSearchSupplier.Location = new System.Drawing.Point(128, 18);
            this.TxtSearchSupplier.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TxtSearchSupplier.Name = "TxtSearchSupplier";
            this.TxtSearchSupplier.Size = new System.Drawing.Size(883, 22);
            this.TxtSearchSupplier.TabIndex = 2;
            this.TxtSearchSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnCancel);
            this.panel2.Controls.Add(this.BtnClean);
            this.panel2.Controls.Add(this.BtnDelete);
            this.panel2.Controls.Add(this.BtnEdit);
            this.panel2.Controls.Add(this.BtnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 688);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1312, 74);
            this.panel2.TabIndex = 1;
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Gray;
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnCancel.Location = new System.Drawing.Point(1020, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(226, 66);
            this.BtnCancel.TabIndex = 12;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnClean
            // 
            this.BtnClean.BackColor = System.Drawing.Color.Black;
            this.BtnClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClean.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnClean.Location = new System.Drawing.Point(768, 3);
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
            this.BtnDelete.Location = new System.Drawing.Point(515, 3);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(226, 66);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAdd.Location = new System.Drawing.Point(18, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(226, 66);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Agregar";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.Black;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.SeaShell;
            this.BtnEdit.Location = new System.Drawing.Point(264, 3);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(226, 66);
            this.BtnEdit.TabIndex = 9;
            this.BtnEdit.Text = "Modificar";
            this.BtnEdit.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cedula:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 208);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Correo Electronico:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(639, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección:";
            // 
            // TxtIDSupplier
            // 
            this.TxtIDSupplier.Location = new System.Drawing.Point(174, 48);
            this.TxtIDSupplier.Name = "TxtIDSupplier";
            this.TxtIDSupplier.ReadOnly = true;
            this.TxtIDSupplier.Size = new System.Drawing.Size(216, 22);
            this.TxtIDSupplier.TabIndex = 8;
            this.TxtIDSupplier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtSupplierName
            // 
            this.TxtSupplierName.Location = new System.Drawing.Point(108, 86);
            this.TxtSupplierName.Name = "TxtSupplierName";
            this.TxtSupplierName.Size = new System.Drawing.Size(482, 22);
            this.TxtSupplierName.TabIndex = 9;
            // 
            // TxtSupplierCardID
            // 
            this.TxtSupplierCardID.Location = new System.Drawing.Point(108, 129);
            this.TxtSupplierCardID.Name = "TxtSupplierCardID";
            this.TxtSupplierCardID.Size = new System.Drawing.Size(482, 22);
            this.TxtSupplierCardID.TabIndex = 10;
            // 
            // TxtSupplierEmail
            // 
            this.TxtSupplierEmail.Location = new System.Drawing.Point(155, 168);
            this.TxtSupplierEmail.Name = "TxtSupplierEmail";
            this.TxtSupplierEmail.Size = new System.Drawing.Size(435, 22);
            this.TxtSupplierEmail.TabIndex = 11;
            // 
            // TxtSupplierAddress
            // 
            this.TxtSupplierAddress.Location = new System.Drawing.Point(745, 174);
            this.TxtSupplierAddress.Multiline = true;
            this.TxtSupplierAddress.Name = "TxtSupplierAddress";
            this.TxtSupplierAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtSupplierAddress.Size = new System.Drawing.Size(533, 81);
            this.TxtSupplierAddress.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(639, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Estado:";
            // 
            // CbSupplierType
            // 
            this.CbSupplierType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSupplierType.FormattingEnabled = true;
            this.CbSupplierType.Location = new System.Drawing.Point(699, 89);
            this.CbSupplierType.Name = "CbSupplierType";
            this.CbSupplierType.Size = new System.Drawing.Size(579, 24);
            this.CbSupplierType.TabIndex = 18;
            // 
            // TxtSupplierPhone
            // 
            this.TxtSupplierPhone.Location = new System.Drawing.Point(126, 208);
            this.TxtSupplierPhone.Name = "TxtSupplierPhone";
            this.TxtSupplierPhone.Size = new System.Drawing.Size(482, 22);
            this.TxtSupplierPhone.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo:";
            // 
            // TxtSupplierActive
            // 
            this.TxtSupplierActive.Location = new System.Drawing.Point(699, 132);
            this.TxtSupplierActive.Name = "TxtSupplierActive";
            this.TxtSupplierActive.Size = new System.Drawing.Size(572, 22);
            this.TxtSupplierActive.TabIndex = 21;
            // 
            // userDetail
            // 
            this.userDetail.Controls.Add(this.TxtSupplierActive);
            this.userDetail.Controls.Add(this.label8);
            this.userDetail.Controls.Add(this.TxtSupplierPhone);
            this.userDetail.Controls.Add(this.CbSupplierType);
            this.userDetail.Controls.Add(this.label10);
            this.userDetail.Controls.Add(this.TxtSupplierAddress);
            this.userDetail.Controls.Add(this.TxtSupplierEmail);
            this.userDetail.Controls.Add(this.TxtSupplierCardID);
            this.userDetail.Controls.Add(this.TxtSupplierName);
            this.userDetail.Controls.Add(this.TxtIDSupplier);
            this.userDetail.Controls.Add(this.label7);
            this.userDetail.Controls.Add(this.label6);
            this.userDetail.Controls.Add(this.label5);
            this.userDetail.Controls.Add(this.label4);
            this.userDetail.Controls.Add(this.label3);
            this.userDetail.Controls.Add(this.label2);
            this.userDetail.Location = new System.Drawing.Point(5, 416);
            this.userDetail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userDetail.Name = "userDetail";
            this.userDetail.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userDetail.Size = new System.Drawing.Size(1274, 265);
            this.userDetail.TabIndex = 4;
            this.userDetail.TabStop = false;
            this.userDetail.Text = "Detalle Usuario";
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
            // CPhoneNumber
            // 
            this.CPhoneNumber.DataPropertyName = "PhoneNumber";
            this.CPhoneNumber.HeaderText = "Celular";
            this.CPhoneNumber.MinimumWidth = 6;
            this.CPhoneNumber.Name = "CPhoneNumber";
            this.CPhoneNumber.ReadOnly = true;
            this.CPhoneNumber.Width = 150;
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
            // CUserCardID
            // 
            this.CUserCardID.DataPropertyName = "UserCardID";
            this.CUserCardID.HeaderText = "Cedula";
            this.CUserCardID.MinimumWidth = 6;
            this.CUserCardID.Name = "CUserCardID";
            this.CUserCardID.ReadOnly = true;
            this.CUserCardID.Width = 200;
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
            // CUserID
            // 
            this.CUserID.DataPropertyName = "UserID";
            this.CUserID.HeaderText = "Cod.Usuario";
            this.CUserID.MinimumWidth = 6;
            this.CUserID.Name = "CUserID";
            this.CUserID.ReadOnly = true;
            this.CUserID.Width = 200;
            // 
            // DgSupplier
            // 
            this.DgSupplier.AllowUserToAddRows = false;
            this.DgSupplier.AllowUserToDeleteRows = false;
            this.DgSupplier.AllowUserToOrderColumns = true;
            this.DgSupplier.BackgroundColor = System.Drawing.Color.Moccasin;
            this.DgSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUserID,
            this.CUserName,
            this.CUserCardID,
            this.CEmail,
            this.CPhoneNumber,
            this.CDescription});
            this.DgSupplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgSupplier.Location = new System.Drawing.Point(5, 75);
            this.DgSupplier.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DgSupplier.MultiSelect = false;
            this.DgSupplier.Name = "DgSupplier";
            this.DgSupplier.ReadOnly = true;
            this.DgSupplier.RowHeadersVisible = false;
            this.DgSupplier.RowHeadersWidth = 62;
            this.DgSupplier.RowTemplate.Height = 28;
            this.DgSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgSupplier.Size = new System.Drawing.Size(1308, 333);
            this.DgSupplier.TabIndex = 5;
            // 
            // Frmsupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 778);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmsupplier";
            this.Text = "Gestion Proveedor";
            this.Load += new System.EventHandler(this.Frmsupplier_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.userDetail.ResumeLayout(false);
            this.userDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgSupplier)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUserCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.GroupBox userDetail;
        private System.Windows.Forms.TextBox TxtSupplierActive;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtSupplierPhone;
        private System.Windows.Forms.ComboBox CbSupplierType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSupplierAddress;
        private System.Windows.Forms.TextBox TxtSupplierEmail;
        private System.Windows.Forms.TextBox TxtSupplierCardID;
        private System.Windows.Forms.TextBox TxtSupplierName;
        private System.Windows.Forms.TextBox TxtIDSupplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
    }
}