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
    public partial class SupplierDiary : Form
    {
        public SupplierDiary()
        {
            InitializeComponent();
        }

        private void SupplierDiary_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void SearchByName()
        {
            string Sql = "Select * from Supplier where SupplierName Like '" + txtSearch.Text + "%'";
            var data = DBConnection.GetTableByQuery(Sql);
            grdSupplierList.DataSource = data;
        }
        void LoadData()
        {
            string Sql = "Select SupplierID,SupplierName,Address,Telephone,Remarks from Supplier";
            var data = DBConnection.GetTableByQuery(Sql);
            grdSupplierList.DataSource = data;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SearchByName();
            }
            catch (Exception)
            {

            }
        }
    }
}
