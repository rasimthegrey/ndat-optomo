namespace OptomoMedicalDevice
{
    partial class DeviceTestControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabDeviceTestList = new System.Windows.Forms.TabControl();
            this.tabXrayTest = new System.Windows.Forms.TabPage();
            this.xRayTestContol1 = new OptomoMedicalDevice.XRayTestContol();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.angularTestControl1 = new OptomoMedicalDevice.AngularTestControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.verticalMovementTestControl1 = new OptomoMedicalDevice.VerticalMovementTestControl();
            this.tabDeviceTestList.SuspendLayout();
            this.tabXrayTest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeviceTestList
            // 
            this.tabDeviceTestList.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDeviceTestList.Controls.Add(this.tabXrayTest);
            this.tabDeviceTestList.Controls.Add(this.tabPage2);
            this.tabDeviceTestList.Controls.Add(this.tabPage3);
            this.tabDeviceTestList.Location = new System.Drawing.Point(3, 3);
            this.tabDeviceTestList.Multiline = true;
            this.tabDeviceTestList.Name = "tabDeviceTestList";
            this.tabDeviceTestList.SelectedIndex = 0;
            this.tabDeviceTestList.Size = new System.Drawing.Size(642, 400);
            this.tabDeviceTestList.TabIndex = 0;
            // 
            // tabXrayTest
            // 
            this.tabXrayTest.Controls.Add(this.xRayTestContol1);
            this.tabXrayTest.Location = new System.Drawing.Point(23, 4);
            this.tabXrayTest.Name = "tabXrayTest";
            this.tabXrayTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabXrayTest.Size = new System.Drawing.Size(615, 392);
            this.tabXrayTest.TabIndex = 0;
            this.tabXrayTest.Text = "X-RAY TEST";
            this.tabXrayTest.UseVisualStyleBackColor = true;
            // 
            // xRayTestContol1
            // 
            this.xRayTestContol1.Location = new System.Drawing.Point(0, 0);
            this.xRayTestContol1.Name = "xRayTestContol1";
            this.xRayTestContol1.Size = new System.Drawing.Size(619, 396);
            this.xRayTestContol1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.angularTestControl1);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(615, 392);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ACISAL TARAMA TESTI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // angularTestControl1
            // 
            this.angularTestControl1.Location = new System.Drawing.Point(0, 0);
            this.angularTestControl1.Name = "angularTestControl1";
            this.angularTestControl1.Size = new System.Drawing.Size(619, 396);
            this.angularTestControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.verticalMovementTestControl1);
            this.tabPage3.Location = new System.Drawing.Point(23, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(615, 392);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "YATAY HAREKET TESTI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // verticalMovementTestControl1
            // 
            this.verticalMovementTestControl1.Location = new System.Drawing.Point(0, -4);
            this.verticalMovementTestControl1.Name = "verticalMovementTestControl1";
            this.verticalMovementTestControl1.Size = new System.Drawing.Size(619, 400);
            this.verticalMovementTestControl1.TabIndex = 0;
            // 
            // DeviceTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDeviceTestList);
            this.Name = "DeviceTestControl";
            this.Size = new System.Drawing.Size(645, 406);
            this.tabDeviceTestList.ResumeLayout(false);
            this.tabXrayTest.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabDeviceTestList;
        private System.Windows.Forms.TabPage tabXrayTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private XRayTestContol xRayTestContol1;
        private AngularTestControl angularTestControl1;
        private VerticalMovementTestControl verticalMovementTestControl1;
    }
}
