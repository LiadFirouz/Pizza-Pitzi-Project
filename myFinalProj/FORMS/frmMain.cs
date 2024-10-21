using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myFinalProj.FORMS;
using System.Data.OleDb;
using myFinalProj.DAL;
using myFinalProj.FORMS.Reports;

namespace myFinalProj.FORMS
{
    public partial class frmMain : Form
    {
        public bool Login;
        DataTable TUsers;

        public frmMain(bool enable)
        {
            InitializeComponent();
            groupBox1.Hide();
            Login = enable;
        }

        public frmMain()
        {
            
            InitializeComponent();
            Login = false;
            groupBox1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer b = new frmCustomer();
            this.Hide();
            
            b.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSale f = new frmSale("");
            this.Hide();
            f.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Suppliers f = new Suppliers();
            this.Hide();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports.Reports f = new Reports.Reports();
            this.Hide();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            this.Hide();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmAbout f = new frmAbout();
            this.Hide();
            f.Show();
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            TUsers = Class1.OpenTable("Users");

            foreach (DataRow dr in TUsers.Rows)
            {
                if (dr[0].ToString().Equals(textBox1.Text))
                {
                    if (dr[1].ToString().Equals(textBox2.Text))
                    {
                        groupBox1.Visible = false;
                        Login = true;

                    }
                }
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Login)
            {
                groupBox1.Hide();
            }
            
        }

 
        private void button9_Click(object sender, EventArgs e)
        {
            frmProducts f = new frmProducts();
            this.Hide();
            f.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != (char)8) && (e.KeyChar != '.'))
                e.Handled = true;
           
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
              
    }
}
