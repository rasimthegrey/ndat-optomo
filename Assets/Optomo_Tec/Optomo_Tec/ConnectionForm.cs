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
    public partial class ConnectionForm : Form
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connectionSelect.SelectedItem != null && !string.IsNullOrEmpty(portText.Text))
            {
                MessageBox.Show("Connection successful", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(connectionSelect.SelectedItem != null && string.IsNullOrEmpty(portText.Text))
            {
                MessageBox.Show("Hatali port numarasi!\nLutfen port numarasini giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(connectionSelect.SelectedItem ==null && !string.IsNullOrEmpty(portText.Text))
            {
                MessageBox.Show("Hatali baglanti tipi!\nLutfen baglanti tipini seciniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Baglanti tipi ve port numarasi bos olamaz!\nLutfen baglanti tipini seciniz ve port numarasini giriniz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
