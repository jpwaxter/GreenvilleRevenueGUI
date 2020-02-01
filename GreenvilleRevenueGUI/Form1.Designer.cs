namespace GreenvilleRevenueGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtLastYearCount = new System.Windows.Forms.TextBox();
            this.txtThisYearCount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLastYearCount = new System.Windows.Forms.Label();
            this.lblThisYearCount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblComparison = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLastYearCount
            // 
            this.txtLastYearCount.Location = new System.Drawing.Point(184, 12);
            this.txtLastYearCount.Name = "txtLastYearCount";
            this.txtLastYearCount.Size = new System.Drawing.Size(100, 20);
            this.txtLastYearCount.TabIndex = 0;
            // 
            // txtThisYearCount
            // 
            this.txtThisYearCount.Location = new System.Drawing.Point(184, 40);
            this.txtThisYearCount.Name = "txtThisYearCount";
            this.txtThisYearCount.Size = new System.Drawing.Size(100, 20);
            this.txtThisYearCount.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 410);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblLastYearCount
            // 
            this.lblLastYearCount.AutoSize = true;
            this.lblLastYearCount.Location = new System.Drawing.Point(12, 16);
            this.lblLastYearCount.Name = "lblLastYearCount";
            this.lblLastYearCount.Size = new System.Drawing.Size(166, 13);
            this.lblLastYearCount.TabIndex = 3;
            this.lblLastYearCount.Text = "Number of Contestants Last Year:";
            // 
            // lblThisYearCount
            // 
            this.lblThisYearCount.AutoSize = true;
            this.lblThisYearCount.Location = new System.Drawing.Point(12, 43);
            this.lblThisYearCount.Name = "lblThisYearCount";
            this.lblThisYearCount.Size = new System.Drawing.Size(166, 13);
            this.lblThisYearCount.TabIndex = 4;
            this.lblThisYearCount.Text = "Number of Contestants This Year:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(112, 66);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblRevenue
            // 
            this.lblRevenue.AutoSize = true;
            this.lblRevenue.Location = new System.Drawing.Point(15, 95);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(112, 13);
            this.lblRevenue.TabIndex = 7;
            this.lblRevenue.Text = "This Year\'s Revenue: ";
            // 
            // lblComparison
            // 
            this.lblComparison.AutoSize = true;
            this.lblComparison.Location = new System.Drawing.Point(15, 119);
            this.lblComparison.Name = "lblComparison";
            this.lblComparison.Size = new System.Drawing.Size(124, 13);
            this.lblComparison.TabIndex = 8;
            this.lblComparison.Text = "Year to Year Comparison";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 566);
            this.Controls.Add(this.lblComparison);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblThisYearCount);
            this.Controls.Add(this.lblLastYearCount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtThisYearCount);
            this.Controls.Add(this.txtLastYearCount);
            this.Name = "Form1";
            this.Text = "Greenville Contestants";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastYearCount;
        private System.Windows.Forms.TextBox txtThisYearCount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLastYearCount;
        private System.Windows.Forms.Label lblThisYearCount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblComparison;
    }
}

