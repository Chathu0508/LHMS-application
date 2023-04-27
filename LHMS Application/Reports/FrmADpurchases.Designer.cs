namespace LHMS_Application.Reports
{
    partial class FrmADpurchases
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
            this.lbllog = new System.Windows.Forms.Label();
            this.btnexport = new System.Windows.Forms.Button();
            this.dgvlogtrack = new System.Windows.Forms.DataGridView();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).BeginInit();
            this.SuspendLayout();
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(336, 25);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(220, 23);
            this.lbllog.TabIndex = 5;
            this.lbllog.Text = "Purchases Log Report";
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.Color.White;
            this.btnexport.Image = global::LHMS_Application.Properties.Resources.document__1_;
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(728, 14);
            this.btnexport.Margin = new System.Windows.Forms.Padding(4);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(229, 50);
            this.btnexport.TabIndex = 4;
            this.btnexport.Text = "Expot to Excel";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // dgvlogtrack
            // 
            this.dgvlogtrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlogtrack.BackgroundColor = System.Drawing.Color.White;
            this.dgvlogtrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogtrack.GridColor = System.Drawing.Color.Black;
            this.dgvlogtrack.Location = new System.Drawing.Point(13, 72);
            this.dgvlogtrack.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlogtrack.Name = "dgvlogtrack";
            this.dgvlogtrack.RowHeadersWidth = 51;
            this.dgvlogtrack.RowTemplate.Height = 24;
            this.dgvlogtrack.Size = new System.Drawing.Size(936, 573);
            this.dgvlogtrack.TabIndex = 3;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Image = global::LHMS_Application.Properties.Resources.document;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(13, 12);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(186, 51);
            this.btnImport.TabIndex = 21;
            this.btnImport.Text = "Import Details";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // FrmADpurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(962, 658);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dgvlogtrack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADpurchases";
            this.Text = "Purchaseing Reports";
            this.Load += new System.EventHandler(this.FrmADpurchases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllog;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.DataGridView dgvlogtrack;
        private System.Windows.Forms.Button btnImport;
    }
}