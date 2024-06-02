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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numShotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numScanningAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAngularScanTestStart
            // 
            this.btnAngularScanTestStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btnAngularScanTestStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAngularScanTestStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAngularScanTestStart.Location = new System.Drawing.Point(221, 324);
            this.btnAngularScanTestStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnAngularScanTestStart.Name = "btnAngularScanTestStart";
            this.btnAngularScanTestStart.Size = new System.Drawing.Size(242, 42);
            this.btnAngularScanTestStart.TabIndex = 0;
            this.btnAngularScanTestStart.Text = "TEST BASLAT";
            this.btnAngularScanTestStart.UseVisualStyleBackColor = false;
            this.btnAngularScanTestStart.Click += new System.EventHandler(this.btnAngularScanTestStart_Click);
            // 
            // lblScanningAngle
            // 
            this.lblScanningAngle.AutoSize = true;
            this.lblScanningAngle.Location = new System.Drawing.Point(217, 192);
            this.lblScanningAngle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScanningAngle.Name = "lblScanningAngle";
            this.lblScanningAngle.Size = new System.Drawing.Size(119, 20);
            this.lblScanningAngle.TabIndex = 1;
            this.lblScanningAngle.Text = "Tarama Açısı*";
            this.lblScanningAngle.Click += new System.EventHandler(this.lblScanningAngle_Click);
            // 
            // lblShotCount
            // 
            this.lblShotCount.AutoSize = true;
            this.lblShotCount.Location = new System.Drawing.Point(217, 258);
            this.lblShotCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShotCount.Name = "lblShotCount";
            this.lblShotCount.Size = new System.Drawing.Size(99, 20);
            this.lblShotCount.TabIndex = 2;
            this.lblShotCount.Text = "Atış Sayısı*";
            // 
            // lblAngularScanningTest
            // 
            this.lblAngularScanningTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAngularScanningTest.Location = new System.Drawing.Point(205, 22);
            this.lblAngularScanningTest.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAngularScanningTest.Name = "lblAngularScanningTest";
            this.lblAngularScanningTest.Size = new System.Drawing.Size(247, 42);
            this.lblAngularScanningTest.TabIndex = 5;
            this.lblAngularScanningTest.Text = "Açısal Tarama Testi";
            this.lblAngularScanningTest.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAngularScanningTest.Click += new System.EventHandler(this.lblAngularScanningTest_Click);
            // 
            // numShotCount
            // 
            this.numShotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numShotCount.Location = new System.Drawing.Point(221, 283);
            this.numShotCount.Margin = new System.Windows.Forms.Padding(5);
            this.numShotCount.Name = "numShotCount";
            this.numShotCount.Size = new System.Drawing.Size(242, 31);
            this.numShotCount.TabIndex = 6;
            // 
            // numScanningAngle
            // 
            this.numScanningAngle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScanningAngle.Location = new System.Drawing.Point(221, 217);
            this.numScanningAngle.Margin = new System.Windows.Forms.Padding(5);
            this.numScanningAngle.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numScanningAngle.Name = "numScanningAngle";
            this.numScanningAngle.Size = new System.Drawing.Size(242, 31);
            this.numScanningAngle.TabIndex = 7;
            this.numScanningAngle.ValueChanged += new System.EventHandler(this.numScanningAngle_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(206, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 86);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lütfen tarama açısını ve atış sayısını girin. Ardından “Testi Başlat” butonuna tı" +
    "klayarak açısal tarama testini başlatabilirsiniz.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AngularTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numScanningAngle);
            this.Controls.Add(this.numShotCount);
            this.Controls.Add(this.lblAngularScanningTest);
            this.Controls.Add(this.lblShotCount);
            this.Controls.Add(this.lblScanningAngle);
            this.Controls.Add(this.btnAngularScanTestStart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Location = new System.Drawing.Point(0, -5);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AngularTestControl";
            this.Size = new System.Drawing.Size(660, 400);
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
        private System.Windows.Forms.Label label1;
    }
}
