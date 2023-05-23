namespace ProiectPAW_TravelAgency
{
    partial class VacanteUser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvVacante = new System.Windows.Forms.ListView();
            this.clPret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clServicii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goBackToolStripMenuItem
            // 
            this.goBackToolStripMenuItem.Name = "goBackToolStripMenuItem";
            this.goBackToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.goBackToolStripMenuItem.Text = "Go Back";
            this.goBackToolStripMenuItem.Click += new System.EventHandler(this.goBackToolStripMenuItem_Click);
            // 
            // lvVacante
            // 
            this.lvVacante.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lvVacante.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lvVacante.BackgroundImageTiled = true;
            this.lvVacante.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clDen,
            this.clServicii,
            this.clPret});
            this.lvVacante.Enabled = false;
            this.lvVacante.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lvVacante.FullRowSelect = true;
            this.lvVacante.HideSelection = false;
            this.lvVacante.Location = new System.Drawing.Point(34, 47);
            this.lvVacante.Name = "lvVacante";
            this.lvVacante.ShowItemToolTips = true;
            this.lvVacante.Size = new System.Drawing.Size(691, 364);
            this.lvVacante.TabIndex = 0;
            this.lvVacante.UseCompatibleStateImageBehavior = false;
            this.lvVacante.View = System.Windows.Forms.View.Details;
            // 
            // clPret
            // 
            this.clPret.Text = "Pret";
            this.clPret.Width = 172;
            // 
            // clServicii
            // 
            this.clServicii.Text = "Servicii";
            this.clServicii.Width = 136;
            // 
            // clDen
            // 
            this.clDen.Text = "Denumire";
            this.clDen.Width = 115;
            // 
            // VacanteUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvVacante);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VacanteUser";
            this.Text = "VacanteUser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goBackToolStripMenuItem;
        private System.Windows.Forms.ListView lvVacante;
        private System.Windows.Forms.ColumnHeader clPret;
        private System.Windows.Forms.ColumnHeader clServicii;
        private System.Windows.Forms.ColumnHeader clDen;
    }
}