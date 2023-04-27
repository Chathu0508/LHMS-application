namespace LHMS_Application.Froms
{
    partial class FrmKancard
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
            this.txtkencode = new System.Windows.Forms.TextBox();
            this.lblKanCode = new System.Windows.Forms.Label();
            this.lbltaskcode = new System.Windows.Forms.Label();
            this.cmbcode = new System.Windows.Forms.ComboBox();
            this.lbltaskname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblprod = new System.Windows.Forms.Label();
            this.txtRawMetID = new System.Windows.Forms.TextBox();
            this.btncreatecard = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgvinvtory = new System.Windows.Forms.DataGridView();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txttaskname = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblAvailableQty = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.dgvtask = new System.Windows.Forms.DataGridView();
            this.dgvkencard = new System.Windows.Forms.DataGridView();
            this.btnrest = new System.Windows.Forms.Button();
            this.btnkancode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbstatus = new System.Windows.Forms.ComboBox();
            this.btnmodify = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnsearchken = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvtory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkencard)).BeginInit();
            this.SuspendLayout();
            // 
            // txtkencode
            // 
            this.txtkencode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtkencode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkencode.Location = new System.Drawing.Point(223, 224);
            this.txtkencode.Name = "txtkencode";
            this.txtkencode.Size = new System.Drawing.Size(340, 28);
            this.txtkencode.TabIndex = 0;
            this.txtkencode.TextChanged += new System.EventHandler(this.txtkencode_TextChanged);
            // 
            // lblKanCode
            // 
            this.lblKanCode.AutoSize = true;
            this.lblKanCode.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKanCode.Location = new System.Drawing.Point(43, 229);
            this.lblKanCode.Name = "lblKanCode";
            this.lblKanCode.Size = new System.Drawing.Size(151, 21);
            this.lblKanCode.TabIndex = 1;
            this.lblKanCode.Text = "Kan Card code ";
            // 
            // lbltaskcode
            // 
            this.lbltaskcode.AutoSize = true;
            this.lbltaskcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskcode.Location = new System.Drawing.Point(43, 137);
            this.lbltaskcode.Name = "lbltaskcode";
            this.lbltaskcode.Size = new System.Drawing.Size(99, 21);
            this.lbltaskcode.TabIndex = 5;
            this.lbltaskcode.Text = "Task Code";
            // 
            // cmbcode
            // 
            this.cmbcode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbcode.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcode.FormattingEnabled = true;
            this.cmbcode.Location = new System.Drawing.Point(223, 128);
            this.cmbcode.Name = "cmbcode";
            this.cmbcode.Size = new System.Drawing.Size(340, 29);
            this.cmbcode.TabIndex = 6;
            this.cmbcode.SelectedIndexChanged += new System.EventHandler(this.cmbcode_SelectedIndexChanged);
            // 
            // lbltaskname
            // 
            this.lbltaskname.AutoSize = true;
            this.lbltaskname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaskname.Location = new System.Drawing.Point(43, 185);
            this.lbltaskname.Name = "lbltaskname";
            this.lbltaskname.Size = new System.Drawing.Size(82, 21);
            this.lbltaskname.TabIndex = 7;
            this.lbltaskname.Text = "Task title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Available Qty :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 21);
            this.label3.TabIndex = 23;
            this.label3.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(47, 496);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(319, 28);
            this.txtProductName.TabIndex = 22;
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(47, 400);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(131, 21);
            this.lblprod.TabIndex = 18;
            this.lblprod.Text = "Raw Metrial Id";
            // 
            // txtRawMetID
            // 
            this.txtRawMetID.BackColor = System.Drawing.Color.White;
            this.txtRawMetID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRawMetID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawMetID.Location = new System.Drawing.Point(47, 429);
            this.txtRawMetID.Name = "txtRawMetID";
            this.txtRawMetID.Size = new System.Drawing.Size(319, 28);
            this.txtRawMetID.TabIndex = 17;
            // 
            // btncreatecard
            // 
            this.btncreatecard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btncreatecard.FlatAppearance.BorderSize = 0;
            this.btncreatecard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncreatecard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatecard.ForeColor = System.Drawing.Color.White;
            this.btncreatecard.Location = new System.Drawing.Point(410, 698);
            this.btncreatecard.Name = "btncreatecard";
            this.btncreatecard.Size = new System.Drawing.Size(259, 50);
            this.btncreatecard.TabIndex = 31;
            this.btncreatecard.Text = "Create Ken card";
            this.btncreatecard.UseVisualStyleBackColor = false;
            this.btncreatecard.Click += new System.EventHandler(this.btncreatecard_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(47, 353);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(161, 37);
            this.btnsearch.TabIndex = 29;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // dgvinvtory
            // 
            this.dgvinvtory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvinvtory.BackgroundColor = System.Drawing.Color.White;
            this.dgvinvtory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvtory.Location = new System.Drawing.Point(383, 373);
            this.dgvinvtory.Name = "dgvinvtory";
            this.dgvinvtory.RowHeadersWidth = 51;
            this.dgvinvtory.RowTemplate.Height = 24;
            this.dgvinvtory.Size = new System.Drawing.Size(797, 252);
            this.dgvinvtory.TabIndex = 28;
            this.dgvinvtory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvinvtory_CellContentClick);
            this.dgvinvtory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvinvtory_RowHeaderMouseClick);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(44, 271);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(138, 21);
            this.lblsearch.TabIndex = 27;
            this.lblsearch.Text = "Search Product";
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(47, 306);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(319, 28);
            this.txtsearch.TabIndex = 26;
            // 
            // txttaskname
            // 
            this.txttaskname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttaskname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttaskname.Location = new System.Drawing.Point(223, 177);
            this.txttaskname.Name = "txttaskname";
            this.txttaskname.Size = new System.Drawing.Size(340, 28);
            this.txttaskname.TabIndex = 32;
            // 
            // txtqty
            // 
            this.txtqty.BackColor = System.Drawing.Color.White;
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(47, 620);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(319, 28);
            this.txtqty.TabIndex = 35;
            // 
            // lblAvailableQty
            // 
            this.lblAvailableQty.AutoSize = true;
            this.lblAvailableQty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQty.Location = new System.Drawing.Point(230, 547);
            this.lblAvailableQty.Name = "lblAvailableQty";
            this.lblAvailableQty.Size = new System.Drawing.Size(19, 21);
            this.lblAvailableQty.TabIndex = 25;
            this.lblAvailableQty.Text = "0";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(45, 589);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(40, 21);
            this.lblqty.TabIndex = 36;
            this.lblqty.Text = "Qty";
            // 
            // dgvtask
            // 
            this.dgvtask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtask.BackgroundColor = System.Drawing.Color.White;
            this.dgvtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtask.Location = new System.Drawing.Point(647, 58);
            this.dgvtask.Name = "dgvtask";
            this.dgvtask.RowHeadersWidth = 51;
            this.dgvtask.RowTemplate.Height = 24;
            this.dgvtask.Size = new System.Drawing.Size(533, 253);
            this.dgvtask.TabIndex = 37;
            // 
            // dgvkencard
            // 
            this.dgvkencard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvkencard.BackgroundColor = System.Drawing.Color.White;
            this.dgvkencard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkencard.Location = new System.Drawing.Point(32, 794);
            this.dgvkencard.Name = "dgvkencard";
            this.dgvkencard.RowHeadersWidth = 51;
            this.dgvkencard.RowTemplate.Height = 24;
            this.dgvkencard.Size = new System.Drawing.Size(1133, 214);
            this.dgvkencard.TabIndex = 38;
            this.dgvkencard.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvkencard_RowHeaderMouseClick);
            // 
            // btnrest
            // 
            this.btnrest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnrest.FlatAppearance.BorderSize = 0;
            this.btnrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrest.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrest.ForeColor = System.Drawing.Color.White;
            this.btnrest.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnrest.Location = new System.Drawing.Point(887, 698);
            this.btnrest.Name = "btnrest";
            this.btnrest.Size = new System.Drawing.Size(55, 50);
            this.btnrest.TabIndex = 30;
            this.btnrest.UseVisualStyleBackColor = false;
            this.btnrest.Click += new System.EventHandler(this.btnrest_Click);
            // 
            // btnkancode
            // 
            this.btnkancode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnkancode.Image = global::LHMS_Application.Properties.Resources.add1;
            this.btnkancode.Location = new System.Drawing.Point(587, 214);
            this.btnkancode.Name = "btnkancode";
            this.btnkancode.Size = new System.Drawing.Size(54, 49);
            this.btnkancode.TabIndex = 2;
            this.btnkancode.UseVisualStyleBackColor = false;
            this.btnkancode.Click += new System.EventHandler(this.btnkancode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 39;
            this.label1.Text = "Status";
            // 
            // cmbstatus
            // 
            this.cmbstatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbstatus.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbstatus.FormattingEnabled = true;
            this.cmbstatus.Items.AddRange(new object[] {
            "Pending stage",
            "Still in pending stage",
            "Task is in active stage ",
            "Task is complete "});
            this.cmbstatus.Location = new System.Drawing.Point(47, 698);
            this.cmbstatus.Name = "cmbstatus";
            this.cmbstatus.Size = new System.Drawing.Size(340, 29);
            this.cmbstatus.TabIndex = 40;
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnmodify.FlatAppearance.BorderSize = 0;
            this.btnmodify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodify.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodify.ForeColor = System.Drawing.Color.White;
            this.btnmodify.Location = new System.Drawing.Point(688, 698);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(184, 50);
            this.btnmodify.TabIndex = 41;
            this.btnmodify.Text = "Update Ken card";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(44, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 21);
            this.label10.TabIndex = 53;
            this.label10.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(223, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 28);
            this.dateTimePicker1.TabIndex = 54;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged_1);
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtid.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(51, 22);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(512, 28);
            this.txtid.TabIndex = 55;
            // 
            // btnsearchken
            // 
            this.btnsearchken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsearchken.Image = global::LHMS_Application.Properties.Resources.search1;
            this.btnsearchken.Location = new System.Drawing.Point(587, 12);
            this.btnsearchken.Name = "btnsearchken";
            this.btnsearchken.Size = new System.Drawing.Size(54, 49);
            this.btnsearchken.TabIndex = 56;
            this.btnsearchken.UseVisualStyleBackColor = false;
            this.btnsearchken.Click += new System.EventHandler(this.btnsearchken_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(647, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 57;
            this.label4.Text = "Task Table";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(379, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "Inventory Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 758);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Task Update Table";
            // 
            // FrmKancard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1192, 1020);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnsearchken);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnmodify);
            this.Controls.Add(this.cmbstatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvkencard);
            this.Controls.Add(this.dgvtask);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.txttaskname);
            this.Controls.Add(this.btncreatecard);
            this.Controls.Add(this.btnrest);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.dgvinvtory);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblAvailableQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblprod);
            this.Controls.Add(this.txtRawMetID);
            this.Controls.Add(this.lbltaskname);
            this.Controls.Add(this.cmbcode);
            this.Controls.Add(this.lbltaskcode);
            this.Controls.Add(this.btnkancode);
            this.Controls.Add(this.lblKanCode);
            this.Controls.Add(this.txtkencode);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKancard";
            this.Text = "Kancard creation";
            this.Load += new System.EventHandler(this.FrmKancard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvtory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkencard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtkencode;
        private System.Windows.Forms.Label lblKanCode;
        private System.Windows.Forms.Button btnkancode;
        private System.Windows.Forms.Label lbltaskcode;
        private System.Windows.Forms.ComboBox cmbcode;
        private System.Windows.Forms.Label lbltaskname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.TextBox txtRawMetID;
        private System.Windows.Forms.Button btncreatecard;
        private System.Windows.Forms.Button btnrest;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.DataGridView dgvinvtory;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txttaskname;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblAvailableQty;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.DataGridView dgvtask;
        private System.Windows.Forms.DataGridView dgvkencard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbstatus;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Button btnsearchken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}