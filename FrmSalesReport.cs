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
    public partial class FrmSalesReport : Form
    {
        public FrmSalesReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FrmSalesReport_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            string sql = "Select CustomerID, InvoiceNo, Amount from Sales where DateofSales between'" + dtFrom.Value + "' and '" + dtTo.Value + "'";
            var data = DBConnection.GetTableByQuery(sql);
            grdSales.DataSource = data;
        }
    }
}
