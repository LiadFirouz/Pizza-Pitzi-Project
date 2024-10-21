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
    public partial class frmReportSupplier : Form
    {
        public frmReportSupplier()
        {
            InitializeComponent();
        }

        private void frmReportSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSuppliers.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.dsSuppliers.Suppliers);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
