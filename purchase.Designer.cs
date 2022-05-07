namespace project
{
    partial class Purchase
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbPurchaseList = new System.Windows.Forms.GroupBox();
            this.grdPurchaseList = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.dtPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.ndQuantity = new System.Windows.Forms.NumericUpDown();
            this.ndRate = new System.Windows.Forms.NumericUpDown();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.txtAmountofInvoice = new System.Windows.Forms.TextBox();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.lblDateofpurchase = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAmountofInvoice = new System.Windows.Forms.Label();
            this.lblPurchaseID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbPurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 436);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbPurchaseList);
            this.panel4.Location = new System.Drawing.Point(9, 236);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(784, 191);
            this.panel4.TabIndex = 2;
            // 
            // grbPurchaseList
            // 
            this.grbPurchaseList.Controls.Add(this.grdPurchaseList);
            this.grbPurchaseList.Location = new System.Drawing.Point(6, 3);
            this.grbPurchaseList.Name = "grbPurchaseList";
            this.grbPurchaseList.Size = new System.Drawing.Size(772, 185);
            this.grbPurchaseList.TabIndex = 1;
            this.grbPurchaseList.TabStop = false;
            this.grbPurchaseList.Text = "Purchase List";
            // 
            // grdPurchaseList
            // 
            this.grdPurchaseList.AllowUserToAddRows = false;
            this.grdPurchaseList.AllowUserToDeleteRows = false;
            this.grdPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.PurchaseRate,
            this.Total});
            this.grdPurchaseList.Location = new System.Drawing.Point(6, 21);
            this.grdPurchaseList.Name = "grdPurchaseList";
            this.grdPurchaseList.RowTemplate.Height = 24;
            this.grdPurchaseList.Size = new System.Drawing.Size(756, 158);
            this.grdPurchaseList.TabIndex = 0;
            this.grdPurchaseList.AllowUserToAddRowsChanged += new System.EventHandler(this.False);
            this.grdPurchaseList.AllowUserToDeleteRowsChanged += new System.EventHandler(this.False);
            this.grdPurchaseList.DoubleClick += new System.EventHandler(this.grdPurchaseList_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtRemarks);
            this.panel3.Controls.Add(this.lblRemarks);
            this.panel3.Controls.Add(this.dtPurchase);
            this.panel3.Controls.Add(this.cmbSupplier);
            this.panel3.Controls.Add(this.ndQuantity);
            this.panel3.Controls.Add(this.ndRate);
            this.panel3.Controls.Add(this.cmbProduct);
            this.panel3.Controls.Add(this.lblProductID);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtInvoiceNo);
            this.panel3.Controls.Add(this.txtAmountofInvoice);
            this.panel3.Controls.Add(this.txtPurchaseID);
            this.panel3.Controls.Add(this.lblDateofpurchase);
            this.panel3.Controls.Add(this.lblSupplierID);
            this.panel3.Controls.Add(this.lblInvoiceNo);
            this.panel3.Controls.Add(this.lblRate);
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Controls.Add(this.lblAmountofInvoice);
            this.panel3.Controls.Add(this.lblPurchaseID);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(796, 174);
            this.panel3.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(262, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(146, 143);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(100, 22);
            this.txtRemarks.TabIndex = 12;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Location = new System.Drawing.Point(15, 141);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(64, 17);
            this.lblRemarks.TabIndex = 11;
            this.lblRemarks.Text = "Remarks";
            // 
            // dtPurchase
            // 
            this.dtPurchase.Location = new System.Drawing.Point(146, 48);
            this.dtPurchase.Name = "dtPurchase";
            this.dtPurchase.Size = new System.Drawing.Size(200, 22);
            this.dtPurchase.TabIndex = 10;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(524, 16);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(121, 24);
            this.cmbSupplier.TabIndex = 9;
            // 
            // ndQuantity
            // 
            this.ndQuantity.Location = new System.Drawing.Point(524, 101);
            this.ndQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndQuantity.Name = "ndQuantity";
            this.ndQuantity.Size = new System.Drawing.Size(120, 22);
            this.ndQuantity.TabIndex = 8;
            this.ndQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ndRate
            // 
            this.ndRate.Location = new System.Drawing.Point(525, 139);
            this.ndRate.Name = "ndRate";
            this.ndRate.Size = new System.Drawing.Size(120, 22);
            this.ndRate.TabIndex = 7;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(146, 112);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 6;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(11, 112);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(70, 17);
            this.lblProductID.TabIndex = 5;
            this.lblProductID.Text = "ProductID";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(688, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(688, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(146, 79);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(100, 22);
            this.txtInvoiceNo.TabIndex = 1;
            // 
            // txtAmountofInvoice
            // 
            this.txtAmountofInvoice.Location = new System.Drawing.Point(524, 61);
            this.txtAmountofInvoice.Name = "txtAmountofInvoice";
            this.txtAmountofInvoice.Size = new System.Drawing.Size(100, 22);
            this.txtAmountofInvoice.TabIndex = 1;
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(146, 11);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseID.TabIndex = 1;
            // 
            // lblDateofpurchase
            // 
            this.lblDateofpurchase.AutoSize = true;
            this.lblDateofpurchase.Location = new System.Drawing.Point(6, 48);
            this.lblDateofpurchase.Name = "lblDateofpurchase";
            this.lblDateofpurchase.Size = new System.Drawing.Size(118, 17);
            this.lblDateofpurchase.TabIndex = 0;
            this.lblDateofpurchase.Text = "Date of Purchase";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Location = new System.Drawing.Point(386, 19);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(77, 17);
            this.lblSupplierID.TabIndex = 0;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(7, 79);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(74, 17);
            this.lblInvoiceNo.TabIndex = 0;
            this.lblInvoiceNo.Text = "Invoice No";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(386, 141);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(38, 17);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(386, 98);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblAmountofInvoice
            // 
            this.lblAmountofInvoice.AutoSize = true;
            this.lblAmountofInvoice.Location = new System.Drawing.Point(386, 61);
            this.lblAmountofInvoice.Name = "lblAmountofInvoice";
            this.lblAmountofInvoice.Size = new System.Drawing.Size(120, 17);
            this.lblAmountofInvoice.TabIndex = 0;
            this.lblAmountofInvoice.Text = "Amount of Invoice";
            // 
            // lblPurchaseID
            // 
            this.lblPurchaseID.AutoSize = true;
            this.lblPurchaseID.Location = new System.Drawing.Point(7, 14);
            this.lblPurchaseID.Name = "lblPurchaseID";
            this.lblPurchaseID.Size = new System.Drawing.Size(85, 17);
            this.lblPurchaseID.TabIndex = 0;
            this.lblPurchaseID.Text = "Purchase ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.lblPurchase);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 56);
            this.panel2.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(702, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(604, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(496, 22);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(402, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchase.Location = new System.Drawing.Point(27, 13);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(135, 32);
            this.lblPurchase.TabIndex = 0;
            this.lblPurchase.Text = "Purchase";
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
            // PurchaseRate
            // 
            this.PurchaseRate.DataPropertyName = "PurchaseRate";
            this.PurchaseRate.HeaderText = "PurchaseRate";
            this.PurchaseRate.Name = "PurchaseRate";
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Purchase";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.purchase_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grbPurchaseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAmountofInvoice;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.Label lblDateofpurchase;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.Label lblPurchaseID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView grdPurchaseList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblAmountofInvoice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox grbPurchaseList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown ndRate;
        private System.Windows.Forms.NumericUpDown ndQuantity;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.DateTimePicker dtPurchase;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}