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
namespace myFinalProj.FORMS
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        DataTable Tcustomer;
        int count;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            Location = new Point(200, 200);
            Tcustomer = Class1.OpenTable("Customers");
            count = 0;
            DisplayUtilities.FillCombo(Tcustomer, 5, CreditCompanyCB);
            DisplayUtilities.FillDataGrid(dataGridView1, Tcustomer);
            if (CustomerIdTB.Text == "")
                Sales.Enabled = false;
            DisplayRecord(count);

        }
        public void DisplayRecord(int index)// פונקציה המציגה רשומה אחת בטבלה לפי קוד רשומה
        {
            Tcustomer = Class1.OpenTable("Customers");
            CustomerIdTB.Text = Class1.ds.Tables[0].Rows[0]["id"].ToString();
            FullNameTB.Text = Class1.ds.Tables[0].Rows[0]["cname"].ToString();
            AddressTB.Text = Class1.ds.Tables[0].Rows[0]["address"].ToString();
            TelphoneTB.Text = Class1.ds.Tables[0].Rows[0]["tel"].ToString();
            CelphoneTB.Text = Class1.ds.Tables[0].Rows[0]["cell"].ToString();
            CreditCompanyCB.Text = Class1.ds.Tables[0].Rows[0][5].ToString();
            ExpirationDateTB.Text = Class1.ds.Tables[0].Rows[0][6].ToString();
            ActiveCB.Text = Class1.ds.Tables[0].Rows[0]["act"].ToString();


            DisplayUtilities.DisableControls(this);
            SearchCustomerTB.Enabled = true;
            SaveUpdate.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool t = false;
            if (CustomerIdTB.Text != "" && FullNameTB.Text != "" && AddressTB.Text != "" && TelphoneTB.Text != "" && CelphoneTB.Text != "" &&  ExpirationDateTB.Text != "")
                t = true;
            else
                t = false;

            if (t == false)
                MessageBox.Show("Data Is Mising");
            else
            {


                Class1.GetDataSet("Select * from Customers where id='" + CustomerIdTB.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("Customer Already Exist");
                else
                {
                    string strSql = string.Format("INSERT INTO Customers ( id, cname, address, tel, cell, cerditCompany, creditNum, expirationDate, act) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", CustomerIdTB.Text, FullNameTB.Text, AddressTB.Text, TelphoneTB.Text, CelphoneTB.Text, CreditCompanyCB.Text, ExpirationDateTB.Text, dtSaleDate.Value.ToShortDateString(), ActiveCB.Text);
                        //"INSERT INTO Customer(id,cname,address,tel,cell,cerditCompany,creditNum,expirationDate,act,password) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "','" + textBox9.Text + "')";
                    DisplayRecord(0);
                    DisplayRecord(Tcustomer.Rows.Count - 1);
                    Class1.GetDataSet(strSql);
                    MessageBox.Show("The Data Has Being Saved");
                    frmCustomer_Load(sender, e);
                    CustomerIdTB.Clear();
                    FullNameTB.Clear();
                    AddressTB.Clear();
                    TelphoneTB.Clear();
                    CelphoneTB.Clear();
                    ExpirationDateTB.Clear();
                    
                    SearchCustomerTB.Clear();
                    CreditCompanyCB.ResetText();
                    ActiveCB.ResetText();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (CustomerIdTB.Text != "" && FullNameTB.Text != "" && AddressTB.Text != "" && TelphoneTB.Text != "" && CelphoneTB.Text != "" && CreditCompanyCB.Text != "" && ExpirationDateTB.Text != "")
                t = true;
            else
                t = false;
            if (t == false)
                MessageBox.Show("Data Is Mising");
            else
            {
                Class1.GetDataSet("Select * from Customers where id='" + CustomerIdTB.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("Customer Doesn't Exist");
                else
                {
                    string strSql = "UPDATE Customers SET id='" + CustomerIdTB.Text + "',cname='" + FullNameTB.Text + "',address='" + AddressTB.Text + "',tel='" + TelphoneTB.Text + "',cell='" + CelphoneTB.Text + "',cerditCompany='" + CreditCompanyCB.Text + "',creditNum='" + ExpirationDateTB.Text + "',expirationDate='" + dtSaleDate.Value.ToShortDateString() + "',act='" + ActiveCB.Text + "' WHERE id='" + CustomerIdTB.Text + "' ";

                    Class1.GetDataSet(strSql);
                    MessageBox.Show("The Data Has Being Updated");
                    frmCustomer_Load(sender, e);
                    CustomerIdTB.Enabled = false;
                    SaveUpdate.Enabled = false;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Class1.GetDataSet("Select * from Customers where id='" + SearchCustomerTB.Text + "'");
            string s = SearchCustomerTB.Text;
            if (Class1.ds.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("Customer doesn't EXIST");
                frmCustomer_Load(sender, e);
                CustomerIdTB.Text = s;

                FullNameTB.Text = "";
                AddressTB.Text = "";
                TelphoneTB.Text = "";
                CelphoneTB.Text = "";
                CreditCompanyCB.Text = "";
                ExpirationDateTB.Text = "";
                ActiveCB.Text = "";
                
            }
            else
            {
                Class1.GetDataSet("Select * from Customers where id='" + SearchCustomerTB.Text + "'");
                CustomerIdTB.Text = Class1.ds.Tables[0].Rows[0]["id"].ToString();
                FullNameTB.Text = Class1.ds.Tables[0].Rows[0]["cname"].ToString();
                AddressTB.Text = Class1.ds.Tables[0].Rows[0]["address"].ToString();
                TelphoneTB.Text = Class1.ds.Tables[0].Rows[0]["tel"].ToString();
                CelphoneTB.Text = Class1.ds.Tables[0].Rows[0]["cell"].ToString();
                CreditCompanyCB.Text = Class1.ds.Tables[0].Rows[0][5].ToString();
                ExpirationDateTB.Text = Class1.ds.Tables[0].Rows[0][6].ToString();
                ActiveCB.Text = Class1.ds.Tables[0].Rows[0]["act"].ToString();

                DisplayUtilities.DisableControls(this);

            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CustomerIdTB.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            FullNameTB.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            AddressTB.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TelphoneTB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            CelphoneTB.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            CreditCompanyCB.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            ExpirationDateTB.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            ActiveCB.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            dtSaleDate.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString());

            DisplayUtilities.DisableControls(this);
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
             
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != (char)8) && (e.KeyChar != ' ')) e.Handled = true;
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != (char)8) && (e.KeyChar != ' ')) e.Handled = true;
            
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
            
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
            
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
            else e.Handled = false;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
            else e.Handled = false;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.')) e.Handled = true;
            else e.Handled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreditCompanyCB.SelectedItem = null;
            ActiveCB.SelectedItem = null;
            DisplayUtilities.ClearControls(this);
            int max = 0;
            foreach (DataRow dr in Tcustomer.Rows)
            {
                if (max <= int.Parse(dr[0].ToString()))
                    max = int.Parse(dr[0].ToString());
            }
            max++;
            CustomerIdTB.Text = max.ToString();

            DisplayUtilities.EnableControls(this);
            AddCustomer.Enabled = true;
            CustomerIdTB.Enabled = false;

        }


        private void button5_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain(true);
            this.Hide();
            b.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cuscod = CustomerIdTB.Text;
            frmSale b = new frmSale(cuscod);
            this.Hide();
            b.Show();
             
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CustomerIdTB.Text != "")
                Sales.Enabled = true;
            if (CustomerIdTB.Text == "")
                Sales.Enabled = false;
        }

  

        private void ToTheStartB_Click(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToFirst(Tcustomer, count));

        }
                      
        private void BackwordB_Click_1(object sender, EventArgs e)
        {
            count = GeneralUtilities.MovePrev(Tcustomer, count);
            DisplayRecord(count);
        }

        private void ForwordB_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.MoveNext(Tcustomer, count));
            count++;
        }

        private void ToTheEndB_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToLast(Tcustomer, count));
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            count = GeneralUtilities.MovePrev(Tcustomer, count);
            DisplayRecord(count);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.MoveNext(Tcustomer, count));
            count++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DisplayRecord(GeneralUtilities.GoToLast(Tcustomer, count));
        }

        private void DeleteSuppliers_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in Tcustomer.Rows)
            {
                if (CustomerIdTB.Text.Equals(dr[0].ToString()))
                {
                    string strSQL1 = "DELETE FROM Customers WHERE id='" + CustomerIdTB.Text + "'";
                    Class1.GetDataSet(strSQL1);
                    MessageBox.Show("The Customer has been deleted");
                    DisplayUtilities.FillDataGrid(dataGridView1, Tcustomer);
                    
                    frmCustomer_Load(sender, e);
                    break;
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            DisplayUtilities.EnableControls(this);
            CustomerIdTB.Enabled = false;
            SaveUpdate.Enabled = true;
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
