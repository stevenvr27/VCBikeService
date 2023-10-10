namespace VCBikeService.Forms
{
    partial class RecuperarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseña));
            this.btnSend = new WindowsFormsAero.Button();
            this.txtCode2 = new WindowsFormsAero.TextBox();
            this.TxtCode1 = new WindowsFormsAero.TextBox();
            this.TxtUserName = new WindowsFormsAero.TextBox();
            this.TxtEmail = new WindowsFormsAero.TextBox();
            this.button1 = new WindowsFormsAero.Button();
            this.button2 = new WindowsFormsAero.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gray;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(196, 246);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(122, 36);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Enviar Codigo";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtCode2
            // 
            this.txtCode2.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode2.Location = new System.Drawing.Point(154, 406);
            this.txtCode2.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode2.Name = "txtCode2";
            this.txtCode2.Size = new System.Drawing.Size(217, 29);
            this.txtCode2.TabIndex = 21;
            // 
            // TxtCode1
            // 
            this.TxtCode1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode1.Location = new System.Drawing.Point(154, 324);
            this.TxtCode1.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCode1.Name = "TxtCode1";
            this.TxtCode1.Size = new System.Drawing.Size(217, 29);
            this.TxtCode1.TabIndex = 20;
            // 
            // TxtUserName
            // 
            this.TxtUserName.BackColor = System.Drawing.SystemColors.Info;
            this.TxtUserName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(154, 76);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(217, 29);
            this.TxtUserName.TabIndex = 19;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(154, 192);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(217, 29);
            this.TxtEmail.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(57, 484);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 44);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(292, 484);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(183, 33);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(153, 20);
            this.label19.TabIndex = 27;
            this.label19.Text = "Nombre del Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(192, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Correo Electronico:";
            // 
            // RecuperarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 605);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtCode2);
            this.Controls.Add(this.TxtCode1);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtEmail);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RecuperarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecuperarContraseña";
            this.Load += new System.EventHandler(this.RecuperarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsAero.Button btnSend;
        private WindowsFormsAero.TextBox txtCode2;
        private WindowsFormsAero.TextBox TxtCode1;
        private WindowsFormsAero.TextBox TxtUserName;
        private WindowsFormsAero.TextBox TxtEmail;
        private WindowsFormsAero.Button button1;
        private WindowsFormsAero.Button button2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label1;
    }
}