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
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(moveText.Text))
            {
            movePicture.Visible = true;
            moveLabel.Visible = true;

            }
        }

        private void xrayTestButton_Click(object sender, EventArgs e)
        {
            xrayLabel.Visible = true;
            xrayPicture.Visible = true;
        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void scanTestButton_Click(object sender, EventArgs e)
        {
            

            if(!string.IsNullOrEmpty(scanangel.Text) && !string.IsNullOrEmpty(proNumber.Text))
            {
                scanPicture.Visible = true;
                scanLabel.Visible = true;
            }
            else
            {
                MessageBox.Show("Tarama açısını ve Atış Sayısını Tekrar Giriniz", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
