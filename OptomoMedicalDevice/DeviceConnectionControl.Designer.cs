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
            this.lblConnectionType = new System.Windows.Forms.Label();
            this.cmbConnectionType = new System.Windows.Forms.ComboBox();
            this.lblPortNumber = new System.Windows.Forms.Label();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblConnectionType
            // 
            this.lblConnectionType.AutoSize = true;
            this.lblConnectionType.Location = new System.Drawing.Point(30, 30);
            this.lblConnectionType.Name = "lblConnectionType";
            this.lblConnectionType.Size = new System.Drawing.Size(81, 13);
            this.lblConnectionType.TabIndex = 0;
            this.lblConnectionType.Text = "Cihaz Baglantisi";
            // 
            // cmbConnectionType
            // 
            this.cmbConnectionType.FormattingEnabled = true;
            this.cmbConnectionType.Items.AddRange(new object[] {
            "USB 2.0",
            "USB 3.0",
            "USB 3.1",
            "Type-C"});
            this.cmbConnectionType.Location = new System.Drawing.Point(150, 27);
            this.cmbConnectionType.Name = "cmbConnectionType";
            this.cmbConnectionType.Size = new System.Drawing.Size(121, 21);
            this.cmbConnectionType.TabIndex = 1;
            // 
            // lblPortNumber
            // 
            this.lblPortNumber.AutoSize = true;
            this.lblPortNumber.Location = new System.Drawing.Point(30, 70);
            this.lblPortNumber.Name = "lblPortNumber";
            this.lblPortNumber.Size = new System.Drawing.Size(73, 13);
            this.lblPortNumber.TabIndex = 2;
            this.lblPortNumber.Text = "Port Numarasi";
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(150, 67);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(121, 20);
            this.txtPortNumber.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(150, 110);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "BAGLAN";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // DeviceConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblConnectionType);
            this.Controls.Add(this.cmbConnectionType);
            this.Controls.Add(this.lblPortNumber);
            this.Controls.Add(this.txtPortNumber);
            this.Controls.Add(this.btnConnect);
            this.Name = "DeviceConnectionControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
