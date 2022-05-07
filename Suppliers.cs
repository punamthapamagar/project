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
    public partial class Suppliers : Form
    {
        private bool IsEditMode = false;
        public Suppliers()
        {
            InitializeComponent();
        }
        private int GetSupplierID()
        {
            try
            {
                string Id = "SELECT max(SupplierID)+1 as supplier from Supplier";
                var data = DBConnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
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
                    txtSuppID.Clear();
                    txtName.Clear();
                    txtAdd.Clear();
                    txtTel.Clear();
                    txtRem.Clear();
                    grbSupp.Enabled = true;
                    txtName.ReadOnly = true;
                    txtAdd.ReadOnly = true;
                    txtRem.ReadOnly = true;
                    txtTel.ReadOnly = true;
                    break;
                case "New":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    //grdSuppList.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAdd.ReadOnly = false;
                    txtRem.ReadOnly = false;
                    txtTel.ReadOnly = false;
                    txtSuppID.Clear();
                    txtName.Clear();
                    txtTel.Clear();
                    txtAdd.Clear();
                    txtRem.Clear();
                    break;
                case "Edit":
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    // grdSupp.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAdd.ReadOnly = false;
                    txtRem.ReadOnly = false;
                    txtTel.ReadOnly = false;
                    break;

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtSuppID.Text = GetSupplierID().ToString();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            grdSuppList.DataSource = GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                return;
            }
            else
            {
                MessageBox.Show("Invalid Login.");
                txtName.Focus();
                txtName.SelectAll();
            }
            if (IsEditMode == false)
            {
                string sql = "Insert into Supplier ( SupplierID,SupplierName, Address, Telephone, Remarks) Values (" + txtSuppID.Text + ",'" + txtName.Text + "','" + txtAdd.Text + "'," + txtTel.Text + ",'" + txtRem.Text + "')";

                DBConnection.ExecuteNonQuery(sql);
                MessageBox.Show("Sucessfully Saved");
                EnableDisableControl("Reset");
            }

            else
            {
                string Updatesql = "Update Supplier set SupplierID= " + txtSuppID.Text + " , SupplierName= '" + txtName.Text + "', Address='" + txtAdd.Text + "',Telephone=" + txtTel.Text + ",Remarks= '" + txtRem.Text + "' Where SupplierID = " + txtSuppID.Text + " ";
                DBConnection.ExecuteNonQuery(Updatesql);
            }
            grdSuppList.DataSource = GetData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        private void Serialize() //function to generate serial number
        {
            for (int i = 0; i < grdSuppList.Rows.Count; i++)
            {
                grdSuppList.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void LoadSupplier()// function to load combo with data of Supplier
        {
            //query to select data from Supplier
            string sql = "select SupplierID,SupplierName, Address, Telephone, Remarks from supplier";
            var dataList = DBConnection.GetTableByQuery(sql); // execute command to sql
            grdSuppList.DataSource = dataList; //assigning data to grid
            Serialize();
        }
        private DataTable GetData()
        {
            string sql = " Select SupplierID,SupplierName, Address, Telephone, Remarks from Supplier";

            return DBConnection.GetTableByQuery(sql);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DelStr = " delete from Supplier where SupplierID=" + txtSuppID.Text;

            var a = MessageBox.Show("Do you confirm to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                DBConnection.ExecuteNonQuery(DelStr);
                MessageBox.Show("Deleted Successfully");
                grdSuppList.DataSource = GetData();
            }
        }

        private void grdSuppList_DoubleClick(object sender, EventArgs e)
        {
            txtSuppID.Text = grdSuppList.CurrentRow.Cells["SupplierID"].Value.ToString();
            txtName.Text = grdSuppList.CurrentRow.Cells["SupplierName"].Value.ToString();
            txtAdd.Text = grdSuppList.CurrentRow.Cells["Address"].Value.ToString();
            txtTel.Text = grdSuppList.CurrentRow.Cells["Telephone"].Value.ToString();
            txtRem.Text = grdSuppList.CurrentRow.Cells["Remarks"].Value.ToString();
        }
        bool ValidateData()
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the Supplier Name");
                txtName.Focus();
                return true;

            }
            if (txtAdd.Text == "")
            {
                MessageBox.Show("Please enter the Address");
                txtAdd.Focus();
                return true;
            }
            if (txtTel.Text == "")
            {
                MessageBox.Show("Please enter the Telephone number");
                txtTel.Focus();
                return true;
            }

            return false;

        }
    }
}
