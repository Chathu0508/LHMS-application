namespace LHMS_Application.Reports
{
    partial class FrmADLogTrack
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
            this.dgvlogtrack = new System.Windows.Forms.DataGridView();
            this.btnexport = new System.Windows.Forms.Button();
            this.lbllog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvlogtrack
            // 
            this.dgvlogtrack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvlogtrack.BackgroundColor = System.Drawing.Color.White;
            this.dgvlogtrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlogtrack.GridColor = System.Drawing.Color.Black;
            this.dgvlogtrack.Location = new System.Drawing.Point(31, 98);
            this.dgvlogtrack.Margin = new System.Windows.Forms.Padding(4);
            this.dgvlogtrack.Name = "dgvlogtrack";
            this.dgvlogtrack.RowHeadersWidth = 51;
            this.dgvlogtrack.RowTemplate.Height = 24;
            this.dgvlogtrack.Size = new System.Drawing.Size(944, 573);
            this.dgvlogtrack.TabIndex = 0;
            this.dgvlogtrack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlogtrack_CellContentClick);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnexport.FlatAppearance.BorderSize = 0;
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.ForeColor = System.Drawing.Color.White;
            this.btnexport.Image = global::LHMS_Application.Properties.Resources.document__1_;
            this.btnexport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexport.Location = new System.Drawing.Point(792, 40);
            this.btnexport.Margin = new System.Windows.Forms.Padding(4);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(183, 50);
            this.btnexport.TabIndex = 1;
            this.btnexport.Text = "Expot to Excel";
            this.btnexport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(27, 53);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(203, 23);
            this.lbllog.TabIndex = 2;
            this.lbllog.Text = "Login Status Reports";
            // 
            // FrmADLogTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 684);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.btnexport);
            this.Controls.Add(this.dgvlogtrack);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmADLogTrack";
            this.Text = "User Loging Report ";
            this.Load += new System.EventHandler(this.FrmLogTrack_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlogtrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvlogtrack;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Label lbllog;
    }
}