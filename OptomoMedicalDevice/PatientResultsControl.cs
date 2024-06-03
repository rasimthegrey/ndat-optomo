using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OptomoMedicalDevice.WaitingPatientsControl;

namespace OptomoMedicalDevice
{
    public partial class PatientResultsControl : UserControl
    {
        
        public PatientResultsControl()
        {
            InitializeComponent();
        }

        private void PatientResultsControl_Load(object sender, EventArgs e)
        {
            LoadPatientResults();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadPatientResults();
        }

        private void LoadPatientResults()
        {
            listViewPatientResults.Items.Clear();
            string directoryPath = @"..\..\Hastalar";

            try
            {
                // Get the folders in the directory
                string[] folders = Directory.GetDirectories(directoryPath);

                // Add each folder name to the ListView
                foreach (string folder in folders)
                {
                    string folderName = Path.GetFileName(folder);
                    //string dirName = folderName.Replace(" ", "_");
                    ListViewItem item = new ListViewItem(folderName);

                    listViewPatientResults.Items.Add(item);


                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (e.g., directory not found)
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void listViewPatientResults_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = listViewPatientResults.SelectedItems[0];

            // Open a new form and pass the selected item's details
            ResultByPatient resultByPatientForm = new ResultByPatient(selectedItem);
            resultByPatientForm.Show();
        }



    }
}
