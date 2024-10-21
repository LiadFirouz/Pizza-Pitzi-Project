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
using myFinalProj.FORMS;
using System.IO;
namespace myFinalProj.FORMS
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        DataTable Tproduct;
        DataTable Tsupplier;
 
        
        private void frmItem_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tproduct = Class1.OpenTable("Products");
            Tsupplier = Class1.OpenTable("Suppliers");
            DisplayUtilities.FillCombo(Tsupplier, 1, cmbCspak);
            DisplayUtilities.FillDataGrid(dataGridView1, Tproduct);
            button1.Enabled = false;
        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain(true);
            this.Hide();
            f.Show();
        }

        private void cmbCspak_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Tsupplier = Class1.OpenTable("Suppliers");
            Class1.GetDataSet("Select * from Suppliers where supplierName='" + cmbCspak.Text + "'");
            txtSCod.Text = Tsupplier.Rows[0][0].ToString();
        }

        private void dataGridView1_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSCod.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSog.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMinAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbActive.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            DisplayUtilities.ClearControls(this);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Class1.GetDataSet("Select * from Products where productCode='" + textBox8.Text + "'");
            if (Class1.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("פריט לא קיים");
                frmItem_Load(sender, e);
            }
            else
            {
                Class1.GetDataSet("Select * from Products where productCode='" + textBox8.Text + "'");
                txtPCode.Text = Class1.ds.Tables[0].Rows[0][0].ToString();
                txtPName.Text = Class1.ds.Tables[0].Rows[0][1].ToString();
                txtSCod.Text = Class1.ds.Tables[0].Rows[0][3].ToString();
                txtSog.Text = Class1.ds.Tables[0].Rows[0][2].ToString();
                txtAmount.Text = Class1.ds.Tables[0].Rows[0][4].ToString();
                txtMinAmount.Text = Class1.ds.Tables[0].Rows[0][5].ToString();
                txtPrice.Text = Class1.ds.Tables[0].Rows[0][6].ToString();
                cmbActive.Text = Class1.ds.Tables[0].Rows[0][7].ToString();
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = false;
            bool t = false;
            // string input = Microsoft.VisualBasic.Interaction.InputBox("insert picture name ", "", "Default", -1, -1);
            if (txtPCode.Text != "" && txtPName.Text != "" && txtSog.Text != "" && txtSCod.Text != "" && txtAmount.Text != "" && txtMinAmount.Text != "" && txtPrice.Text != "" && cmbActive.Text != "" )
                t = true;
            else
                t = false;

            if (t == false)
                MessageBox.Show("חסרים נתונים");
            else
            {
                Class1.GetDataSet("Select * from Products where productCode='" + txtPCode.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("פריט כבר קיים");
                else
                {
                    string strSql1 = "INSERT INTO Products(productCode,productName,catgory,supplierCode,quantityInStock,minimalAmount,price,active,pic)";
                    string strSql2 = "VALUES ('" + txtPCode.Text + "','" + txtPName.Text + "','" + txtSog.Text + "','" + txtAmount.Text + "','" + txtMinAmount.Text + "','" + txtPrice.Text + "','" + cmbActive.Text + "')";
                    string strSql = strSql1 + strSql2;
                    Class1.GetDataSet(strSql);
                    MessageBox.Show("נתונים נשמרו");
                    frmItem_Load(sender, e);
                    DisplayUtilities.ClearControls(this);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            bool t = false;
            // string input = Microsoft.VisualBasic.Interaction.InputBox("insert picture name ", "", "Default", -1, -1);
            if (txtPCode.Text != "" && txtPName.Text != "" && txtSog.Text != "" && txtSCod.Text != "" && txtAmount.Text != "" && txtMinAmount.Text != "" && txtPrice.Text != "" && cmbActive.Text != "" )
                t = true;
            else
                t = false;

            if (t == false)
                MessageBox.Show("חסרים נתונים");
            else
            {
                Class1.GetDataSet("Select * from Products where productCode='" + txtPCode.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("פריט לא קיים");
                else
                {
                    string strSql = "UPDATE Products SET productCode='" + txtPCode.Text + "',productName='" + txtPName.Text + "',catgory='" + txtSog.Text + "',supplierCode='" + txtSCod.Text + "',quantityInStock='" + txtAmount.Text + "',minimalAmount='" + txtMinAmount.Text + "',price='" + txtPrice.Text + "',active='" + cmbActive.Text + "' WHERE productCode='" + txtPCode.Text + "' ";

                    Class1.GetDataSet(strSql);
                    MessageBox.Show("נתונים עודכנו");
                    frmItem_Load(sender, e);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSuppliers_Click(object sender, EventArgs e)
        {

        }
    }
}
