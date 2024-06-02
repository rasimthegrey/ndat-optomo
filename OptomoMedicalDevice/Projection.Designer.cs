namespace OptomoMedicalDevice
{
    partial class Projection
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
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numTaramaAcı = new System.Windows.Forms.NumericUpDown();
            this.numShotCount = new System.Windows.Forms.NumericUpDown();
            this.lblShotCount = new System.Windows.Forms.Label();
            this.lblScanningAngle = new System.Windows.Forms.Label();
            this.btnCekimBaslat = new System.Windows.Forms.Button();
            this.btnCekimBitir = new System.Windows.Forms.Button();
            this.panelgör = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numTaramaAcı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShotCount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.BackColor = System.Drawing.Color.White;
            this.lblPatientID.Location = new System.Drawing.Point(62, 143);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "T.C. Kimlik";
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.BackColor = System.Drawing.Color.White;
            this.lblPatientFullName.Location = new System.Drawing.Point(62, 110);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(53, 13);
            this.lblPatientFullName.TabIndex = 2;
            this.lblPatientFullName.Text = "Ad Soyad";
            this.lblPatientFullName.Click += new System.EventHandler(this.lblPatientFullName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(33, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Bilgileri";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(37, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 100);
            this.panel1.TabIndex = 4;
            // 
            // numTaramaAcı
            // 
            this.numTaramaAcı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTaramaAcı.Location = new System.Drawing.Point(37, 246);
            this.numTaramaAcı.Margin = new System.Windows.Forms.Padding(5);
            this.numTaramaAcı.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.numTaramaAcı.Name = "numTaramaAcı";
            this.numTaramaAcı.Size = new System.Drawing.Size(262, 31);
            this.numTaramaAcı.TabIndex = 12;
            // 
            // numShotCount
            // 
            this.numShotCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numShotCount.Location = new System.Drawing.Point(37, 312);
            this.numShotCount.Margin = new System.Windows.Forms.Padding(5);
            this.numShotCount.Name = "numShotCount";
            this.numShotCount.Size = new System.Drawing.Size(262, 31);
            this.numShotCount.TabIndex = 11;
            // 
            // lblShotCount
            // 
            this.lblShotCount.AutoSize = true;
            this.lblShotCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblShotCount.Location = new System.Drawing.Point(33, 287);
            this.lblShotCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShotCount.Name = "lblShotCount";
            this.lblShotCount.Size = new System.Drawing.Size(58, 13);
            this.lblShotCount.TabIndex = 10;
            this.lblShotCount.Text = "Atış Sayısı*";
            // 
            // lblScanningAngle
            // 
            this.lblScanningAngle.AutoSize = true;
            this.lblScanningAngle.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScanningAngle.Location = new System.Drawing.Point(33, 221);
            this.lblScanningAngle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblScanningAngle.Name = "lblScanningAngle";
            this.lblScanningAngle.Size = new System.Drawing.Size(72, 13);
            this.lblScanningAngle.TabIndex = 9;
            this.lblScanningAngle.Text = "Tarama Açısı*";
            // 
            // btnCekimBaslat
            // 
            this.btnCekimBaslat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(158)))), ((int)(((byte)(13)))));
            this.btnCekimBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekimBaslat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCekimBaslat.Location = new System.Drawing.Point(37, 353);
            this.btnCekimBaslat.Margin = new System.Windows.Forms.Padding(5);
            this.btnCekimBaslat.Name = "btnCekimBaslat";
            this.btnCekimBaslat.Size = new System.Drawing.Size(126, 42);
            this.btnCekimBaslat.TabIndex = 8;
            this.btnCekimBaslat.Text = "Çekimi Başlat";
            this.btnCekimBaslat.UseVisualStyleBackColor = false;
            // 
            // btnCekimBitir
            // 
            this.btnCekimBitir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(19)))), ((int)(((byte)(34)))));
            this.btnCekimBitir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCekimBitir.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCekimBitir.Location = new System.Drawing.Point(173, 353);
            this.btnCekimBitir.Margin = new System.Windows.Forms.Padding(5);
            this.btnCekimBitir.Name = "btnCekimBitir";
            this.btnCekimBitir.Size = new System.Drawing.Size(126, 42);
            this.btnCekimBitir.TabIndex = 13;
            this.btnCekimBitir.Text = "Çekimi Bitir";
            this.btnCekimBitir.UseVisualStyleBackColor = false;
            this.btnCekimBitir.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelgör
            // 
            this.panelgör.AutoScroll = true;
            this.panelgör.BackColor = System.Drawing.Color.White;
            this.panelgör.Location = new System.Drawing.Point(417, 51);
            this.panelgör.Name = "panelgör";
            this.panelgör.Size = new System.Drawing.Size(331, 344);
            this.panelgör.TabIndex = 14;
            this.panelgör.Paint += new System.Windows.Forms.PaintEventHandler(this.panelgör_Paint);
            // 
            // Projection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelgör);
            this.Controls.Add(this.btnCekimBitir);
            this.Controls.Add(this.numTaramaAcı);
            this.Controls.Add(this.numShotCount);
            this.Controls.Add(this.lblShotCount);
            this.Controls.Add(this.lblScanningAngle);
            this.Controls.Add(this.btnCekimBaslat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.panel1);
            this.Name = "Projection";
            this.Text = "Projection";
            this.Load += new System.EventHandler(this.Projection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTaramaAcı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numShotCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numTaramaAcı;
        private System.Windows.Forms.NumericUpDown numShotCount;
        private System.Windows.Forms.Label lblShotCount;
        private System.Windows.Forms.Label lblScanningAngle;
        private System.Windows.Forms.Button btnCekimBaslat;
        private System.Windows.Forms.Button btnCekimBitir;
        private System.Windows.Forms.Panel panelgör;
    }
}