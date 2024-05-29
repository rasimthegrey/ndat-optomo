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
            this.btnXrayTest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAngularScanTest = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerticalMovementTest = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXrayTest
            // 
            this.btnXrayTest.Location = new System.Drawing.Point(55, 185);
            this.btnXrayTest.Name = "btnXrayTest";
            this.btnXrayTest.Size = new System.Drawing.Size(95, 23);
            this.btnXrayTest.TabIndex = 0;
            this.btnXrayTest.Text = "TEST BASLAT";
            this.btnXrayTest.UseVisualStyleBackColor = true;
            this.btnXrayTest.Click += new System.EventHandler(this.btnXrayTest_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnXrayTest);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 400);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "X-RAY Testi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnAngularScanTest);
            this.panel2.Location = new System.Drawing.Point(221, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 400);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 62);
            this.label2.TabIndex = 2;
            this.label2.Text = "Acisal Tarama\r\nTesti";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAngularScanTest
            // 
            this.btnAngularScanTest.Location = new System.Drawing.Point(58, 185);
            this.btnAngularScanTest.Name = "btnAngularScanTest";
            this.btnAngularScanTest.Size = new System.Drawing.Size(95, 23);
            this.btnAngularScanTest.TabIndex = 1;
            this.btnAngularScanTest.Text = "TEST BASLAT";
            this.btnAngularScanTest.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnVerticalMovementTest);
            this.panel3.Location = new System.Drawing.Point(434, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(208, 400);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 62);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yatay Hareket\r\nTesti";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnVerticalMovementTest
            // 
            this.btnVerticalMovementTest.Location = new System.Drawing.Point(54, 185);
            this.btnVerticalMovementTest.Name = "btnVerticalMovementTest";
            this.btnVerticalMovementTest.Size = new System.Drawing.Size(95, 23);
            this.btnVerticalMovementTest.TabIndex = 1;
            this.btnVerticalMovementTest.Text = "TEST BASLAT";
            this.btnVerticalMovementTest.UseVisualStyleBackColor = true;
            // 
            // DeviceTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DeviceTestControl";
            this.Size = new System.Drawing.Size(645, 406);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXrayTest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAngularScanTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnVerticalMovementTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
