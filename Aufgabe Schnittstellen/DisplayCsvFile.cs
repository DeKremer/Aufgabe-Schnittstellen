using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe_Schnittstellen
{
    public partial class DisplayCsvFile : Form
    {

        
        public DisplayCsvFile()
        {
            InitializeComponent();
           

            
           
        }

       

        public void TBCsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void openCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select a CSV File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    TBCsv.Text = Path.GetFileName(filePath); // Dateiname anzeigen

                    DataTable dataTable = new DataTable();
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string[] headers = sr.ReadLine().Split(',');
                        foreach (string header in headers)
                        {
                            dataTable.Columns.Add(header);
                        }
                        while (!sr.EndOfStream)
                        {
                            string[] rows = sr.ReadLine().Split(',');
                            DataRow dr = dataTable.NewRow();
                            for (int i = 0; i < headers.Length; i++)
                            {
                                dr[i] = rows[i];
                            }
                            dataTable.Rows.Add(dr);
                        }
                    }
                    DGVCsv.DataSource = dataTable;
                  

                }
                catch (IOException ex)
                {
                    MessageBox.Show("Error reading file: " + ex.Message);
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Security error: " + ex.Message);
                }
  
            }
        }
    

        private void DGVCsv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
