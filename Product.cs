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
    public partial class Product : Form
    {
        private bool IsEditMode = false;
        public Product()
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
                    txtProductID.Clear();
                    txtProductName.Clear();
                    txtUnit.Clear();
                    txtSP.Clear();
                    txtCP.Clear();
                    txtSQ.Clear();
                    grbProductList.Enabled = true;
                    txtProductName.ReadOnly = true;
                    txtUnit.ReadOnly = true;
                    txtSP.ReadOnly = true;
                    txtCP.ReadOnly = true;
                    txtSQ.ReadOnly = true;
                    break;

                case "New": //setting when new is click
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grbProductList.Enabled = false;
                    txtProductName.ReadOnly = false;
                    txtUnit.ReadOnly = false;
                    txtSP.ReadOnly = false;
                    txtCP.ReadOnly = false;
                    txtSQ.ReadOnly = false;
                    txtProductID.Clear();
                    txtProductName.Clear();
                    txtUnit.Clear();
                    txtSP.Clear();
                    txtCP.Clear();
                    txtSQ.Clear();
                    break;

                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grdProductList.Enabled = false;
                    txtProductName.ReadOnly = false;
                    txtUnit.ReadOnly = false;
                    txtSP.ReadOnly = false;
                    txtCP.ReadOnly = false;
                    txtSQ.ReadOnly = false;
                    break;
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int GetProductID()//to generate id
        {
            try
            {
                string Id = "SELECT max (ProductID)+1 as Product from Product";
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
            txtProductID.Text = GetProductID().ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                if (ValidateData() == true)
                {
                    return;
                }
            }
            if (IsEditMode == false)
            {
                string sql = "Insert into Product(ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity) values(" + txtProductID.Text + ",'" + txtProductName.Text + "','" + txtUnit.Text + "','" + txtSP.Text + "','" + txtCP.Text + "','" + txtSQ.Text + "')";
                DBConnection.ExecuteNonQuery(sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");


            }
            else
            {
                string UpdateSql = "Update Product set ProductID = " + txtProductID.Text + ",ProductName='" + txtProductName.Text + "',Unit='" + txtUnit.Text + "',SellingPrice='" + txtSP.Text + "',CostPrice='" + txtCP.Text + "',StockQuantity='" + txtSQ.Text + "'where ProductID =" + txtProductID.Text;
                DBConnection.ExecuteNonQuery(UpdateSql);
            }
            grdProductList.DataSource = GetData();
        }
        private DataTable GetData()
        {
            string sql = "select ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity from Product";
            return DBConnection.GetTableByQuery(sql);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        private void Serialize()//fnction to generate serial number
        {
            for (int i = 0; i < grdProductList.Rows.Count; i++)
            {
                grdProductList.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadCustomer()
        {

            string sql = "select ProductID,ProductName,Unit,SellingPrice,CostPrice,StockQuantity from Product";
            var datalist = DBConnection.GetTableByQuery(sql);
            grdProductList.DataSource = datalist;
            Serialize();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteStr = "Delete from Product where ProductID=" + txtProductID.Text;
            var a = MessageBox.Show("Do you Confirm to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                DBConnection.ExecuteNonQuery(DeleteStr);
                MessageBox.Show("Deleted Successfully");
                grdProductList.DataSource = GetData();
            }
            btnReset_Click(null, null);
        }

        private void Product_Load(object sender, EventArgs e)
        {
            grdProductList.DataSource = GetData();
        }

        private void grdProductList_DoubleClick(object sender, EventArgs e)
        {
            txtProductID.Text = grdProductList.CurrentRow.Cells["ProductID"].Value.ToString();
            txtProductName.Text = grdProductList.CurrentRow.Cells["ProductName"].Value.ToString();
            txtUnit.Text = grdProductList.CurrentRow.Cells["Unit"].Value.ToString();
            txtSP.Text = grdProductList.CurrentRow.Cells["SellingPrice"].Value.ToString();
            txtCP.Text = grdProductList.CurrentRow.Cells["CostPrice"].Value.ToString();
            txtSQ.Text = grdProductList.CurrentRow.Cells["StockQuantity"].Value.ToString();
        }
        bool ValidateData()
        {
            if (txtProductName.Text == "")
            {
                MessageBox.Show("please enter the ProductName");
                txtProductName.Focus();
                return true;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("please enter the Unit");
                txtUnit.Focus();
                return true;
            }
            if (txtSP.Text == "")
            {
                MessageBox.Show("please enter the SellingPrice");
                txtSP.Focus();
                return true;
            }
            if (txtCP.Text == "")
            {
                MessageBox.Show("please enter the CostPrice");
                txtCP.Focus();
                return true;
            }
            if (txtSQ.Text == "")
            {
                MessageBox.Show("please enter the StockQuantity");
                txtSQ.Focus();
                return true;
            }
            return false;
        }
    }
}
