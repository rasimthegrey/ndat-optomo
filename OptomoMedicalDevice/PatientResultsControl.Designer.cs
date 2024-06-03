namespace OptomoMedicalDevice
{
    partial class PatientResultsControl
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
            this.listViewPatientResults = new System.Windows.Forms.ListView();
            this.patientFullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewPatientResults
            // 
            this.listViewPatientResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientFullName});
            this.listViewPatientResults.HideSelection = false;
            this.listViewPatientResults.Location = new System.Drawing.Point(13, 47);
            this.listViewPatientResults.Name = "listViewPatientResults";
            this.listViewPatientResults.Size = new System.Drawing.Size(502, 268);
            this.listViewPatientResults.TabIndex = 0;
            this.listViewPatientResults.UseCompatibleStateImageBehavior = false;
            this.listViewPatientResults.View = System.Windows.Forms.View.Details;
            // 
            // patientFullName
            // 
            this.patientFullName.Text = "Hasta Ad Soyad";
            this.patientFullName.Width = 116;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hasta Sonuclari";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(440, 23);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "YENILE";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // PatientResultsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPatientResults);
            this.Name = "PatientResultsControl";
            this.Size = new System.Drawing.Size(591, 355);
            this.Load += new System.EventHandler(this.PatientResultsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.listViewPatientResults.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPatientResults_MouseDoubleClick);

        }

        #endregion

        private System.Windows.Forms.ListView listViewPatientResults;
        private System.Windows.Forms.ColumnHeader patientFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReload;
    }
}
