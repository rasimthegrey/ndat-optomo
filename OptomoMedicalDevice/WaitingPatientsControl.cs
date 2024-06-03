using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace OptomoMedicalDevice
{

    public partial class WaitingPatientsControl : UserControl
    {
        public class WaitingPatientList
        {
            public string QueueNumber { get; set; }
            public string PatientID { get; set; }
            public string PatientFullName { get; set; }
        }
        public WaitingPatientsControl()
        {
            InitializeComponent();
        }

        private void WaitingPatientsControl_Load(object sender, EventArgs e)
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


        private void listWaitingPatients_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listWaitingPatients.SelectedItems.Count > 0)
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
    }
}
