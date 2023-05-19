﻿namespace VCBikeService.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.Lblrecoverpassword = new System.Windows.Forms.LinkLabel();
            this.BtnLogin = new VCBikeService.Extras.CustomButtons();
            this.BtnCancel = new VCBikeService.Extras.CustomButtons();
            this.customButtons2 = new VCBikeService.Extras.CustomButtons();
            this.customButtons1 = new VCBikeService.Extras.CustomButtons();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(211, 198);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(265, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(188, 243);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(302, 34);
            this.TxtUserName.TabIndex = 4;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Font = new System.Drawing.Font("Tahoma", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(188, 337);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(302, 34);
            this.TxtPassword.TabIndex = 5;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // Lblrecoverpassword
            // 
            this.Lblrecoverpassword.AutoSize = true;
            this.Lblrecoverpassword.BackColor = System.Drawing.Color.Transparent;
            this.Lblrecoverpassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblrecoverpassword.LinkColor = System.Drawing.Color.Red;
            this.Lblrecoverpassword.Location = new System.Drawing.Point(326, 374);
            this.Lblrecoverpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lblrecoverpassword.Name = "Lblrecoverpassword";
            this.Lblrecoverpassword.Size = new System.Drawing.Size(164, 19);
            this.Lblrecoverpassword.TabIndex = 8;
            this.Lblrecoverpassword.TabStop = true;
            this.Lblrecoverpassword.Text = "Recuperar Contraseña";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.OliveDrab;
            this.BtnLogin.Backgroundcolor = System.Drawing.Color.OliveDrab;
            this.BtnLogin.BackgroundColor = System.Drawing.Color.OliveDrab;
            this.BtnLogin.BorderColor = System.Drawing.Color.Black;
            this.BtnLogin.BorderRadius = 20;
            this.BtnLogin.BorderSize = 0;
            this.BtnLogin.FlatAppearance.BorderSize = 0;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.White;
            this.BtnLogin.Location = new System.Drawing.Point(365, 411);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(185, 48);
            this.BtnLogin.TabIndex = 7;
            this.BtnLogin.Text = "Ingresar";
            this.BtnLogin.Textcolor = System.Drawing.Color.White;
            this.BtnLogin.TextColor = System.Drawing.Color.White;
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.Red;
            this.BtnCancel.Backgroundcolor = System.Drawing.Color.Red;
            this.BtnCancel.BackgroundColor = System.Drawing.Color.Red;
            this.BtnCancel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnCancel.BorderRadius = 20;
            this.BtnCancel.BorderSize = 0;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(124, 413);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(185, 48);
            this.BtnCancel.TabIndex = 6;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.Textcolor = System.Drawing.Color.White;
            this.BtnCancel.TextColor = System.Drawing.Color.White;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // customButtons2
            // 
            this.customButtons2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons2.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons2.BorderRadius = 20;
            this.customButtons2.BorderSize = 0;
            this.customButtons2.FlatAppearance.BorderSize = 0;
            this.customButtons2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons2.ForeColor = System.Drawing.Color.White;
            this.customButtons2.Location = new System.Drawing.Point(18552, 18040);
            this.customButtons2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customButtons2.Name = "customButtons2";
            this.customButtons2.Size = new System.Drawing.Size(185, 48);
            this.customButtons2.TabIndex = 1;
            this.customButtons2.Text = "customButtons2";
            this.customButtons2.Textcolor = System.Drawing.Color.White;
            this.customButtons2.TextColor = System.Drawing.Color.White;
            this.customButtons2.UseVisualStyleBackColor = false;
            // 
            // customButtons1
            // 
            this.customButtons1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons1.Backgroundcolor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customButtons1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButtons1.BorderRadius = 20;
            this.customButtons1.BorderSize = 0;
            this.customButtons1.FlatAppearance.BorderSize = 0;
            this.customButtons1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButtons1.ForeColor = System.Drawing.Color.White;
            this.customButtons1.Location = new System.Drawing.Point(18552, 18040);
            this.customButtons1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.customButtons1.Name = "customButtons1";
            this.customButtons1.Size = new System.Drawing.Size(362, 128);
            this.customButtons1.TabIndex = 0;
            this.customButtons1.Text = "customButtons1";
            this.customButtons1.Textcolor = System.Drawing.Color.White;
            this.customButtons1.TextColor = System.Drawing.Color.White;
            this.customButtons1.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 915);
            this.Controls.Add(this.Lblrecoverpassword);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customButtons2);
            this.Controls.Add(this.customButtons1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Extras.CustomButtons customButtons1;
        private Extras.CustomButtons customButtons2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.LinkLabel Lblrecoverpassword;
        private Extras.CustomButtons BtnLogin;
        private Extras.CustomButtons BtnCancel;
    }
}