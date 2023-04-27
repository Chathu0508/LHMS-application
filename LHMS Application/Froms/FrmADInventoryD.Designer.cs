namespace LHMS_Application.Froms
{
    partial class FrmADInventoryD
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
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblproduct = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblproductname = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.dgvinvtory = new System.Windows.Forms.DataGridView();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnadde = new System.Windows.Forms.Button();
            this.Lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblavaqty = new System.Windows.Forms.Label();
            this.lblAvailableQty = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnsaveadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvtory)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(73, 91);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(422, 28);
            this.txtsearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(69, 57);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(67, 21);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // lblproduct
            // 
            this.lblproduct.AutoSize = true;
            this.lblproduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproduct.Location = new System.Drawing.Point(69, 138);
            this.lblproduct.Name = "lblproduct";
            this.lblproduct.Size = new System.Drawing.Size(99, 21);
            this.lblproduct.TabIndex = 3;
            this.lblproduct.Text = "Product ID";
            // 
            // txtProductId
            // 
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductId.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.Location = new System.Drawing.Point(73, 172);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(422, 28);
            this.txtProductId.TabIndex = 2;
            // 
            // lblproductname
            // 
            this.lblproductname.AutoSize = true;
            this.lblproductname.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblproductname.Location = new System.Drawing.Point(69, 217);
            this.lblproductname.Name = "lblproductname";
            this.lblproductname.Size = new System.Drawing.Size(132, 21);
            this.lblproductname.TabIndex = 5;
            this.lblproductname.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(73, 251);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(422, 28);
            this.txtProductName.TabIndex = 4;
            // 
            // dgvinvtory
            // 
            this.dgvinvtory.BackgroundColor = System.Drawing.Color.White;
            this.dgvinvtory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinvtory.Location = new System.Drawing.Point(73, 460);
            this.dgvinvtory.Name = "dgvinvtory";
            this.dgvinvtory.RowHeadersWidth = 51;
            this.dgvinvtory.RowTemplate.Height = 24;
            this.dgvinvtory.Size = new System.Drawing.Size(986, 214);
            this.dgvinvtory.TabIndex = 8;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Image = global::LHMS_Application.Properties.Resources.refresh1;
            this.btnreset.Location = new System.Drawing.Point(623, 78);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(75, 54);
            this.btnreset.TabIndex = 7;
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsearch.FlatAppearance.BorderSize = 0;
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Image = global::LHMS_Application.Properties.Resources.search1;
            this.btnsearch.Location = new System.Drawing.Point(523, 78);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 54);
            this.btnsearch.TabIndex = 6;
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btnadde
            // 
            this.btnadde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnadde.FlatAppearance.BorderSize = 0;
            this.btnadde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadde.Image = global::LHMS_Application.Properties.Resources.add1;
            this.btnadde.Location = new System.Drawing.Point(523, 159);
            this.btnadde.Name = "btnadde";
            this.btnadde.Size = new System.Drawing.Size(75, 54);
            this.btnadde.TabIndex = 9;
            this.btnadde.UseVisualStyleBackColor = false;
            this.btnadde.Click += new System.EventHandler(this.btnadde_Click);
            // 
            // Lblqty
            // 
            this.Lblqty.AutoSize = true;
            this.Lblqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblqty.Location = new System.Drawing.Point(69, 361);
            this.Lblqty.Name = "Lblqty";
            this.Lblqty.Size = new System.Drawing.Size(132, 21);
            this.Lblqty.TabIndex = 11;
            this.Lblqty.Text = "Product Name";
            // 
            // txtqty
            // 
            this.txtqty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(73, 395);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(422, 28);
            this.txtqty.TabIndex = 10;
            // 
            // lblavaqty
            // 
            this.lblavaqty.AutoSize = true;
            this.lblavaqty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavaqty.Location = new System.Drawing.Point(69, 305);
            this.lblavaqty.Name = "lblavaqty";
            this.lblavaqty.Size = new System.Drawing.Size(137, 21);
            this.lblavaqty.TabIndex = 12;
            this.lblavaqty.Text = "Avaiable Qty : ";
            // 
            // lblAvailableQty
            // 
            this.lblAvailableQty.AutoSize = true;
            this.lblAvailableQty.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableQty.Location = new System.Drawing.Point(231, 305);
            this.lblAvailableQty.Name = "lblAvailableQty";
            this.lblAvailableQty.Size = new System.Drawing.Size(15, 21);
            this.lblAvailableQty.TabIndex = 13;
            this.lblAvailableQty.Text = " ";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnadd.FlatAppearance.BorderSize = 0;
            this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Location = new System.Drawing.Point(523, 380);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(186, 54);
            this.btnadd.TabIndex = 14;
            this.btnadd.Text = "Transfer Stock";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnsaveadd
            // 
            this.btnsaveadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnsaveadd.FlatAppearance.BorderSize = 0;
            this.btnsaveadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsaveadd.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsaveadd.ForeColor = System.Drawing.Color.White;
            this.btnsaveadd.Location = new System.Drawing.Point(727, 380);
            this.btnsaveadd.Name = "btnsaveadd";
            this.btnsaveadd.Size = new System.Drawing.Size(186, 54);
            this.btnsaveadd.TabIndex = 15;
            this.btnsaveadd.Text = "Save Stock";
            this.btnsaveadd.UseVisualStyleBackColor = false;
            this.btnsaveadd.Click += new System.EventHandler(this.btnsaveadd_Click);
            // 
            // FrmADInventoryD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1122, 704);
            this.Controls.Add(this.btnsaveadd);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblAvailableQty);
            this.Controls.Add(this.lblavaqty);
            this.Controls.Add(this.Lblqty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.btnadde);
            this.Controls.Add(this.dgvinvtory);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lblproductname);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblproduct);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADInventoryD";
            this.Text = "FrmADInventoryD";
            this.Load += new System.EventHandler(this.FrmADInventoryD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinvtory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblproduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblproductname;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView dgvinvtory;
        private System.Windows.Forms.Button btnadde;
        private System.Windows.Forms.Label Lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblavaqty;
        private System.Windows.Forms.Label lblAvailableQty;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnsaveadd;
    }
}