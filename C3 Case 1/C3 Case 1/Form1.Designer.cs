namespace C3_Case_1
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtThisYear = new System.Windows.Forms.TextBox();
            this.txtlastYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(220, 141);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(127, 125);
            this.lblOutput.TabIndex = 20;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(111, 243);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(91, 23);
            this.btnGenerate.TabIndex = 19;
            this.btnGenerate.Text = "Generate Data";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtThisYear
            // 
            this.txtThisYear.Location = new System.Drawing.Point(220, 90);
            this.txtThisYear.Name = "txtThisYear";
            this.txtThisYear.Size = new System.Drawing.Size(127, 20);
            this.txtThisYear.TabIndex = 18;
            // 
            // txtlastYear
            // 
            this.txtlastYear.Location = new System.Drawing.Point(220, 49);
            this.txtlastYear.Name = "txtlastYear";
            this.txtlastYear.Size = new System.Drawing.Size(127, 20);
            this.txtlastYear.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Data Present";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Number of participants of this year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Number of participants of last year";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 325);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtThisYear);
            this.Controls.Add(this.txtlastYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GreenvilleRevenueGUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtThisYear;
        private System.Windows.Forms.TextBox txtlastYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

