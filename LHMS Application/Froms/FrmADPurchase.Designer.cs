namespace LHMS_Application.Reports
{
    partial class FrmADPurchase
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
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.txtproductcode = new System.Windows.Forms.TextBox();
            this.lblprodcide = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.txtcategoryCode = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblcatecode = new System.Windows.Forms.Label();
            this.lblCatetype = new System.Windows.Forms.Label();
            this.lblDelcusid = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.dgvbuyer = new System.Windows.Forms.DataGridView();
            this.btnadd = new System.Windows.Forms.Button();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.cmbdealcus = new System.Windows.Forms.ComboBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotle = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.tbnrate = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbproduct
            // 
            this.cmbproduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(260, 151);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(322, 29);
            this.cmbproduct.TabIndex = 18;
            this.cmbproduct.SelectedIndexChanged += new System.EventHandler(this.cmbproduct_SelectedIndexChanged);
            // 
            // txtproductcode
            // 
            this.txtproductcode.BackColor = System.Drawing.Color.White;
            this.txtproductcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtproductcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproductcode.Location = new System.Drawing.Point(260, 192);
            this.txtproductcode.Name = "txtproductcode";
            this.txtproductcode.Size = new System.Drawing.Size(322, 28);
            this.txtproductcode.TabIndex = 17;
            this.txtproductcode.TextChanged += new System.EventHandler(this.txtproductcode_TextChanged);
            // 
            // lblprodcide
            // 
            this.lblprodcide.AutoSize = true;
            this.lblprodcide.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodcide.Location = new System.Drawing.Point(26, 194);
            this.lblprodcide.Name = "lblprodcide";
            this.lblprodcide.Size = new System.Drawing.Size(129, 21);
            this.lblprodcide.TabIndex = 16;
            this.lblprodcide.Text = "Product Code";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductType.Location = new System.Drawing.Point(26, 154);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(120, 21);
            this.lblProductType.TabIndex = 15;
            this.lblProductType.Text = "Product Type";
            // 
            // txtcategoryCode
            // 
            this.txtcategoryCode.BackColor = System.Drawing.Color.White;
            this.txtcategoryCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcategoryCode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcategoryCode.Location = new System.Drawing.Point(260, 113);
            this.txtcategoryCode.Name = "txtcategoryCode";
            this.txtcategoryCode.Size = new System.Drawing.Size(322, 28);
            this.txtcategoryCode.TabIndex = 14;
            this.txtcategoryCode.TextChanged += new System.EventHandler(this.txtcategoryCode_TextChanged);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(260, 68);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(322, 29);
            this.cmbCategory.TabIndex = 13;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // lblcatecode
            // 
            this.lblcatecode.AutoSize = true;
            this.lblcatecode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcatecode.Location = new System.Drawing.Point(26, 115);
            this.lblcatecode.Name = "lblcatecode";
            this.lblcatecode.Size = new System.Drawing.Size(142, 21);
            this.lblcatecode.TabIndex = 12;
            this.lblcatecode.Text = "Category Code";
            // 
            // lblCatetype
            // 
            this.lblCatetype.AutoSize = true;
            this.lblCatetype.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetype.Location = new System.Drawing.Point(26, 71);
            this.lblCatetype.Name = "lblCatetype";
            this.lblCatetype.Size = new System.Drawing.Size(132, 21);
            this.lblCatetype.TabIndex = 11;
            this.lblCatetype.Text = "Category type";
            // 
            // lblDelcusid
            // 
            this.lblDelcusid.AutoSize = true;
            this.lblDelcusid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelcusid.Location = new System.Drawing.Point(26, 270);
            this.lblDelcusid.Name = "lblDelcusid";
            this.lblDelcusid.Size = new System.Drawing.Size(118, 21);
            this.lblDelcusid.TabIndex = 19;
            this.lblDelcusid.Text = "Dealer name";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(26, 315);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(50, 21);
            this.rate.TabIndex = 22;
            this.rate.Text = "Rate";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstatus.Location = new System.Drawing.Point(26, 379);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(174, 21);
            this.lblstatus.TabIndex = 23;
            this.lblstatus.Text = "Status of the action";
            // 
            // txtrate
            // 
            this.txtrate.BackColor = System.Drawing.Color.White;
            this.txtrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtrate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrate.Location = new System.Drawing.Point(260, 308);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(322, 28);
            this.txtrate.TabIndex = 24;
            this.txtrate.TextChanged += new System.EventHandler(this.txtrate_TextChanged);
            // 
            // dgvbuyer
            // 
            this.dgvbuyer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvbuyer.BackgroundColor = System.Drawing.Color.White;
            this.dgvbuyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuyer.Location = new System.Drawing.Point(24, 505);
            this.dgvbuyer.Name = "dgvbuyer";
            this.dgvbuyer.RowHeadersWidth = 51;
            this.dgvbuyer.RowTemplate.Height = 24;
            this.dgvbuyer.Size = new System.Drawing.Size(825, 301);
            this.dgvbuyer.TabIndex = 27;
            this.dgvbuyer.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtranaction_RowHeaderMouseClick);
            this.dgvbuyer.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtranaction_RowHeaderMouseDoubleClick);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(260, 420);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(322, 69);
            this.btnadd.TabIndex = 28;
            this.btnadd.Text = "Added Action";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cmbstatus
            // 
            this.cmbstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Pending Purchase",
            "Complete Purchase"});
            this.cmbstatus.Location = new System.Drawing.Point(260, 376);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(322, 29);
            this.cmbstatus.TabIndex = 31;
            // 
            // cmbdealcus
            // 
            this.cmbdealcus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbdealcus.FormattingEnabled = true;
            this.cmbdealcus.Items.AddRange(new object[] {
            "Sales",
            "Purchase"});
            this.cmbdealcus.Location = new System.Drawing.Point(260, 270);
            this.cmbdealcus.Name = "cmbdealcus";
            this.cmbdealcus.Size = new System.Drawing.Size(322, 29);
            this.cmbdealcus.TabIndex = 32;
            this.cmbdealcus.SelectedIndexChanged += new System.EventHandler(this.cmbdealcus_SelectedIndexChanged);
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(260, 232);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(322, 28);
            this.txtqty.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Product Qty";
            // 
            // txttotle
            // 
            this.txttotle.BackColor = System.Drawing.Color.White;
            this.txttotle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotle.Location = new System.Drawing.Point(260, 342);
            this.txttotle.Name = "txttotle";
            this.txttotle.Size = new System.Drawing.Size(322, 28);
            this.txttotle.TabIndex = 38;
            this.txttotle.TextChanged += new System.EventHandler(this.txttotle_TextChanged);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(26, 349);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(95, 21);
            this.lbltotal.TabIndex = 37;
            this.lbltotal.Text = "Total Cost";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnreset.Location = new System.Drawing.Point(715, 420);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(78, 69);
            this.btnreset.TabIndex = 40;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // tbnrate
            // 
            this.tbnrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbnrate.FlatAppearance.BorderSize = 0;
            this.tbnrate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tbnrate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnrate.ForeColor = System.Drawing.Color.White;
            this.tbnrate.Image = global::LHMS_Application.Properties.Resources.add__1_;
            this.tbnrate.Location = new System.Drawing.Point(600, 300);
            this.tbnrate.Name = "tbnrate";
            this.tbnrate.Size = new System.Drawing.Size(57, 50);
            this.tbnrate.TabIndex = 41;
            this.tbnrate.UseVisualStyleBackColor = false;
            this.tbnrate.Click += new System.EventHandler(this.tbnrate_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(600, 420);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(109, 69);
            this.btnupdate.TabIndex = 42;
            this.btnupdate.Text = "Update Action";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(30, 24);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(552, 28);
            this.txtid.TabIndex = 43;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = global::LHMS_Application.Properties.Resources.search1;
            this.btnsearch.Location = new System.Drawing.Point(600, 12);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(57, 50);
            this.btnsearch.TabIndex = 44;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // FrmADPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(865, 838);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.tbnrate);
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
            this.Name = "FrmADPurchase";
            this.Text = "Purchase and Sales";
            this.Load += new System.EventHandler(this.FrmADPurchaseandsales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuyer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.TextBox txtproductcode;
        private System.Windows.Forms.Label lblprodcide;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.TextBox txtcategoryCode;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblcatecode;
        private System.Windows.Forms.Label lblCatetype;
        private System.Windows.Forms.Label lblDelcusid;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.DataGridView dgvbuyer;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.ComboBox cmbdealcus;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotle;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button tbnrate;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsearch;
    }
}