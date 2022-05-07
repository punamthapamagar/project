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
    public partial class FrmMain : Form
    {
        public bool IsLogOut;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {

            Customer f = new Customer();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSupplier_Click(object sender, EventArgs e)
        {
            Suppliers f = new Suppliers();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuProduct_Click(object sender, EventArgs e)
        {
            Product f = new Product();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchase_Click(object sender, EventArgs e)
        {
            Purchase f = new Purchase();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseDetails_Click(object sender, EventArgs e)
        {
            PurchaseDetails f = new PurchaseDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSales_Click(object sender, EventArgs e)
        {
            Sales f = new Sales();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSalesDetails_Click(object sender, EventArgs e)
        {
            SalesDetails f = new SalesDetails();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuStaff_Click(object sender, EventArgs e)
        {
            Staff f = new Staff();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuPurchaseReport_Click(object sender, EventArgs e)
        {
            FrmPurchaseReport f = new FrmPurchaseReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuSalesReport_Click(object sender, EventArgs e)
        {
            FrmSalesReport f = new FrmSalesReport();
            f.MdiParent = this;
            f.Show();
        }

        private void mnuStockReport_Click(object sender, EventArgs e)
        {
            FrmStockReport f = new FrmStockReport();
            f.MdiParent = this;
            f.Show();
        }
    }
}
