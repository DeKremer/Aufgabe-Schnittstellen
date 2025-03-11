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
    public partial class DisplayXmlFile : Form
    {
        public DisplayXmlFile()
        {
            InitializeComponent();
        }

        private void openXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select a CSV File";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    TBxml.Text = Path.GetFileName(filePath); // Dateiname anzeigen
                    DataSet dataSet = new DataSet();
                    dataSet.ReadXml(filePath);
                    dGVXml.DataSource = dataSet.Tables[0];
  
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
            

        private void TBxml_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVXml_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
