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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializareDateFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salveazaModificariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pageSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raportVanzariUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewClienti = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareDateFisierToolStripMenuItem,
            this.deserializareDateToolStripMenuItem,
            this.salveazaModificariToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printToolStripMenuItem1,
            this.pageSetupToolStripMenuItem,
            this.raportVanzariUserToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(222, 196);
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
            this.deserializareDateToolStripMenuItem.Text = "Extragere Date ";
            this.deserializareDateToolStripMenuItem.Click += new System.EventHandler(this.deserializareDateToolStripMenuItem_Click);
            // 
            // salveazaModificariToolStripMenuItem
            // 
            this.salveazaModificariToolStripMenuItem.Name = "salveazaModificariToolStripMenuItem";
            this.salveazaModificariToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.salveazaModificariToolStripMenuItem.Text = "Salveaza Modificari";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.printToolStripMenuItem.Text = "Print Preview";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem1
            // 
            this.printToolStripMenuItem1.Name = "printToolStripMenuItem1";
            this.printToolStripMenuItem1.Size = new System.Drawing.Size(221, 24);
            this.printToolStripMenuItem1.Text = "Print";
            this.printToolStripMenuItem1.Click += new System.EventHandler(this.printToolStripMenuItem1_Click);
            // 
            // pageSetupToolStripMenuItem
            // 
            this.pageSetupToolStripMenuItem.Name = "pageSetupToolStripMenuItem";
            this.pageSetupToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.pageSetupToolStripMenuItem.Text = "Page Setup";
            this.pageSetupToolStripMenuItem.Click += new System.EventHandler(this.pageSetupToolStripMenuItem_Click);
            // 
            // raportVanzariUserToolStripMenuItem
            // 
            this.raportVanzariUserToolStripMenuItem.Name = "raportVanzariUserToolStripMenuItem";
            this.raportVanzariUserToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.raportVanzariUserToolStripMenuItem.Text = "Raport Vanzari/User";
            this.raportVanzariUserToolStripMenuItem.Click += new System.EventHandler(this.raportVanzariUserToolStripMenuItem_Click);
            // 
            // listViewClienti
            // 
            this.listViewClienti.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewClienti.FullRowSelect = true;
            this.listViewClienti.HideSelection = false;
            this.listViewClienti.Location = new System.Drawing.Point(26, 73);
            this.listViewClienti.Name = "listViewClienti";
            this.listViewClienti.Size = new System.Drawing.Size(512, 324);
            this.listViewClienti.TabIndex = 5;
            this.listViewClienti.UseCompatibleStateImageBehavior = false;
            this.listViewClienti.View = System.Windows.Forms.View.Details;
            this.listViewClienti.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.listViewClienti_ItemDrag);
            this.listViewClienti.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listViewClienti_MouseDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "No. Vac";
            this.columnHeader3.Width = 80;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(544, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 223);
            this.panel1.TabIndex = 6;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.logOutToolStripMenuItem.Text = "LogOut";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listViewClienti);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Admin";
            this.Text = "Admin";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareDateFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salveazaModificariToolStripMenuItem;
        private System.Windows.Forms.ListView listViewClienti;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem1;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.ToolStripMenuItem pageSetupToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripMenuItem raportVanzariUserToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}