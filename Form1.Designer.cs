namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Step1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Step2 = new System.Windows.Forms.Label();
            this.Step3 = new System.Windows.Forms.Label();
            this.Step4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Step0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter The degree you want to rotate your picture by.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 2: Horizontal Skew by: ";
            // 
            // Step1
            // 
            this.Step1.AutoSize = true;
            this.Step1.Location = new System.Drawing.Point(294, 116);
            this.Step1.Name = "Step1";
            this.Step1.Size = new System.Drawing.Size(0, 17);
            this.Step1.TabIndex = 3;
            this.Step1.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step 3: Vertical Stretch by:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Step 4: Vertical Skew by:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Step 5: Horizontal + Vertical stretch by:";
            // 
            // Step2
            // 
            this.Step2.AutoSize = true;
            this.Step2.Location = new System.Drawing.Point(297, 152);
            this.Step2.Name = "Step2";
            this.Step2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Step2.Size = new System.Drawing.Size(0, 17);
            this.Step2.TabIndex = 7;
            this.Step2.Click += new System.EventHandler(this.label6_Click);
            // 
            // Step3
            // 
            this.Step3.AutoSize = true;
            this.Step3.Location = new System.Drawing.Point(294, 184);
            this.Step3.Name = "Step3";
            this.Step3.Size = new System.Drawing.Size(0, 17);
            this.Step3.TabIndex = 8;
            this.Step3.Click += new System.EventHandler(this.label7_Click);
            // 
            // Step4
            // 
            this.Step4.AutoSize = true;
            this.Step4.Location = new System.Drawing.Point(294, 224);
            this.Step4.Name = "Step4";
            this.Step4.Size = new System.Drawing.Size(0, 17);
            this.Step4.TabIndex = 9;
            this.Step4.Click += new System.EventHandler(this.label8_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(19, 38);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(138, 22);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Step 1:";
            // 
            // Step0
            // 
            this.Step0.AutoSize = true;
            this.Step0.Location = new System.Drawing.Point(75, 77);
            this.Step0.Name = "Step0";
            this.Step0.Size = new System.Drawing.Size(0, 17);
            this.Step0.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 427);
            this.Controls.Add(this.Step0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Step4);
            this.Controls.Add(this.Step3);
            this.Controls.Add(this.Step2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Step1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "msrotate 3000";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Step1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Step2;
        private System.Windows.Forms.Label Step3;
        private System.Windows.Forms.Label Step4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Step0;
    }
}

