using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptomoMedicalDevice
{
    public partial class AngularTestControl : UserControl
    {
        public AngularTestControl()
        {
            InitializeComponent();
        }

        private void btnAngularScanTestStart_Click(object sender, EventArgs e)
        {
            decimal inputScanningAnlge = numScanningAngle.Value;
            decimal inputShotCount = numShotCount.Value;

            string msg = $"Tarama Acisi: {inputScanningAnlge}\nAtis Sayisi: {inputShotCount}";

            MessageBox.Show(msg, "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lblAngularScanningTest_Click(object sender, EventArgs e)
        {

        }

        private void lblScanningAngle_Click(object sender, EventArgs e)
        {

        }

        private void numScanningAngle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
