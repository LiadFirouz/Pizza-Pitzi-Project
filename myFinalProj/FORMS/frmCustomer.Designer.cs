namespace myFinalProj.FORMS
{
    partial class frmCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomer));
            this.ActiveCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIdTB = new System.Windows.Forms.TextBox();
            this.CreditCompanyCB = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchCustomerTB = new System.Windows.Forms.TextBox();
            this.SearchCustomer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.SaveUpdate = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpirationDateTB = new System.Windows.Forms.TextBox();
            this.CelphoneTB = new System.Windows.Forms.TextBox();
            this.TelphoneTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.FullNameTB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClearScreen = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Sales = new System.Windows.Forms.Button();
            this.ToTheEndB = new System.Windows.Forms.Button();
            this.ForwordB = new System.Windows.Forms.Button();
            this.BackwordB = new System.Windows.Forms.Button();
            this.ToTheStartB = new System.Windows.Forms.Button();
            this.DeleteSuppliers = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.dtSaleDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ActiveCB
            // 
            this.ActiveCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ActiveCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ActiveCB.FormattingEnabled = true;
            this.ActiveCB.Items.AddRange(new object[] {
            "כן",
            "לא"});
            this.ActiveCB.Location = new System.Drawing.Point(262, 608);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(195, 21);
            this.ActiveCB.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 492);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 40);
            this.label11.TabIndex = 60;
            this.label11.Text = " Expiration Date:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 40);
            this.label1.TabIndex = 58;
            this.label1.Text = "Customer Id:";
            // 
            // CustomerIdTB
            // 
            this.CustomerIdTB.BackColor = System.Drawing.Color.White;
            this.CustomerIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomerIdTB.Location = new System.Drawing.Point(262, 217);
            this.CustomerIdTB.MaxLength = 9;
            this.CustomerIdTB.Name = "CustomerIdTB";
            this.CustomerIdTB.Size = new System.Drawing.Size(196, 20);
            this.CustomerIdTB.TabIndex = 57;
            this.CustomerIdTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreditCompanyCB
            // 
            this.CreditCompanyCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CreditCompanyCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CreditCompanyCB.FormattingEnabled = true;
            this.CreditCompanyCB.Location = new System.Drawing.Point(264, 451);
            this.CreditCompanyCB.Name = "CreditCompanyCB";
            this.CreditCompanyCB.Size = new System.Drawing.Size(195, 21);
            this.CreditCompanyCB.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(638, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 40);
            this.label9.TabIndex = 48;
            this.label9.Text = "Customer Id:";
            // 
            // SearchCustomerTB
            // 
            this.SearchCustomerTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchCustomerTB.Location = new System.Drawing.Point(810, 304);
            this.SearchCustomerTB.MaxLength = 9;
            this.SearchCustomerTB.Name = "SearchCustomerTB";
            this.SearchCustomerTB.Size = new System.Drawing.Size(115, 19);
            this.SearchCustomerTB.TabIndex = 39;
            // 
            // SearchCustomer
            // 
            this.SearchCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchCustomer.BackColor = System.Drawing.Color.Transparent;
            this.SearchCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchCustomer.Font = new System.Drawing.Font("Segoe Print", 7.5F, System.Drawing.FontStyle.Bold);
            this.SearchCustomer.ForeColor = System.Drawing.Color.White;
            this.SearchCustomer.Location = new System.Drawing.Point(931, 286);
            this.SearchCustomer.Name = "SearchCustomer";
            this.SearchCustomer.Size = new System.Drawing.Size(113, 43);
            this.SearchCustomer.TabIndex = 53;
            this.SearchCustomer.Text = "Search Customer";
            this.SearchCustomer.UseVisualStyleBackColor = false;
            this.SearchCustomer.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(403, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(439, 61);
            this.label10.TabIndex = 54;
            this.label10.Text = "Customers Management";
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveUpdate.BackColor = System.Drawing.Color.Transparent;
            this.SaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUpdate.Font = new System.Drawing.Font("Segoe Print", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUpdate.ForeColor = System.Drawing.Color.White;
            this.SaveUpdate.Location = new System.Drawing.Point(394, 72);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(113, 43);
            this.SaveUpdate.TabIndex = 52;
            this.SaveUpdate.Text = "Save Update ";
            this.SaveUpdate.UseVisualStyleBackColor = false;
            this.SaveUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.AddCustomer.Enabled = false;
            this.AddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddCustomer.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.Location = new System.Drawing.Point(275, 72);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(113, 43);
            this.AddCustomer.TabIndex = 51;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = false;
            this.AddCustomer.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 593);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 40);
            this.label8.TabIndex = 49;
            this.label8.Text = "Active:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 541);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 40);
            this.label7.TabIndex = 47;
            this.label7.Text = "Card Number:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 40);
            this.label6.TabIndex = 50;
            this.label6.Text = "Credit Company:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 40);
            this.label5.TabIndex = 46;
            this.label5.Text = "CelPhone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 40);
            this.label4.TabIndex = 45;
            this.label4.Text = "TelPhone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 40);
            this.label3.TabIndex = 44;
            this.label3.Text = "Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 40);
            this.label2.TabIndex = 43;
            this.label2.Text = "Full Name:";
            // 
            // ExpirationDateTB
            // 
            this.ExpirationDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExpirationDateTB.Location = new System.Drawing.Point(261, 556);
            this.ExpirationDateTB.MaxLength = 16;
            this.ExpirationDateTB.Name = "ExpirationDateTB";
            this.ExpirationDateTB.Size = new System.Drawing.Size(195, 20);
            this.ExpirationDateTB.TabIndex = 41;
            // 
            // CelphoneTB
            // 
            this.CelphoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CelphoneTB.Location = new System.Drawing.Point(262, 396);
            this.CelphoneTB.MaxLength = 10;
            this.CelphoneTB.Name = "CelphoneTB";
            this.CelphoneTB.Size = new System.Drawing.Size(195, 20);
            this.CelphoneTB.TabIndex = 40;
            // 
            // TelphoneTB
            // 
            this.TelphoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TelphoneTB.Location = new System.Drawing.Point(262, 349);
            this.TelphoneTB.MaxLength = 10;
            this.TelphoneTB.Name = "TelphoneTB";
            this.TelphoneTB.Size = new System.Drawing.Size(195, 20);
            this.TelphoneTB.TabIndex = 38;
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddressTB.Location = new System.Drawing.Point(262, 304);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(196, 20);
            this.AddressTB.TabIndex = 42;
            // 
            // FullNameTB
            // 
            this.FullNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FullNameTB.Location = new System.Drawing.Point(262, 263);
            this.FullNameTB.Name = "FullNameTB";
            this.FullNameTB.Size = new System.Drawing.Size(195, 20);
            this.FullNameTB.TabIndex = 37;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.dataGridView1.Location = new System.Drawing.Point(479, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(729, 271);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ClearScreen
            // 
            this.ClearScreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearScreen.BackColor = System.Drawing.Color.Transparent;
            this.ClearScreen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ClearScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScreen.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.ClearScreen.ForeColor = System.Drawing.Color.White;
            this.ClearScreen.Location = new System.Drawing.Point(513, 72);
            this.ClearScreen.Name = "ClearScreen";
            this.ClearScreen.Size = new System.Drawing.Size(113, 43);
            this.ClearScreen.TabIndex = 62;
            this.ClearScreen.Text = "Clear Screen";
            this.ClearScreen.UseVisualStyleBackColor = false;
            this.ClearScreen.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(1144, 641);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 69);
            this.button5.TabIndex = 152;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Sales
            // 
            this.Sales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sales.BackColor = System.Drawing.Color.Transparent;
            this.Sales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sales.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold);
            this.Sales.ForeColor = System.Drawing.Color.White;
            this.Sales.Location = new System.Drawing.Point(870, 72);
            this.Sales.Name = "Sales";
            this.Sales.Size = new System.Drawing.Size(113, 43);
            this.Sales.TabIndex = 153;
            this.Sales.Text = "Sales";
            this.Sales.UseVisualStyleBackColor = false;
            this.Sales.Click += new System.EventHandler(this.button6_Click);
            // 
            // ToTheEndB
            // 
            this.ToTheEndB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToTheEndB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheEndB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheEndB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheEndB.ForeColor = System.Drawing.Color.White;
            this.ToTheEndB.Location = new System.Drawing.Point(732, 121);
            this.ToTheEndB.Name = "ToTheEndB";
            this.ToTheEndB.Size = new System.Drawing.Size(94, 30);
            this.ToTheEndB.TabIndex = 159;
            this.ToTheEndB.Text = ">>";
            this.ToTheEndB.UseVisualStyleBackColor = false;
            this.ToTheEndB.Click += new System.EventHandler(this.ToTheEndB_Click_1);
            // 
            // ForwordB
            // 
            this.ForwordB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForwordB.BackColor = System.Drawing.Color.Transparent;
            this.ForwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwordB.ForeColor = System.Drawing.Color.White;
            this.ForwordB.Location = new System.Drawing.Point(632, 121);
            this.ForwordB.Name = "ForwordB";
            this.ForwordB.Size = new System.Drawing.Size(94, 30);
            this.ForwordB.TabIndex = 158;
            this.ForwordB.Text = ">";
            this.ForwordB.UseVisualStyleBackColor = false;
            this.ForwordB.Click += new System.EventHandler(this.ForwordB_Click_1);
            // 
            // BackwordB
            // 
            this.BackwordB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackwordB.BackColor = System.Drawing.Color.Transparent;
            this.BackwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwordB.ForeColor = System.Drawing.Color.White;
            this.BackwordB.Location = new System.Drawing.Point(532, 121);
            this.BackwordB.Name = "BackwordB";
            this.BackwordB.Size = new System.Drawing.Size(94, 30);
            this.BackwordB.TabIndex = 157;
            this.BackwordB.Text = "<";
            this.BackwordB.UseVisualStyleBackColor = false;
            this.BackwordB.Click += new System.EventHandler(this.BackwordB_Click_1);
            // 
            // ToTheStartB
            // 
            this.ToTheStartB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToTheStartB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheStartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheStartB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheStartB.ForeColor = System.Drawing.Color.White;
            this.ToTheStartB.Location = new System.Drawing.Point(432, 121);
            this.ToTheStartB.Name = "ToTheStartB";
            this.ToTheStartB.Size = new System.Drawing.Size(94, 30);
            this.ToTheStartB.TabIndex = 156;
            this.ToTheStartB.Text = "<<";
            this.ToTheStartB.UseVisualStyleBackColor = false;
            this.ToTheStartB.Click += new System.EventHandler(this.ToTheStartB_Click);
            // 
            // DeleteSuppliers
            // 
            this.DeleteSuppliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSuppliers.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSuppliers.ForeColor = System.Drawing.Color.White;
            this.DeleteSuppliers.Location = new System.Drawing.Point(751, 72);
            this.DeleteSuppliers.Name = "DeleteSuppliers";
            this.DeleteSuppliers.Size = new System.Drawing.Size(113, 43);
            this.DeleteSuppliers.TabIndex = 160;
            this.DeleteSuppliers.Text = "Delete Suppliers";
            this.DeleteSuppliers.UseVisualStyleBackColor = false;
            this.DeleteSuppliers.Click += new System.EventHandler(this.DeleteSuppliers_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateCustomer.BackColor = System.Drawing.Color.Transparent;
            this.UpdateCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomer.Font = new System.Drawing.Font("Segoe Print", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.UpdateCustomer.Location = new System.Drawing.Point(632, 72);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(113, 43);
            this.UpdateCustomer.TabIndex = 161;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = false;
            this.UpdateCustomer.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // dtSaleDate
            // 
            this.dtSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaleDate.Location = new System.Drawing.Point(260, 504);
            this.dtSaleDate.Name = "dtSaleDate";
            this.dtSaleDate.Size = new System.Drawing.Size(196, 20);
            this.dtSaleDate.TabIndex = 162;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 720);
            this.Controls.Add(this.dtSaleDate);
            this.Controls.Add(this.UpdateCustomer);
            this.Controls.Add(this.DeleteSuppliers);
            this.Controls.Add(this.ToTheEndB);
            this.Controls.Add(this.ForwordB);
            this.Controls.Add(this.BackwordB);
            this.Controls.Add(this.ToTheStartB);
            this.Controls.Add(this.Sales);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ClearScreen);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerIdTB);
            this.Controls.Add(this.CreditCompanyCB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchCustomerTB);
            this.Controls.Add(this.SearchCustomer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SaveUpdate);
            this.Controls.Add(this.AddCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpirationDateTB);
            this.Controls.Add(this.CelphoneTB);
            this.Controls.Add(this.TelphoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.FullNameTB);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ActiveCB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerIdTB;
        private System.Windows.Forms.ComboBox CreditCompanyCB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchCustomerTB;
        private System.Windows.Forms.Button SearchCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SaveUpdate;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ExpirationDateTB;
        private System.Windows.Forms.TextBox CelphoneTB;
        private System.Windows.Forms.TextBox TelphoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox FullNameTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ClearScreen;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Sales;
        private System.Windows.Forms.Button ToTheEndB;
        private System.Windows.Forms.Button ForwordB;
        private System.Windows.Forms.Button BackwordB;
        private System.Windows.Forms.Button ToTheStartB;
        private System.Windows.Forms.Button DeleteSuppliers;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.DateTimePicker dtSaleDate;
    }
}