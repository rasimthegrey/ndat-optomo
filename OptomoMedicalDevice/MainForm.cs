using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace OptomoMedicalDevice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabWaitingPatients_Click(object sender, EventArgs e)
        {

        }

        private void deviceConnectionControl1_Load(object sender, EventArgs e)
        {

        }

        private void tabDeviceConncetion_Click(object sender, EventArgs e)
        {

        }

        private void waitingPatientsControl1_Load(object sender, EventArgs e)
        {

        }

        

        private void deviceTestControl1_Load(object sender, EventArgs e)
        {

        }

        private void tabPatientResults_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
