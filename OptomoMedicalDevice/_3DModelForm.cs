using System.Windows.Forms;
using System.Windows.Forms.Integration;
using HelixToolkit.Wpf;
using System.Windows.Media.Media3D;
using System.IO;
using System.Windows.Media;

namespace OptomoMedicalDevice
{
    public partial class _3DModelForm : Form
    {
        public _3DModelForm(string filePath)
        {
            InitializeComponent();

            // ElementHost ayarları
            ElementHost elementHost = new ElementHost
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(elementHost);

            // HelixViewport3D ayarları
            var viewPort = new HelixViewport3D
            {
                Background = Brushes.Black
            };
            elementHost.Child = viewPort;

            // Kamera ve ışık ekleme
            viewPort.Camera = new PerspectiveCamera(new Point3D(0, 0, 5), new Vector3D(0, 0, -1), new Vector3D(0, 1, 0), 45);
            viewPort.Children.Add(new DefaultLights());

            // .stl dosyasını yükleme
            var stlModel = LoadStlModel(filePath);
            if (stlModel != null)
            {
                viewPort.Children.Add(stlModel);
            }
        }

        private ModelVisual3D LoadStlModel(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("STL dosyası bulunamadı.");
                return null;
            }

            var importer = new StLReader();
            var model = importer.Read(filePath);

            return new ModelVisual3D { Content = model };
        }
    }
}
