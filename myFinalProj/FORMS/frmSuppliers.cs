using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myFinalProj.UTILITIES;
using myFinalProj.DAL;
using myFinalProj.FORMS;

using System.Drawing.Drawing2D;

namespace myFinalProj.FORMS
{
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();
        }

        DialogResult dr;
        DataTable TSuppliers;
        DataView DV;
        int count;
        bool OneClick = false;

        public void DisplayRecord(int index)// פונקציה המציגה רשומה אחת בטבלה לפי קוד רשומה
        {
            TSuppliers = Class1.OpenTable("Suppliers");
            SupCodTB.Text = TSuppliers.Rows[index][0].ToString();
            SupNaTB.Text = TSuppliers.Rows[index][1].ToString();
            AddTB.Text = TSuppliers.Rows[index][2].ToString();
            PhoNumTB.Text = TSuppliers.Rows[index][3].ToString();
            ActiveCB.Text = TSuppliers.Rows[index][4].ToString();


            DisplayUtilities.DisableControls(this);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            string strSQL1 = "insert into Suppliers(supplierCode, supplierName, address, phoneNumber,active)";
            string strSQL2 = "values('" + SupCodTB.Text + "','" + SupNaTB.Text + "','" + AddTB.Text + "','" + PhoNumTB.Text + "','" + ActiveCB.Text + "')";
            strSQL1 = strSQL1 + strSQL2;
            MessageBox.Show(GeneralUtilities.AddRecd(TSuppliers, strSQL1).ToString());
            Class1.GetDataSet("SELECT * from Suppliers");
            DisplayRecord(0);
            DisplayRecord(TSuppliers.Rows.Count - 1);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {


            Location = new Point(400, 300);
            count = 0;
            TSuppliers = Class1.OpenTable("Suppliers");
            DisplayUtilities.FillDataGrid(dataGridView1, TSuppliers);

            DisplayRecord(count);// תצוגה של רשומה בתיבות הטקסט 
            Class1.GetDataSet("Select * from Suppliers order by supplierCode");//מיון הרשומות בטבלה לפי קוד מוצר 
            dataGridView1.Visible = true;
            customerCodeRB.Visible = false;
            customerFirstNameRB.Visible = false;
            customerLastNameRB.Visible = false;
            phoneNumberRB.Visible = false;
            SearchTB.Visible = false;
            SearchTB.Enabled = true;

        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            DisplayUtilities.EnableControls(this);
            SupCodTB.Enabled = false;
        }

        private void CusCodTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearScreen_Click(object sender, EventArgs e)
        {
            DisplayUtilities.ClearControls(this);
            int j = TSuppliers.Rows.Count;
            string p = TSuppliers.Rows[j - 1][0].ToString();
            SupCodTB.Text = (Convert.ToInt32(p) + 1).ToString();
            DisplayUtilities.EnableControls(this);
            SupCodTB.Enabled = false;
        }

        private void SaveCustomer_Click(object sender, EventArgs e)
        {
            string a, b, d, r, q;
            a = SupCodTB.Text;
            b = SupNaTB.Text;

            d = AddTB.Text;
            r = PhoNumTB.Text;

            q = ActiveCB.Text;
            if (a != "" && b != "" && d != "" && r != "" && q != "")
            {
                string s = "UPDATE Suppliers SET supplierName= '" + b + "',  address='" + d + "', phoneNumber='" + r + "',    active='" + q + "' WHERE supplierCode='" + a + "' ";
                Class1.GetDataSet(s);
                MessageBox.Show("Your Data Has Being Saved");
                Class1.GetDataSet("Select*from Suppliers");
                TSuppliers = Class1.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(TSuppliers.Rows.Count - 1);
            }

            else
                MessageBox.Show("Fill All The Feed Charts");
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {

            dr = MessageBox.Show("Do You Want To Delete This Record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string s = "UPDATE Suppliers SET active='No' WHERE supplierCode='" + SupCodTB.Text + "'";
                Class1.GetDataSet(s);
                MessageBox.Show("Your Data Has Being Saved");
                Class1.GetDataSet("Select * from Suppliers");
                TSuppliers = Class1.ds.Tables[0];
                DisplayRecord(0);
                DisplayRecord(TSuppliers.Rows.Count - 1);
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            if (!OneClick)
            {
                dataGridView1.Visible = true;
                dataGridView1.Refresh();
                customerCodeRB.Visible = true;
                customerFirstNameRB.Visible = true;
                customerLastNameRB.Visible = true;
                phoneNumberRB.Visible = true;
                SearchTB.Visible = true;
                OneClick = true;
            }
            else
            {
                dataGridView1.Visible = false;
                dataGridView1.Refresh();
                customerCodeRB.Visible = false;
                customerFirstNameRB.Visible = false;
                customerLastNameRB.Visible = false;
                phoneNumberRB.Visible = false;
                SearchTB.Visible = false;
                OneClick = false;
            }

        }

        private void ToTheStartB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToFirst(TSuppliers, count));
        }

        private void BackwordB_Click(object sender, EventArgs e)
        {
            count = GeneralUtilities.MovePrev(TSuppliers, count);
            DisplayRecord(count);
        }

        private void ForwordB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.MoveNext(TSuppliers, count));
            count++;
        }

        private void ToTheEndB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToLast(TSuppliers, count));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DV = new DataView(TSuppliers);
            if (customerCodeRB.Checked)
            {
                DV.RowFilter = string.Format("supplierCode like '*{0}*'", SearchTB.Text);
            }
            if (customerFirstNameRB.Checked)
            {
                DV.RowFilter = string.Format("supplierName like '*{0}*'", SearchTB.Text);
            }
            if (customerLastNameRB.Checked)
            {
                DV.RowFilter = string.Format("address like '*{0}*'", SearchTB.Text);
            }
            if (phoneNumberRB.Checked)
            {
                DV.RowFilter = string.Format("phoneNumber like '*{0}*'", SearchTB.Text);
            }
            dataGridView1.DataSource = DV;
        }



        private void Suppliers_Load(object sender, EventArgs e)
        {
            Location = new Point(400, 300);
            count = 0;
            TSuppliers = Class1.OpenTable("Suppliers");
            DisplayUtilities.FillDataGrid(dataGridView1, TSuppliers);

            DisplayRecord(count);// תצוגה של רשומה בתיבות הטקסט 
            Class1.GetDataSet("Select * from Suppliers order by supplierCode");//מיון הרשומות בטבלה לפי קוד מוצר 
            customerCodeRB.Visible = false;
            customerFirstNameRB.Visible = false;
            customerLastNameRB.Visible = false;
            phoneNumberRB.Visible = false;
            SearchTB.Visible = false;
            SearchTB.Enabled = true;
            SaveSuppliers.Enabled = false;
            button1.Visible = false;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SupCodTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            SupNaTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AddTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            PhoNumTB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            ActiveCB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void AddSuppliers_Click(object sender, EventArgs e)
        {

            string strSql1 = "INSERT INTO Suppliers(supplierCode,supplierName,address,phoneNumber,active)";
            string strSql2 = "VALUES('" + SupCodTB.Text + "','" + SupNaTB.Text + "','" + AddTB.Text + "','" + PhoNumTB.Text + "','" + ActiveCB.Text + "')";
            string strSqrl = strSql1 + strSql2;
            MessageBox.Show(GeneralUtilities.AddRecd(TSuppliers, strSqrl).ToString());
            Class1.GetDataSet("Select * from Suppliers");
            TSuppliers = Class1.ds.Tables[0];
            dataGridView1.Refresh();
            dataGridView1.DataSource = TSuppliers;

        }

        private void UpdateSuppliers_Click(object sender, EventArgs e)
        {
            SupCodTB.Enabled = true;
            SupNaTB.Enabled = true;
            AddTB.Enabled = true;
            PhoNumTB.Enabled = true;
            ActiveCB.Enabled = true;
            SaveSuppliers.Visible = false;
            button1.Visible = true;


        }

        private void SaveSuppliers_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (SupCodTB.Text != "" && SupNaTB.Text != "" && AddTB.Text != "" && PhoNumTB.Text != "" && ActiveCB.Text != "")
                t = true;
            else
                t = false;
            if (t == false)
                MessageBox.Show("Please Fill All The Required Boxes");
            else
            {
                Class1.GetDataSet("Select * from Suppliers where supplierCode='" + SupCodTB.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count != 0)
                    MessageBox.Show("Supplier Already Exist");
                else
                {
                    string strSql = "INSERT INTO Suppliers(supplierCode,supplierName,address,phoneNumber,active) VALUES ('" + SupCodTB.Text + "','" + SupNaTB.Text + "','" + AddTB.Text + "','" + PhoNumTB.Text + "','" + ActiveCB.Text + "')";

                    Class1.GetDataSet(strSql);
                    MessageBox.Show("The Data Has Being Update");
                    Supplier_Load(sender, e);
                    TSuppliers = Class1.OpenTable("Suppliers");
                }
            }




        }

        private void ClearScreen_Click_1(object sender, EventArgs e)
        {
            SupNaTB.Clear();
            AddTB.Clear();
            PhoNumTB.Clear();
            string d = (Convert.ToInt32(TSuppliers.Rows[TSuppliers.Rows.Count - 1][0].ToString()) + 1).ToString();
            SupCodTB.Text = d;
            DisplayUtilities.EnableControls(this);
            SupCodTB.Enabled = false;
        }

        private void DeleteSuppliers_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

       
            if ((SupCodTB.Text != "") && (SupNaTB.Text != "") && (AddTB.Text != "") && (PhoNumTB.Text != "") && (ActiveCB.Text != ""))
            {

                string strSql = "UPDATE Suppliers SET supplierName='" + SupNaTB.Text + "',address='" + AddTB.Text + "',phoneNumber='" + PhoNumTB.Text + "',active='" + ActiveCB.Text + "' WHERE supplierCode='" + SupCodTB.Text + "' ";
                Class1.GetDataSet(strSql);
                MessageBox.Show("The Data Has Being Update");
                Supplier_Load(sender, e);
                TSuppliers = Class1.OpenTable("Suppliers");
            }

            button1.Visible = false;
            SaveSuppliers.Visible = true;
        }

        private void ToTheStartB_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToFirst(TSuppliers, count));
        }

        private void BackwordB_Click_1(object sender, EventArgs e)
        {
            count = GeneralUtilities.MovePrev(TSuppliers, count);
            DisplayRecord(count);
        }

        private void ForwordB_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.MoveNext(TSuppliers, count));
            count++;
        }

        private void ToTheEndB_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToLast(TSuppliers, count));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain(true);
            this.Hide();
            b.Show();
        }



    }
}