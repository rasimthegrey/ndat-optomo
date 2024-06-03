using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace OptomoMedicalDevice
{

    public partial class PatientResultsControl : UserControl
    {
        private ListView listPatientResults;
        private ColumnHeader queueNumber;
        private ColumnHeader patientID;
        private ColumnHeader patientFullName;

           public class PatientResultsList
{
public string QueueNumber { get; set; }
public string PatientID { get; set; }
public string PatientFullName { get; set; }
}

        public PatientResultsControl()
        {
            InitializeComponent();
        }
     

/*        private void PatientResultsControl_Load(object sender, EventArgs e)
        {
            // Load JSON data
            string jsonWaitingPatients = "C:\\Users\\parce\\Desktop\\ndat-optomo\\OptomoMedicalDevice\\waitingPatients.json";
            string jsonData = File.ReadAllText(jsonWaitingPatients);

            List<WaitingPatientList> items = JsonSerializer.Deserialize<List<WaitingPatientList>>(jsonData);

            foreach (var item in items)
            {
                ListViewItem listViewItem = new ListViewItem(item.QueueNumber);
                listViewItem.SubItems.Add(item.PatientID);
                listViewItem.SubItems.Add(item.PatientFullName);
                listWaitingPatients.Items.Add(listViewItem);
            }
        }
*//*
        private void listWaitingPatients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listPatientResults.SelectedItems.Count > 0)
            {
                // Get the selected item
                ListViewItem selectedItem = listWaitingPatients.SelectedItems[0];

                // Open a new form and pass the selected item's details
                Projection projectionForm = new Projection(selectedItem);
                projectionForm.Show();
            }
        }

        private void listWaitingPatients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
*/
        private void InitializeComponent()
        {
            this.listPatientResults = new System.Windows.Forms.ListView();
            this.queueNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listPatientResults
            // 
            this.listPatientResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.queueNumber,
            this.patientID,
            this.patientFullName});
            this.listPatientResults.FullRowSelect = true;
            this.listPatientResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listPatientResults.HideSelection = false;
            this.listPatientResults.Location = new System.Drawing.Point(3, 15);
            this.listPatientResults.Name = "listPatientResults";
            this.listPatientResults.Size = new System.Drawing.Size(516, 283);
            this.listPatientResults.TabIndex = 1;
            this.listPatientResults.UseCompatibleStateImageBehavior = false;
            this.listPatientResults.View = System.Windows.Forms.View.Details;
            this.listPatientResults.SelectedIndexChanged += new System.EventHandler(this.listPatientResults_SelectedIndexChanged);
            // 
            // queueNumber
            // 
            this.queueNumber.Text = "Sira No";
            // 
            // patientID
            // 
            this.patientID.Text = "T.C. Kimlik No";
            this.patientID.Width = 83;
            // 
            // patientFullName
            // 
            this.patientFullName.Text = "Ad - Soyad";
            this.patientFullName.Width = 125;
            // 
            // PatientResultsControl
            // 
            this.Controls.Add(this.listPatientResults);
            this.Name = "PatientResultsControl";
            this.Size = new System.Drawing.Size(659, 351);
            this.ResumeLayout(false);

        }

        private void listPatientResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

}
