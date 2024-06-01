namespace OptomoMedicalDevice
{
    partial class VerticalMovementTestControl
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
            this.lblVerticalMovementTest = new System.Windows.Forms.Label();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblMovementDistance = new System.Windows.Forms.Label();
            this.btnVerticalMovementTestStart = new System.Windows.Forms.Button();
            this.numMovementDistance = new System.Windows.Forms.NumericUpDown();
            this.cmbDirection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMovementDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerticalMovementTest
            // 
            this.lblVerticalMovementTest.AutoSize = true;
            this.lblVerticalMovementTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVerticalMovementTest.Location = new System.Drawing.Point(93, 24);
            this.lblVerticalMovementTest.Name = "lblVerticalMovementTest";
            this.lblVerticalMovementTest.Size = new System.Drawing.Size(343, 31);
            this.lblVerticalMovementTest.TabIndex = 6;
            this.lblVerticalMovementTest.Text = "YATAY HAREKET TESTI";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(162, 93);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(73, 13);
            this.lblDirection.TabIndex = 7;
            this.lblDirection.Text = "Hareket Yonu";
            // 
            // lblMovementDistance
            // 
            this.lblMovementDistance.AutoSize = true;
            this.lblMovementDistance.Location = new System.Drawing.Point(120, 118);
            this.lblMovementDistance.Name = "lblMovementDistance";
            this.lblMovementDistance.Size = new System.Drawing.Size(115, 13);
            this.lblMovementDistance.TabIndex = 8;
            this.lblMovementDistance.Text = "Hareket Mesafesi (mm)";
            // 
            // btnVerticalMovementTestStart
            // 
            this.btnVerticalMovementTestStart.Location = new System.Drawing.Point(284, 151);
            this.btnVerticalMovementTestStart.Name = "btnVerticalMovementTestStart";
            this.btnVerticalMovementTestStart.Size = new System.Drawing.Size(121, 29);
            this.btnVerticalMovementTestStart.TabIndex = 9;
            this.btnVerticalMovementTestStart.Text = "TEST BASLAT";
            this.btnVerticalMovementTestStart.UseVisualStyleBackColor = true;
            this.btnVerticalMovementTestStart.Click += new System.EventHandler(this.btnVerticalMovementTestStart_Click);
            // 
            // numMovementDistance
            // 
            this.numMovementDistance.Location = new System.Drawing.Point(241, 116);
            this.numMovementDistance.Name = "numMovementDistance";
            this.numMovementDistance.Size = new System.Drawing.Size(164, 20);
            this.numMovementDistance.TabIndex = 10;
            // 
            // cmbDirection
            // 
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "SOL",
            "SAG"});
            this.cmbDirection.Location = new System.Drawing.Point(241, 85);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(164, 21);
            this.cmbDirection.TabIndex = 11;
            // 
            // VerticalMovementTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbDirection);
            this.Controls.Add(this.numMovementDistance);
            this.Controls.Add(this.btnVerticalMovementTestStart);
            this.Controls.Add(this.lblMovementDistance);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblVerticalMovementTest);
            this.Name = "VerticalMovementTestControl";
            this.Size = new System.Drawing.Size(558, 355);
            ((System.ComponentModel.ISupportInitialize)(this.numMovementDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerticalMovementTest;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblMovementDistance;
        private System.Windows.Forms.Button btnVerticalMovementTestStart;
        private System.Windows.Forms.NumericUpDown numMovementDistance;
        private System.Windows.Forms.ComboBox cmbDirection;
    }
}
