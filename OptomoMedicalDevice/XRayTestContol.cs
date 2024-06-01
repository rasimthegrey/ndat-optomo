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
    public partial class XRayTestContol : UserControl
    {
        public XRayTestContol()
        {
            InitializeComponent();
        }

        private void btnXrayTestStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("X-RAY Tesi Basarili", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
