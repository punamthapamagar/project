namespace project
{
    partial class Product
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
            this.grbProductDetails = new System.Windows.Forms.GroupBox();
            this.txtSQ = new System.Windows.Forms.TextBox();
            this.lblSQ = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.txtSP = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbProductList = new System.Windows.Forms.GroupBox();
            this.grdProductList = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.grbProductDetails.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 438);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbProductDetails);
            this.panel4.Location = new System.Drawing.Point(411, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 342);
            this.panel4.TabIndex = 2;
            // 
            // grbProductDetails
            // 
            this.grbProductDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbProductDetails.Controls.Add(this.txtSQ);
            this.grbProductDetails.Controls.Add(this.lblSQ);
            this.grbProductDetails.Controls.Add(this.btnDelete);
            this.grbProductDetails.Controls.Add(this.btnSave);
            this.grbProductDetails.Controls.Add(this.txtCP);
            this.grbProductDetails.Controls.Add(this.txtSP);
            this.grbProductDetails.Controls.Add(this.txtUnit);
            this.grbProductDetails.Controls.Add(this.txtProductName);
            this.grbProductDetails.Controls.Add(this.txtProductID);
            this.grbProductDetails.Controls.Add(this.lblCP);
            this.grbProductDetails.Controls.Add(this.lblSP);
            this.grbProductDetails.Controls.Add(this.lblUnit);
            this.grbProductDetails.Controls.Add(this.lblProductName);
            this.grbProductDetails.Controls.Add(this.lblProductID);
            this.grbProductDetails.Location = new System.Drawing.Point(3, 6);
            this.grbProductDetails.Name = "grbProductDetails";
            this.grbProductDetails.Size = new System.Drawing.Size(372, 333);
            this.grbProductDetails.TabIndex = 0;
            this.grbProductDetails.TabStop = false;
            this.grbProductDetails.Text = "Product Details";
            // 
            // txtSQ
            // 
            this.txtSQ.Location = new System.Drawing.Point(197, 252);
            this.txtSQ.Name = "txtSQ";
            this.txtSQ.Size = new System.Drawing.Size(100, 22);
            this.txtSQ.TabIndex = 4;
            // 
            // lblSQ
            // 
            this.lblSQ.AutoSize = true;
            this.lblSQ.Location = new System.Drawing.Point(51, 252);
            this.lblSQ.Name = "lblSQ";
            this.lblSQ.Size = new System.Drawing.Size(100, 17);
            this.lblSQ.TabIndex = 3;
            this.lblSQ.Text = "Stock Quantity";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::project.Properties.Resources.icons8_trash_32;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(209, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 41);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::project.Properties.Resources.icons8_save_32;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(62, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(197, 218);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(100, 22);
            this.txtCP.TabIndex = 2;
            // 
            // txtSP
            // 
            this.txtSP.Location = new System.Drawing.Point(197, 177);
            this.txtSP.Name = "txtSP";
            this.txtSP.Size = new System.Drawing.Size(100, 22);
            this.txtSP.TabIndex = 2;
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(197, 133);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 22);
            this.txtUnit.TabIndex = 2;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(197, 86);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 22);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(197, 47);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 2;
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(51, 218);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(72, 17);
            this.lblCP.TabIndex = 1;
            this.lblCP.Text = "Cost Price";
            this.lblCP.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(51, 180);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(86, 17);
            this.lblSP.TabIndex = 1;
            this.lblSP.Text = "Selling Price";
            this.lblSP.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(51, 136);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(33, 17);
            this.lblUnit.TabIndex = 1;
            this.lblUnit.Text = "Unit";
            this.lblUnit.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(51, 91);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name";
            this.lblProductName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(51, 52);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 17);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            this.lblProductID.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grbProductList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(405, 351);
            this.panel3.TabIndex = 1;
            // 
            // grbProductList
            // 
            this.grbProductList.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbProductList.Controls.Add(this.grdProductList);
            this.grbProductList.Location = new System.Drawing.Point(3, 6);
            this.grbProductList.Name = "grbProductList";
            this.grbProductList.Size = new System.Drawing.Size(399, 336);
            this.grbProductList.TabIndex = 3;
            this.grbProductList.TabStop = false;
            this.grbProductList.Text = "Product List";
            // 
            // grdProductList
            // 
            this.grdProductList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grdProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.ProductID,
            this.ProductName,
            this.Unit,
            this.SellingPrice,
            this.CostPrice,
            this.StockQuantity});
            this.grdProductList.Location = new System.Drawing.Point(7, 21);
            this.grdProductList.Name = "grdProductList";
            this.grdProductList.RowTemplate.Height = 24;
            this.grdProductList.Size = new System.Drawing.Size(386, 309);
            this.grdProductList.TabIndex = 0;
            this.grdProductList.DoubleClick += new System.EventHandler(this.grdProductList_DoubleClick);
            // 
            // SN
            // 
            this.SN.DataPropertyName = "S.N";
            this.SN.HeaderText = "S.N";
            this.SN.Name = "SN";
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
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.HeaderText = "SellingPrice";
            this.SellingPrice.Name = "SellingPrice";
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "CostPrice";
            this.CostPrice.Name = "CostPrice";
            // 
            // StockQuantity
            // 
            this.StockQuantity.DataPropertyName = "StockQuantity";
            this.StockQuantity.HeaderText = "StockQuantity";
            this.StockQuantity.Name = "StockQuantity";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblProduct);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 87);
            this.panel2.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(64, 35);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(57, 17);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "Product";
            // 
            // btnReset
            // 
            this.btnReset.Image = global::project.Properties.Resources.icons8_reset_32;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(390, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(83, 37);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.Image = global::project.Properties.Resources.export;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(491, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(82, 37);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnShow
            // 
            this.btnShow.Image = global::project.Properties.Resources.iconfinder_List_1031512;
            this.btnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShow.Location = new System.Drawing.Point(687, 9);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(99, 58);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show/HideDetails";
            this.btnShow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::project.Properties.Resources.iconfinder_print_172530;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(589, 23);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 37);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::project.Properties.Resources.icons8_create_32;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNew.Location = new System.Drawing.Point(189, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 37);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::project.Properties.Resources.icons8_pencil_26;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(293, 23);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 37);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.grbProductDetails.ResumeLayout(false);
            this.grbProductDetails.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.grbProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductList)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.GroupBox grbProductList;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox grbProductDetails;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.TextBox txtSP;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView grdProductList;
        private System.Windows.Forms.TextBox txtSQ;
        private System.Windows.Forms.Label lblSQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockQuantity;
    }
}