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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnXrayTestStart
            // 
            this.btnXrayTestStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btnXrayTestStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXrayTestStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnXrayTestStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnXrayTestStart.Location = new System.Drawing.Point(208, 220);
            this.btnXrayTestStart.Name = "btnXrayTestStart";
            this.btnXrayTestStart.Size = new System.Drawing.Size(242, 42);
            this.btnXrayTestStart.TabIndex = 0;
            this.btnXrayTestStart.Text = "Testi Başlat";
            this.btnXrayTestStart.UseVisualStyleBackColor = false;
            this.btnXrayTestStart.Click += new System.EventHandler(this.btnXrayTestStart_Click);
            // 
            // lblXrayTest
            // 
            this.lblXrayTest.AutoSize = true;
            this.lblXrayTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold);
            this.lblXrayTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblXrayTest.Location = new System.Drawing.Point(250, 106);
            this.lblXrayTest.Name = "lblXrayTest";
            this.lblXrayTest.Size = new System.Drawing.Size(159, 30);
            this.lblXrayTest.TabIndex = 1;
            this.lblXrayTest.Text = "X-Ray Testi";
            this.lblXrayTest.Click += new System.EventHandler(this.lblXrayTest_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(180, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "X-Ray testini başlatmak için lütfen \"testi başlat\" butonuna tıklayınız";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // XRayTestContol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblXrayTest);
            this.Controls.Add(this.btnXrayTestStart);
            this.Name = "XRayTestContol";
            this.Size = new System.Drawing.Size(660, 400);
            this.Load += new System.EventHandler(this.XRayTestContol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXrayTestStart;
        private System.Windows.Forms.Label lblXrayTest;
        private System.Windows.Forms.Label label1;
    }
}
