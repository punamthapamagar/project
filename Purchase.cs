using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Purchase : Form
    {
        private bool IsEditMode = false;
        public Purchase()
        {
            InitializeComponent();
        }
        private void EnableDisableControl(string mode) //to enable and  disable 
        {
            switch (mode)
            {
                case "Reset": //to reset form
                    btnNew.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    txtPurchaseID.Clear();
                    txtInvoiceNo.Clear();
                    txtAmountofInvoice.Clear();
                    txtRemarks.Clear();
                    ndQuantity.Value = 1;
                    ndRate.Value = 1;
                    grbPurchaseList.Enabled = true;
                    txtPurchaseID.ReadOnly = true;
                    txtInvoiceNo.ReadOnly = true;
                    txtAmountofInvoice.ReadOnly = true;
                    ndQuantity.ReadOnly = true;
                    ndRate.ReadOnly = true;
                    break;

                case "New": //setting when new is click
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grbPurchaseList.Enabled = false;
                    txtRemarks.ReadOnly = false;
                    txtAmountofInvoice.ReadOnly = false;
                    txtInvoiceNo.ReadOnly = false;
                    ndQuantity.ReadOnly = false;
                    ndRate.ReadOnly = false;
                    txtPurchaseID.Clear();
                    txtInvoiceNo.Clear();
                    txtAmountofInvoice.Clear();
                    txtRemarks.Clear();
                    ndQuantity.Value = 1;
                    break;

                case "Edit": 
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grdPurchaseList.Enabled = false;
                    txtInvoiceNo.ReadOnly = false;
                    txtAmountofInvoice.ReadOnly = false;
                    txtRemarks.ReadOnly = false;
                    ndQuantity.ReadOnly = false;
                    ndRate.ReadOnly = false;
                    break;
            }

        }
        private int GetPurchaseID()//to generate id
        {
            try
            {
                string Id = "SELECT max (PurchaseID)+1 as Purchase from Purchase";
                var data = DBConnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtPurchaseID.Text = GetPurchaseID().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i;
            if (IsEditMode == false)
            {
                string sql = "Insert into Purchase (PurchaseID,InvoiceNo,SupplierID,DateofPurchase,AmountofInvoice,Remarks) Values(" + txtPurchaseID.Text + ",'" + txtInvoiceNo.Text + "'," + cmbSupplier.SelectedValue + ",'" + dtPurchase.Value + "'," + txtAmountofInvoice.Text + ",'" + txtRemarks.Text + "')";
                DBConnection.ExecuteNonQuery(sql);
                for(i = 0; i < grdPurchaseList.Rows.Count; i++)
                {
                    string sqlInsert = "Insert into PurchaseDetails(PurchaseID,ProductID,PurchaseRate,Quantity) Values(" + txtPurchaseID.Text + "," + grdPurchaseList.Rows[i].Cells["ProductID"].Value + "," + grdPurchaseList.Rows[i].Cells["PurchaseRate"].Value + "," + grdPurchaseList.Rows[i].Cells["Quantity"].Value + ")";
                    DBConnection.ExecuteNonQuery(sqlInsert);
                    UpdateStockAdd(Convert.ToInt32(grdPurchaseList.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdPurchaseList.Rows[i].Cells["Quantity"].Value));
                    MessageBox.Show("Successfully saved");
                    EnableDisableControl("Reset");
                }
            }
            else
            {
                string Updatesql = "Update Purchase set InvoiceNo='" + txtInvoiceNo.Text + "',SupplierID=" + cmbSupplier.SelectedValue + ",DateofPurchase='" + dtPurchase.Value + "',AmountofInvoice=" + txtAmountofInvoice.Text + ",Remarks='" + txtRemarks.Text + "' where PurchaseID=" + txtPurchaseID.Text;
                DBConnection.ExecuteNonQuery(Updatesql);
                for(i = 0; i < grdPurchaseList.Rows.Count; i++)
                {
                    UpdateStockSub(Convert.ToInt32(grdPurchaseList.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdPurchaseList.Rows[i].Cells["Quantity"].Value));
                }
                string Delstr = "delete from PurchaseDetails where PurchaseID =" + txtPurchaseID.Text;
                DBConnection.ExecuteNonQuery(Delstr);
                string sql = "Insert into Purchase (PurchaseID,InvoiceNo,SupplierID," + "DateofPurchase,AmountofInvoice,Remarks) Values(" + txtPurchaseID.Text + ",'" + txtInvoiceNo.Text + ",'" + cmbSupplier.SelectedValue + ",'" + dtPurchase.Value + ",'" + txtAmountofInvoice.Text + ",'" + txtRemarks.Text + "')";
                DBConnection.ExecuteNonQuery(sql);
                for (i = 0; i < grdPurchaseList.Rows.Count; i++)
                {
                    string sqlInsert = "Insert into PurchaseDetails(PurchaseID,ProductID,PurchaseRate,Quantity) Values(" + txtPurchaseID.Text + "," + grdPurchaseList.Rows[i].Cells["ProductID"].Value + "," + grdPurchaseList.Rows[i].Cells["PurchaseRate"].Value + "," + grdPurchaseList.Rows[i].Cells["Quantity"].Value + ")";

                    DBConnection.ExecuteNonQuery(sqlInsert);
                    MessageBox.Show("Edited Successfully");
                    EnableDisableControl("Reset");
                }
            }
        }
        void CalculateTotal()
        {
            decimal sum = 0;
            for(int i = 0; i < grdPurchaseList.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdPurchaseList.Rows[i].Cells[5].Value);
            }
            txtAmountofInvoice.Text = sum.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = AddDuplicateItem(Convert.ToInt32(cmbProduct.SelectedValue), Convert.ToInt32(ndQuantity.Value));
            if (a == true)
            {
                grdPurchaseList.Rows.Add(0, cmbProduct.SelectedValue, cmbProduct.Text, ndQuantity.Value, ndRate.Value, Convert.ToDecimal(ndQuantity.Value) * Convert.ToDecimal(ndRate.Value));
                Serialize();
            }
            CalculateTotal();
        }
        private void Serialize()//function to generate
        {
            for (int i = 0; i < grdPurchaseList.Rows.Count; i++)
            {
                grdPurchaseList.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeletePurchase = "delete from Purchase where PurchaseID =" + txtPurchaseID.Text;
            DBConnection.ExecuteNonQuery(DeletePurchase);
            string delPurchaseDetails = "delete from PurchaseDetails where PurchaseID =" + txtPurchaseID.Text;
            DBConnection.ExecuteNonQuery(delPurchaseDetails);
            MessageBox.Show("Deleted Successfully");
        }

        private void purchase_Load(object sender, EventArgs e)
        {
            LoadSupplierCombo();
            LoadProductCombo();
        }

        
        private void LoadSupplierCombo()
        {
            string SQL = "Select SupplierID,SupplierName from Supplier";
            var data = DBConnection.GetTableByQuery(SQL);
            cmbSupplier.DataSource = data;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "SupplierID";
        }
        private void LoadProductCombo()
        {
            string SQL = "Select ProductID,ProductName from Product";
            var data = DBConnection.GetTableByQuery(SQL);
            cmbProduct.DataSource = data;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string SQL = "Select Costprice from Product where ProductID = "+ cmbProduct.SelectedValue + " ";
                var data = DBConnection.GetTableByQuery(SQL);
                ndRate.Value = Convert.ToDecimal(data.Rows[0][0].ToString());
            }
            catch(Exception ex)
            {
                ndRate.Value = 0;
            }
        }

        private void False(object sender, EventArgs e)
        { 
        }
        private bool AddDuplicateItem(int ID,int Quantity)
        {
            int i;
                if (grdPurchaseList.Rows.Count > 0)
                {
                    for (i = 0; i < grdPurchaseList.Rows.Count; i++)
                    {
                        if (grdPurchaseList.Rows[i].Cells["ProductID"].Value.ToString() == ID.ToString())
                        {
                            grdPurchaseList.Rows[i].Cells["Total"].Value = Convert.ToInt32(grdPurchaseList.Rows[i].Cells["Quantity"].Value) * Convert.ToInt32(grdPurchaseList.Rows[i].Cells["PurchaseRate"].Value);
                            return false;
                        }
                    }
                }
                return true;
        }

        private void grdPurchaseList_DoubleClick(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("are you sure", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                grdPurchaseList.Rows.Remove(grdPurchaseList.CurrentRow);
                CalculateTotal();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SQL = "Select * from Purchase where PurchaseID = " + txtPurchaseID.Text;
            DataTable dt = DBConnection.GetTableByQuery(SQL);
            if(dt.Rows.Count>0)
            { 
                txtInvoiceNo.Text = dt.Rows[0]["InvoiceNo"].ToString();
                dtPurchase.Value = Convert.ToDateTime(dt.Rows[0]["DateofPurchase"]);
                cmbSupplier.SelectedValue = Convert.ToInt32(dt.Rows[0]["SupplierID"]);
                txtAmountofInvoice.Text = Convert.ToDecimal(dt.Rows[0]["AmountofInvoice"]).ToString();
                txtRemarks.Text = Convert.ToString(dt.Rows[0]["Remarks"]);
            }
            string DetailSQL = "Select PurchaseID,p.ProductName,pd.ProductID,PurchaseRate,Quantity,PurchaseRate*Quantity as Total from PurchaseDetails pd" + " inner join Product p on pd.ProductID = p.ProductID where pd.PurchaseID =" + txtPurchaseID.Text;
            var data = DBConnection.GetTableByQuery(DetailSQL);
            grdPurchaseList.DataSource = data;
        }
        private void UpdateStockAdd(int ProductID,int Quantity)
        {
            string Searchstr = "Select StockQuantity from Product where ProductID =" + ProductID;
            var data = DBConnection.GetTableByQuery(Searchstr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock + Quantity;

            string SqlUpdate = "Update Product set StockQuantity =" + Stock + " where ProductID= " + ProductID;
            DBConnection.ExecuteNonQuery(SqlUpdate);
        }
        private void UpdateStockSub(int ProductID, int Quantity)
        {
            string Searchstr = "Select StockQuantity from Product where ProductID =" + ProductID;
            var data = DBConnection.GetTableByQuery(Searchstr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock - Quantity;

            string SqlUpdate = "Update Product set StockQuantity =" + Stock + " where ProductID =" + ProductID;
            DBConnection.ExecuteNonQuery(SqlUpdate);
        }
    }
}
