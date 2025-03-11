using System;
using System.ComponentModel;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Aufgabe_Schnittstellen
{


    public partial class ConverterApp : Form
    {
        public SpeechSynthesizer synthesizer;

        public string fileContent;
        public ConverterApp()
        {
            InitializeComponent();
            bTAuswahl.Click += new EventHandler(bTAuswahl_Click);
            synthesizer = new SpeechSynthesizer();
        }

        private void bTAuswahl_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    fileContent = File.ReadAllText(filePath);
                    tBAusgabe.Text = fileContent;
                    //synthesizer.Speak(fileContent);
                    tBDateiName.Text = Path.GetFileName(filePath); // Dateiname anzeigen
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

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            
        }

       

        private void tBDateiName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCsv_Click(object sender, EventArgs e)
        {
            DisplayCsvFile displayCsvFile = new DisplayCsvFile();
            displayCsvFile.Show();

            this.Hide();
        }

        private void bTXml_Click(object sender, EventArgs e)
        {
            DisplayXmlFile displayXmlFile = new DisplayXmlFile();
            displayXmlFile.Show();

            this.Hide();
        }

        private void BtVoice_Click_1(object sender, EventArgs e)
        {
            SpeechSynthesizer _synthesizer = new SpeechSynthesizer();

            _synthesizer.SetOutputToDefaultAudioDevice();
            _synthesizer.Speak(fileContent);
        }
    }
}