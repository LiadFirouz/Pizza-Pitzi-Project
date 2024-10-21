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
    public partial class frmOrderAssistance : Form
    {
        CheckBox[] myToppings = new CheckBox[10];
        CheckBox[] myDeserts = new CheckBox[6];
        CheckBox[] myBeverages = new CheckBox[8];
        CheckBox[] mySalades = new CheckBox[4];
        TextBox[] myPratim = new TextBox[4];
        TextBox[] myDesertsQ = new TextBox[6];
        TextBox[] mySaladesQ = new TextBox[4];
        TextBox[] myBeveragesQ = new TextBox[8];

        DataTable Torder;
        DataTable TorderAssistence;
        public frmOrderAssistance(string a, string b)
        {
            InitializeComponent();
            txtSaleCod.Text = a;
            txtCustomerCod.Text = b;
        }

        public frmOrderAssistance()
        {
            InitializeComponent();



        }

        //****************************************************************************מאפייני בצק ***************************************




        private void button1_Click(object sender, EventArgs e)
        {
            if ((rb1.Checked) && (rb4.Checked))
                addProductToBasket(txtSaleCod.Text, "001001", 1, 20);
            if ((rb1.Checked) && (rb5.Checked))
                addProductToBasket(txtSaleCod.Text, "001002", 1, 25);
            if ((rb2.Checked) && (rb4.Checked))
                addProductToBasket(txtSaleCod.Text, "002001", 1, 25);
            if ((rb2.Checked) && (rb5.Checked))
                addProductToBasket(txtSaleCod.Text, "002002", 1, 30);
            if ((rb3.Checked) && (rb4.Checked))
                addProductToBasket(txtSaleCod.Text, "003001", 1, 30);
            if ((rb3.Checked) && (rb5.Checked))
                addProductToBasket(txtSaleCod.Text, "003002", 1, 35);
        }

        //*************************************************** פונקציות כלליות

        public void addProductToBasket(string saleCod, string productCod, int productAmount, int productPrice)
        {
            String searchValue;
            dgv1.Refresh();
            if (dgv1.Rows.Count - 1 == 0)
            {
                dgv1.Rows.Add(saleCod, productCod, productAmount, productPrice * productAmount);
            }
            else
            {
                searchValue = productCod;
                int rowIndex = -1;
                for (int i = 0; i < (dgv1.Rows.Count - 1); i++)
                {
                    if (dgv1.Rows[i].Cells[1].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = i;
                        break;
                    }
                }
                if (rowIndex != -1)
                {
                    dgv1.Rows[rowIndex].Cells[2].Value = Convert.ToInt32(dgv1.Rows[rowIndex].Cells[2].Value) + productAmount;
                    dgv1.Rows[rowIndex].Cells[3].Value = Convert.ToInt32(dgv1.Rows[rowIndex].Cells[3].Value) + (productAmount * productPrice);

                }

                else
                {
                    dgv1.Rows.Add(saleCod, productCod, productAmount, productPrice * productAmount);

                }
            }

        }
        //**************************************************************בחירת תוספות **************************************
        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if ((myToppings[i].Checked) && ((i + 5) < 10))
                    addProductToBasket(txtSaleCod.Text, "000" + (i + 5).ToString() + "00", 1, 8);
                if ((myToppings[i].Checked) && (i + 5 >= 10))
                    addProductToBasket(txtSaleCod.Text, "00" + (i + 5).ToString() + "00", 1, 8);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (mySalades[i].Checked)
                    addProductToBasket(txtSaleCod.Text, "00" + (i + 15).ToString() + "00", Convert.ToInt32(mySaladesQ[i].Text), 35);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                if (myDeserts[i].Checked)
                    addProductToBasket(txtSaleCod.Text, "00" + (i + 19).ToString() + "00", Convert.ToInt32(myDesertsQ[i].Text), 20);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                if (myBeverages[i].Checked)
                    addProductToBasket(txtSaleCod.Text, "00" + (i + 25).ToString() + "00", Convert.ToInt32(myBeveragesQ[i].Text), 10);
            }
        }

        private void EndSale_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int Tprice = 0;
            for (int i = 0; i < dgv1.Rows.Count; i++)
            {
                sum = sum + Convert.ToInt32(dgv1.Rows[i].Cells[2].Value);
                Tprice = Tprice + Convert.ToInt32(dgv1.Rows[i].Cells[3].Value);
            }
            txtNumOfItems.Text = sum.ToString();
            txtTotalPrice.Text = Tprice.ToString();
        }

        private void frmManue_Load(object sender, EventArgs e)
        {
            

            //filling myTopping array
            myToppings[0] = checkBoxT1;
            myToppings[1] = checkBoxT2;
            myToppings[2] = checkBoxT3;
            myToppings[3] = checkBoxT4;
            myToppings[4] = checkBoxT5;
            myToppings[5] = checkBoxT6;
            myToppings[6] = checkBoxT7;
            myToppings[7] = checkBoxT8;
            myToppings[8] = checkBoxT9;
            myToppings[9] = checkBoxT10;
            //filling myDeserts array
            myDeserts[0] = checkBoxD1;
            myDeserts[1] = checkBoxD2;
            myDeserts[2] = checkBoxD3;
            myDeserts[3] = checkBoxD4;
            myDeserts[4] = checkBoxD5;
            myDeserts[5] = checkBoxD6;
            //filling mySakades array
            mySalades[0] = checkBoxS1;
            mySalades[1] = checkBoxS2;
            mySalades[2] = checkBoxS3;
            mySalades[3] = checkBoxS4;
            //filling myBevrage array
            myBeverages[0] = checkBoxM1;
            myBeverages[1] = checkBoxM2;
            myBeverages[2] = checkBoxM3;
            myBeverages[3] = checkBoxM4;
            myBeverages[4] = checkBoxM5;
            myBeverages[5] = checkBoxM6;
            myBeverages[6] = checkBoxM7;
            myBeverages[7] = checkBoxM8;
            //

            myDesertsQ[0] = textBoxD1;
            myDesertsQ[1] = textBoxD2;
            myDesertsQ[2] = textBoxD3;
            myDesertsQ[3] = textBoxD4;
            myDesertsQ[4] = textBoxD5;
            myDesertsQ[5] = textBoxD6;
            //
            mySaladesQ[0] = textBoxS1;
            mySaladesQ[1] = textBoxS2;
            mySaladesQ[2] = textBoxS3;
            mySaladesQ[3] = textBoxS4;
            //  
            myBeveragesQ[0] = textBoxM1;
            myBeveragesQ[1] = textBoxM2;
            myBeveragesQ[2] = textBoxM3;
            myBeveragesQ[3] = textBoxM4;
            myBeveragesQ[4] = textBoxM5;
            myBeveragesQ[5] = textBoxM6;
            myBeveragesQ[6] = textBoxM7;
            myBeveragesQ[7] = textBoxM8;
            Torder = Class1.OpenTable("Orders");
            TorderAssistence = Class1.OpenTable("OrdersAssistance");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime toDay = DateTime.Now;
            string o, p, u, q;
            for (int i = 0; i < dgv1.Rows.Count - 1; i++)
            {
                o = (dgv1.Rows[i].Cells[0].Value).ToString();
                p = (dgv1.Rows[i].Cells[1].Value).ToString();
                q = (dgv1.Rows[i].Cells[2].Value).ToString();
                u = (dgv1.Rows[i].Cells[3].Value).ToString();
                string strSql1 = "INSERT INTO OrdersAssistance(orderCode,productCode,amount,price)";//הוספת פריטים לטבלת
                string strSql2 = "VALUES('" + o + "','" + p + "','" + q + "','" + u + "')";
                string strSqrl = strSql1 + strSql2;
                Class1.GetDataSet(strSqrl);

            }
            string str1 = "INSERT INTO Orders(orderCode,supplierCode,orderDate,arrivalDate,orderAmount,orderPrice)";//הוספת שורה  לטבלת ORDERS
            string str2 = "VALUES('" + txtSaleCod.Text + "','" + txtCustomerCod.Text + "','" + toDay.ToShortDateString() + "','" + toDay.ToShortDateString() + "','" + txtNumOfItems.Text + "','" + txtTotalPrice.Text + "')";
            string str = str1 + str2;
            MessageBox.Show(GeneralUtilities.AddRecd(Torder, str).ToString());
            Class1.GetDataSet("Select * from Orders");

        }

        private void txtAddNew_Click(object sender, EventArgs e)
        {
            Orders f = new Orders();
            this.Hide();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerCod_TextChanged(object sender, EventArgs e)
        {

        }


    }
}

