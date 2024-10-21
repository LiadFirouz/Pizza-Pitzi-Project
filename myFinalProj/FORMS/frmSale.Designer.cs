namespace myFinalProj.FORMS
{
    partial class frmSale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSale));
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.txtAddNew = new System.Windows.Forms.Button();
            this.SaleUpdae = new System.Windows.Forms.Button();
            this.txtCustomerCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.dtSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumOfItems = new System.Windows.Forms.TextBox();
            this.txtSaleCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ToTheEndB = new System.Windows.Forms.Button();
            this.ForwordB = new System.Windows.Forms.Button();
            this.BackwordB = new System.Windows.Forms.Button();
            this.ToTheStartB = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SearchSaleTB = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SaveUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(590, 409);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(629, 224);
            this.dgv2.TabIndex = 144;
            this.dgv2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv2_RowHeaderMouseClick);
            // 
            // txtAddNew
            // 
            this.txtAddNew.BackColor = System.Drawing.Color.Transparent;
            this.txtAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtAddNew.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddNew.ForeColor = System.Drawing.Color.White;
            this.txtAddNew.Location = new System.Drawing.Point(358, 73);
            this.txtAddNew.Name = "txtAddNew";
            this.txtAddNew.Size = new System.Drawing.Size(113, 43);
            this.txtAddNew.TabIndex = 143;
            this.txtAddNew.Text = "New Sale ";
            this.txtAddNew.UseVisualStyleBackColor = false;
            this.txtAddNew.Click += new System.EventHandler(this.txtAddNew_Click);
            // 
            // SaleUpdae
            // 
            this.SaleUpdae.BackColor = System.Drawing.Color.Transparent;
            this.SaleUpdae.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaleUpdae.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleUpdae.ForeColor = System.Drawing.Color.White;
            this.SaleUpdae.Location = new System.Drawing.Point(477, 73);
            this.SaleUpdae.Name = "SaleUpdae";
            this.SaleUpdae.Size = new System.Drawing.Size(113, 43);
            this.SaleUpdae.TabIndex = 142;
            this.SaleUpdae.Text = "Sale UpDate";
            this.SaleUpdae.UseVisualStyleBackColor = false;
            this.SaleUpdae.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerCod
            // 
            this.txtCustomerCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCustomerCod.Location = new System.Drawing.Point(243, 293);
            this.txtCustomerCod.Name = "txtCustomerCod";
            this.txtCustomerCod.Size = new System.Drawing.Size(196, 20);
            this.txtCustomerCod.TabIndex = 139;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 40);
            this.label4.TabIndex = 138;
            this.label4.Text = "Customer Code:";
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtTotalPrice.Location = new System.Drawing.Point(243, 505);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(196, 20);
            this.txtTotalPrice.TabIndex = 136;
            // 
            // dtSaleDate
            // 
            this.dtSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dtSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSaleDate.Location = new System.Drawing.Point(243, 351);
            this.dtSaleDate.Name = "dtSaleDate";
            this.dtSaleDate.Size = new System.Drawing.Size(196, 20);
            this.dtSaleDate.TabIndex = 135;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(205, 521);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 24);
            this.lblCount.TabIndex = 134;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 498);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 40);
            this.label5.TabIndex = 131;
            this.label5.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 40);
            this.label3.TabIndex = 130;
            this.label3.Text = "Amount";
            // 
            // txtNumOfItems
            // 
            this.txtNumOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNumOfItems.Location = new System.Drawing.Point(243, 423);
            this.txtNumOfItems.Name = "txtNumOfItems";
            this.txtNumOfItems.Size = new System.Drawing.Size(196, 20);
            this.txtNumOfItems.TabIndex = 129;
            // 
            // txtSaleCod
            // 
            this.txtSaleCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSaleCod.Location = new System.Drawing.Point(243, 222);
            this.txtSaleCod.Name = "txtSaleCod";
            this.txtSaleCod.Size = new System.Drawing.Size(196, 20);
            this.txtSaleCod.TabIndex = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 40);
            this.label2.TabIndex = 127;
            this.label2.Text = "Sale Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 40);
            this.label1.TabIndex = 126;
            this.label1.Text = "Sale Code:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe Print", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1002, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 43);
            this.button2.TabIndex = 146;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(417, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(346, 61);
            this.label6.TabIndex = 147;
            this.label6.Text = "Sales Management";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1144, 639);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 69);
            this.button3.TabIndex = 151;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ToTheEndB
            // 
            this.ToTheEndB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToTheEndB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheEndB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheEndB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheEndB.ForeColor = System.Drawing.Color.White;
            this.ToTheEndB.Location = new System.Drawing.Point(695, 122);
            this.ToTheEndB.Name = "ToTheEndB";
            this.ToTheEndB.Size = new System.Drawing.Size(94, 30);
            this.ToTheEndB.TabIndex = 163;
            this.ToTheEndB.Text = ">>";
            this.ToTheEndB.UseVisualStyleBackColor = false;
            this.ToTheEndB.Click += new System.EventHandler(this.ToTheEndB_Click);
            // 
            // ForwordB
            // 
            this.ForwordB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ForwordB.BackColor = System.Drawing.Color.Transparent;
            this.ForwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForwordB.ForeColor = System.Drawing.Color.White;
            this.ForwordB.Location = new System.Drawing.Point(595, 122);
            this.ForwordB.Name = "ForwordB";
            this.ForwordB.Size = new System.Drawing.Size(94, 30);
            this.ForwordB.TabIndex = 162;
            this.ForwordB.Text = ">";
            this.ForwordB.UseVisualStyleBackColor = false;
            this.ForwordB.Click += new System.EventHandler(this.ForwordB_Click);
            // 
            // BackwordB
            // 
            this.BackwordB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackwordB.BackColor = System.Drawing.Color.Transparent;
            this.BackwordB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackwordB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackwordB.ForeColor = System.Drawing.Color.White;
            this.BackwordB.Location = new System.Drawing.Point(495, 122);
            this.BackwordB.Name = "BackwordB";
            this.BackwordB.Size = new System.Drawing.Size(94, 30);
            this.BackwordB.TabIndex = 161;
            this.BackwordB.Text = "<";
            this.BackwordB.UseVisualStyleBackColor = false;
            this.BackwordB.Click += new System.EventHandler(this.BackwordB_Click);
            // 
            // ToTheStartB
            // 
            this.ToTheStartB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToTheStartB.BackColor = System.Drawing.Color.Transparent;
            this.ToTheStartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTheStartB.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTheStartB.ForeColor = System.Drawing.Color.White;
            this.ToTheStartB.Location = new System.Drawing.Point(395, 122);
            this.ToTheStartB.Name = "ToTheStartB";
            this.ToTheStartB.Size = new System.Drawing.Size(94, 30);
            this.ToTheStartB.TabIndex = 160;
            this.ToTheStartB.Text = "<<";
            this.ToTheStartB.UseVisualStyleBackColor = false;
            this.ToTheStartB.Click += new System.EventHandler(this.ToTheStartB_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(730, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 40);
            this.label9.TabIndex = 165;
            this.label9.Text = "Sale Code:";
            // 
            // SearchSaleTB
            // 
            this.SearchSaleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchSaleTB.Location = new System.Drawing.Point(872, 366);
            this.SearchSaleTB.MaxLength = 9;
            this.SearchSaleTB.Name = "SearchSaleTB";
            this.SearchSaleTB.Size = new System.Drawing.Size(115, 20);
            this.SearchSaleTB.TabIndex = 164;
            this.SearchSaleTB.TextChanged += new System.EventHandler(this.SearchCustomerTB_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(713, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 43);
            this.button4.TabIndex = 166;
            this.button4.Text = "Delete Sale";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SaveUpdate
            // 
            this.SaveUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveUpdate.BackColor = System.Drawing.Color.Transparent;
            this.SaveUpdate.Enabled = false;
            this.SaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveUpdate.Font = new System.Drawing.Font("Segoe Print", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUpdate.ForeColor = System.Drawing.Color.White;
            this.SaveUpdate.Location = new System.Drawing.Point(596, 73);
            this.SaveUpdate.Name = "SaveUpdate";
            this.SaveUpdate.Size = new System.Drawing.Size(113, 43);
            this.SaveUpdate.TabIndex = 169;
            this.SaveUpdate.Text = "Save Update ";
            this.SaveUpdate.UseVisualStyleBackColor = false;
            this.SaveUpdate.Click += new System.EventHandler(this.SaveUpdate_Click);
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1231, 720);
            this.ControlBox = false;
            this.Controls.Add(this.SaveUpdate);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.SearchSaleTB);
            this.Controls.Add(this.ToTheEndB);
            this.Controls.Add(this.ForwordB);
            this.Controls.Add(this.BackwordB);
            this.Controls.Add(this.ToTheStartB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.txtAddNew);
            this.Controls.Add(this.SaleUpdae);
            this.Controls.Add(this.txtCustomerCod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.dtSaleDate);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumOfItems);
            this.Controls.Add(this.txtSaleCod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.Button txtAddNew;
        private System.Windows.Forms.Button SaleUpdae;
        private System.Windows.Forms.TextBox txtCustomerCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.DateTimePicker dtSaleDate;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumOfItems;
        private System.Windows.Forms.TextBox txtSaleCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button ToTheEndB;
        private System.Windows.Forms.Button ForwordB;
        private System.Windows.Forms.Button BackwordB;
        private System.Windows.Forms.Button ToTheStartB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SearchSaleTB;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button SaveUpdate;
    }
}