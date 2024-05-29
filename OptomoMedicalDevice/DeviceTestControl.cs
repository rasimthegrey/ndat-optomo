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
    public partial class DeviceTestControl : UserControl
    {
        public DeviceTestControl()
        {
            InitializeComponent();
        }

        private void btnXrayTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X-RAY Testi Basarili", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
