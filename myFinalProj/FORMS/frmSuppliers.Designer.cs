namespace myFinalProj.FORMS
{
    partial class Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Suppliers));
            this.ToTheEndB = new System.Windows.Forms.Button();
            this.ForwordB = new System.Windows.Forms.Button();
            this.BackwordB = new System.Windows.Forms.Button();
            this.ToTheStartB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ActiveCB = new System.Windows.Forms.ComboBox();
            this.PhoNumTB = new System.Windows.Forms.TextBox();
            this.AddTB = new System.Windows.Forms.TextBox();
            this.SupNaTB = new System.Windows.Forms.TextBox();
            this.SupCodTB = new System.Windows.Forms.TextBox();
            this.ClearScreen = new System.Windows.Forms.Button();
            this.SaveSuppliers = new System.Windows.Forms.Button();
            this.DeleteSuppliers = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.UpdateSuppliers = new System.Windows.Forms.Button();
            this.AddSuppliers = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerCodeRB = new System.Windows.Forms.RadioButton();
            this.customerFirstNameRB = new System.Windows.Forms.RadioButton();
            this.customerLastNameRB = new System.Windows.Forms.RadioButton();
            this.phoneNumberRB = new System.Windows.Forms.RadioButton();
            this.SearchTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ToTheEndB
            // 
            this.ToTheEndB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheEndB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheEndB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheEndB.ForeColor = System.Drawing.Color.White;
            this.ToTheEndB.Location = new System.Drawing.Point(721, 122);
            this.ToTheEndB.Name = "ToTheEndB";
            this.ToTheEndB.Size = new System.Drawing.Size(94, 30);
            this.ToTheEndB.TabIndex = 60;
            this.ToTheEndB.Text = ">>";
            this.ToTheEndB.UseVisualStyleBackColor = false;
            this.ToTheEndB.Click += new System.EventHandler(this.ToTheEndB_Click_1);
            // 
            // ForwordB
            // 
            this.ForwordB.BackColor = System.Drawing.Color.Transparent;
            this.ForwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwordB.ForeColor = System.Drawing.Color.White;
            this.ForwordB.Location = new System.Drawing.Point(621, 122);
            this.ForwordB.Name = "ForwordB";
            this.ForwordB.Size = new System.Drawing.Size(94, 30);
            this.ForwordB.TabIndex = 59;
            this.ForwordB.Text = ">";
            this.ForwordB.UseVisualStyleBackColor = false;
            this.ForwordB.Click += new System.EventHandler(this.ForwordB_Click_1);
            // 
            // BackwordB
            // 
            this.BackwordB.BackColor = System.Drawing.Color.Transparent;
            this.BackwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwordB.ForeColor = System.Drawing.Color.White;
            this.BackwordB.Location = new System.Drawing.Point(521, 122);
            this.BackwordB.Name = "BackwordB";
            this.BackwordB.Size = new System.Drawing.Size(94, 30);
            this.BackwordB.TabIndex = 58;
            this.BackwordB.Text = "<";
            this.BackwordB.UseVisualStyleBackColor = false;
            this.BackwordB.Click += new System.EventHandler(this.BackwordB_Click_1);
            // 
            // ToTheStartB
            // 
            this.ToTheStartB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheStartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheStartB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheStartB.ForeColor = System.Drawing.Color.White;
            this.ToTheStartB.Location = new System.Drawing.Point(421, 122);
            this.ToTheStartB.Name = "ToTheStartB";
            this.ToTheStartB.Size = new System.Drawing.Size(94, 30);
            this.ToTheStartB.TabIndex = 57;
            this.ToTheStartB.Text = "<<";
            this.ToTheStartB.UseVisualStyleBackColor = false;
            this.ToTheStartB.Click += new System.EventHandler(this.ToTheStartB_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(629, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(590, 252);
            this.dataGridView1.TabIndex = 56;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // ActiveCB
            // 
            this.ActiveCB.FormattingEnabled = true;
            this.ActiveCB.Items.AddRange(new object[] {
            "yes",
            "no "});
            this.ActiveCB.Location = new System.Drawing.Point(221, 405);
            this.ActiveCB.Name = "ActiveCB";
            this.ActiveCB.Size = new System.Drawing.Size(125, 21);
            this.ActiveCB.TabIndex = 55;
            // 
            // PhoNumTB
            // 
            this.PhoNumTB.Location = new System.Drawing.Point(221, 365);
            this.PhoNumTB.Name = "PhoNumTB";
            this.PhoNumTB.Size = new System.Drawing.Size(125, 20);
            this.PhoNumTB.TabIndex = 54;
            // 
            // AddTB
            // 
            this.AddTB.Location = new System.Drawing.Point(221, 327);
            this.AddTB.Name = "AddTB";
            this.AddTB.Size = new System.Drawing.Size(125, 20);
            this.AddTB.TabIndex = 53;
            // 
            // SupNaTB
            // 
            this.SupNaTB.Location = new System.Drawing.Point(221, 287);
            this.SupNaTB.Name = "SupNaTB";
            this.SupNaTB.Size = new System.Drawing.Size(125, 20);
            this.SupNaTB.TabIndex = 52;
            // 
            // SupCodTB
            // 
            this.SupCodTB.Location = new System.Drawing.Point(221, 247);
            this.SupCodTB.Name = "SupCodTB";
            this.SupCodTB.Size = new System.Drawing.Size(125, 20);
            this.SupCodTB.TabIndex = 51;
            // 
            // ClearScreen
            // 
            this.ClearScreen.BackColor = System.Drawing.Color.Transparent;
            this.ClearScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearScreen.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearScreen.ForeColor = System.Drawing.Color.White;
            this.ClearScreen.Location = new System.Drawing.Point(563, 73);
            this.ClearScreen.Name = "ClearScreen";
            this.ClearScreen.Size = new System.Drawing.Size(113, 43);
            this.ClearScreen.TabIndex = 50;
            this.ClearScreen.Text = "Clear Screen";
            this.ClearScreen.UseVisualStyleBackColor = false;
            this.ClearScreen.Click += new System.EventHandler(this.ClearScreen_Click_1);
            // 
            // SaveSuppliers
            // 
            this.SaveSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.SaveSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveSuppliers.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSuppliers.ForeColor = System.Drawing.Color.White;
            this.SaveSuppliers.Location = new System.Drawing.Point(682, 73);
            this.SaveSuppliers.Name = "SaveSuppliers";
            this.SaveSuppliers.Size = new System.Drawing.Size(113, 43);
            this.SaveSuppliers.TabIndex = 49;
            this.SaveSuppliers.Text = "Save Suppliers";
            this.SaveSuppliers.UseVisualStyleBackColor = false;
            this.SaveSuppliers.Click += new System.EventHandler(this.SaveSuppliers_Click);
            // 
            // DeleteSuppliers
            // 
            this.DeleteSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteSuppliers.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteSuppliers.ForeColor = System.Drawing.Color.White;
            this.DeleteSuppliers.Location = new System.Drawing.Point(801, 73);
            this.DeleteSuppliers.Name = "DeleteSuppliers";
            this.DeleteSuppliers.Size = new System.Drawing.Size(113, 43);
            this.DeleteSuppliers.TabIndex = 48;
            this.DeleteSuppliers.Text = "Delete Suppliers";
            this.DeleteSuppliers.UseVisualStyleBackColor = false;
            this.DeleteSuppliers.Click += new System.EventHandler(this.DeleteSuppliers_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Transparent;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.Color.White;
            this.Search.Location = new System.Drawing.Point(1039, 332);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(113, 43);
            this.Search.TabIndex = 47;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            // 
            // UpdateSuppliers
            // 
            this.UpdateSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.UpdateSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSuppliers.Font = new System.Drawing.Font("Segoe Print", 7F, System.Drawing.FontStyle.Bold);
            this.UpdateSuppliers.ForeColor = System.Drawing.Color.White;
            this.UpdateSuppliers.Location = new System.Drawing.Point(444, 73);
            this.UpdateSuppliers.Name = "UpdateSuppliers";
            this.UpdateSuppliers.Size = new System.Drawing.Size(113, 43);
            this.UpdateSuppliers.TabIndex = 46;
            this.UpdateSuppliers.Text = "Update Suppliers";
            this.UpdateSuppliers.UseVisualStyleBackColor = false;
            this.UpdateSuppliers.Click += new System.EventHandler(this.UpdateSuppliers_Click);
            // 
            // AddSuppliers
            // 
            this.AddSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.AddSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddSuppliers.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSuppliers.ForeColor = System.Drawing.Color.White;
            this.AddSuppliers.Location = new System.Drawing.Point(325, 73);
            this.AddSuppliers.Name = "AddSuppliers";
            this.AddSuppliers.Size = new System.Drawing.Size(113, 43);
            this.AddSuppliers.TabIndex = 45;
            this.AddSuppliers.Text = "Add Suppliers";
            this.AddSuppliers.UseVisualStyleBackColor = false;
            this.AddSuppliers.Click += new System.EventHandler(this.AddSuppliers_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 40);
            this.label12.TabIndex = 44;
            this.label12.Text = "Active:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 40);
            this.label6.TabIndex = 43;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 40);
            this.label5.TabIndex = 42;
            this.label5.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 40);
            this.label3.TabIndex = 41;
            this.label3.Text = "Supplier Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 40);
            this.label2.TabIndex = 40;
            this.label2.Text = "Supplier code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(410, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(418, 61);
            this.label4.TabIndex = 148;
            this.label4.Text = "Suppliers Management";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(682, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 149;
            this.button1.Text = "Save Suppliers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Rage Italic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1144, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 69);
            this.button2.TabIndex = 150;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(906, 355);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 152;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(718, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 40);
            this.label1.TabIndex = 151;
            this.label1.Text = "Supplier code:";
            // 
            // customerCodeRB
            // 
            this.customerCodeRB.AutoSize = true;
            this.customerCodeRB.BackColor = System.Drawing.Color.Transparent;
            this.customerCodeRB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerCodeRB.ForeColor = System.Drawing.Color.White;
            this.customerCodeRB.Location = new System.Drawing.Point(1039, 140);
            this.customerCodeRB.Name = "customerCodeRB";
            this.customerCodeRB.Size = new System.Drawing.Size(112, 23);
            this.customerCodeRB.TabIndex = 61;
            this.customerCodeRB.TabStop = true;
            this.customerCodeRB.Text = "Customer Code";
            this.customerCodeRB.UseVisualStyleBackColor = false;
            // 
            // customerFirstNameRB
            // 
            this.customerFirstNameRB.AutoSize = true;
            this.customerFirstNameRB.BackColor = System.Drawing.Color.Transparent;
            this.customerFirstNameRB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerFirstNameRB.ForeColor = System.Drawing.Color.White;
            this.customerFirstNameRB.Location = new System.Drawing.Point(1039, 173);
            this.customerFirstNameRB.Name = "customerFirstNameRB";
            this.customerFirstNameRB.Size = new System.Drawing.Size(147, 23);
            this.customerFirstNameRB.TabIndex = 62;
            this.customerFirstNameRB.TabStop = true;
            this.customerFirstNameRB.Text = "Customer First Name";
            this.customerFirstNameRB.UseVisualStyleBackColor = false;
            // 
            // customerLastNameRB
            // 
            this.customerLastNameRB.AutoSize = true;
            this.customerLastNameRB.BackColor = System.Drawing.Color.Transparent;
            this.customerLastNameRB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLastNameRB.ForeColor = System.Drawing.Color.White;
            this.customerLastNameRB.Location = new System.Drawing.Point(1039, 210);
            this.customerLastNameRB.Name = "customerLastNameRB";
            this.customerLastNameRB.Size = new System.Drawing.Size(144, 23);
            this.customerLastNameRB.TabIndex = 63;
            this.customerLastNameRB.TabStop = true;
            this.customerLastNameRB.Text = "Customer Last Name";
            this.customerLastNameRB.UseVisualStyleBackColor = false;
            // 
            // phoneNumberRB
            // 
            this.phoneNumberRB.AutoSize = true;
            this.phoneNumberRB.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumberRB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberRB.ForeColor = System.Drawing.Color.White;
            this.phoneNumberRB.Location = new System.Drawing.Point(1039, 247);
            this.phoneNumberRB.Name = "phoneNumberRB";
            this.phoneNumberRB.Size = new System.Drawing.Size(110, 23);
            this.phoneNumberRB.TabIndex = 64;
            this.phoneNumberRB.TabStop = true;
            this.phoneNumberRB.Text = "Phone Number";
            this.phoneNumberRB.UseVisualStyleBackColor = false;
            // 
            // SearchTB
            // 
            this.SearchTB.Location = new System.Drawing.Point(1039, 288);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(100, 20);
            this.SearchTB.TabIndex = 65;
            // 
            // Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 720);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchTB);
            this.Controls.Add(this.phoneNumberRB);
            this.Controls.Add(this.customerLastNameRB);
            this.Controls.Add(this.customerFirstNameRB);
            this.Controls.Add(this.customerCodeRB);
            this.Controls.Add(this.ToTheEndB);
            this.Controls.Add(this.ForwordB);
            this.Controls.Add(this.BackwordB);
            this.Controls.Add(this.ToTheStartB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ActiveCB);
            this.Controls.Add(this.PhoNumTB);
            this.Controls.Add(this.AddTB);
            this.Controls.Add(this.SupNaTB);
            this.Controls.Add(this.SupCodTB);
            this.Controls.Add(this.ClearScreen);
            this.Controls.Add(this.SaveSuppliers);
            this.Controls.Add(this.DeleteSuppliers);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.UpdateSuppliers);
            this.Controls.Add(this.AddSuppliers);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Suppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSupplier";
            this.Load += new System.EventHandler(this.Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToTheEndB;
        private System.Windows.Forms.Button ForwordB;
        private System.Windows.Forms.Button BackwordB;
        private System.Windows.Forms.Button ToTheStartB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ActiveCB;
        private System.Windows.Forms.TextBox PhoNumTB;
        private System.Windows.Forms.TextBox AddTB;
        private System.Windows.Forms.TextBox SupNaTB;
        private System.Windows.Forms.TextBox SupCodTB;
        private System.Windows.Forms.Button ClearScreen;
        private System.Windows.Forms.Button SaveSuppliers;
        private System.Windows.Forms.Button DeleteSuppliers;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button UpdateSuppliers;
        private System.Windows.Forms.Button AddSuppliers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton customerCodeRB;
        private System.Windows.Forms.RadioButton customerFirstNameRB;
        private System.Windows.Forms.RadioButton customerLastNameRB;
        private System.Windows.Forms.RadioButton phoneNumberRB;
        private System.Windows.Forms.TextBox SearchTB;
    }
}