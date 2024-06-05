using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.Windows.Media;




namespace OptomoMedicalDevice
{
    public partial class Projection : Form
    {
        private Timer timer;
        private List<string> imageFiles;
        private int currentImageIndex = 0;
        public string patientFullName;
        private ListViewItem selectedItem;                                                   //1


        public Projection(ListViewItem selectedItem)
        {
            InitializeComponent();
            patientFullName = selectedItem.SubItems[2].Text;
            // Display the selected item's details
            lblPatientID.Text = "T.C. Kimlik No : " + selectedItem.SubItems[1].Text;
            lblPatientFullName.Text = "Ad Soyad       : " + selectedItem.SubItems[2].Text;

            this.selectedItem = selectedItem;                                               //1


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
            string imageDirectory = @"..\..\xrayhavuz";

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
            try
            {
                string patientID = selectedItem.SubItems[1].Text; // Hasta ID'si
                string patientFullName = selectedItem.SubItems[2].Text; // Hasta adı ve soyadı
                string queueNo = selectedItem.SubItems[0].Text; // Sıra numarası

                // Hedef klasör yolu
                string targetDirectory = @"..\..\Hastalar\";

                // Hasta adını alın ve boşlukları alt çizgiyle değiştirin
                string patientName = patientFullName.Replace(" ", "_");

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

                // Görüntülerden 3D model oluştur
                var stlModel = Create3DModelFromImages(imageFiles);

                // Oluşturulan 3D modeli STL formatında kaydet
                Save3DModelAsSTL(stlModel, patientDirectory, patientName);

                // JSON dosyasına bilgileri ekle
                AddInfoToJson(patientID, patientFullName, patientDirectory);

                // Pencereyi kapat
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Kayıt işlemi sırasında hata oluştu. " + ex.Message);
            }
        }
        private Model3D Create3DModelFromImages(List<string> imageFiles)
        {
            // Helix Toolkit kullanarak bir MeshBuilder oluşturun
            var meshBuilder = new MeshBuilder();

            // Her bir görüntüyü döngüye alarak 3D modeli oluşturun
            foreach (var imageFile in imageFiles)
            {
                // Görseli yüzey olarak eklemek için yüzey oluştur
                var surface = CreateSurfaceFromImage(imageFile);

                // Oluşturulan yüzeyin üçgenlerini ekleyin
                for (int i = 0; i < surface.TriangleIndices.Count; i += 3)
                {
                    meshBuilder.AddTriangle(surface.Positions[surface.TriangleIndices[i]],
                                            surface.Positions[surface.TriangleIndices[i + 1]],
                                            surface.Positions[surface.TriangleIndices[i + 2]]);
                }
            }

            // MeshBuilder'daki mesh'i alarak Model3D öğesine dönüştürün
            var meshGeometry = meshBuilder.ToMesh();
            var material = MaterialHelper.CreateMaterial(Colors.Silver); // İstediğiniz materyali ayarlayabilirsiniz
            return new GeometryModel3D(meshGeometry, material);
        }
        private MeshGeometry3D CreateSurfaceFromImage(string imageFile)
        {
            // Burada, imageFile'dan bir yüzey oluşturmanız gerekiyor.
            // Bu aşamada, görüntü işleme ve yüzey oluşturma algoritmalarını kullanarak bir MeshGeometry3D oluşturmanız gerekecek.

            // Oluşturulan yüzeyi döndürün
            return new MeshGeometry3D();
        }

        private void Save3DModelAsSTL(Model3D stlModel, string patientDirectory, string patientName)
        {
            // STL dosyasının adını oluşturun (hastanın ismi ile)
            string stlFileName = patientName + "_model.stl";

            // STL dosyasının tam yolunu oluşturun
            string stlFilePath = Path.Combine(patientDirectory, stlFileName);

            // STL dosyasını oluşturmak için bir akım oluşturun
            using (FileStream fs = new FileStream(stlFilePath, FileMode.Create))
            {
                // StlExporter sınıfını kullanarak Model3D nesnesini STL dosyasına dönüştürün
                StlExporter exporter = new StlExporter();
                exporter.Export(stlModel, fs);
            }
        }
        private void AddInfoToJson(string patientID, string patientFullName, string patientDirectory)
        {
            // Hedef JSON dosyası yolu
            string jsonFilePath = Path.Combine(patientDirectory, "hasta_sonucu.json");

            // JSON verisi oluşturun
            var jsonData = new
            {
                patientID = patientID,
                patientFullName = patientFullName
            };

            // JSON verisini dosyaya yazın
            string jsonString = JsonSerializer.Serialize(jsonData);
            File.WriteAllText(jsonFilePath, jsonString);
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (currentImageIndex < imageFiles.Count)
            {
                // Görseli panel'e ekleyin
                AddImageToPanel(imageFiles[currentImageIndex]);
                currentImageIndex++;

                // Eğer tüm görseller eklendiyse timer'ı durdurun
                if (currentImageIndex == numShotCount.Value)
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
