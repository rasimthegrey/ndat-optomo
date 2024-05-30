namespace OptomoMedicalDevice
{
    partial class XRayTestContol
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
            this.btnXrayTestStart = new System.Windows.Forms.Button();
            this.lblXrayTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXrayTestStart
            // 
            this.btnXrayTestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXrayTestStart.Location = new System.Drawing.Point(221, 178);
            this.btnXrayTestStart.Name = "btnXrayTestStart";
            this.btnXrayTestStart.Size = new System.Drawing.Size(130, 34);
            this.btnXrayTestStart.TabIndex = 0;
            this.btnXrayTestStart.Text = "TEST BASLAT";
            this.btnXrayTestStart.UseVisualStyleBackColor = true;
            this.btnXrayTestStart.Click += new System.EventHandler(this.btnXrayTestStart_Click);
            // 
            // lblXrayTest
            // 
            this.lblXrayTest.AutoSize = true;
            this.lblXrayTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblXrayTest.Location = new System.Drawing.Point(188, 25);
            this.lblXrayTest.Name = "lblXrayTest";
            this.lblXrayTest.Size = new System.Drawing.Size(193, 31);
            this.lblXrayTest.TabIndex = 1;
            this.lblXrayTest.Text = "X-RAY TESTI";
            // 
            // XRayTestContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblXrayTest);
            this.Controls.Add(this.btnXrayTestStart);
            this.Name = "XRayTestContol";
            this.Size = new System.Drawing.Size(577, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXrayTestStart;
        private System.Windows.Forms.Label lblXrayTest;
    }
}
