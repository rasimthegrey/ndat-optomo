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

namespace OptomoMedicalDevice
{
    public partial class Projection : Form
    {
        public Projection(ListViewItem selectedItem)
        {
            InitializeComponent();

            // Display the selected item's details
            lblQueueNo.Text = "Sira No: " + selectedItem.Text;
            lblPatientID.Text = "T.C. Kimlik No: " + selectedItem.SubItems[1].Text;
            lblPatientFullName.Text = "Ad Soyad: " + selectedItem.SubItems[2].Text;
        }

        
    }
}
