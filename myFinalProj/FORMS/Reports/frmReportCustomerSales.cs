using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFinalProj.FORMS.Reports
{
    public partial class frmReportCustomerSales : Form
    {
        public frmReportCustomerSales()
        {
            InitializeComponent();
        }

        private void frmRepCustSale_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // TODO: This line of code loads data into the 'dsCustomerSales.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dsCustomerSales.DataTable1,textBox1.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
