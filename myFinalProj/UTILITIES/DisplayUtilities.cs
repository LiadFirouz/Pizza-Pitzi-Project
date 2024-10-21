using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace myFinalProj.UTILITIES
{
    public static class DisplayUtilities
    {
        public static void FillDataGrid(DataGridView gv, DataTable table)
        {
            gv.DataSource = table.DefaultView;
        }


        public static void DisplayListView(ListView lv, DataRow[] rows)
        {

            foreach (DataRow dr in rows)
            {
                ListViewItem it = new ListViewItem(dr[0].ToString());
                for (int i = 1; i < dr.ItemArray.Length; i++)
                    it.SubItems.Add(dr[i].ToString());
                lv.Items.Add(it);
            }
        }
        public static void FillCombo(DataTable Table, int col, ComboBox cmb)//ממלא קומבו בלי כפילויות 
        {
            List<string> list1 = new List<string>();
            for (int i = 0; i < Table.Rows.Count; i++)//מעתיקים פריטים מעמודה בטבלה לקומבו 
            {
                cmb.Items.Add(Table.Rows[i][col].ToString());
            }
            for (int i = 0; i < cmb.Items.Count; i++)// מעתיקים פריטים מהקומבו לרשימה פריט רק אם אינו קיים בה
            {
                string s = cmb.Items[i].ToString();
                if (!list1.Contains(s))
                    list1.Add(s);
            }
            PopulateCmbFromList(list1, cmb);
        }
        public static void PopulateList(DataTable table, List<int> myList)
        {
            foreach (DataRow row in table.Rows)
            {
                myList.Add((int)row[0]);
            }
        }
        public static void PopulateCmbFromList(List<string> list2, ComboBox cmb1)
        {
            cmb1.Items.Clear();
            for (int j = 0; j < list2.Count; j++)
                cmb1.Items.Add(list2.ElementAt(j).ToString());
        }
        public static void DisableControls(Control c)
        {
            foreach (Control Ctrl in c.Controls)
            {
                if (Ctrl is TextBox)
                    Ctrl.Enabled = false;
                if (Ctrl is CheckBox)
                    ((CheckBox)Ctrl).Enabled = false;
                if (Ctrl is ComboBox)
                    ((ComboBox)Ctrl).Enabled = false;
                if (Ctrl is DateTimePicker)
                    (Ctrl as DateTimePicker).Enabled = false;
            }
        }
        public static void EnableControls(Control c)
        {
            foreach (Control Ctrl in c.Controls)
            {
                if (Ctrl is TextBox)
                    Ctrl.Enabled = true;
                if (Ctrl is CheckBox)
                    ((CheckBox)Ctrl).Enabled = true;
                if (Ctrl is ComboBox)
                    ((ComboBox)Ctrl).Enabled = true;
                if (Ctrl is DateTimePicker)
                    (Ctrl as DateTimePicker).Enabled = true;
            }
        }
        public static void ClearControls(Control c)
        {
            foreach (Control Ctrl in c.Controls)
            {
                switch (Ctrl.GetType().ToString())
                {
                    case "System.Windows.Forms.CheckBox":
                        ((CheckBox)Ctrl).Checked = false;
                        break;

                    case "System.Windows.Forms.TextBox":
                        ((TextBox)Ctrl).Text = "";
                        break;

                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)Ctrl).Value =DateTime.Now;
                        break;

                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)Ctrl).Text = " ";
                        break;
                }
            }
        }
        public static void FillComboWithCondition(DataTable Table, int col,string conditionS,ComboBox cmb)//ממלא קומבו בלי כפילויות 
        {
            for (int i = 0; i < Table.Rows.Count; i++)//מעתיקים פריטים מעמודה בטבלה עם תנאי לקומבו 
               if (Table.Rows[i][col].ToString().Equals(conditionS))
                  cmb.Items.Add(Table.Rows[i][col].ToString());
       }
 }
}
    


        
        
        
       
