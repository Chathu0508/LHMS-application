namespace LHMS_Application.Froms
{
    partial class FrmADSales
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
            this.btnreset = new System.Windows.Forms.Button();
            this.txttotle = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdealcus = new System.Windows.Forms.ComboBox();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.dgvbuyer = new System.Windows.Forms.DataGridView();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.lblstatus = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.lblDelcusid = new System.Windows.Forms.Label();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.txtproductcode = new System.Windows.Forms.TextBox();
            this.lblprodcide = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtcategoryCode = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblcatecode = new System.Windows.Forms.Label();
            this.lblCatetype = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnreset.Location = new System.Drawing.Point(599, 414);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(78, 69);
            this.btnreset.TabIndex = 67;
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // txttotle
            // 
            this.txttotle.BackColor = System.Drawing.Color.White;
            this.txttotle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotle.Location = new System.Drawing.Point(258, 298);
            this.txttotle.Name = "txttotle";
            this.txttotle.Size = new System.Drawing.Size(322, 28);
            this.txttotle.TabIndex = 65;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(24, 302);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(95, 21);
            this.lbltotal.TabIndex = 64;
            this.lbltotal.Text = "Total Cost";
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(258, 187);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(322, 28);
            this.txtqty.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 62;
            this.label2.Text = "Product Qty";
            // 
            // cmbdealcus
            // 
            this.cmbdealcus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdealcus.FormattingEnabled = true;
            this.cmbdealcus.Items.AddRange(new object[] {
            "Sales",
            "Purchase"});
            this.cmbdealcus.Location = new System.Drawing.Point(258, 225);
            this.cmbdealcus.Name = "cmbdealcus";
            this.cmbdealcus.Size = new System.Drawing.Size(322, 29);
            this.cmbdealcus.TabIndex = 59;
            // 
            // cmbstatus
            // 
            this.cmbstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Pending payment",
            "Complete Payment"});
            this.cmbstatus.Location = new System.Drawing.Point(258, 331);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(322, 29);
            this.cmbstatus.TabIndex = 58;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(258, 414);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(322, 69);
            this.btnadd.TabIndex = 55;
            this.btnadd.Text = "Added Action";
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // dgvbuyer
            // 
            this.dgvbuyer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbuyer.BackgroundColor = System.Drawing.Color.White;
            this.dgvbuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyer.Location = new System.Drawing.Point(12, 506);
            this.dgvbuyer.Name = "dgvbuyer";
            this.dgvbuyer.RowHeadersWidth = 51;
            this.dgvbuyer.RowTemplate.Height = 24;
            this.dgvbuyer.Size = new System.Drawing.Size(665, 256);
            this.dgvbuyer.TabIndex = 54;
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.Color.White;
            this.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(258, 264);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(322, 28);
            this.txtrate.TabIndex = 53;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(24, 335);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(174, 21);
            this.lblstatus.TabIndex = 52;
            this.lblstatus.Text = "Status of the action";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(24, 268);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(50, 21);
            this.rate.TabIndex = 51;
            this.rate.Text = "Rate";
            // 
            // lblDelcusid
            // 
            this.lblDelcusid.AutoSize = true;
            this.lblDelcusid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelcusid.Location = new System.Drawing.Point(24, 225);
            this.lblDelcusid.Name = "lblDelcusid";
            this.lblDelcusid.Size = new System.Drawing.Size(143, 21);
            this.lblDelcusid.TabIndex = 49;
            this.lblDelcusid.Text = "Customer name";
            // 
            // cmbproduct
            // 
            this.cmbproduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(258, 106);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(322, 29);
            this.cmbproduct.TabIndex = 48;
            // 
            // txtproductcode
            // 
            this.txtproductcode.BackColor = System.Drawing.Color.White;
            this.txtproductcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductcode.Location = new System.Drawing.Point(258, 147);
            this.txtproductcode.Name = "txtproductcode";
            this.txtproductcode.Size = new System.Drawing.Size(322, 28);
            this.txtproductcode.TabIndex = 47;
            // 
            // lblprodcide
            // 
            this.lblprodcide.AutoSize = true;
            this.lblprodcide.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodcide.Location = new System.Drawing.Point(24, 149);
            this.lblprodcide.Name = "lblprodcide";
            this.lblprodcide.Size = new System.Drawing.Size(129, 21);
            this.lblprodcide.TabIndex = 46;
            this.lblprodcide.Text = "Product Code";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(24, 109);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(120, 21);
            this.lblProductType.TabIndex = 45;
            this.lblProductType.Text = "Product Type";
            // 
            // txtcategoryCode
            // 
            this.txtcategoryCode.BackColor = System.Drawing.Color.White;
            this.txtcategoryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoryCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryCode.Location = new System.Drawing.Point(258, 68);
            this.txtcategoryCode.Name = "txtcategoryCode";
            this.txtcategoryCode.Size = new System.Drawing.Size(322, 28);
            this.txtcategoryCode.TabIndex = 44;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(258, 23);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(322, 29);
            this.cmbCategory.TabIndex = 43;
            // 
            // lblcatecode
            // 
            this.lblcatecode.AutoSize = true;
            this.lblcatecode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatecode.Location = new System.Drawing.Point(24, 70);
            this.lblcatecode.Name = "lblcatecode";
            this.lblcatecode.Size = new System.Drawing.Size(142, 21);
            this.lblcatecode.TabIndex = 42;
            this.lblcatecode.Text = "Category Code";
            // 
            // lblCatetype
            // 
            this.lblCatetype.AutoSize = true;
            this.lblCatetype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetype.Location = new System.Drawing.Point(24, 26);
            this.lblCatetype.Name = "lblCatetype";
            this.lblCatetype.Size = new System.Drawing.Size(132, 21);
            this.lblCatetype.TabIndex = 41;
            this.lblCatetype.Text = "Category type";
            // 
            // FrmADSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 789);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.txttotle);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbdealcus);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvbuyer);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.lblDelcusid);
            this.Controls.Add(this.cmbproduct);
            this.Controls.Add(this.txtproductcode);
            this.Controls.Add(this.lblprodcide);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.txtcategoryCode);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblcatecode);
            this.Controls.Add(this.lblCatetype);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADSales";
            this.Text = "FrmADSales";
            this.Load += new System.EventHandler(this.FrmADSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txttotle;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdealcus;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dgvbuyer;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label lblDelcusid;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.TextBox txtproductcode;
        private System.Windows.Forms.Label lblprodcide;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtcategoryCode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblcatecode;
        private System.Windows.Forms.Label lblCatetype;
    }
}