namespace LHMS_Application.EMForms
{
    partial class FrmTask
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodegn = new System.Windows.Forms.TextBox();
            this.dgvtask = new System.Windows.Forms.DataGridView();
            this.btnAddtask = new System.Windows.Forms.Button();
            this.cmbDevepartment = new System.Windows.Forms.ComboBox();
            this.cmbFactory = new System.Windows.Forms.ComboBox();
            this.lblFactory = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblDapertment = new System.Windows.Forms.Label();
            this.lbldiscription = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnCodegen = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.timmer = new System.Windows.Forms.Timer(this.components);
            this.lblmessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 21);
            this.label1.TabIndex = 81;
            this.label1.Text = "Task Code";
            // 
            // txtCodegn
            // 
            this.txtCodegn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodegn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodegn.Location = new System.Drawing.Point(214, 95);
            this.txtCodegn.Name = "txtCodegn";
            this.txtCodegn.Size = new System.Drawing.Size(334, 28);
            this.txtCodegn.TabIndex = 80;
            // 
            // dgvtask
            // 
            this.dgvtask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtask.BackgroundColor = System.Drawing.Color.White;
            this.dgvtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtask.Location = new System.Drawing.Point(648, 24);
            this.dgvtask.Name = "dgvtask";
            this.dgvtask.RowHeadersWidth = 51;
            this.dgvtask.RowTemplate.Height = 24;
            this.dgvtask.Size = new System.Drawing.Size(381, 580);
            this.dgvtask.TabIndex = 77;
            this.dgvtask.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvtask_RowHeaderMouseClick);
            // 
            // btnAddtask
            // 
            this.btnAddtask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnAddtask.FlatAppearance.BorderSize = 0;
            this.btnAddtask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddtask.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtask.ForeColor = System.Drawing.Color.White;
            this.btnAddtask.Location = new System.Drawing.Point(214, 388);
            this.btnAddtask.Name = "btnAddtask";
            this.btnAddtask.Size = new System.Drawing.Size(334, 44);
            this.btnAddtask.TabIndex = 76;
            this.btnAddtask.Text = "Create new task";
            this.btnAddtask.UseVisualStyleBackColor = false;
            this.btnAddtask.Click += new System.EventHandler(this.btnAddtask_Click);
            // 
            // cmbDevepartment
            // 
            this.cmbDevepartment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDevepartment.FormattingEnabled = true;
            this.cmbDevepartment.Items.AddRange(new object[] {
            "Engineering Design ",
            "Engineering",
            "R&D Department"});
            this.cmbDevepartment.Location = new System.Drawing.Point(214, 297);
            this.cmbDevepartment.Name = "cmbDevepartment";
            this.cmbDevepartment.Size = new System.Drawing.Size(334, 29);
            this.cmbDevepartment.TabIndex = 75;
            // 
            // cmbFactory
            // 
            this.cmbFactory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFactory.FormattingEnabled = true;
            this.cmbFactory.Items.AddRange(new object[] {
            "Fac 01",
            "Fac 02",
            "Fac 03"});
            this.cmbFactory.Location = new System.Drawing.Point(214, 253);
            this.cmbFactory.Name = "cmbFactory";
            this.cmbFactory.Size = new System.Drawing.Size(334, 29);
            this.cmbFactory.TabIndex = 74;
            // 
            // lblFactory
            // 
            this.lblFactory.AutoSize = true;
            this.lblFactory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFactory.Location = new System.Drawing.Point(35, 258);
            this.lblFactory.Name = "lblFactory";
            this.lblFactory.Size = new System.Drawing.Size(72, 21);
            this.lblFactory.TabIndex = 73;
            this.lblFactory.Text = "Factory";
            // 
            // txtDiscription
            // 
            this.txtDiscription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscription.Location = new System.Drawing.Point(214, 206);
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(334, 28);
            this.txtDiscription.TabIndex = 72;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(214, 153);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(334, 28);
            this.txtTitle.TabIndex = 71;
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(39, 36);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(509, 28);
            this.txtID.TabIndex = 70;
            // 
            // lblDapertment
            // 
            this.lblDapertment.AutoSize = true;
            this.lblDapertment.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapertment.Location = new System.Drawing.Point(35, 302);
            this.lblDapertment.Name = "lblDapertment";
            this.lblDapertment.Size = new System.Drawing.Size(113, 21);
            this.lblDapertment.TabIndex = 69;
            this.lblDapertment.Text = "Department";
            // 
            // lbldiscription
            // 
            this.lbldiscription.AutoSize = true;
            this.lbldiscription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiscription.Location = new System.Drawing.Point(35, 208);
            this.lbldiscription.Name = "lbldiscription";
            this.lbldiscription.Size = new System.Drawing.Size(103, 21);
            this.lbldiscription.TabIndex = 68;
            this.lbldiscription.Text = "Description";
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.Location = new System.Drawing.Point(35, 155);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(136, 21);
            this.lbltitle.TabIndex = 67;
            this.lbltitle.Text = "Title of the task";
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.White;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.Black;
            this.btnreset.Image = global::LHMS_Application.Properties.Resources.undo;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(416, 438);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(132, 48);
            this.btnreset.TabIndex = 83;
            this.btnreset.Text = "Reset";
            this.btnreset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnCodegen
            // 
            this.btnCodegen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnCodegen.FlatAppearance.BorderSize = 0;
            this.btnCodegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCodegen.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodegen.ForeColor = System.Drawing.Color.White;
            this.btnCodegen.Image = global::LHMS_Application.Properties.Resources.add1;
            this.btnCodegen.Location = new System.Drawing.Point(560, 89);
            this.btnCodegen.Name = "btnCodegen";
            this.btnCodegen.Size = new System.Drawing.Size(73, 44);
            this.btnCodegen.TabIndex = 82;
            this.btnCodegen.UseVisualStyleBackColor = false;
            this.btnCodegen.Click += new System.EventHandler(this.btnCodegen_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnsearch.Location = new System.Drawing.Point(560, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(73, 44);
            this.btnsearch.TabIndex = 79;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnupdate.Location = new System.Drawing.Point(214, 438);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(182, 48);
            this.btnupdate.TabIndex = 78;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpDate.CustomFormat = "DD-MM-YYYY";
            this.dtpDate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(214, 344);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(334, 28);
            this.dtpDate.TabIndex = 84;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(35, 350);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(53, 21);
            this.lbldate.TabIndex = 85;
            this.lbldate.Text = "Date";
            // 
            // timmer
            // 
            this.timmer.Enabled = true;
            this.timmer.Interval = 1000;
            this.timmer.Tick += new System.EventHandler(this.timmer_Tick);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(211, 505);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(0, 16);
            this.lblmessage.TabIndex = 86;
            // 
            // FrmTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 616);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnCodegen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodegn);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.dgvtask);
            this.Controls.Add(this.btnAddtask);
            this.Controls.Add(this.cmbDevepartment);
            this.Controls.Add(this.cmbFactory);
            this.Controls.Add(this.lblFactory);
            this.Controls.Add(this.txtDiscription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDapertment);
            this.Controls.Add(this.lbldiscription);
            this.Controls.Add(this.lbltitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTask";
            this.Text = "Task Create";
            this.Load += new System.EventHandler(this.FrmTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCodegen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodegn;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dgvtask;
        private System.Windows.Forms.Button btnAddtask;
        private System.Windows.Forms.ComboBox cmbDevepartment;
        private System.Windows.Forms.ComboBox cmbFactory;
        private System.Windows.Forms.Label lblFactory;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblDapertment;
        private System.Windows.Forms.Label lbldiscription;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer timmer;
        private System.Windows.Forms.Label lblmessage;
    }
}