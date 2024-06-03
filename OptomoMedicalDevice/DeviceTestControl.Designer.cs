using System;
using System.Drawing;
using System.Windows.Forms;
namespace OptomoMedicalDevice
{
    partial class DeviceTestControl
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
            this.tabDeviceTestList = new System.Windows.Forms.TabControl();
            this.tabXrayTest = new System.Windows.Forms.TabPage();
            this.xRayTestContol1 = new OptomoMedicalDevice.XRayTestContol();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.angularTestControl1 = new OptomoMedicalDevice.AngularTestControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.verticalMovementTestControl1 = new OptomoMedicalDevice.VerticalMovementTestControl();
            this.tabKapakKontrol = new System.Windows.Forms.TabPage();
            this.lidCoverControl1 = new OptomoMedicalDevice.LidCoverControl();
            this.tabDeviceTestList.SuspendLayout();
            this.tabXrayTest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabKapakKontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabDeviceTestList
            // 
            this.tabDeviceTestList.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabDeviceTestList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tabDeviceTestList.Controls.Add(this.tabXrayTest);
            this.tabDeviceTestList.Controls.Add(this.tabPage2);
            this.tabDeviceTestList.Controls.Add(this.tabPage3);
            this.tabDeviceTestList.Controls.Add(this.tabKapakKontrol);
            this.tabDeviceTestList.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabDeviceTestList.ItemSize = new System.Drawing.Size(20, 150);
            this.tabDeviceTestList.Location = new System.Drawing.Point(3, 12);
            this.tabDeviceTestList.Margin = new System.Windows.Forms.Padding(0);
            this.tabDeviceTestList.Multiline = true;
            this.tabDeviceTestList.Name = "tabDeviceTestList";
            this.tabDeviceTestList.SelectedIndex = 0;
            this.tabDeviceTestList.Size = new System.Drawing.Size(765, 391);
            this.tabDeviceTestList.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabDeviceTestList.TabIndex = 0;
            this.tabDeviceTestList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabDeviceTestList_DrawItem);
            // 
            // tabXrayTest
            // 
            this.tabXrayTest.Controls.Add(this.xRayTestContol1);
            this.tabXrayTest.Location = new System.Drawing.Point(154, 4);
            this.tabXrayTest.Name = "tabXrayTest";
            this.tabXrayTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabXrayTest.Size = new System.Drawing.Size(607, 383);
            this.tabXrayTest.TabIndex = 0;
            this.tabXrayTest.Text = "X-RAY TEST";
            this.tabXrayTest.UseVisualStyleBackColor = true;
            // 
            // xRayTestContol1
            // 
            this.xRayTestContol1.BackColor = System.Drawing.Color.White;
            this.xRayTestContol1.Location = new System.Drawing.Point(0, -5);
            this.xRayTestContol1.Name = "xRayTestContol1";
            this.xRayTestContol1.Size = new System.Drawing.Size(660, 400);
            this.xRayTestContol1.TabIndex = 0;
            this.xRayTestContol1.Load += new System.EventHandler(this.xRayTestContol1_Load);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.angularTestControl1);
            this.tabPage2.Location = new System.Drawing.Point(154, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(607, 383);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ACISAL TARAMA TESTI";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // angularTestControl1
            // 
            this.angularTestControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angularTestControl1.Location = new System.Drawing.Point(0, 0);
            this.angularTestControl1.Margin = new System.Windows.Forms.Padding(0);
            this.angularTestControl1.Name = "angularTestControl1";
            this.angularTestControl1.Size = new System.Drawing.Size(660, 403);
            this.angularTestControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.verticalMovementTestControl1);
            this.tabPage3.Location = new System.Drawing.Point(154, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(607, 383);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "YATAY HAREKET TESTI";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // verticalMovementTestControl1
            // 
            this.verticalMovementTestControl1.Location = new System.Drawing.Point(0, -4);
            this.verticalMovementTestControl1.Name = "verticalMovementTestControl1";
            this.verticalMovementTestControl1.Size = new System.Drawing.Size(660, 400);
            this.verticalMovementTestControl1.TabIndex = 0;
            // 
            // tabKapakKontrol
            // 
            this.tabKapakKontrol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabKapakKontrol.Controls.Add(this.lidCoverControl1);
            this.tabKapakKontrol.Location = new System.Drawing.Point(154, 4);
            this.tabKapakKontrol.Name = "tabKapakKontrol";
            this.tabKapakKontrol.Padding = new System.Windows.Forms.Padding(3);
            this.tabKapakKontrol.Size = new System.Drawing.Size(607, 383);
            this.tabKapakKontrol.TabIndex = 3;
            this.tabKapakKontrol.Text = "KAPAK KONTROL";
            this.tabKapakKontrol.UseVisualStyleBackColor = true;
            // 
            // lidCoverControl1
            // 
            this.lidCoverControl1.Location = new System.Drawing.Point(0, -36);
            this.lidCoverControl1.Name = "lidCoverControl1";
            this.lidCoverControl1.Size = new System.Drawing.Size(600, 423);
            this.lidCoverControl1.TabIndex = 0;
            // 
            // DeviceTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabDeviceTestList);
            this.Name = "DeviceTestControl";
            this.Size = new System.Drawing.Size(645, 406);
            this.tabDeviceTestList.ResumeLayout(false);
            this.tabXrayTest.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabKapakKontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private void tabDeviceTestList_DrawItem(object sender, DrawItemEventArgs e)
        {

            //Get the working area of the TabControl main control
            Rectangle rec = tabDeviceTestList.ClientRectangle;
            //Create a StringFormat object to set the layout of the label text
            StringFormat StrFormat = new StringFormat();
            StrFormat.LineAlignment = StringAlignment.Center;// Set the text to be centered vertically
            StrFormat.Alignment = StringAlignment.Center;// Set the text to be centered horizontally

            // The background fill color of the label, it can also be a picture (e.Graphics.DrawImage)
            SolidBrush backColor = new SolidBrush(Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))));
            SolidBrush backColor2 = new SolidBrush(Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92))))));

            SolidBrush fontColor;// Label font color
                                 //Draw the background of the main control
            e.Graphics.FillRectangle(backColor2, rec);

            //Draw label style
            Font fntTab = e.Font;
            Brush bshBack = new SolidBrush(Color.White);

            for (int i = 0; i < tabDeviceTestList.TabPages.Count; i++)
            {
                bool bSelected = (tabDeviceTestList.SelectedIndex == i);
                Rectangle recBounds = tabDeviceTestList.GetTabRect(i);
                RectangleF tabTextArea = (RectangleF)tabDeviceTestList.GetTabRect(i);
                if (bSelected)
                {
                    e.Graphics.FillRectangle(bshBack, recBounds);
                    fontColor = new SolidBrush(Color.Black);
                    e.Graphics.DrawString(tabDeviceTestList.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
                else
                {
                    e.Graphics.FillRectangle(backColor2, recBounds);
                    fontColor = new SolidBrush(Color.White);
                    e.Graphics.DrawString(tabDeviceTestList.TabPages[i].Text, fntTab, fontColor, tabTextArea, StrFormat);
                }
            }
        }

        #endregion

        private System.Windows.Forms.TabControl tabDeviceTestList;
        private System.Windows.Forms.TabPage tabXrayTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private XRayTestContol xRayTestContol1;
        private AngularTestControl angularTestControl1;
        private VerticalMovementTestControl verticalMovementTestControl1;
        private TabPage tabKapakKontrol;
        private LidCoverControl lidCoverControl1;
    }
}
