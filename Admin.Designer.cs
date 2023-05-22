namespace ProiectPAW_TravelAgency
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnSerialize = new System.Windows.Forms.Button();
            this.btnDeserialize = new System.Windows.Forms.Button();
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.colUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPassword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumberVacation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.pctBin = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareDateFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaModificariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pctBin)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSerialize
            // 
            this.btnSerialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSerialize.Location = new System.Drawing.Point(26, 73);
            this.btnSerialize.Name = "btnSerialize";
            this.btnSerialize.Size = new System.Drawing.Size(196, 48);
            this.btnSerialize.TabIndex = 0;
            this.btnSerialize.Text = "Salveaza date clienti in fisier";
            this.btnSerialize.UseVisualStyleBackColor = true;
            this.btnSerialize.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeserialize
            // 
            this.btnDeserialize.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeserialize.Location = new System.Drawing.Point(297, 73);
            this.btnDeserialize.Name = "btnDeserialize";
            this.btnDeserialize.Size = new System.Drawing.Size(203, 48);
            this.btnDeserialize.TabIndex = 1;
            this.btnDeserialize.Text = "Vizualizeaza Date Fisier";
            this.btnDeserialize.UseVisualStyleBackColor = true;
            this.btnDeserialize.Click += new System.EventHandler(this.btnDeserialize_Click);
            // 
            // listViewClienti
            // 
            this.listViewClienti.AllowDrop = true;
            this.listViewClienti.BackColor = System.Drawing.SystemColors.HighlightText;
            this.listViewClienti.BackgroundImageTiled = true;
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUsername,
            this.colPassword,
            this.colNumberVacation});
            this.listViewClienti.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.HoverSelection = true;
            this.listViewClienti.Location = new System.Drawing.Point(26, 176);
            this.listViewClienti.MultiSelect = false;
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.OwnerDraw = true;
            this.listViewClienti.Size = new System.Drawing.Size(474, 237);
            this.listViewClienti.TabIndex = 2;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            this.listViewClienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 104;
            // 
            // colPassword
            // 
            this.colPassword.Text = "Password";
            this.colPassword.Width = 114;
            // 
            // colNumberVacation
            // 
            this.colNumberVacation.Text = "Number of Vacations";
            this.colNumberVacation.Width = 145;
            // 
            // btnSelect
            // 
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSelect.Location = new System.Drawing.Point(603, 73);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(96, 48);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pctBin
            // 
            this.pctBin.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pctBin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pctBin.ErrorImage")));
            this.pctBin.ImageLocation = "C:\\Users\\costa\\source\\repos\\ProiectPAW_TravelAgency\\images\\bin.png";
            this.pctBin.InitialImage = ((System.Drawing.Image)(resources.GetObject("pctBin.InitialImage")));
            this.pctBin.Location = new System.Drawing.Point(567, 197);
            this.pctBin.Name = "pctBin";
            this.pctBin.Size = new System.Drawing.Size(175, 187);
            this.pctBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctBin.TabIndex = 4;
            this.pctBin.TabStop = false;
            this.pctBin.Click += new System.EventHandler(this.pctBin_Click);
            this.pctBin.DragDrop += new System.Windows.Forms.DragEventHandler(this.binDragDrop);
            this.pctBin.DragEnter += new System.Windows.Forms.DragEventHandler(this.binDragEnter);
            this.pctBin.DragLeave += new System.EventHandler(this.binDragLeave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareDateFisierToolStripMenuItem,
            this.deserializareDateToolStripMenuItem,
            this.salveazaModificariToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // serializareDateFisierToolStripMenuItem
            // 
            this.serializareDateFisierToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.serializareDateFisierToolStripMenuItem.Name = "serializareDateFisierToolStripMenuItem";
            this.serializareDateFisierToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.serializareDateFisierToolStripMenuItem.Text = "Serializare Date Fisier";
            this.serializareDateFisierToolStripMenuItem.Click += new System.EventHandler(this.serializareDateFisierToolStripMenuItem_Click);
            // 
            // deserializareDateToolStripMenuItem
            // 
            this.deserializareDateToolStripMenuItem.Name = "deserializareDateToolStripMenuItem";
            this.deserializareDateToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.deserializareDateToolStripMenuItem.Text = "Deserializare Date ";
            this.deserializareDateToolStripMenuItem.Click += new System.EventHandler(this.deserializareDateToolStripMenuItem_Click);
            // 
            // salveazaModificariToolStripMenuItem
            // 
            this.salveazaModificariToolStripMenuItem.Name = "salveazaModificariToolStripMenuItem";
            this.salveazaModificariToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.salveazaModificariToolStripMenuItem.Text = "Salveaza Modificari";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pctBin);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.listViewClienti);
            this.Controls.Add(this.btnDeserialize);
            this.Controls.Add(this.btnSerialize);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBin)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSerialize;
        private System.Windows.Forms.Button btnDeserialize;
        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.ColumnHeader colUsername;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colNumberVacation;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pctBin;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareDateFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaModificariToolStripMenuItem;
    }
}