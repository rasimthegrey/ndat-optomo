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
    public partial class DeviceConnectionControl : UserControl
    {
        public DeviceConnectionControl()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbConnectionType.SelectedItem != null && !string.IsNullOrWhiteSpace(txtPortNumber.Text))
            {
                MessageBox.Show("Connection successful", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbConnectionType.SelectedItem != null && string.IsNullOrWhiteSpace(txtPortNumber.Text))
            {
                MessageBox.Show("Hatali port numarasi!\nLutfen port numarasini giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbConnectionType.SelectedItem == null && !string.IsNullOrWhiteSpace(txtPortNumber.Text))
            {
                MessageBox.Show("Hatali baglanti tipi!\nLutfen baglanti tipini seciniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Baglanti tipi ve port numarasi bos olamaz!\nLutfen baglanti tipini seciniz ve port numarasini giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbConnectionType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
