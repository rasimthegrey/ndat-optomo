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
    public partial class LidCoverControl : UserControl
    {
        public LidCoverControl()
        {
            InitializeComponent();
        }

        

        private void btnLidControlStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kapak Acik", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
