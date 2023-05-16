namespace VCBikeService.Forms
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
            this.customButtons2 = new VCBikeService.Extras.CustomButtons();
            this.customButtons1 = new VCBikeService.Extras.CustomButtons();
            this.SuspendLayout();
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
            this.customButtons2.Location = new System.Drawing.Point(15179, 15034);
            this.customButtons2.Name = "customButtons2";
            this.customButtons2.Size = new System.Drawing.Size(150, 40);
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
            this.customButtons1.Location = new System.Drawing.Point(15179, 15034);
            this.customButtons1.Name = "customButtons1";
            this.customButtons1.Size = new System.Drawing.Size(296, 106);
            this.customButtons1.TabIndex = 0;
            this.customButtons1.Text = "customButtons1";
            this.customButtons1.Textcolor = System.Drawing.Color.White;
            this.customButtons1.TextColor = System.Drawing.Color.White;
            this.customButtons1.UseVisualStyleBackColor = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(564, 775);
            this.Controls.Add(this.customButtons2);
            this.Controls.Add(this.customButtons1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Extras.CustomButtons customButtons1;
        private Extras.CustomButtons customButtons2;
    }
}