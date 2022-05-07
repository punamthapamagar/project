namespace project
{
    partial class PurchaseDetails
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
            this.grbPurchaseDetails = new System.Windows.Forms.GroupBox();
            this.grdPurchaseDetails = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.grbPurchaseList = new System.Windows.Forms.GroupBox();
            this.grdPurchaseList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblPurchaseID = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPurchaseRate = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ndQuantity = new System.Windows.Forms.NumericUpDown();
            this.ndRate = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.grbPurchaseDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseDetails)).BeginInit();
            this.panel4.SuspendLayout();
            this.grbPurchaseList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 444);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.grbPurchaseDetails);
            this.panel5.Location = new System.Drawing.Point(402, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(390, 209);
            this.panel5.TabIndex = 3;
            // 
            // grbPurchaseDetails
            // 
            this.grbPurchaseDetails.Controls.Add(this.grdPurchaseDetails);
            this.grbPurchaseDetails.Location = new System.Drawing.Point(3, 3);
            this.grbPurchaseDetails.Name = "grbPurchaseDetails";
            this.grbPurchaseDetails.Size = new System.Drawing.Size(380, 203);
            this.grbPurchaseDetails.TabIndex = 0;
            this.grbPurchaseDetails.TabStop = false;
            this.grbPurchaseDetails.Text = "Purchase Details";
            // 
            // grdPurchaseDetails
            // 
            this.grdPurchaseDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchaseDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grdPurchaseDetails.Location = new System.Drawing.Point(6, 21);
            this.grdPurchaseDetails.Name = "grdPurchaseDetails";
            this.grdPurchaseDetails.RowTemplate.Height = 24;
            this.grdPurchaseDetails.Size = new System.Drawing.Size(368, 176);
            this.grdPurchaseDetails.TabIndex = 0;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ProductID";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PurchaseRate";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quantity";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Total";
            this.Column9.Name = "Column9";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grbPurchaseList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 222);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 222);
            this.panel4.TabIndex = 2;
            // 
            // grbPurchaseList
            // 
            this.grbPurchaseList.Controls.Add(this.grdPurchaseList);
            this.grbPurchaseList.Location = new System.Drawing.Point(3, 6);
            this.grbPurchaseList.Name = "grbPurchaseList";
            this.grbPurchaseList.Size = new System.Drawing.Size(384, 209);
            this.grbPurchaseList.TabIndex = 0;
            this.grbPurchaseList.TabStop = false;
            this.grbPurchaseList.Text = "Purchase List";
            // 
            // grdPurchaseList
            // 
            this.grdPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grdPurchaseList.Location = new System.Drawing.Point(6, 21);
            this.grdPurchaseList.Name = "grdPurchaseList";
            this.grdPurchaseList.RowTemplate.Height = 24;
            this.grdPurchaseList.Size = new System.Drawing.Size(372, 188);
            this.grdPurchaseList.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "PurchaseID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "DateofPurchase";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SupplierID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "InvoiceNo";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "AmountofInvoice";
            this.Column5.Name = "Column5";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ndRate);
            this.panel3.Controls.Add(this.ndQuantity);
            this.panel3.Controls.Add(this.txtProductID);
            this.panel3.Controls.Add(this.txtPurchaseID);
            this.panel3.Controls.Add(this.txtPurchaseRate);
            this.panel3.Controls.Add(this.lblProductID);
            this.panel3.Controls.Add(this.lblPurchaseID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblQuantity);
            this.panel3.Controls.Add(this.lblPurchaseRate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 149);
            this.panel3.TabIndex = 1;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(143, 70);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 22);
            this.txtProductID.TabIndex = 2;
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(143, 18);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseID.TabIndex = 2;
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Location = new System.Drawing.Point(609, 18);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(100, 22);
            this.txtPurchaseRate.TabIndex = 2;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(26, 75);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(74, 17);
            this.lblProductID.TabIndex = 1;
            this.lblProductID.Text = "Product ID";
            // 
            // lblPurchaseID
            // 
            this.lblPurchaseID.AutoSize = true;
            this.lblPurchaseID.Location = new System.Drawing.Point(26, 23);
            this.lblPurchaseID.Name = "lblPurchaseID";
            this.lblPurchaseID.Size = new System.Drawing.Size(85, 17);
            this.lblPurchaseID.TabIndex = 1;
            this.lblPurchaseID.Text = "Purchase ID";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(466, 70);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPurchaseRate
            // 
            this.lblPurchaseRate.AutoSize = true;
            this.lblPurchaseRate.Location = new System.Drawing.Point(466, 26);
            this.lblPurchaseRate.Name = "lblPurchaseRate";
            this.lblPurchaseRate.Size = new System.Drawing.Size(102, 17);
            this.lblPurchaseRate.TabIndex = 1;
            this.lblPurchaseRate.Text = "Purchase Rate";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnPrint);
            this.panel2.Controls.Add(this.btnShow);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnReset);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 73);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PurchaseDetails";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(572, 22);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(663, 22);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 32);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show/Hide Details";
            this.btnShow.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(482, 22);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(401, 22);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(320, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(239, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rate";
            // 
            // ndQuantity
            // 
            this.ndQuantity.Location = new System.Drawing.Point(609, 70);
            this.ndQuantity.Name = "ndQuantity";
            this.ndQuantity.Size = new System.Drawing.Size(120, 22);
            this.ndQuantity.TabIndex = 3;
            // 
            // ndRate
            // 
            this.ndRate.Location = new System.Drawing.Point(609, 113);
            this.ndRate.Name = "ndRate";
            this.ndRate.Size = new System.Drawing.Size(120, 22);
            this.ndRate.TabIndex = 4;
            // 
            // PurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseDetails";
            this.Text = "PurchaseDetails";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.grbPurchaseDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseDetails)).EndInit();
            this.panel4.ResumeLayout(false);
            this.grbPurchaseList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPurchaseList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ndRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox grbPurchaseDetails;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox grbPurchaseList;
        private System.Windows.Forms.DataGridView grdPurchaseList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblPurchaseID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPurchaseRate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView grdPurchaseDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.NumericUpDown ndRate;
        private System.Windows.Forms.NumericUpDown ndQuantity;
        private System.Windows.Forms.Label label1;
    }
}