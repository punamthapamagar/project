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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidateData() == true)
            {
                return;
            }

            var data = DBConnection.GetTableByQuery("Select * from Staff where UserName='" + txtUserName.Text.Trim() + "' and Password='" +txtPassword.Text.Trim() + "'");
            if(data.Rows.Count>0)
            {
                CommonInfo.StaffID = (int)data.Rows[0]["StaffID"];
                CommonInfo.StaffName = data.Rows[0]["StaffName"].ToString();
                CommonInfo.Username = data.Rows[0]["UserName"].ToString();
                CommonInfo.IsAdmin = Convert.ToBoolean(data.Rows[0]["IsAdmin"]);
                CommonInfo.Password = txtPassword.Text;

                Close();
            }
            else
            {
                MessageBox.Show("Invalid Login .");
                txtPassword.Focus();
                txtPassword.SelectAll();
                //password errror message
            }
        }
        bool ValidateData()
        {
            if(txtUserName.Text=="")
            {
                MessageBox.Show("please enter the UserName");
                txtUserName.Focus();
                return true;
            }
            if(txtPassword.Text=="")
            {
                MessageBox.Show("please enter the Password");
                txtPassword.Focus();
                return true;
            }
            return false;
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
