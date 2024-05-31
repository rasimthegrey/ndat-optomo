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
            this.deviceConnectionControl1 = new OptomoMedicalDevice.DeviceConnectionControl();
            this.tabDeviceTest = new System.Windows.Forms.TabPage();
            this.deviceTestControl1 = new OptomoMedicalDevice.DeviceTestControl();
            this.tabWaitingPatients = new System.Windows.Forms.TabPage();
            this.waitingPatientsControl1 = new OptomoMedicalDevice.WaitingPatientsControl();
            this.tabPatientResults = new System.Windows.Forms.TabPage();
            this.tabDeviceConnection.SuspendLayout();
            this.tabDeviceConncetion.SuspendLayout();
            this.tabDeviceTest.SuspendLayout();
            this.tabWaitingPatients.SuspendLayout();
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
            // deviceConnectionControl1
            // 
            this.deviceConnectionControl1.Location = new System.Drawing.Point(238, 99);
            this.deviceConnectionControl1.Name = "deviceConnectionControl1";
            this.deviceConnectionControl1.Size = new System.Drawing.Size(300, 150);
            this.deviceConnectionControl1.TabIndex = 0;
            // 
            // tabDeviceTest
            // 
            this.tabDeviceTest.Controls.Add(this.deviceTestControl1);
            this.tabDeviceTest.Location = new System.Drawing.Point(4, 22);
            this.tabDeviceTest.Name = "tabDeviceTest";
            this.tabDeviceTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceTest.Size = new System.Drawing.Size(768, 400);
            this.tabDeviceTest.TabIndex = 2;
            this.tabDeviceTest.Text = "Cihaz Testi";
            this.tabDeviceTest.UseVisualStyleBackColor = true;
            // 
            // deviceTestControl1
            // 
            this.deviceTestControl1.Location = new System.Drawing.Point(6, 0);
            this.deviceTestControl1.Name = "deviceTestControl1";
            this.deviceTestControl1.Size = new System.Drawing.Size(756, 394);
            this.deviceTestControl1.TabIndex = 0;
            // 
            // tabWaitingPatients
            // 
            this.tabWaitingPatients.Controls.Add(this.waitingPatientsControl1);
            this.tabWaitingPatients.Location = new System.Drawing.Point(4, 22);
            this.tabWaitingPatients.Name = "tabWaitingPatients";
            this.tabWaitingPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitingPatients.Size = new System.Drawing.Size(768, 400);
            this.tabWaitingPatients.TabIndex = 3;
            this.tabWaitingPatients.Text = "Bekleyen Hastalar";
            this.tabWaitingPatients.UseVisualStyleBackColor = true;
            // 
            // waitingPatientsControl1
            // 
            this.waitingPatientsControl1.Location = new System.Drawing.Point(0, 3);
            this.waitingPatientsControl1.Name = "waitingPatientsControl1";
            this.waitingPatientsControl1.Size = new System.Drawing.Size(768, 397);
            this.waitingPatientsControl1.TabIndex = 0;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabDeviceConnection);
            this.Name = "MainForm";
            this.Text = "OPTOMO";
            this.tabDeviceConnection.ResumeLayout(false);
            this.tabDeviceConncetion.ResumeLayout(false);
            this.tabDeviceTest.ResumeLayout(false);
            this.tabWaitingPatients.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeviceConnection;
        private System.Windows.Forms.TabPage tabDeviceConncetion;
        private System.Windows.Forms.TabPage tabDeviceTest;
        private System.Windows.Forms.TabPage tabWaitingPatients;
        private System.Windows.Forms.TabPage tabPatientResults;
        private DeviceConnectionControl deviceConnectionControl1;
        private DeviceTestControl deviceTestControl1;
        private WaitingPatientsControl waitingPatientsControl1;
    }
}