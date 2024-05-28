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
            this.tabDeviceTest = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabWaitingPatients = new System.Windows.Forms.TabPage();
            this.tabDeviceTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeviceTest
            // 
            this.tabDeviceTest.Controls.Add(this.tabPage1);
            this.tabDeviceTest.Controls.Add(this.tabWaitingPatients);
            this.tabDeviceTest.Location = new System.Drawing.Point(12, 12);
            this.tabDeviceTest.Name = "tabDeviceTest";
            this.tabDeviceTest.SelectedIndex = 0;
            this.tabDeviceTest.Size = new System.Drawing.Size(776, 426);
            this.tabDeviceTest.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cihaz Testi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabWaitingPatients
            // 
            this.tabWaitingPatients.Location = new System.Drawing.Point(4, 22);
            this.tabWaitingPatients.Name = "tabWaitingPatients";
            this.tabWaitingPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitingPatients.Size = new System.Drawing.Size(768, 400);
            this.tabWaitingPatients.TabIndex = 1;
            this.tabWaitingPatients.Text = "Bekleyen Hastalar";
            this.tabWaitingPatients.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabDeviceTest);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabDeviceTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeviceTest;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabWaitingPatients;
    }
}