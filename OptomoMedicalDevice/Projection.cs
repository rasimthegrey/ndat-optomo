using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace OptomoMedicalDevice
{
    public partial class Projection : Form
    {
        private Timer timer;
        private List<string> imageFiles;
        private int currentImageIndex = 0;
        public string isim;

        public Projection(ListViewItem selectedItem)
        {
            InitializeComponent();
            isim = selectedItem.SubItems[2].Text;
            // Display the selected item's details
            lblPatientID.Text = "T.C. Kimlik No : " + selectedItem.SubItems[1].Text;
            lblPatientFullName.Text = "Ad Soyad       : " + selectedItem.SubItems[2].Text;

            // Buton Click olaylarını ayarlayın
            btnCekimBaslat.Click += new EventHandler(btnCekimBaslat_Click);
            btnCekimBitir.Click += new EventHandler(btnCekimBitir_Click);

            // Timer'ı oluşturun ve ayarlayın
            timer = new Timer();
            timer.Interval = 500; // 0.5 saniye
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void btnCekimBaslat_Click(object sender, EventArgs e)
        {
            // Görsellerin bulunduğu dizin
            string imageDirectory = @"C:\Users\parce\Desktop\ndat-optomo\xrayhavuz";

            // Görsellerin dosya yollarını al
            imageFiles = new List<string>(Directory.GetFiles(imageDirectory, "*.PNG"));

            // Görsellerin bulunduğundan emin olun
            if (imageFiles.Count > 0)
            {
                currentImageIndex = 0;
                timer.Start(); // Timer'ı başlatın
            }
            else
            {
                MessageBox.Show("Görsel bulunamadı.");
            }
        }

        private void btnCekimBitir_Click(object sender, EventArgs e)
        {
            // Hedef klasör yolu
            string targetDirectory = @"C:\Users\parce\Desktop\ndat-optomo\Hastalar\";

            // Hasta adını alın ve boşlukları alt çizgiyle değiştirin
            string patientName = isim.Replace(" ", "_");

            // Hasta adıyla bir klasör oluşturun (eğer yoksa)
            string patientDirectory = Path.Combine(targetDirectory, patientName);
            if (!Directory.Exists(patientDirectory))
            {
                Directory.CreateDirectory(patientDirectory);
            }

            // Her bir PictureBox için
            foreach (Control control in panelgör.Controls)
            {
                if (control is PictureBox)
                {
                    // PictureBox'ın Image'ını alın
                    Image image = ((PictureBox)control).Image;

                    // Dosya adını ve sıra numarasını ekleyerek dosya yolu oluşturun
                    string fileName = patientName + "_" + currentImageIndex.ToString("D4") + ".png";
                    string filePath = Path.Combine(patientDirectory, fileName);

                    // Eğer dosya zaten varsa, yeni bir isimle kaydedin
                    int counter = 1;
                    while (File.Exists(filePath))
                    {
                        fileName = patientName + "_" + currentImageIndex.ToString("D4") + "_" + counter.ToString() + ".png";
                        filePath = Path.Combine(patientDirectory, fileName);
                        counter++;
                    }

                    // Görseli PNG formatında kaydedin
                    image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

                    currentImageIndex++;
                }
            }

            // Pencereyi kapat
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imageFiles.Count)
            {
                // Görseli panel'e ekleyin
                AddImageToPanel(imageFiles[currentImageIndex]);
                currentImageIndex++;

                // Eğer tüm görseller eklendiyse timer'ı durdurun
                if (currentImageIndex == numTaramaAcı.Value)
                {
                    timer.Stop();
                }
            }
        }

        private void AddImageToPanel(string imageFile)
        {
            // Panel'i formdan alın (Eğer Designer'da eklediyseniz)
            Panel panel1 = this.panelgör;

            int x = 10, y = 10; // PictureBox konumu için başlangıç koordinatları
            int padding = 10; // PictureBox kontrolleri arasındaki boşluk
            int pictureBoxSize = 100; // PictureBox boyutu

            // Mevcut PictureBox konumunu hesaplayın
            int count = panel1.Controls.Count;
            x += (count % (panel1.Width / (pictureBoxSize + padding))) * (pictureBoxSize + padding);
            y += (count / (panel1.Width / (pictureBoxSize + padding))) * (pictureBoxSize + padding);

            // PictureBox'ı oluşturun ve ayarlayın
            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new Size(pictureBoxSize, pictureBoxSize); // PictureBox boyutu
            pictureBox.Location = new Point(x, y); // PictureBox konumu
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage; // Görseli PictureBox boyutuna uyar

            // Görseli yükleyin
            pictureBox.Image = Image.FromFile(imageFile);

            // PictureBox'ı panel'e ekleyin
            panel1.Controls.Add(pictureBox);
        }

        private void Projection_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde yapılacak işlemler
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Etiket tıklama olayı
        }

        private void lblPatientFullName_Click(object sender, EventArgs e)
        {
            // Etiket tıklama olayı
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Buton tıklama olayı
        }

        private void panelgör_Paint(object sender, PaintEventArgs e)
        {
            // Panel paint olayı
        }
    }
}
