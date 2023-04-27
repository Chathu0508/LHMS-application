namespace LHMS_Application.Froms
{
    partial class FrmADUserReports
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
            this.btnexport = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.dgvdealcus = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdealcus)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.Color.White;
            this.btnexport.Location = new System.Drawing.Point(57, 90);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(214, 56);
            this.btnexport.TabIndex = 1;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Black;
            this.lbluser.Location = new System.Drawing.Point(53, 30);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(111, 21);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "User Detials ";
            // 
            // dgvdealcus
            // 
            this.dgvdealcus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdealcus.Location = new System.Drawing.Point(57, 169);
            this.dgvdealcus.Name = "dgvdealcus";
            this.dgvdealcus.RowHeadersWidth = 51;
            this.dgvdealcus.RowTemplate.Height = 24;
            this.dgvdealcus.Size = new System.Drawing.Size(1046, 475);
            this.dgvdealcus.TabIndex = 4;
            // 
            // FrmADUserReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1155, 728);
            this.Controls.Add(this.dgvdealcus);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnexport);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmADUserReports";
            this.Text = "FrmADUserReports";
            this.Load += new System.EventHandler(this.FrmADUserReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdealcus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.DataGridView dgvdealcus;
    }
}