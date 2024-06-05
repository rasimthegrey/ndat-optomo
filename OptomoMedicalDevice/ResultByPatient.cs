using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
                string[] imageFiles = Directory.GetFiles(folderPath, "*.png"); // Gerektiğinde filtreyi değiştirebilirsiniz
                flowLayoutPanel1.Controls.Clear();

                foreach (string imageFile in imageFiles)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = Image.FromFile(imageFile),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Height = 100, // Yüksekliği ayarlayın
                        Width = 100,  // Genişliği ayarlayın
                        Tag = imageFile // Dosya ismini Tag özelliğine atama
                    };

                    // Click olayı ekleme
                    pictureBox.Click += PictureBox_Click;

                    // DoubleClick olayı ekleme
                    pictureBox.DoubleClick += PictureBox_DoubleClick;

                    flowLayoutPanel1.Controls.Add(pictureBox);
                }
            }
            else
            {
                MessageBox.Show("Belirtilen klasör mevcut değil.");
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

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null)
            {
                // Dosya yolunu okuyarak işleme
                string imageFilePath = clickedPictureBox.Tag as string;
                if (!string.IsNullOrEmpty(imageFilePath))
                {
                    // Dosya ismini alma
                    string fileName = Path.GetFileName(imageFilePath);

                    // Dosya adını parçalara ayır
                    string[] parcalar = fileName.Split('_');
                    string baseAdi = string.Join("_", parcalar[0], parcalar[1]);

                    // Yeni dosya adını oluştur
                    string stlFileName = $"{baseAdi}_model.stl";

                    string stlFilePath = Path.Combine(Path.GetDirectoryName(imageFilePath), stlFileName);
                    var modelForm = new _3DModelForm(stlFilePath);
                    modelForm.Show();
                }
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Bu metot kullanılmıyor, kaldırabilirsiniz
        }
    }
}
