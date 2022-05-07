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
    public partial class Sales : Form
    {
        private bool IsEditMode = false;

        public Sales()
        {
            InitializeComponent();
        }
        private void EnableDisableControl(string mode)
        {
            switch (mode)
            {
                case "Reset":
                    btnNew.Enabled = true;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = true;
                    btnSave.Enabled = false;
                    txtSalesID.Clear();
                    txtInvoiceNo.Clear();
                    txtAmountofInvoice.Clear();
                    txtRemark.Clear();
                    ndQuantity.Value = 1;
                    ndRate.Value = 1;
                    txtInvoiceNo.ReadOnly = true;
                    txtAmountofInvoice.ReadOnly = true;
                    txtRemark.ReadOnly = true;
                    ndQuantity.ReadOnly = true;
                    ndRate.ReadOnly = true;
                    break;

                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    txtInvoiceNo.ReadOnly = false;
                    txtAmountofInvoice.ReadOnly = false;
                    txtRemark.ReadOnly = false;
                    ndQuantity.ReadOnly = false;
                    ndRate.ReadOnly = false;
                    txtSalesID.Clear();
                    txtInvoiceNo.Clear();
                    txtAmountofInvoice.Clear();
                    txtRemark.Clear();
                    ndQuantity.Value = 1;
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    txtInvoiceNo.ReadOnly = false;
                    txtAmountofInvoice.ReadOnly = false;
                    txtRemark.ReadOnly = false;
                    ndQuantity.ReadOnly = false;
                    ndRate.ReadOnly = false;
                    break;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            LoadProductCombo();
            LoadCustomerCombo();
        }
        private int GetSalesID()
        {
            try
            {
                string Id = "SELECT max(SalesID)+1 as Sales from Sales";
                var data = DBConnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        private void LoadCustomerCombo()
        {
            string sql = " Select CustomerID,CustomerName from Customer";
            var data = DBConnection.GetTableByQuery(sql);
            cmbCustomer.DataSource = data;
            cmbCustomer.DisplayMember = "CustomerName";
            cmbCustomer.ValueMember = "CustomerID";

        }
        private void LoadProductCombo()
        {
            string sql = "Select ProductID,ProductName from Product";
            var data = DBConnection.GetTableByQuery(sql);
            cmbProduct.DataSource = data;
            cmbProduct.DisplayMember = "ProductName";
            cmbProduct.ValueMember = "ProductID";
        }
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select CostPrice from Product where ProductID = " + cmbProduct.SelectedValue + " ";
                var data = DBConnection.GetTableByQuery(sql);
                ndRate.Value = Convert.ToDecimal(data.Rows[0][0].ToString());
            }
            catch (Exception ex)
            {
                ndRate.Value = 0;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtSalesID.Text = GetSalesID().ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var a = AddDuplicateItem(Convert.ToInt32(cmbProduct.SelectedValue), Convert.ToInt32(ndQuantity.Value));
            if (a == true)
            {
                grdSales.Rows.Add(0, cmbProduct.SelectedValue, cmbProduct.Text, ndQuantity.Value, ndRate.Value, Convert.ToDecimal(ndQuantity.Value) * Convert.ToDecimal(ndRate.Value));
                Serialize();

            }
            CalculateTotal();
        }
        private void Serialize()
        {
            for (int i = 0; i < grdSales.Rows.Count; i++)
            {
                grdSales.Rows[i].Cells[0].Value = i + 1;
            }
        }
        private bool AddDuplicateItem(int ID, int Quantity)
        {
            int i;
            if (grdSales.Rows.Count > 0)
            {
                for (i = 0; i < grdSales.Rows.Count; i++)
                {
                    if (grdSales.Rows[i].Cells["ProductID"].Value.ToString() == ID.ToString())
                    {
                        grdSales.Rows[i].Cells["Quantity"].Value = Convert.ToInt32(grdSales.Rows[i].Cells["Quantity"].Value) + Quantity;
                        grdSales.Rows[i].Cells["Total"].Value = Convert.ToInt32(grdSales.Rows[i].Cells["Quantity"].Value) * Convert.ToInt32(grdSales.Rows[i].Cells["SalesRate"].Value);
                        return false;
                    }
                }
            }
            return true;
        }

        private void grdSales_DoubleClick(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Are you sure?", "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                grdSales.Rows.Remove(grdSales.CurrentRow);
                CalculateTotal();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SqlSelect = "Select * from Sales where SalesID =" + txtSalesID.Text;
            DataTable dt = DBConnection.GetTableByQuery(SqlSelect); 
            if (dt.Rows.Count > 0)
            {
                txtInvoiceNo.Text = dt.Rows[0]["InvoiceNo"].ToString();
                dtSales.Value = Convert.ToDateTime(dt.Rows[0]["DateofSales"]);
                cmbCustomer.SelectedValue = Convert.ToInt32(dt.Rows[0]["CustomerID"]);
                txtAmountofInvoice.Text = Convert.ToDecimal(dt.Rows[0]["AmountofInvoice"]).ToString();
                txtRemark.Text = Convert.ToString(dt.Rows[0]["Remarks"]);
            }

            string detailSql = "Select  SalesID,p.ProductName, pd.ProductID, SalesRate, Quantity, SalesRate*Quantity as Total from SalesDetails pd " + "inner join Product p on pd.ProductID = p.ProductID where pd.SalesID = " + txtSalesID.Text;
            var data = DBConnection.GetTableByQuery(detailSql);
            grdSales.DataSource = data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i;
            if (IsEditMode == false)
            {
                string sql = "Insert into Sales(SalesID,InvoiceNo,CustomerID, DateofSales,AmountofInvoice,Remarks) values(" + txtSalesID.Text + ",'" + txtInvoiceNo.Text + "'," + cmbCustomer.SelectedValue + ",'" + dtSales.Value + "'," + txtAmountofInvoice.Text + ",'" + txtRemark.Text + "')";
                DBConnection.ExecuteNonQuery(sql);
                for (i = 0; i < grdSales.RowCount; i++)
                {
                    string sqlInsert = "Insert into SalesDetails(SalesID,ProductID,SalesRate,Quantity) values(" + txtSalesID.Text + "," + grdSales.Rows[i].Cells["ProductID"].Value + "," + grdSales.Rows[i].Cells["SalesRate"].Value + "," + grdSales.Rows[i].Cells["Quantity"].Value + ")";
                    DBConnection.ExecuteNonQuery(sqlInsert);
                    UpdateStockAdd(Convert.ToInt32(grdSales.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdSales.Rows[i].Cells["Quantity"].Value));
                    MessageBox.Show("Sucessfully Saved");
                    EnableDisableControl("Reset");
                }


            }
            else
            {
                string Updatestr = "Update Sales set InvoiceNo='" + txtInvoiceNo.Text + "',CustomerID =" + cmbCustomer.SelectedValue + ",DateofSales='" + dtSales + "',AmountofInvoice=" + txtAmountofInvoice.Text + ",Remarks='" + txtRemark.Text +"' where SalesID=" + txtSalesID.Text;
                DBConnection.ExecuteNonQuery(Updatestr);
                for (i = 0; i < grdSales.RowCount; i++)
                {
                    UpdateStockSub(Convert.ToInt32(grdSales.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdSales.Rows[i].Cells["Quantity"].Value));

                }
                string DelStr = "delete from SalesDetails where SalesID =" + txtSalesID.Text;
                DBConnection.ExecuteNonQuery(DelStr);
                for (i = 0; i < grdSales.RowCount; i++)
                {
                    string sqlInsert = "Insert into SalesDetails(SalesID,ProductID,SalesRate,Quantity) values(" + txtSalesID.Text + "," + grdSales.Rows[i].Cells["ProductID"].Value + "," + grdSales.Rows[i].Cells["SalesRate"].Value + "," + grdSales.Rows[i].Cells["Quantity"].Value + ")";
                    DBConnection.ExecuteNonQuery(sqlInsert);
                    UpdateStockAdd(Convert.ToInt32(grdSales.Rows[i].Cells["ProductID"].Value), Convert.ToInt32(grdSales.Rows[i].Cells["Quantity"].Value));

                    MessageBox.Show("Edited Successfully");
                    EnableDisableControl("Reset");
                }

            }
        }
        void CalculateTotal()
        {
            decimal sum = 0;

            for (int i = 0; i < grdSales.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdSales.Rows[i].Cells[5].Value);
            }
            txtAmountofInvoice.Text = sum.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteSales = "delete from Sales where SalesID=" + txtSalesID.Text;
            DBConnection.ExecuteNonQuery(DeleteSales);
            string delSalesDetails = "delete from SalesDetails where SalesID =" + txtSalesID.Text;
            DBConnection.ExecuteNonQuery(delSalesDetails);
            MessageBox.Show("Deleted Successfully");
        }
        private void UpdateStockAdd(int ProductID, int Quantity)
        {
            string SearchStr = "Select StockQuantity from Product where ProductID =" + ProductID;
            var data = DBConnection.GetTableByQuery(SearchStr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock + Quantity;

            string SqlUpdate = "Update Product set StockQuantity =" + Stock + " where ProductID =" + ProductID;
            DBConnection.ExecuteNonQuery(SqlUpdate);


        }
        private void UpdateStockSub(int ProductID, int Quantity)
        {
            string SearchStr = "Select StockQuantity from Product where ProductID =" + ProductID;
            var data = DBConnection.GetTableByQuery(SearchStr);
            Int32 Stock = Convert.ToInt32(data.Rows[0][0]);
            Stock = Stock - Quantity;

            string SqlUpdate = "Update Product set StockQuantity =" + Stock + " where ProductID =" + ProductID;
            DBConnection.ExecuteNonQuery(SqlUpdate);
        }
    }
}
