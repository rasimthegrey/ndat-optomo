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
    public partial class VerticalMovementTestControl : UserControl
    {
        public VerticalMovementTestControl()
        {
            InitializeComponent();
        }

        private void btnVerticalMovementTestStart_Click(object sender, EventArgs e)
        {
            decimal movementDistance = numMovementDistance.Value;
            if (cmbDirection.SelectedItem != null && movementDistance >= 1)
            {
                MessageBox.Show("Yatay Hareket Testi Basarili", "BASARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbDirection.SelectedItem == null && movementDistance >= 1)
            {
                MessageBox.Show("Lutfen hareket yonu seciniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmbDirection.SelectedItem != null && movementDistance == 0)
            {
                MessageBox.Show("Lutfen hareket mesafesi giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Lutfen hareket yonu seciniz ve hareket mesafesini giriniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
            
        }

        private void numScanningAngle_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblScanningAngle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDirection_Click(object sender, EventArgs e)
        {

        }

        private void cmbDirection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMovementDistance_Click(object sender, EventArgs e)
        {

        }

        private void numMovementDistance_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
