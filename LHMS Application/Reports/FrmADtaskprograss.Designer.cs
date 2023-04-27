namespace LHMS_Application.Reports
{
    partial class FrmADtaskprograss
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
            this.Dgvtaskprogress = new System.Windows.Forms.DataGridView();
            this.btnexport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblSerach = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtaskprogress)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvtaskprogress
            // 
            this.Dgvtaskprogress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgvtaskprogress.BackgroundColor = System.Drawing.Color.White;
            this.Dgvtaskprogress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvtaskprogress.Location = new System.Drawing.Point(28, 107);
            this.Dgvtaskprogress.Name = "Dgvtaskprogress";
            this.Dgvtaskprogress.RowHeadersWidth = 51;
            this.Dgvtaskprogress.RowTemplate.Height = 24;
            this.Dgvtaskprogress.Size = new System.Drawing.Size(956, 512);
            this.Dgvtaskprogress.TabIndex = 0;
            // 
            // btnexport
            // 
            this.btnexport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.Color.White;
            this.btnexport.Image = global::LHMS_Application.Properties.Resources.document__1_;
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(769, 48);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(215, 51);
            this.btnexport.TabIndex = 3;
            this.btnexport.Text = "Export to Excel";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.White;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.Black;
            this.btnImport.Image = global::LHMS_Application.Properties.Resources.document;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(28, 48);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(186, 51);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "Import Details";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblSerach
            // 
            this.lblSerach.AutoSize = true;
            this.lblSerach.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerach.Location = new System.Drawing.Point(401, 63);
            this.lblSerach.Name = "lblSerach";
            this.lblSerach.Size = new System.Drawing.Size(186, 21);
            this.lblSerach.TabIndex = 21;
            this.lblSerach.Text = "Task Prograss Report";
            // 
            // FrmADtaskprograss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 642);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblSerach);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.Dgvtaskprogress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADtaskprograss";
            this.Text = "Task Prograss Report";
            this.Load += new System.EventHandler(this.Frmtaskprograss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvtaskprogress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgvtaskprogress;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblSerach;
    }
}