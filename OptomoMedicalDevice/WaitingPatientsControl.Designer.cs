namespace OptomoMedicalDevice
{
    partial class WaitingPatientsControl
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
            this.listWaitingPatients = new System.Windows.Forms.ListView();
            this.queueNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listWaitingPatients
            // 
            this.listWaitingPatients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.queueNumber,
            this.patientID,
            this.patientFullName});
            this.listWaitingPatients.FullRowSelect = true;
            this.listWaitingPatients.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listWaitingPatients.HideSelection = false;
            this.listWaitingPatients.Location = new System.Drawing.Point(8, 38);
            this.listWaitingPatients.Name = "listWaitingPatients";
            this.listWaitingPatients.Size = new System.Drawing.Size(516, 283);
            this.listWaitingPatients.TabIndex = 0;
            this.listWaitingPatients.UseCompatibleStateImageBehavior = false;
            this.listWaitingPatients.View = System.Windows.Forms.View.Details;
            this.listWaitingPatients.SelectedIndexChanged += new System.EventHandler(this.listWaitingPatients_SelectedIndexChanged);
            this.listWaitingPatients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listWaitingPatients_MouseDoubleClick);
            // 
            // queueNumber
            // 
            this.queueNumber.Text = "Sira No";
            // 
            // patientID
            // 
            this.patientID.Text = "T.C. Kimlik No";
            this.patientID.Width = 83;
            // 
            // patientFullName
            // 
            this.patientFullName.Text = "Ad - Soyad";
            this.patientFullName.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bekleyen Hastalar";
            // 
            // WaitingPatientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listWaitingPatients);
            this.Name = "WaitingPatientsControl";
            this.Size = new System.Drawing.Size(539, 344);
            this.Load += new System.EventHandler(this.WaitingPatientsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listWaitingPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader patientID;
        private System.Windows.Forms.ColumnHeader patientFullName;
        private System.Windows.Forms.ColumnHeader queueNumber;
    }
}
