using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optomo_Tec
{
    public partial class waitPatientForm : Form
    {
        public waitPatientForm()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void waitPatient_Load(object sender, EventArgs e)
        {
            string[] patient1 = { "1", "Onur Cura", "22222222222","09.07.1999" };
            string[] patient2 = { "2", "Rasim Mutlu", "11111111111", "01.01.1999" };
            string[] patient3 = { "3", "Ayberk Kahraman", "00000000000", "02.02.1998" };
            string[] patient4 = { "4", "Cihan Par", "55555555555","03.03.1997" };

            ListViewItem kayit1 = new ListViewItem(patient1);
            ListViewItem kayit2 = new ListViewItem(patient2);
            ListViewItem kayit3 = new ListViewItem(patient3);
            ListViewItem kayit4 =new ListViewItem(patient4);

             patientView.Items.Add(kayit1);
            patientView.Items.Add(kayit2);
            patientView.Items.Add (kayit3);
            patientView.Items.Add(kayit4);

            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
