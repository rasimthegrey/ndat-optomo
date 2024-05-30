namespace OptomoMedicalDevice
{
    partial class AngularTestControl
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
            this.btnAngularScanTestStart = new System.Windows.Forms.Button();
            this.lblScanningAngle = new System.Windows.Forms.Label();
            this.lblShotCount = new System.Windows.Forms.Label();
            this.lblAngularScanningTest = new System.Windows.Forms.Label();
            this.numShotCount = new System.Windows.Forms.NumericUpDown();
            this.numScanningAngle = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numShotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanningAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAngularScanTestStart
            // 
            this.btnAngularScanTestStart.Location = new System.Drawing.Point(239, 147);
            this.btnAngularScanTestStart.Name = "btnAngularScanTestStart";
            this.btnAngularScanTestStart.Size = new System.Drawing.Size(109, 29);
            this.btnAngularScanTestStart.TabIndex = 0;
            this.btnAngularScanTestStart.Text = "TEST BASLAT";
            this.btnAngularScanTestStart.UseVisualStyleBackColor = true;
            this.btnAngularScanTestStart.Click += new System.EventHandler(this.btnAngularScanTestStart_Click);
            // 
            // lblScanningAngle
            // 
            this.lblScanningAngle.AutoSize = true;
            this.lblScanningAngle.Location = new System.Drawing.Point(134, 98);
            this.lblScanningAngle.Name = "lblScanningAngle";
            this.lblScanningAngle.Size = new System.Drawing.Size(68, 13);
            this.lblScanningAngle.TabIndex = 1;
            this.lblScanningAngle.Text = "Tarama Acisi";
            // 
            // lblShotCount
            // 
            this.lblShotCount.AutoSize = true;
            this.lblShotCount.Location = new System.Drawing.Point(148, 124);
            this.lblShotCount.Name = "lblShotCount";
            this.lblShotCount.Size = new System.Drawing.Size(54, 13);
            this.lblShotCount.TabIndex = 2;
            this.lblShotCount.Text = "Atis Sayisi";
            // 
            // lblAngularScanningTest
            // 
            this.lblAngularScanningTest.AutoSize = true;
            this.lblAngularScanningTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAngularScanningTest.Location = new System.Drawing.Point(105, 13);
            this.lblAngularScanningTest.Name = "lblAngularScanningTest";
            this.lblAngularScanningTest.Size = new System.Drawing.Size(335, 31);
            this.lblAngularScanningTest.TabIndex = 5;
            this.lblAngularScanningTest.Text = "ACISAL TARAMA TESTI";
            // 
            // numShotCount
            // 
            this.numShotCount.Location = new System.Drawing.Point(208, 122);
            this.numShotCount.Name = "numShotCount";
            this.numShotCount.Size = new System.Drawing.Size(140, 20);
            this.numShotCount.TabIndex = 6;
            // 
            // numScanningAngle
            // 
            this.numScanningAngle.Location = new System.Drawing.Point(208, 96);
            this.numScanningAngle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numScanningAngle.Name = "numScanningAngle";
            this.numScanningAngle.Size = new System.Drawing.Size(139, 20);
            this.numScanningAngle.TabIndex = 7;
            // 
            // AngularTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numScanningAngle);
            this.Controls.Add(this.numShotCount);
            this.Controls.Add(this.lblAngularScanningTest);
            this.Controls.Add(this.lblShotCount);
            this.Controls.Add(this.lblScanningAngle);
            this.Controls.Add(this.btnAngularScanTestStart);
            this.Name = "AngularTestControl";
            this.Size = new System.Drawing.Size(541, 349);
            ((System.ComponentModel.ISupportInitialize)(this.numShotCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanningAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAngularScanTestStart;
        private System.Windows.Forms.Label lblScanningAngle;
        private System.Windows.Forms.Label lblShotCount;
        private System.Windows.Forms.Label lblAngularScanningTest;
        private System.Windows.Forms.NumericUpDown numShotCount;
        private System.Windows.Forms.NumericUpDown numScanningAngle;
    }
}
