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
    public partial class FrmStockReport : Form
    {
        public FrmStockReport()
        {
            InitializeComponent();
        }

        private void FrmStockReport_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            string sql = "Select ProductID,ProductName,StockQuantity from Product";
            var data = DBConnection.GetTableByQuery(sql);
            grdProductList.DataSource = data;
        }

    }
}
