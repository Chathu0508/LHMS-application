namespace LHMS_Application.Reports
{
    partial class SampleTestUI
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
            this.dgvtask = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtask
            // 
            this.dgvtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtask.Location = new System.Drawing.Point(12, 12);
            this.dgvtask.Name = "dgvtask";
            this.dgvtask.RowHeadersWidth = 51;
            this.dgvtask.RowTemplate.Height = 24;
            this.dgvtask.Size = new System.Drawing.Size(1019, 535);
            this.dgvtask.TabIndex = 0;
            // 
            // SampleTestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 632);
            this.Controls.Add(this.dgvtask);
            this.Name = "SampleTestUI";
            this.Text = "SampleTestUI";
            this.Load += new System.EventHandler(this.SampleTestUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtask)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvtask;
    }
}