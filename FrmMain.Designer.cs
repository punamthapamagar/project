namespace project
{
    partial class FrmMain
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
            this.masterEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSales = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPurchaseReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalesReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockReport = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterEntryToolStripMenuItem,
            this.entryToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterEntryToolStripMenuItem
            // 
            this.masterEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuSupplier,
            this.mnuProduct});
            this.masterEntryToolStripMenuItem.Name = "masterEntryToolStripMenuItem";
            this.masterEntryToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.masterEntryToolStripMenuItem.Text = "Master Entry";
            // 
            // entryToolStripMenuItem
            // 
            this.entryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurchase,
            this.mnuPurchaseDetails,
            this.mnuSales,
            this.mnuSalesDetails});
            this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
            this.entryToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.entryToolStripMenuItem.Text = "Entry";
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStaff});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPurchaseReport,
            this.mnuSalesReport,
            this.mnuStockReport});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // mnuCustomer
            // 
            this.mnuCustomer.Name = "mnuCustomer";
            this.mnuCustomer.Size = new System.Drawing.Size(216, 26);
            this.mnuCustomer.Text = "Customer";
            this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
            // 
            // mnuSupplier
            // 
            this.mnuSupplier.Name = "mnuSupplier";
            this.mnuSupplier.Size = new System.Drawing.Size(216, 26);
            this.mnuSupplier.Text = "Supplier";
            this.mnuSupplier.Click += new System.EventHandler(this.mnuSupplier_Click);
            // 
            // mnuProduct
            // 
            this.mnuProduct.Name = "mnuProduct";
            this.mnuProduct.Size = new System.Drawing.Size(216, 26);
            this.mnuProduct.Text = "Product";
            this.mnuProduct.Click += new System.EventHandler(this.mnuProduct_Click);
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.Name = "mnuPurchase";
            this.mnuPurchase.Size = new System.Drawing.Size(216, 26);
            this.mnuPurchase.Text = "Purchase";
            this.mnuPurchase.Click += new System.EventHandler(this.mnuPurchase_Click);
            // 
            // mnuPurchaseDetails
            // 
            this.mnuPurchaseDetails.Name = "mnuPurchaseDetails";
            this.mnuPurchaseDetails.Size = new System.Drawing.Size(216, 26);
            this.mnuPurchaseDetails.Text = "PurchaseDetails";
            this.mnuPurchaseDetails.Click += new System.EventHandler(this.mnuPurchaseDetails_Click);
            // 
            // mnuSales
            // 
            this.mnuSales.Name = "mnuSales";
            this.mnuSales.Size = new System.Drawing.Size(216, 26);
            this.mnuSales.Text = "Sales";
            this.mnuSales.Click += new System.EventHandler(this.mnuSales_Click);
            // 
            // mnuSalesDetails
            // 
            this.mnuSalesDetails.Name = "mnuSalesDetails";
            this.mnuSalesDetails.Size = new System.Drawing.Size(216, 26);
            this.mnuSalesDetails.Text = "SalesDetails";
            this.mnuSalesDetails.Click += new System.EventHandler(this.mnuSalesDetails_Click);
            // 
            // mnuStaff
            // 
            this.mnuStaff.Name = "mnuStaff";
            this.mnuStaff.Size = new System.Drawing.Size(216, 26);
            this.mnuStaff.Text = "Staff";
            this.mnuStaff.Click += new System.EventHandler(this.mnuStaff_Click);
            // 
            // mnuPurchaseReport
            // 
            this.mnuPurchaseReport.Name = "mnuPurchaseReport";
            this.mnuPurchaseReport.Size = new System.Drawing.Size(216, 26);
            this.mnuPurchaseReport.Text = "PurchaseReport";
            this.mnuPurchaseReport.Click += new System.EventHandler(this.mnuPurchaseReport_Click);
            // 
            // mnuSalesReport
            // 
            this.mnuSalesReport.Name = "mnuSalesReport";
            this.mnuSalesReport.Size = new System.Drawing.Size(216, 26);
            this.mnuSalesReport.Text = "SalesReport";
            this.mnuSalesReport.Click += new System.EventHandler(this.mnuSalesReport_Click);
            // 
            // mnuStockReport
            // 
            this.mnuStockReport.Name = "mnuStockReport";
            this.mnuStockReport.Size = new System.Drawing.Size(216, 26);
            this.mnuStockReport.Text = "StockReport";
            this.mnuStockReport.Click += new System.EventHandler(this.mnuStockReport_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnuSupplier;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchaseDetails;
        private System.Windows.Forms.ToolStripMenuItem mnuSales;
        private System.Windows.Forms.ToolStripMenuItem mnuSalesDetails;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStaff;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuPurchaseReport;
        private System.Windows.Forms.ToolStripMenuItem mnuSalesReport;
        private System.Windows.Forms.ToolStripMenuItem mnuStockReport;
    }
}