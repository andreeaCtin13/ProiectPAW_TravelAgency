namespace ProiectPAW_TravelAgency
{
    partial class Modal
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
            this.lblDestionation = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblServicii = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRezerva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDestionation
            // 
            this.lblDestionation.AutoSize = true;
            this.lblDestionation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDestionation.Location = new System.Drawing.Point(49, 58);
            this.lblDestionation.Name = "lblDestionation";
            this.lblDestionation.Size = new System.Drawing.Size(0, 29);
            this.lblDestionation.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrice.Location = new System.Drawing.Point(54, 128);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 16);
            this.lblPrice.TabIndex = 1;
            // 
            // lblServicii
            // 
            this.lblServicii.AutoSize = true;
            this.lblServicii.Location = new System.Drawing.Point(51, 196);
            this.lblServicii.Name = "lblServicii";
            this.lblServicii.Size = new System.Drawing.Size(0, 16);
            this.lblServicii.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "euro";
            // 
            // btnRezerva
            // 
            this.btnRezerva.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRezerva.Location = new System.Drawing.Point(377, 246);
            this.btnRezerva.Name = "btnRezerva";
            this.btnRezerva.Size = new System.Drawing.Size(145, 42);
            this.btnRezerva.TabIndex = 4;
            this.btnRezerva.Text = "REZERVA";
            this.btnRezerva.UseVisualStyleBackColor = true;
            this.btnRezerva.Click += new System.EventHandler(this.btnRezerva_Click);
            // 
            // Modal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(619, 339);
            this.Controls.Add(this.btnRezerva);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblServicii);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDestionation);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Modal";
            this.Text = "Modal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestionation;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblServicii;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezerva;
    }
}