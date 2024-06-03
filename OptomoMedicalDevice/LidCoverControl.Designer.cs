namespace OptomoMedicalDevice
{
    partial class LidCoverControl
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
            this.lblLidControlDesc = new System.Windows.Forms.Label();
            this.lblLidControl = new System.Windows.Forms.Label();
            this.btnLidControlStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLidControlDesc
            // 
            this.lblLidControlDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLidControlDesc.Location = new System.Drawing.Point(181, 191);
            this.lblLidControlDesc.Name = "lblLidControlDesc";
            this.lblLidControlDesc.Size = new System.Drawing.Size(316, 45);
            this.lblLidControlDesc.TabIndex = 5;
            this.lblLidControlDesc.Text = "Kapak kontrolunu başlatmak için lütfen \"testi başlat\" butonuna tıklayınız";
            // 
            // lblLidControl
            // 
            this.lblLidControl.AutoSize = true;
            this.lblLidControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.25F, System.Drawing.FontStyle.Bold);
            this.lblLidControl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLidControl.Location = new System.Drawing.Point(246, 145);
            this.lblLidControl.Name = "lblLidControl";
            this.lblLidControl.Size = new System.Drawing.Size(186, 30);
            this.lblLidControl.TabIndex = 4;
            this.lblLidControl.Text = "Kapak Kontrol";
            // 
            // btnLidControlStart
            // 
            this.btnLidControlStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btnLidControlStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLidControlStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLidControlStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLidControlStart.Location = new System.Drawing.Point(209, 263);
            this.btnLidControlStart.Name = "btnLidControlStart";
            this.btnLidControlStart.Size = new System.Drawing.Size(242, 42);
            this.btnLidControlStart.TabIndex = 3;
            this.btnLidControlStart.Text = "Testi Başlat";
            this.btnLidControlStart.UseVisualStyleBackColor = false;
            this.btnLidControlStart.Click += new System.EventHandler(this.btnLidControlStart_Click);
            // 
            // LidCoverControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLidControlDesc);
            this.Controls.Add(this.lblLidControl);
            this.Controls.Add(this.btnLidControlStart);
            this.Name = "LidCoverControl";
            this.Size = new System.Drawing.Size(678, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLidControlDesc;
        private System.Windows.Forms.Label lblLidControl;
        private System.Windows.Forms.Button btnLidControlStart;
    }
}
