using System;
using System.Drawing;
using System.Windows.Forms;
namespace OptomoMedicalDevice
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabCDeviceConnection = new System.Windows.Forms.TabControl();
            this.tabDeviceConncetion = new System.Windows.Forms.TabPage();
            this.deviceConnectionControl1 = new OptomoMedicalDevice.DeviceConnectionControl();
            this.tabDeviceTest = new System.Windows.Forms.TabPage();
            this.deviceTestControl1 = new OptomoMedicalDevice.DeviceTestControl();
            this.tabWaitingPatients = new System.Windows.Forms.TabPage();
            this.waitingPatientsControl1 = new OptomoMedicalDevice.WaitingPatientsControl();
            this.tabPatientResults = new System.Windows.Forms.TabPage();
            this.patientResultsControl1 = new OptomoMedicalDevice.PatientResultsControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabCDeviceConnection.SuspendLayout();
            this.tabDeviceConncetion.SuspendLayout();
            this.tabDeviceTest.SuspendLayout();
            this.tabWaitingPatients.SuspendLayout();
            this.tabPatientResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCDeviceConnection
            // 
            this.tabCDeviceConnection.Controls.Add(this.tabDeviceConncetion);
            this.tabCDeviceConnection.Controls.Add(this.tabDeviceTest);
            this.tabCDeviceConnection.Controls.Add(this.tabWaitingPatients);
            this.tabCDeviceConnection.Controls.Add(this.tabPatientResults);
            this.tabCDeviceConnection.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabCDeviceConnection.ItemSize = new System.Drawing.Size(140, 30);
            this.tabCDeviceConnection.Location = new System.Drawing.Point(20, 50);
            this.tabCDeviceConnection.Multiline = true;
            this.tabCDeviceConnection.Name = "tabCDeviceConnection";
            this.tabCDeviceConnection.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabCDeviceConnection.SelectedIndex = 0;
            this.tabCDeviceConnection.Size = new System.Drawing.Size(800, 426);
            this.tabCDeviceConnection.TabIndex = 0;
            this.tabCDeviceConnection.TabStop = false;
            this.tabCDeviceConnection.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabCDeviceConnection_DrawItem);
            // 
            // tabDeviceConncetion
            // 
            this.tabDeviceConncetion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabDeviceConncetion.Controls.Add(this.deviceConnectionControl1);
            this.tabDeviceConncetion.Cursor = System.Windows.Forms.Cursors.SizeNS;
            this.tabDeviceConncetion.Location = new System.Drawing.Point(4, 34);
            this.tabDeviceConncetion.Name = "tabDeviceConncetion";
            this.tabDeviceConncetion.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceConncetion.Size = new System.Drawing.Size(792, 362);
            this.tabDeviceConncetion.TabIndex = 1;
            this.tabDeviceConncetion.Text = "Cihaz Baglantisi";
            this.tabDeviceConncetion.Click += new System.EventHandler(this.tabDeviceConncetion_Click);
            // 
            // deviceConnectionControl1
            // 
            this.deviceConnectionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceConnectionControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.deviceConnectionControl1.Location = new System.Drawing.Point(-14, 0);
            this.deviceConnectionControl1.Name = "deviceConnectionControl1";
            this.deviceConnectionControl1.Size = new System.Drawing.Size(784, 357);
            this.deviceConnectionControl1.TabIndex = 0;
            this.deviceConnectionControl1.Load += new System.EventHandler(this.deviceConnectionControl1_Load);
            // 
            // tabDeviceTest
            // 
            this.tabDeviceTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabDeviceTest.Controls.Add(this.deviceTestControl1);
            this.tabDeviceTest.Location = new System.Drawing.Point(4, 34);
            this.tabDeviceTest.Name = "tabDeviceTest";
            this.tabDeviceTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeviceTest.Size = new System.Drawing.Size(792, 388);
            this.tabDeviceTest.TabIndex = 2;
            this.tabDeviceTest.Text = "Cihaz Testi";
            this.tabDeviceTest.UseVisualStyleBackColor = true;
            // 
            // deviceTestControl1
            // 
            this.deviceTestControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.deviceTestControl1.Location = new System.Drawing.Point(-4, 0);
            this.deviceTestControl1.Name = "deviceTestControl1";
            this.deviceTestControl1.Size = new System.Drawing.Size(802, 392);
            this.deviceTestControl1.TabIndex = 0;
            this.deviceTestControl1.Load += new System.EventHandler(this.deviceTestControl1_Load);
            // 
            // tabWaitingPatients
            // 
            this.tabWaitingPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabWaitingPatients.Controls.Add(this.waitingPatientsControl1);
            this.tabWaitingPatients.Location = new System.Drawing.Point(4, 34);
            this.tabWaitingPatients.Name = "tabWaitingPatients";
            this.tabWaitingPatients.Padding = new System.Windows.Forms.Padding(3);
            this.tabWaitingPatients.Size = new System.Drawing.Size(792, 362);
            this.tabWaitingPatients.TabIndex = 3;
            this.tabWaitingPatients.Text = "Bekleyen Hastalar";
            this.tabWaitingPatients.UseVisualStyleBackColor = true;
            this.tabWaitingPatients.Click += new System.EventHandler(this.tabWaitingPatients_Click);
            // 
            // waitingPatientsControl1
            // 
            this.waitingPatientsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.waitingPatientsControl1.Location = new System.Drawing.Point(0, 3);
            this.waitingPatientsControl1.Name = "waitingPatientsControl1";
            this.waitingPatientsControl1.Size = new System.Drawing.Size(768, 397);
            this.waitingPatientsControl1.TabIndex = 0;
            this.waitingPatientsControl1.Load += new System.EventHandler(this.waitingPatientsControl1_Load);
            // 
            // tabPatientResults
            // 
            this.tabPatientResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tabPatientResults.Controls.Add(this.patientResultsControl1);
            this.tabPatientResults.Location = new System.Drawing.Point(4, 34);
            this.tabPatientResults.Name = "tabPatientResults";
            this.tabPatientResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatientResults.Size = new System.Drawing.Size(792, 362);
            this.tabPatientResults.TabIndex = 4;
            this.tabPatientResults.Text = "Hasta Sonuclari";
            this.tabPatientResults.UseVisualStyleBackColor = true;
            this.tabPatientResults.Click += new System.EventHandler(this.tabPatientResults_Click);
            // 
            // patientResultsControl1
            // 
            this.patientResultsControl1.Location = new System.Drawing.Point(6, 3);
            this.patientResultsControl1.Name = "patientResultsControl1";
            this.patientResultsControl1.Size = new System.Drawing.Size(780, 353);
            this.patientResultsControl1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(834, 488);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabCDeviceConnection);
            this.Name = "MainForm";
            this.Text = "OPTOMO";
            this.tabCDeviceConnection.ResumeLayout(false);
            this.tabDeviceConncetion.ResumeLayout(false);
            this.tabDeviceTest.ResumeLayout(false);
            this.tabWaitingPatients.ResumeLayout(false);
            this.tabPatientResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tabCDeviceConnection_DrawItem(object sender, DrawItemEventArgs e)
        {

            //Get the working area of the TabControl main control
            Rectangle rec = tabCDeviceConnection.ClientRectangle;
            //Create a StringFormat object to set the layout of the label text
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// Set the text to be centered vertically
            StrFormat.Alignment = StringAlignment.Center;// Set the text to be centered horizontally

            // The background fill color of the label, it can also be a picture (e.Graphics.DrawImage)
            SolidBrush backColor2 = new SolidBrush(Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92))))));

            SolidBrush fontColor;// Label font color
                                 //Draw the background of the main control
            e.Graphics.FillRectangle(backColor2, rec);

            //Draw label style
            Font fntTab = e.Font;
            Brush bshBack = new SolidBrush(Color.White);

            for (int i = 0; i < tabCDeviceConnection.TabPages.Count; i++)
            {
                bool bSelected = (tabCDeviceConnection.SelectedIndex == i);
                Rectangle recBounds = tabCDeviceConnection.GetTabRect(i);
                RectangleF tabTextArea = (RectangleF)tabCDeviceConnection.GetTabRect(i);
                if (bSelected)
                {
                    e.Graphics.FillRectangle(bshBack, recBounds);
                    fontColor = new SolidBrush(Color.Black);
                    e.Graphics.DrawString(tabCDeviceConnection.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
                else
                {
                    e.Graphics.FillRectangle(backColor2, recBounds);
                    fontColor = new SolidBrush(Color.White);
                    e.Graphics.DrawString(tabCDeviceConnection.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
        }

        #endregion

        private System.Windows.Forms.TabControl tabCDeviceConnection;
        private System.Windows.Forms.TabPage tabDeviceConncetion;
        private System.Windows.Forms.TabPage tabDeviceTest;
        private System.Windows.Forms.TabPage tabWaitingPatients;
        private System.Windows.Forms.TabPage tabPatientResults;
        private DeviceConnectionControl deviceConnectionControl1;
        private DeviceTestControl deviceTestControl1;
        private WaitingPatientsControl waitingPatientsControl1;
        private PictureBox pictureBox1;
        private PatientResultsControl patientResultsControl1;
    }

}