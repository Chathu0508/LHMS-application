namespace LHMS_Application.Reports
{
    partial class FrmADCategoryCode
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
            this.dgvcategoryCode = new System.Windows.Forms.DataGridView();
            this.lblProdcode = new System.Windows.Forms.Label();
            this.lblprodname = new System.Windows.Forms.Label();
            this.txtcetagroycode = new System.Windows.Forms.TextBox();
            this.btnAddPCD = new System.Windows.Forms.Button();
            this.cmbCategorypdc = new System.Windows.Forms.ComboBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblid = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoryCode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcategoryCode
            // 
            this.dgvcategoryCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcategoryCode.BackgroundColor = System.Drawing.Color.White;
            this.dgvcategoryCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcategoryCode.Location = new System.Drawing.Point(24, 281);
            this.dgvcategoryCode.Name = "dgvcategoryCode";
            this.dgvcategoryCode.RowHeadersWidth = 51;
            this.dgvcategoryCode.RowTemplate.Height = 24;
            this.dgvcategoryCode.Size = new System.Drawing.Size(583, 423);
            this.dgvcategoryCode.TabIndex = 0;
            // 
            // lblProdcode
            // 
            this.lblProdcode.AutoSize = true;
            this.lblProdcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdcode.Location = new System.Drawing.Point(24, 149);
            this.lblProdcode.Name = "lblProdcode";
            this.lblProdcode.Size = new System.Drawing.Size(142, 21);
            this.lblProdcode.TabIndex = 3;
            this.lblProdcode.Text = "Category Code";
            // 
            // lblprodname
            // 
            this.lblprodname.AutoSize = true;
            this.lblprodname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprodname.Location = new System.Drawing.Point(24, 205);
            this.lblprodname.Name = "lblprodname";
            this.lblprodname.Size = new System.Drawing.Size(145, 21);
            this.lblprodname.TabIndex = 4;
            this.lblprodname.Text = "Category Name";
            // 
            // txtcetagroycode
            // 
            this.txtcetagroycode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcetagroycode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcetagroycode.Location = new System.Drawing.Point(221, 145);
            this.txtcetagroycode.Name = "txtcetagroycode";
            this.txtcetagroycode.Size = new System.Drawing.Size(216, 28);
            this.txtcetagroycode.TabIndex = 5;
            this.txtcetagroycode.TextChanged += new System.EventHandler(this.txtcetagroycode_TextChanged);
            // 
            // btnAddPCD
            // 
            this.btnAddPCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddPCD.FlatAppearance.BorderSize = 0;
            this.btnAddPCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPCD.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPCD.ForeColor = System.Drawing.Color.White;
            this.btnAddPCD.Location = new System.Drawing.Point(468, 194);
            this.btnAddPCD.Name = "btnAddPCD";
            this.btnAddPCD.Size = new System.Drawing.Size(65, 42);
            this.btnAddPCD.TabIndex = 7;
            this.btnAddPCD.Text = "Save";
            this.btnAddPCD.UseVisualStyleBackColor = false;
            this.btnAddPCD.Click += new System.EventHandler(this.btnAddPCD_Click);
            // 
            // cmbCategorypdc
            // 
            this.cmbCategorypdc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorypdc.FormattingEnabled = true;
            this.cmbCategorypdc.Location = new System.Drawing.Point(220, 201);
            this.cmbCategorypdc.Name = "cmbCategorypdc";
            this.cmbCategorypdc.Size = new System.Drawing.Size(217, 29);
            this.cmbCategorypdc.TabIndex = 8;
            this.cmbCategorypdc.Text = "-- Select the category --";
            this.cmbCategorypdc.SelectedIndexChanged += new System.EventHandler(this.cmbCategorypdc_SelectedIndexChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackgroundImage = global::LHMS_Application.Properties.Resources.add;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Location = new System.Drawing.Point(468, 133);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(54, 52);
            this.btnadd.TabIndex = 1;
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(220, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(216, 28);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(24, 84);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(164, 21);
            this.lblid.TabIndex = 10;
            this.lblid.Text = "Category Code Id";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::LHMS_Application.Properties.Resources.close__1_1;
            this.button2.Location = new System.Drawing.Point(571, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 45);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 49);
            this.panel1.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Category Code";
            // 
            // FrmADCategoryCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.cmbCategorypdc);
            this.Controls.Add(this.btnAddPCD);
            this.Controls.Add(this.txtcetagroycode);
            this.Controls.Add(this.lblprodname);
            this.Controls.Add(this.lblProdcode);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dgvcategoryCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADCategoryCode";
            this.Text = "Category Code";
            this.Load += new System.EventHandler(this.FrmproductCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcategoryCode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvcategoryCode;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblProdcode;
        private System.Windows.Forms.Label lblprodname;
        private System.Windows.Forms.TextBox txtcetagroycode;
        private System.Windows.Forms.Button btnAddPCD;
        private System.Windows.Forms.ComboBox cmbCategorypdc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}