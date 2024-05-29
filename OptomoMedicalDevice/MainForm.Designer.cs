namespace OptomoMedicalDevice
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDeviceConnection = new System.Windows.Forms.TabControl();
            this.tabDeviceConncetion = new System.Windows.Forms.TabPage();
            this.tabDeviceTest = new System.Windows.Forms.TabPage();
            this.tabWaitingPatients = new System.Windows.Forms.TabPage();
            this.tabPatientResults = new System.Windows.Forms.TabPage();
            this.deviceConnectionControl1 = new OptomoMedicalDevice.DeviceConnectionControl();
            this.tabDeviceConnection.SuspendLayout();
            this.tabDeviceConncetion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeviceConnection
            // 
            this.tabDeviceConnection.Controls.Add(this.tabDeviceConncetion);
            this.tabDeviceConnection.Controls.Add(this.tabDeviceTest);
            this.tabDeviceConnection.Controls.Add(this.tabWaitingPatients);
            this.tabDeviceConnection.Controls.Add(this.tabPatientResults);
            this.tabDeviceConnection.Location = new System.Drawing.Point(12, 12);
            this.tabDeviceConnection.Multiline = true;
            this.tabDeviceConnection.Name = "tabDeviceConnection";
            this.tabDeviceConnection.SelectedIndex = 0;
            this.tabDeviceConnection.Size = new System.Drawing.Size(776, 426);
            this.tabDeviceConnection.TabIndex = 0;
            // 
            // tabDeviceConncetion
            // 
            this.tabDeviceConncetion.Controls.Add(this.deviceConnectionControl1);
            this.tabDeviceConncetion.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceConncetion.Name = "tabDeviceConncetion";
            this.tabDeviceConncetion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceConncetion.Size = new System.Drawing.Size(768, 400);
            this.tabDeviceConncetion.TabIndex = 1;
            this.tabDeviceConncetion.Text = "Cihaz Baglantisi";
            this.tabDeviceConncetion.UseVisualStyleBackColor = true;
            // 
            // tabDeviceTest
            // 
            this.tabDeviceTest.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceTest.Name = "tabDeviceTest";
            this.tabDeviceTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceTest.Size = new System.Drawing.Size(768, 400);
            this.tabDeviceTest.TabIndex = 2;
            this.tabDeviceTest.Text = "Cihaz Testi";
            this.tabDeviceTest.UseVisualStyleBackColor = true;
            // 
            // tabWaitingPatients
            // 
            this.tabWaitingPatients.Location = new System.Drawing.Point(4, 22);
            this.tabWaitingPatients.Name = "tabWaitingPatients";
            this.tabWaitingPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitingPatients.Size = new System.Drawing.Size(768, 400);
            this.tabWaitingPatients.TabIndex = 3;
            this.tabWaitingPatients.Text = "Bekleyen Hastalar";
            this.tabWaitingPatients.UseVisualStyleBackColor = true;
            // 
            // tabPatientResults
            // 
            this.tabPatientResults.Location = new System.Drawing.Point(4, 22);
            this.tabPatientResults.Name = "tabPatientResults";
            this.tabPatientResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientResults.Size = new System.Drawing.Size(768, 400);
            this.tabPatientResults.TabIndex = 4;
            this.tabPatientResults.Text = "Hasta Sonuclari";
            this.tabPatientResults.UseVisualStyleBackColor = true;
            // 
            // deviceConnectionControl1
            // 
            this.deviceConnectionControl1.Location = new System.Drawing.Point(238, 99);
            this.deviceConnectionControl1.Name = "deviceConnectionControl1";
            this.deviceConnectionControl1.Size = new System.Drawing.Size(300, 150);
            this.deviceConnectionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabDeviceConnection);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabDeviceConnection.ResumeLayout(false);
            this.tabDeviceConncetion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeviceConnection;
        private System.Windows.Forms.TabPage tabDeviceConncetion;
        private System.Windows.Forms.TabPage tabDeviceTest;
        private System.Windows.Forms.TabPage tabWaitingPatients;
        private System.Windows.Forms.TabPage tabPatientResults;
        private DeviceConnectionControl deviceConnectionControl1;
    }
}