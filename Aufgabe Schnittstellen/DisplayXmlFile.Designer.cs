namespace Aufgabe_Schnittstellen
{
    partial class DisplayXmlFile
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
            this.dGVXml = new System.Windows.Forms.DataGridView();
            this.openXML = new System.Windows.Forms.Button();
            this.TBxml = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGVXml)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVXml
            // 
            this.dGVXml.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dGVXml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVXml.Location = new System.Drawing.Point(16, 79);
            this.dGVXml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVXml.Name = "dGVXml";
            this.dGVXml.RowHeadersWidth = 51;
            this.dGVXml.Size = new System.Drawing.Size(1035, 460);
            this.dGVXml.TabIndex = 0;
            this.dGVXml.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVXml_CellContentClick);
            // 
            // openXML
            // 
            this.openXML.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openXML.Location = new System.Drawing.Point(16, 43);
            this.openXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.openXML.Name = "openXML";
            this.openXML.Size = new System.Drawing.Size(155, 28);
            this.openXML.TabIndex = 4;
            this.openXML.Text = "öffnen";
            this.openXML.UseVisualStyleBackColor = true;
            this.openXML.Click += new System.EventHandler(this.openXML_Click);
            // 
            // TBxml
            // 
            this.TBxml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBxml.Location = new System.Drawing.Point(179, 43);
            this.TBxml.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBxml.Name = "TBxml";
            this.TBxml.Size = new System.Drawing.Size(299, 30);
            this.TBxml.TabIndex = 5;
            this.TBxml.Text = "Dateiname";
            this.TBxml.TextChanged += new System.EventHandler(this.TBxml_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xml Dateiname";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // DisplayXmlFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBxml);
            this.Controls.Add(this.openXML);
            this.Controls.Add(this.dGVXml);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DisplayXmlFile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayXmlFile";
            ((System.ComponentModel.ISupportInitialize)(this.dGVXml)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVXml;
        private System.Windows.Forms.Button openXML;
        private System.Windows.Forms.TextBox TBxml;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}