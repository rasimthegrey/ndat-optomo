namespace Optomo_Tec
{
    partial class waitPatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(waitPatientForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.patientView = new System.Windows.Forms.ListView();
            this.patientNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientKimlik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patientBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(140)))), ((int)(((byte)(205)))));
            this.closeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeButton.BackgroundImage")));
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(847, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(41, 43);
            this.closeButton.TabIndex = 5;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // patientView
            // 
            this.patientView.BackColor = System.Drawing.Color.MistyRose;
            this.patientView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.patientNumber,
            this.patientName,
            this.patientKimlik,
            this.patientBirth});
            this.patientView.FullRowSelect = true;
            this.patientView.HideSelection = false;
            this.patientView.Location = new System.Drawing.Point(86, 175);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(728, 349);
            this.patientView.TabIndex = 6;
            this.patientView.UseCompatibleStateImageBehavior = false;
            this.patientView.View = System.Windows.Forms.View.Details;
            this.patientView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // patientNumber
            // 
            this.patientNumber.Text = "SIRA NO";
            this.patientNumber.Width = 88;
            // 
            // patientName
            // 
            this.patientName.Text = "AD-SOYAD";
            this.patientName.Width = 109;
            // 
            // patientKimlik
            // 
            this.patientKimlik.Text = "TC KİMLİK";
            this.patientKimlik.Width = 96;
            // 
            // patientBirth
            // 
            this.patientBirth.Text = "DOĞUM TARİHİ";
            this.patientBirth.Width = 125;
            // 
            // waitPatientForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.patientView);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "waitPatientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.waitPatient_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListView patientView;
        private System.Windows.Forms.ColumnHeader patientNumber;
        private System.Windows.Forms.ColumnHeader patientName;
        private System.Windows.Forms.ColumnHeader patientKimlik;
        private System.Windows.Forms.ColumnHeader patientBirth;
    }
}