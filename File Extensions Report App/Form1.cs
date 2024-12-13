using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Extensions_Report_App
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> fileTypes = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();
            export_path_button.Enabled = false;
            start_button.Enabled = false;
        }

        //select the suorce path and print it on video
        private void suorce_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                suorce_textbox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                start_button.Enabled = true;
                
            }
        }

        //select the file export path and print it on video
        private void export_path_button_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;

            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                export_path_textbox.Text = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
                

            }
        }

        //start the analyzing process
        private void start_button_Click(object sender, EventArgs e)
        {

            status_textbox.Text = "Running...";

                        string suorcePath = suorce_textbox.Text;
            

            string[] fileList = Directory.GetFiles(suorcePath);

            if (fileList.Length == 0)
            {
                No_File_Modal();
            }

            foreach (string file in fileList)
            {
                string extension = Path.GetExtension(file);

                if (fileTypes.ContainsKey(extension))
                {
                    fileTypes[extension]++;
                }

                else
                {
                    fileTypes.Add(extension, +1);
                }
            }

          if (allow_export_checkbox.Checked == true)
            {
                Generate_File(fileTypes);
            }

            status_textbox.Text = "Done.";

            Print_Results(fileTypes);
        }

        //if activated generate a report file
        private void Generate_File(Dictionary<string, int> fileTypes)
        {
            string destinatioPath = export_path_textbox.Text;

            string reportFile = Path.Combine(destinatioPath, "Lista Estensioni.csv");

            if (File.Exists(reportFile))
            {
                File.Delete(reportFile);
            }

            File.Create(reportFile).Dispose();

            string appendTitle = "Estensione, Conteggio" + Environment.NewLine;
            File.WriteAllText(reportFile, appendTitle);

            foreach (var extension in fileTypes)
            {
                File.AppendAllText(reportFile, extension.Key + ", " + extension.Value + Environment.NewLine);
            }

            //Show_Results(Dictionary<string, int> fileTypes);
            
        }

        //print results on a table
        private void Print_Results(Dictionary<string, int> fileTypes)
        {
            results_table.Columns[1].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            foreach (var extension in fileTypes)
            {
                results_table.Rows.Add(new object[] {extension.Key, extension.Value });
            }
        }


        //generate a modal if the folder is empty
        private void No_File_Modal()
        {
            Form noFileModal = new Form();

            MessageBox.Show("Non ci sono file nella cartella.");

            noFileModal.Dispose();
            
        }

        //activate the export path select button
        private void allow_export_checkbox_MouseClick(object sender, MouseEventArgs e)
        {

            if (allow_export_checkbox.Checked)
            {
                export_path_button.Enabled = true;
                export_path_textbox.Enabled = true;
            }
            else
            {
                export_path_button.Enabled = false;
                export_path_textbox.Enabled = false;
            }
        }


    }
}
