namespace VCBikeService.Forms
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.PanelBarraTitulo = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Panelformulario = new System.Windows.Forms.Panel();
            this.PBLongOut = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.PanelContenedor.SuspendLayout();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLongOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.BackColor = System.Drawing.Color.NavajoWhite;
            this.PanelContenedor.Controls.Add(this.Panelformulario);
            this.PanelContenedor.Controls.Add(this.PanelMenu);
            this.PanelContenedor.Controls.Add(this.PanelBarraTitulo);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(0, 0);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(1109, 650);
            this.PanelContenedor.TabIndex = 0;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackColor = System.Drawing.Color.Brown;
            this.PanelBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.PanelBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.PBLongOut);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Size = new System.Drawing.Size(1109, 56);
            this.PanelBarraTitulo.TabIndex = 0;
            this.PanelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseMove);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.Silver;
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 56);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(250, 594);
            this.PanelMenu.TabIndex = 1;
            // 
            // Panelformulario
            // 
            this.Panelformulario.BackColor = System.Drawing.Color.White;
            this.Panelformulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panelformulario.Location = new System.Drawing.Point(250, 56);
            this.Panelformulario.Name = "Panelformulario";
            this.Panelformulario.Size = new System.Drawing.Size(859, 594);
            this.Panelformulario.TabIndex = 2;
            // 
            // PBLongOut
            // 
            this.PBLongOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBLongOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.PBLongOut.Image = ((System.Drawing.Image)(resources.GetObject("PBLongOut.Image")));
            this.PBLongOut.Location = new System.Drawing.Point(1056, 0);
            this.PBLongOut.Name = "PBLongOut";
            this.PBLongOut.Size = new System.Drawing.Size(53, 56);
            this.PBLongOut.TabIndex = 0;
            this.PBLongOut.TabStop = false;
            this.PBLongOut.Click += new System.EventHandler(this.PBLongOut_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(882, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(61, 56);
            this.BtnMinimizar.TabIndex = 0;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(994, 0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(62, 56);
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(943, 0);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(51, 56);
            this.BtnRestaurar.TabIndex = 2;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 650);
            this.Controls.Add(this.PanelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.PanelContenedor.ResumeLayout(false);
            this.PanelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBLongOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.Panel Panelformulario;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelBarraTitulo;
        private System.Windows.Forms.PictureBox PBLongOut;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnMaximizar;
    }
}