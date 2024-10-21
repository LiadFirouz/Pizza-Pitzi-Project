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
    public partial class Orders : Form
    {
        public static string input2;
        public Orders()
        {
            InitializeComponent();
        }

        DataTable Torders;

        private void frmSale_Load(object sender, EventArgs e)
        {
            Torders = Class1.OpenTable("Orders");
           // DisplayUtilities.FillCombo(Torders, 0, cmbCode);
            DisplayUtilities.FillDataGrid(dgv2, Torders);
            Class1.GetDataSet("Select max(orderCode) from Orders");
            int max = int.Parse(Class1.ds.Tables[0].Rows[0][0].ToString());
            max++;
            txtOrderCode.Text = max.ToString();
        }

        private void txtAddNew_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(Torders.Rows[Torders.Rows.Count - 1][0].ToString()) + 1;
            string input = Microsoft.VisualBasic.Interaction.InputBox("insert Supplier code", "Supplier code", "Default", -1, -1);
            //DialogResult res = Microsoft.VisualBasic.Interaction.InputBox.ShowDialog("Select some item from ComboBox below:",
            //"Combo InputBox",   //Text message (mandatory), Title (optional)
            //    InputBox.Icon.Question, //Set icon type (default info)
            //    InputBox.Buttons.OkCancel, //Set buttons (default ok)
            //    InputBox.Type.TextBox, //Set type (default nothing)
            //    new string[] { "Item1", "Item2", "Item3" }, //String field as ComboBox items (default null)
            //    true, //Set visible in taskbar (default false)
            //    new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold));
           // input2 = input;
           frmOrderAssistance f = new frmOrderAssistance(c.ToString(), input);
            this.Hide();
            f.Show();
        }

        private void dgv2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtOrderCode.Text = dgv2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSupplierCode.Text = dgv2.Rows[e.RowIndex].Cells[1].Value.ToString();
           // dtSaleDate.Value = Convert.ToDateTime(dgv2.Rows[e.RowIndex].Cells[2].Value.ToString());
            //הבאת התאריך לא עובדת
            txtOrderArrivalDate.Text = dgv2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtOrderAmount.Text = dgv2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTotalPrice.Text = dgv2.Rows[e.RowIndex].Cells[5].Value.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Torders = Class1.OpenTable("Orders");
            string input = Microsoft.VisualBasic.Interaction.InputBox("insert Order Id", "Order code", "Default", -1, -1);
            Class1.GetDataSet("Select * from Orders where orderCode='" + input + "'");
            if (Torders.Rows.Count == 0)
                MessageBox.Show("This order doesnt exist");

            else
            {
                Class1.GetDataSet("Select * from Orders where orderCode='" + input + "'");
                txtOrderCode.Text = Class1.ds.Tables[0].Rows[0][0].ToString();
                txtSupplierCode.Text = Class1.ds.Tables[0].Rows[0][1].ToString();
                string l = Class1.ds.Tables[0].Rows[0][2].ToString();
                string sd = l.Substring(0, 10);
                dtOrderDate.Value = Convert.ToDateTime(sd);
                txtOrderArrivalDate.Text = Class1.ds.Tables[0].Rows[0][3].ToString();
                txtOrderAmount.Text = Class1.ds.Tables[0].Rows[0][4].ToString();
                txtTotalPrice.Text = Class1.ds.Tables[0].Rows[0][5].ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmMain b = new frmMain(true);
            this.Hide();
            b.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtOrderCode.Enabled = true;
            txtSupplierCode.Enabled = true;
            dtOrderDate.Enabled = true;
            txtOrderArrivalDate.Enabled = true;
            txtOrderAmount.Enabled = true;
            txtTotalPrice.Enabled = true;
            SaveUpdate.Enabled = true;
        }

        private void SaveUpdate_Click(object sender, EventArgs e)
        {
            Torders = Class1.OpenTable("Orders");
            bool t = false;
            if (txtOrderCode.Text != "" && txtSupplierCode.Text != "" && dtOrderDate.Text != "" && txtOrderArrivalDate.Text != "" && txtOrderAmount.Text != "" && txtTotalPrice.Text != "")
                t = true;
            else
                t = false;
            if (t == false)
                MessageBox.Show("Data Is Mising");
            else
            {
                Class1.GetDataSet("Select * from Orders where orderCode='" + txtOrderCode.Text + "'");
                if (Class1.ds.Tables[0].Rows.Count == 0)
                    MessageBox.Show("Order Doesn't Exist");
                else
                {
                    string strSql = "UPDATE Orders SET [supplierCode]='" + txtSupplierCode.Text + "',[orderDate]='" + dtOrderDate.Text + "',[arrivalDate]='" + txtOrderArrivalDate.Text + "',[orderAmount]='" + txtOrderAmount.Text + "',[orderPrice]='" + txtTotalPrice.Text + "' WHERE orderCode='" + txtOrderCode.Text + "'";
                    Class1.GetDataSet(strSql);
                    MessageBox.Show("The Data Has Being Updated");
                    frmSale_Load(sender, e);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in Torders.Rows)
            {
                if (txtOrderCode.Text.Equals(dr[0].ToString()))
                {
                    string strSQL1 = "DELETE FROM Orders WHERE orderCode='" + txtOrderCode.Text + "'";
                    Class1.GetDataSet(strSQL1);
                    string strSQL2 = "DELETE FROM OrdersAssistance WHERE orderCode='" + txtOrderCode.Text + "'";
                    Class1.GetDataSet(strSQL2);
                    MessageBox.Show("The Order has been deleted");
                    DisplayUtilities.FillDataGrid(dgv2, Torders);
                    frmSale_Load(sender, e);
                }
            }
        }

      
    }
}
