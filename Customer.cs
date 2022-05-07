using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Customer : Form
    {
        private bool IsEditMode = false;
        public Customer()
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
                    txtID.Clear();
                    txtName.Clear();
                    txtAddress.Clear();
                    txtTele.Clear();
                    txtRemarks.Clear();
                    grbCustomerList.Enabled = true;
                    txtName.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtRemarks.ReadOnly = true;
                    txtTele.ReadOnly = true;


                    break;
                case "New": //setting when new is click
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grbCustomerList.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtRemarks.ReadOnly = false;
                    txtTele.ReadOnly = false;
                    txtID.Clear();
                    txtName.Clear();
                    txtTele.Clear();
                    txtAddress.Clear();
                    txtRemarks.Clear();
                    break;
                case "Edit": //
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grdCustomerList.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtTele.ReadOnly = false;
                    txtRemarks.ReadOnly = false;

                    break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private int GetCustomerID()//to generate id
        {
            try
            {
                string Id = "SELECT max (CustomerID)+1 as Customer from Customer";
                var data = DBConnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtID.Text = GetCustomerID().ToString();
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
                string sql = "Insert into Customer(CustomerID,CustomerName,Address,Telephone,Remarks) values(" + txtID.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "','" + txtTele.Text + "','" + txtRemarks.Text + "')";
                DBConnection.ExecuteNonQuery(sql);
                MessageBox.Show("Successfully Saved");
                EnableDisableControl("Reset");


            }
            else
            {
                string UpdateSql = "Update Customer set CustomerID = " + txtID.Text + ",CustomerName='" + txtAddress.Text + "',Address='" + txtAddress.Text + "',Telephone=" + txtTele.Text + "',Remarks='" + txtRemarks.Text + "'where CustomerID =" + txtID.Text;
                DBConnection.ExecuteNonQuery(UpdateSql);
            }
            grdCustomerList.DataSource = GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        private void Serialize()//function to generate serial number
        {
            for (int i = 0; i < grdCustomerList.Rows.Count; i++)
            {
                grdCustomerList.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadCustomer()   // function to load combo with data of customer
        {
            // query to select data from customer
            string sql = "select CustomerID,CustomerName,Address,Telephone,Remarks from Customer";
            var datalist = DBConnection.GetTableByQuery(sql);    // execute command to sql
            grdCustomerList.DataSource = datalist;   // assigning data to grid
            Serialize();
        }
        private DataTable GetData()
        {
            string sql = "select CustomerID,CustomerName,Address,Telephone,Remarks from Customer";
            return DBConnection.GetTableByQuery(sql);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DeleteStr = "Delete from Customer where CustomerID=" + txtID.Text;
            var a = MessageBox.Show("Do you Confirm to Delete", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                DBConnection.ExecuteNonQuery(DeleteStr);
                MessageBox.Show("Deleted Successfully");
                grdCustomerList.DataSource = GetData();
            }
            btnReset_Click(null, null);
        }

        private void grdCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            grdCustomerList.DataSource = GetData();
        }

        private void grdCustomerList_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = grdCustomerList.CurrentRow.Cells["CustomerID"].Value.ToString();
            txtName.Text = grdCustomerList.CurrentRow.Cells["CustomerName"].Value.ToString();
            txtAddress.Text = grdCustomerList.CurrentRow.Cells["Address"].Value.ToString();
            txtTele.Text = grdCustomerList.CurrentRow.Cells["Telephone"].Value.ToString();
            txtRemarks.Text = grdCustomerList.CurrentRow.Cells["Remarks"].Value.ToString();
        }

        private void lblcustomer_Click(object sender, EventArgs e)
        {

        }
        bool ValidateData()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("please enter the CustomerName");
                txtName.Focus();
                return true;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("please enter the Address");
                txtAddress.Focus();
                return true;
            }
            if (txtTele.Text == "")
            {
                MessageBox.Show("please enter the Telephone");
                txtName.Focus();
                return true;
            }
            if (txtRemarks.Text == "")
            {
                MessageBox.Show("please enter the Remarks");
                txtName.Focus();
                return true;
            }
            return false;
        }
    }
}
