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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMovementDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerticalMovementTest
            // 
            this.lblVerticalMovementTest.AutoSize = true;
            this.lblVerticalMovementTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblVerticalMovementTest.Location = new System.Drawing.Point(221, 30);
            this.lblVerticalMovementTest.Name = "lblVerticalMovementTest";
            this.lblVerticalMovementTest.Size = new System.Drawing.Size(221, 25);
            this.lblVerticalMovementTest.TabIndex = 6;
            this.lblVerticalMovementTest.Text = "Yatay Hareket Testi";
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Location = new System.Drawing.Point(249, 170);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(73, 13);
            this.lblDirection.TabIndex = 7;
            this.lblDirection.Text = "Hareket Yonu";
            this.lblDirection.Click += new System.EventHandler(this.lblDirection_Click);
            // 
            // lblMovementDistance
            // 
            this.lblMovementDistance.AutoSize = true;
            this.lblMovementDistance.Location = new System.Drawing.Point(249, 239);
            this.lblMovementDistance.Name = "lblMovementDistance";
            this.lblMovementDistance.Size = new System.Drawing.Size(115, 13);
            this.lblMovementDistance.TabIndex = 8;
            this.lblMovementDistance.Text = "Hareket Mesafesi (mm)";
            this.lblMovementDistance.Click += new System.EventHandler(this.lblMovementDistance_Click);
            // 
            // btnVerticalMovementTestStart
            // 
            this.btnVerticalMovementTestStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(121)))), ((int)(((byte)(184)))));
            this.btnVerticalMovementTestStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnVerticalMovementTestStart.Location = new System.Drawing.Point(210, 303);
            this.btnVerticalMovementTestStart.Name = "btnVerticalMovementTestStart";
            this.btnVerticalMovementTestStart.Size = new System.Drawing.Size(242, 42);
            this.btnVerticalMovementTestStart.TabIndex = 9;
            this.btnVerticalMovementTestStart.Text = "TEST BASLAT";
            this.btnVerticalMovementTestStart.UseVisualStyleBackColor = false;
            this.btnVerticalMovementTestStart.Click += new System.EventHandler(this.btnVerticalMovementTestStart_Click);
            // 
            // numMovementDistance
            // 
            this.numMovementDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.numMovementDistance.Location = new System.Drawing.Point(252, 255);
            this.numMovementDistance.Name = "numMovementDistance";
            this.numMovementDistance.Size = new System.Drawing.Size(164, 31);
            this.numMovementDistance.TabIndex = 10;
            this.numMovementDistance.ValueChanged += new System.EventHandler(this.numMovementDistance_ValueChanged);
            // 
            // cmbDirection
            // 
            this.cmbDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cmbDirection.FormattingEnabled = true;
            this.cmbDirection.Items.AddRange(new object[] {
            "SOL",
            "SAG"});
            this.cmbDirection.Location = new System.Drawing.Point(252, 186);
            this.cmbDirection.Name = "cmbDirection";
            this.cmbDirection.Size = new System.Drawing.Size(164, 33);
            this.cmbDirection.TabIndex = 11;
            this.cmbDirection.SelectedIndexChanged += new System.EventHandler(this.cmbDirection_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(196, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 86);
            this.label1.TabIndex = 18;
            this.label1.Text = "Lütfen hareket yönünü ve hareket mesafesini girin. Ardından “Testi Başlat” butonu" +
    "na tıklayarak yatay hareket testini başlatabilirsiniz.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VerticalMovementTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDirection);
            this.Controls.Add(this.numMovementDistance);
            this.Controls.Add(this.btnVerticalMovementTestStart);
            this.Controls.Add(this.lblMovementDistance);
            this.Controls.Add(this.lblDirection);
            this.Controls.Add(this.lblVerticalMovementTest);
            this.Name = "VerticalMovementTestControl";
            this.Size = new System.Drawing.Size(660, 400);
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
        private System.Windows.Forms.Label label1;
    }
}
