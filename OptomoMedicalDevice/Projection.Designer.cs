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
            this.lblQueueNo = new System.Windows.Forms.Label();
            this.lblPatientID = new System.Windows.Forms.Label();
            this.lblPatientFullName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQueueNo
            // 
            this.lblQueueNo.AutoSize = true;
            this.lblQueueNo.Location = new System.Drawing.Point(131, 50);
            this.lblQueueNo.Name = "lblQueueNo";
            this.lblQueueNo.Size = new System.Drawing.Size(42, 13);
            this.lblQueueNo.TabIndex = 0;
            this.lblQueueNo.Text = "Sira No";
            // 
            // lblPatientID
            // 
            this.lblPatientID.AutoSize = true;
            this.lblPatientID.Location = new System.Drawing.Point(138, 80);
            this.lblPatientID.Name = "lblPatientID";
            this.lblPatientID.Size = new System.Drawing.Size(57, 13);
            this.lblPatientID.TabIndex = 1;
            this.lblPatientID.Text = "T.C. Kimlik";
            // 
            // lblPatientFullName
            // 
            this.lblPatientFullName.AutoSize = true;
            this.lblPatientFullName.Location = new System.Drawing.Point(138, 113);
            this.lblPatientFullName.Name = "lblPatientFullName";
            this.lblPatientFullName.Size = new System.Drawing.Size(53, 13);
            this.lblPatientFullName.TabIndex = 2;
            this.lblPatientFullName.Text = "Ad Soyad";
            // 
            // Projection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPatientFullName);
            this.Controls.Add(this.lblPatientID);
            this.Controls.Add(this.lblQueueNo);
            this.Name = "Projection";
            this.Text = "Projection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQueueNo;
        private System.Windows.Forms.Label lblPatientID;
        private System.Windows.Forms.Label lblPatientFullName;
    }
}