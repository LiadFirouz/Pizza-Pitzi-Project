using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myFinalProj.DAL;
using myFinalProj.UTILITIES;
namespace myFinalProj.FORMS
{
    public partial class frmSale : Form
    {
        public frmSale(string cuscode)
        {
            InitializeComponent();
          
            txtCustomerCod.Text = cuscode.ToString();
        }

        DialogResult dr;
        DataTable Tsales;
        int count;
        private void frmSale_Load(object sender, EventArgs e)
        {
            
            Tsales = Class1.OpenTable("sales");
            DisplayUtilities.FillDataGrid(dgv2, Tsales);
            count = 0;
            DisplayRecord(count);
            SearchSaleTB.Enabled = true;
            

        }

        public void DisplayRecord(int index)// פונקציה המציגה רשומה אחת בטבלה לפי קוד רשומה
        {
            Tsales = Class1.OpenTable("sales");
            txtSaleCod.Text = Class1.ds.Tables[0].Rows[0][0].ToString();
            txtCustomerCod.Text = Class1.ds.Tables[0].Rows[0][1].ToString();
            //dtSaleDate.Text = Class1.ds.Tables[0].Rows[0][2].ToString();
            txtNumOfItems.Text = Class1.ds.Tables[0].Rows[0][3].ToString();
            txtTotalPrice.Text = Class1.ds.Tables[0].Rows[0][4].ToString();
          

            DisplayUtilities.DisableControls(this);
        }


        private void txtAddNew_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(Tsales.Rows[Tsales.Rows.Count - 1][0].ToString()) + 1;
            string input = Microsoft.VisualBasic.Interaction.InputBox("insert customer code", "customer code", "Default", -1, -1);
            frmManue f = new frmManue(c.ToString(), input);
            this.Hide();
            f.Show();
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSaleCod.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCustomerCod.Text = dgv2.Rows[e.RowIndex].Cells[1].Value.ToString();
            //dtSaleDate.Value = Convert.ToDateTime(dgv2.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtNumOfItems.Text = dgv2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTotalPrice.Text = dgv2.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in Tsales.Rows)
            {
                if (SearchSaleTB.Text.Equals(dr[0].ToString()))
                {

                    txtSaleCod.Text = dr[0].ToString();
                    txtCustomerCod.Text = dr[1].ToString();
                    dtSaleDate.Value =Convert.ToDateTime(dr[2].ToString());
                    txtNumOfItems.Text = dr[3].ToString();
                    txtTotalPrice.Text = dr[4].ToString();
                }
            }

        }

   

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain(true);
            this.Hide();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            txtCustomerCod.Enabled=true;
            dtSaleDate.Enabled=true;
            txtNumOfItems.Enabled=true;
            txtTotalPrice.Enabled=true;
            SaveUpdate.Enabled = true;
            SaleUpdae.Enabled = false;
        }


        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            Tsales = Class1.OpenTable("Sales");
            bool t = false;
            if (txtSaleCod.Text != "" && txtCustomerCod.Text != "" && txtNumOfItems.Text != "" && txtTotalPrice.Text != "")
                t = true;
            else
                t = false;
            if (t == false)
                MessageBox.Show("Data Is Mising");
            else
            {
                Class1.GetDataSet("Select * from Sales where saleCode='" + txtSaleCod.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("sale Doesn't Exist");
                else
                {
                    string strSql = "UPDATE Sales SET [customerCode]='" + txtCustomerCod.Text + "',[saleDate]='" + dtSaleDate.Text + "',[salePrice]='" + txtTotalPrice.Text + "',[saleAmount]='" + txtNumOfItems.Text + "' WHERE saleCode='" + txtSaleCod.Text + "'";
                    Class1.GetDataSet(strSql);
                    MessageBox.Show("The Data Has Being Updated");
                    SaveUpdate.Enabled = false;
                    SaleUpdae.Enabled = true;
                    frmSale_Load(sender, e);
                }
            }
        }

   

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataRow dr in Tsales.Rows)
            {
                if (txtSaleCod.Text.Equals(dr[0].ToString()))
                {
                    string strSQL1 = "DELETE FROM sales WHERE saleCode='" + txtSaleCod.Text + "'";
                    Class1.GetDataSet(strSQL1);
                    string strSQL2 = "DELETE FROM saleAssistance WHERE saleCode='" + txtSaleCod.Text + "'";
                    Class1.GetDataSet(strSQL2);
                    MessageBox.Show("The Sale has been deleted");
                    DisplayUtilities.FillDataGrid(dgv2, Tsales);
                    frmSale_Load(sender, e);
                }
            }

          
        }
        
        private void ToTheStartB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToFirst(Tsales, count));
        }

        private void BackwordB_Click(object sender, EventArgs e)
        {
            count = GeneralUtilities.MovePrev(Tsales, count);
            DisplayRecord(count);
        }

        private void ForwordB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.MoveNext(Tsales, count));
            count++;
        }

        private void ToTheEndB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToLast(Tsales, count));

        }

        private void SearchCustomerTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
