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
    public partial class Staff : Form
    {
        private bool IsEditMode = false;
        public Staff()
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
                    txtTelephone.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtRemarks.Clear();
                    grbStaffList.Enabled = true;
                    txtName.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtRemarks.ReadOnly = true;
                    txtTelephone.ReadOnly = true;
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    chkIsAdmin.CheckState = CheckState.Unchecked;

                    break;
                case "New": //setting when new is click
                    btnNew.Enabled = false;
                    btnDelete.Enabled = false;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grdStaffList.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtRemarks.ReadOnly = false;
                    txtTelephone.ReadOnly = false;
                    txtPassword.ReadOnly = false;
                    txtUsername.ReadOnly = false;
                    txtID.Clear();
                    txtName.Clear();
                    txtTelephone.Clear();
                    txtAddress.Clear();
                    txtRemarks.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();

                    break;
                case "Edit": //
                    btnNew.Enabled = false;
                    btnDelete.Enabled = true;
                    btnEdit.Enabled = false;
                    btnSave.Enabled = true;
                    grdStaffList.Enabled = false;
                    txtName.ReadOnly = false;
                    txtAddress.ReadOnly = false;
                    txtTelephone.ReadOnly = false;
                    txtRemarks.ReadOnly = false;
                    txtUsername.ReadOnly = false;
                    txtPassword.ReadOnly = false;

                    break;
            }

        }
        private int GetStaffID()//to generate id
        {
            try
            {
                string Id = "SELECT max (StaffID)+1 as Staff from Staff";
                var data = DBConnection.GetTableByQuery(Id);
                return Convert.ToInt32(data.Rows[0][0]);
            }
            catch (Exception)
            {
                return 1;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }
        private void Serialize()
        {
            for (int i = 0; i < grdStaffList.Rows.Count; i++)
            {
                grdStaffList.Rows[0].Cells[0].Value = i + 1;
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
            txtID.Text = GetStaffID().ToString();
            txtName.Focus();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            grdStaffList.DataSource = GetData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                return;
            }
            Int32 a = chkIsAdmin.CheckState == CheckState.Checked ? 1 : 0;

            if (IsEditMode == false)
            {
                string sql = "Insert into Staff ( StaffID,StaffName, Address,Telephone,Username,Password,Remarks,IsAdmin) Values (" + txtID.Text + ",'" + txtName.Text + "','" + txtAddress.Text + "'," + txtTelephone.Text + ",'" + txtUsername.Text + "','" + txtPassword.Text + "','" + txtRemarks.Text + "'," + a + ")";

                DBConnection.ExecuteNonQuery(sql);
                MessageBox.Show("Sucessfully Saved");
                EnableDisableControl("Reset");
            }
            else
            {
                string Updatesql = "Update Staff set StaffID= " + txtID.Text + " , StaffName= '" + txtName.Text + "', Address='" + txtAddress.Text + "',Telephone=" + txtTelephone.Text + ",Username='" + txtUsername.Text + ",Password='" + txtPassword.Text + "',Remarks = '" + txtRemarks.Text + "',IsAdmin=" + a + " Where StaffID = " + txtID.Text + " ";
                DBConnection.ExecuteNonQuery(Updatesql);

            }
            grdStaffList.DataSource = GetData();
        }
        private void LoadStaff()
        {

            string sql = "select StaffID,StaffName, Address, Address,Username,Password,Remarks,IsAdmin from Staff";
            var dataList = DBConnection.GetTableByQuery(sql);
            grdStaffList.DataSource = dataList;
            Serialize();
        }
        private DataTable GetData()
        {
            string sql = " Select StaffID,StaffName, Address, Telephone,Username,Password, Remarks,IsAdmin from Staff";

            return DBConnection.GetTableByQuery(sql);
        }

        private void grdStaffList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string DelStr = " delete from Staff where StaffID=" + txtID.Text;

            var a = MessageBox.Show("Do you confirm to Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                DBConnection.ExecuteNonQuery(DelStr);
                MessageBox.Show("Deleted Successfully");
                grdStaffList.DataSource = GetData();
            }
            btnReset_Click(null, null);
        }
        bool ValidateData()
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter the StaffName");
                txtName.Focus();
                return true;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter the Address");
                txtAddress.Focus();
                return true;
            }
            if (txtTelephone.Text == "")
            {
                MessageBox.Show("Please enter the Telephone");
                txtTelephone.Focus();
                return true;
            }
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter the Username");
                txtUsername.Focus();
                return true;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter the Password");
                txtPassword.Focus();
                return true;
            }
            return false;

        }

        private void chkIsAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grdStaffList_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = grdStaffList.CurrentRow.Cells["StaffID"].Value.ToString();
            txtName.Text = grdStaffList.CurrentRow.Cells["StaffName"].Value.ToString();
            txtAddress.Text = grdStaffList.CurrentRow.Cells["Address"].Value.ToString();
            txtTelephone.Text = grdStaffList.CurrentRow.Cells["Telephone"].Value.ToString();
            txtUsername.Text = grdStaffList.CurrentRow.Cells["Username"].Value.ToString();
            txtPassword.Text = grdStaffList.CurrentRow.Cells["Password"].Value.ToString();
            txtRemarks.Text = grdStaffList.CurrentRow.Cells["Remarks"].Value.ToString();
            chkIsAdmin.Text = grdStaffList.CurrentRow.Cells["IsAdmin"].Value.ToString();

        }
    }
}
