namespace Aufgabe_Schnittstellen
{
    partial class ConverterApp
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterApp));
            this.tBDateiName = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.tBAusgabe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bTAuswahl = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btCsv = new System.Windows.Forms.Button();
            this.bTXml = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBDateiName
            // 
            this.tBDateiName.Location = new System.Drawing.Point(16, 47);
            this.tBDateiName.Margin = new System.Windows.Forms.Padding(4);
            this.tBDateiName.Name = "tBDateiName";
            this.tBDateiName.Size = new System.Drawing.Size(406, 27);
            this.tBDateiName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datei Auswahl";
            // 
            // tBAusgabe
            // 
            this.tBAusgabe.Location = new System.Drawing.Point(16, 170);
            this.tBAusgabe.Margin = new System.Windows.Forms.Padding(4);
            this.tBAusgabe.Multiline = true;
            this.tBAusgabe.Name = "tBAusgabe";
            this.tBAusgabe.ReadOnly = true;
            this.tBAusgabe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBAusgabe.Size = new System.Drawing.Size(1019, 371);
            this.tBAusgabe.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text Ausgabe";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(988, 118);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 43);
            this.button2.TabIndex = 5;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bTAuswahl
            // 
            this.bTAuswahl.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTAuswahl.Location = new System.Drawing.Point(16, 82);
            this.bTAuswahl.Margin = new System.Windows.Forms.Padding(4);
            this.bTAuswahl.Name = "bTAuswahl";
            this.bTAuswahl.Size = new System.Drawing.Size(176, 28);
            this.bTAuswahl.TabIndex = 1;
            this.bTAuswahl.Text = "Text Datei";
            this.bTAuswahl.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // btCsv
            // 
            this.btCsv.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCsv.Location = new System.Drawing.Point(200, 82);
            this.btCsv.Margin = new System.Windows.Forms.Padding(4);
            this.btCsv.Name = "btCsv";
            this.btCsv.Size = new System.Drawing.Size(176, 28);
            this.btCsv.TabIndex = 6;
            this.btCsv.Text = "CSV Datei";
            this.btCsv.UseVisualStyleBackColor = true;
            this.btCsv.Click += new System.EventHandler(this.btCsv_Click);
            // 
            // bTXml
            // 
            this.bTXml.Font = new System.Drawing.Font("Wide Latin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTXml.Location = new System.Drawing.Point(384, 82);
            this.bTXml.Margin = new System.Windows.Forms.Padding(4);
            this.bTXml.Name = "bTXml";
            this.bTXml.Size = new System.Drawing.Size(176, 28);
            this.bTXml.TabIndex = 7;
            this.bTXml.Text = "XML Datei";
            this.bTXml.UseVisualStyleBackColor = true;
            this.bTXml.Click += new System.EventHandler(this.bTXml_Click);
            // 
            // ConverterApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.bTXml);
            this.Controls.Add(this.btCsv);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBAusgabe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTAuswahl);
            this.Controls.Add(this.tBDateiName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "ConverterApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tBDateiName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAusgabe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bTAuswahl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btCsv;
        private System.Windows.Forms.Button bTXml;
    }
}

