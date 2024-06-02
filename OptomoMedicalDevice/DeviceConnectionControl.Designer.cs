using System;
using System.Drawing;
using System.Windows.Forms;
namespace OptomoMedicalDevice
{
    partial class DeviceConnectionControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblConnectionType;
        private System.Windows.Forms.ComboBox cmbConnectionType;
        private System.Windows.Forms.Label lblPortNumber;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Button btnConnect;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceConnectionControl));
            this.lblConnectionType = new System.Windows.Forms.Label();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConnectionType
            // 
            this.lblConnectionType.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConnectionType.Location = new System.Drawing.Point(353, 112);
            this.lblConnectionType.Name = "lblConnectionType";
            this.lblConnectionType.Size = new System.Drawing.Size(100, 15);
            this.lblConnectionType.TabIndex = 0;
            this.lblConnectionType.Text = "Cihaz Baglantısı*";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "USB 2.0",
            "USB 3.0",
            "USB 3.1",
            "Type-C"});
            this.cmbConnectionType.Location = new System.Drawing.Point(356, 130);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(361, 33);
            this.cmbConnectionType.TabIndex = 1;
            this.cmbConnectionType.SelectedIndexChanged += new System.EventHandler(this.cmbConnectionType_SelectedIndexChanged);
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPortNumber.Location = new System.Drawing.Point(353, 176);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(32, 15);
            this.lblPortNumber.TabIndex = 2;
            this.lblPortNumber.Text = "Port*";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPortNumber.Location = new System.Drawing.Point(356, 194);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(361, 30);
            this.txtPortNumber.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnect.Location = new System.Drawing.Point(356, 247);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(361, 42);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "BAGLAN";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cihaz Baglantısı";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 94);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bağlanmak istediğiniz cihazı seçin, bağlantı türünü ve port numarasını girin. Ard" +
    "ından “Bağlan” butonuna tıklayarak cihazınızı kolayca bağlayın.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // DeviceConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConnectionType);
            this.Controls.Add(this.cmbConnectionType);
            this.Controls.Add(this.lblPortNumber);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.btnConnect);
            this.Name = "DeviceConnectionControl";
            this.Size = new System.Drawing.Size(764, 369);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}
