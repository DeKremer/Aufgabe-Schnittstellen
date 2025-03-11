namespace Aufgabe_Schnittstellen
{
    partial class DisplayCsvFile
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
            this.DGVCsv = new System.Windows.Forms.DataGridView();
            this.TBCsv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openCSV = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCsv)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCsv
            // 
            this.DGVCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCsv.Location = new System.Drawing.Point(16, 110);
            this.DGVCsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVCsv.Name = "DGVCsv";
            this.DGVCsv.RowHeadersWidth = 51;
            this.DGVCsv.Size = new System.Drawing.Size(1035, 430);
            this.DGVCsv.TabIndex = 0;
            this.DGVCsv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCsv_CellContentClick);
            // 
            // TBCsv
            // 
            this.TBCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCsv.Location = new System.Drawing.Point(185, 57);
            this.TBCsv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBCsv.Name = "TBCsv";
            this.TBCsv.Size = new System.Drawing.Size(299, 30);
            this.TBCsv.TabIndex = 1;
            this.TBCsv.Text = "Dateiname";
            this.TBCsv.TextChanged += new System.EventHandler(this.TBCsv_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "CSV Dateiname";
            // 
            // openCSV
            // 
            this.openCSV.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openCSV.Location = new System.Drawing.Point(23, 57);
            this.openCSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openCSV.Name = "openCSV";
            this.openCSV.Size = new System.Drawing.Size(155, 28);
            this.openCSV.TabIndex = 3;
            this.openCSV.Text = "öffnen";
            this.openCSV.UseVisualStyleBackColor = true;
            this.openCSV.Click += new System.EventHandler(this.openCSV_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // DisplayCsvFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.openCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBCsv);
            this.Controls.Add(this.DGVCsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DisplayCsvFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayCsvFile";
            ((System.ComponentModel.ISupportInitialize)(this.DGVCsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCsv;
        private System.Windows.Forms.TextBox TBCsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openCSV;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}