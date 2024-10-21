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
    public partial class frmReportCustomers : Form
    {
        public frmReportCustomers()
        {
            InitializeComponent();
        }

        private void reportCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDB.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.pizzaDB.Customer);
            
            

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
