using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptomoMedicalDevice
{
    public partial class ResultByPatient : Form
    {
        public string patientName;
        public ResultByPatient(ListViewItem selectedItem)
        {
            InitializeComponent();
            this.Load += new EventHandler(ResultByPatient_Load);
            patientName = selectedItem.Text;
            lblPatientName.Text = "Ad Soyad: " + patientName;
        }

        private void ResultByPatient_Load(object sender, EventArgs e)
        {
            string folderPath = "../../Hastalar/" + patientName;
            if (Directory.Exists(folderPath))
            {
                string[] imageFiles = Directory.GetFiles(folderPath, "*.png"); // You can change the filter if needed
                flowLayoutPanel1.Controls.Clear();

                foreach (string imageFile in imageFiles)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(imageFile);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Height = 100; // Adjust height
                    pictureBox.Width = 100;  // Adjust width
                    pictureBox.Click += PictureBox_Click;

                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
            else
            {
                MessageBox.Show("The specified folder does not exist.");
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                pictureBox1.Image = clickedPictureBox.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                pictureBox1.Image = clickedPictureBox.Image;
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
