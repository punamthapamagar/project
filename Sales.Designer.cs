namespace project
{
    partial class Sales
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.grdSales = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbCustomer = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtSales = new System.Windows.Forms.DateTimePicker();
            this.lblProductID = new System.Windows.Forms.Label();
            this.ndQuantity = new System.Windows.Forms.NumericUpDown();
            this.ndRate = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmountofInvoice = new System.Windows.Forms.TextBox();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtSalesID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblAmountofInvoice = new System.Windows.Forms.Label();
            this.txtRemarks = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblDateofSales = new System.Windows.Forms.Label();
            this.lblSalesID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblSales = new System.Windows.Forms.Label();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 467);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grdSales);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(823, 464);
            this.panel2.TabIndex = 0;
            // 
            // grdSales
            // 
            this.grdSales.AllowUserToAddRows = false;
            this.grdSales.AllowUserToDeleteRows = false;
            this.grdSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.SalesRate,
            this.Total});
            this.grdSales.Location = new System.Drawing.Point(0, 226);
            this.grdSales.Name = "grdSales";
            this.grdSales.RowTemplate.Height = 24;
            this.grdSales.Size = new System.Drawing.Size(826, 235);
            this.grdSales.TabIndex = 3;
            this.grdSales.DoubleClick += new System.EventHandler(this.grdSales_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.cmbCustomer);
            this.panel4.Controls.Add(this.cmbProduct);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.dtSales);
            this.panel4.Controls.Add(this.lblProductID);
            this.panel4.Controls.Add(this.ndQuantity);
            this.panel4.Controls.Add(this.ndRate);
            this.panel4.Controls.Add(this.lblQuantity);
            this.panel4.Controls.Add(this.lblRate);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtAmountofInvoice);
            this.panel4.Controls.Add(this.txtRemark);
            this.panel4.Controls.Add(this.txtInvoiceNo);
            this.panel4.Controls.Add(this.txtSalesID);
            this.panel4.Controls.Add(this.lblCustomerID);
            this.panel4.Controls.Add(this.lblAmountofInvoice);
            this.panel4.Controls.Add(this.txtRemarks);
            this.panel4.Controls.Add(this.lblInvoiceNo);
            this.panel4.Controls.Add(this.lblDateofSales);
            this.panel4.Controls.Add(this.lblSalesID);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(823, 155);
            this.panel4.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(680, 65);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 39);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbCustomer
            // 
            this.cmbCustomer.FormattingEnabled = true;
            this.cmbCustomer.Location = new System.Drawing.Point(521, 10);
            this.cmbCustomer.Name = "cmbCustomer";
            this.cmbCustomer.Size = new System.Drawing.Size(121, 24);
            this.cmbCustomer.TabIndex = 10;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(120, 113);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 9;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(245, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtSales
            // 
            this.dtSales.Location = new System.Drawing.Point(120, 48);
            this.dtSales.Name = "dtSales";
            this.dtSales.Size = new System.Drawing.Size(200, 22);
            this.dtSales.TabIndex = 7;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(9, 122);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 17);
            this.lblProductID.TabIndex = 5;
            this.lblProductID.Text = "Product ID";
            // 
            // ndQuantity
            // 
            this.ndQuantity.Location = new System.Drawing.Point(395, 117);
            this.ndQuantity.Name = "ndQuantity";
            this.ndQuantity.Size = new System.Drawing.Size(120, 22);
            this.ndQuantity.TabIndex = 4;
            this.ndQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndRate
            // 
            this.ndRate.Location = new System.Drawing.Point(680, 117);
            this.ndRate.Name = "ndRate";
            this.ndRate.Size = new System.Drawing.Size(120, 22);
            this.ndRate.TabIndex = 4;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(301, 122);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(603, 122);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 17);
            this.lblRate.TabIndex = 3;
            this.lblRate.Text = "Rate";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(680, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAmountofInvoice
            // 
            this.txtAmountofInvoice.Location = new System.Drawing.Point(521, 50);
            this.txtAmountofInvoice.Name = "txtAmountofInvoice";
            this.txtAmountofInvoice.Size = new System.Drawing.Size(100, 22);
            this.txtAmountofInvoice.TabIndex = 1;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(521, 82);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(100, 22);
            this.txtRemark.TabIndex = 1;
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(120, 80);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 22);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // txtSalesID
            // 
            this.txtSalesID.Location = new System.Drawing.Point(120, 9);
            this.txtSalesID.Name = "txtSalesID";
            this.txtSalesID.Size = new System.Drawing.Size(100, 22);
            this.txtSalesID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(355, 17);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblAmountofInvoice
            // 
            this.lblAmountofInvoice.AutoSize = true;
            this.lblAmountofInvoice.Location = new System.Drawing.Point(355, 48);
            this.lblAmountofInvoice.Name = "lblAmountofInvoice";
            this.lblAmountofInvoice.Size = new System.Drawing.Size(120, 17);
            this.lblAmountofInvoice.TabIndex = 0;
            this.lblAmountofInvoice.Text = "Amount of Invoice";
            // 
            // txtRemarks
            // 
            this.txtRemarks.AutoSize = true;
            this.txtRemarks.Location = new System.Drawing.Point(355, 80);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(64, 17);
            this.txtRemarks.TabIndex = 0;
            this.txtRemarks.Text = "Remarks";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(9, 85);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 17);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblDateofSales
            // 
            this.lblDateofSales.AutoSize = true;
            this.lblDateofSales.Location = new System.Drawing.Point(9, 48);
            this.lblDateofSales.Name = "lblDateofSales";
            this.lblDateofSales.Size = new System.Drawing.Size(93, 17);
            this.lblDateofSales.TabIndex = 0;
            this.lblDateofSales.Text = "Date of Sales";
            // 
            // lblSalesID
            // 
            this.lblSalesID.AutoSize = true;
            this.lblSalesID.Location = new System.Drawing.Point(9, 12);
            this.lblSalesID.Name = "lblSalesID";
            this.lblSalesID.Size = new System.Drawing.Size(60, 17);
            this.lblSalesID.TabIndex = 0;
            this.lblSalesID.Text = "Sales ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnReset);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Controls.Add(this.lblSales);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(823, 65);
            this.panel3.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(710, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(89, 40);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(567, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(443, 13);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(324, 13);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(94, 40);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.Location = new System.Drawing.Point(20, 9);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(89, 36);
            this.lblSales.TabIndex = 0;
            this.lblSales.Text = "Sales";
            // 
            // SNo
            // 
            this.SNo.DataPropertyName = "SNo";
            this.SNo.HeaderText = "SNo";
            this.SNo.Name = "SNo";
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ProductName";
            this.ProductName.Name = "ProductName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // SalesRate
            // 
            this.SalesRate.DataPropertyName = "SalesRate";
            this.SalesRate.HeaderText = "SalesRate";
            this.SalesRate.Name = "SalesRate";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 467);
            this.Controls.Add(this.panel1);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdSales)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmountofInvoice;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TextBox txtSalesID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Label lblAmountofInvoice;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblDateofSales;
        private System.Windows.Forms.Label lblSalesID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.DataGridView grdSales;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label txtRemarks;
        private System.Windows.Forms.NumericUpDown ndQuantity;
        private System.Windows.Forms.NumericUpDown ndRate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtSales;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cmbCustomer;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

