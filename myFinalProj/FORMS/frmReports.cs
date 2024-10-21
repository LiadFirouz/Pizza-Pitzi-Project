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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportCustomers b = new frmReportCustomers();
            b.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        { 
            frmReportSupplier p = new frmReportSupplier();
            p.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmReportSale p = new frmReportSale();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
           frmReportSupplierProduct a = new frmReportSupplierProduct();
           a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain(true);
            this.Hide();
            
            b.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmReportCustomerSales f = new frmReportCustomerSales();
            f.Show();
        }
    }
}
