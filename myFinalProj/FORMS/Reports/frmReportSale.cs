using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFinalProj.FORMS
{
    public partial class frmReportSale : Form
    {
        public frmReportSale()
        {
            InitializeComponent();
        }

        private void frmReportSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pizzaDbDataSet2.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.pizzaDbDataSet2.Sales);

            this.reportViewer1.RefreshReport();
        }
    }
}
