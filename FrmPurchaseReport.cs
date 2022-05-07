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
    public partial class FrmPurchaseReport : Form
    {
        public FrmPurchaseReport()
        {
            InitializeComponent();
        }

        private void FrmPurchaseReport_Load(object sender, EventArgs e)
        {

        }
        void LoadData()
        {
            string Sql = "Select PurchaseID,InvoiceNo,AmountofInvoice from Purchase where DateofPurchase between'" + dtFrom.Value + "' and '" + dtTo.Value + "'";
            var data = DBConnection.GetTableByQuery(Sql);
            grdList.DataSource = data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
            CalculateTotal();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
        void CalculateTotal()
        {
            decimal sum = 0;

            for (int i = 0; i < grdList.Rows.Count; i++)
            {
                sum = sum + Convert.ToDecimal(grdList.Rows[i].Cells[2].Value);
            }
            txtTotal.Text = sum.ToString();
        }
    }
}
