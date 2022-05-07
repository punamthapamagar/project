namespace project
{
    partial class SalesDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grdSalesDetails = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grdSalesList = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblSalesRate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblSalesID = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtSalesRate = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSalesDetails = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateofSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountofInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grdSalesDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.grdSalesList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 437);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grdSalesDetails);
            this.panel5.Location = new System.Drawing.Point(386, 218);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(396, 216);
            this.panel5.TabIndex = 3;
            // 
            // grdSalesDetails
            // 
            this.grdSalesDetails.Controls.Add(this.dataGridView2);
            this.grdSalesDetails.Location = new System.Drawing.Point(3, 3);
            this.grdSalesDetails.Name = "grdSalesDetails";
            this.grdSalesDetails.Size = new System.Drawing.Size(390, 210);
            this.grdSalesDetails.TabIndex = 0;
            this.grdSalesDetails.TabStop = false;
            this.grdSalesDetails.Text = "Sales Details";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.SalesRate,
            this.Quantity,
            this.Total});
            this.dataGridView2.Location = new System.Drawing.Point(6, 21);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(378, 184);
            this.dataGridView2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdSalesList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 225);
            this.panel4.TabIndex = 2;
            // 
            // grdSalesList
            // 
            this.grdSalesList.Controls.Add(this.dataGridView1);
            this.grdSalesList.Location = new System.Drawing.Point(9, 9);
            this.grdSalesList.Name = "grdSalesList";
            this.grdSalesList.Size = new System.Drawing.Size(368, 205);
            this.grdSalesList.TabIndex = 0;
            this.grdSalesList.TabStop = false;
            this.grdSalesList.Text = "Sales List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SalesID,
            this.DateofSales,
            this.InvoiceNo,
            this.Column4,
            this.AmountofInvoice});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(356, 178);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblSalesRate);
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Controls.Add(this.lblProductID);
            this.panel3.Controls.Add(this.lblSalesID);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.txtSalesRate);
            this.panel3.Controls.Add(this.txtProductID);
            this.panel3.Controls.Add(this.txtSalesID);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(785, 134);
            this.panel3.TabIndex = 1;
            // 
            // lblSalesRate
            // 
            this.lblSalesRate.AutoSize = true;
            this.lblSalesRate.Location = new System.Drawing.Point(443, 20);
            this.lblSalesRate.Name = "lblSalesRate";
            this.lblSalesRate.Size = new System.Drawing.Size(77, 17);
            this.lblSalesRate.TabIndex = 1;
            this.lblSalesRate.Text = "Sales Rate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(443, 52);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(31, 52);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 17);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblSalesID
            // 
            this.lblSalesID.AutoSize = true;
            this.lblSalesID.Location = new System.Drawing.Point(31, 25);
            this.lblSalesID.Name = "lblSalesID";
            this.lblSalesID.Size = new System.Drawing.Size(60, 17);
            this.lblSalesID.TabIndex = 1;
            this.lblSalesID.Text = "Sales ID";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(566, 52);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.Location = new System.Drawing.Point(566, 17);
            this.txtSalesRate.Name = "txtSalesRate";
            this.txtSalesRate.Size = new System.Drawing.Size(100, 22);
            this.txtSalesRate.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(129, 52);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 1;
            // 
            // txtSalesID
            // 
            this.txtSalesID.Location = new System.Drawing.Point(129, 20);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(100, 22);
            this.txtSalesID.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(414, 94);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSalesDetails);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 78);
            this.panel2.TabIndex = 0;
            // 
            // lblSalesDetails
            // 
            this.lblSalesDetails.AutoSize = true;
            this.lblSalesDetails.Location = new System.Drawing.Point(61, 28);
            this.lblSalesDetails.Name = "lblSalesDetails";
            this.lblSalesDetails.Size = new System.Drawing.Size(90, 17);
            this.lblSalesDetails.TabIndex = 1;
            this.lblSalesDetails.Text = "Sales Details";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(687, 23);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 35);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show/Hide Details";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(591, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(495, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(414, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(321, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(227, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Product ID";
            this.Column6.Name = "Column6";
            // 
            // SalesRate
            // 
            this.SalesRate.DataPropertyName = "SalesRate";
            this.SalesRate.HeaderText = "SalesRate";
            this.SalesRate.Name = "SalesRate";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity ";
            this.Quantity.Name = "Quantity";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // SalesID
            // 
            this.SalesID.DataPropertyName = "SalesID";
            this.SalesID.HeaderText = "SalesID";
            this.SalesID.Name = "SalesID";
            // 
            // DateofSales
            // 
            this.DateofSales.DataPropertyName = "DateofSales";
            this.DateofSales.HeaderText = "DateofSales";
            this.DateofSales.Name = "DateofSales";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.DataPropertyName = "InvoiceNo";
            this.InvoiceNo.HeaderText = "InvoiceNo";
            this.InvoiceNo.Name = "InvoiceNo";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CustomerID";
            this.Column4.HeaderText = "CustomerID";
            this.Column4.Name = "Column4";
            // 
            // AmountofInvoice
            // 
            this.AmountofInvoice.DataPropertyName = "AmountofInvoice";
            this.AmountofInvoice.HeaderText = "AmountofInvoice";
            this.AmountofInvoice.Name = "AmountofInvoice";
            // 
            // SalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "SalesDetails";
            this.Text = "SalesDetail";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grdSalesDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.grdSalesList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grdSalesDetails;
        private System.Windows.Forms.GroupBox grdSalesList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblSalesRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblSalesID;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtSalesRate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSalesDetails;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateofSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountofInvoice;
    }
}