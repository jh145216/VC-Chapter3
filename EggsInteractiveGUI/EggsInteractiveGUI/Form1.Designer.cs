namespace EggsInteractiveGUI
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
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClickToCalculate = new System.Windows.Forms.Button();
            this.txtChicken5 = new System.Windows.Forms.TextBox();
            this.txtChicken4 = new System.Windows.Forms.TextBox();
            this.txtChicken3 = new System.Windows.Forms.TextBox();
            this.txtChicken2 = new System.Windows.Forms.TextBox();
            this.txtChicken1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(100, 217);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(165, 23);
            this.lblResults.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter eggs produced by each of 5 chickens";
            // 
            // btnClickToCalculate
            // 
            this.btnClickToCalculate.Location = new System.Drawing.Point(23, 176);
            this.btnClickToCalculate.Name = "btnClickToCalculate";
            this.btnClickToCalculate.Size = new System.Drawing.Size(118, 23);
            this.btnClickToCalculate.TabIndex = 13;
            this.btnClickToCalculate.Text = "Click To Calculate";
            this.btnClickToCalculate.UseVisualStyleBackColor = true;
            this.btnClickToCalculate.Click += new System.EventHandler(this.btnClickToCalculate_Click);
            // 
            // txtChicken5
            // 
            this.txtChicken5.Location = new System.Drawing.Point(119, 119);
            this.txtChicken5.Name = "txtChicken5";
            this.txtChicken5.Size = new System.Drawing.Size(61, 20);
            this.txtChicken5.TabIndex = 12;
            // 
            // txtChicken4
            // 
            this.txtChicken4.Location = new System.Drawing.Point(23, 119);
            this.txtChicken4.Name = "txtChicken4";
            this.txtChicken4.Size = new System.Drawing.Size(66, 20);
            this.txtChicken4.TabIndex = 11;
            // 
            // txtChicken3
            // 
            this.txtChicken3.Location = new System.Drawing.Point(204, 72);
            this.txtChicken3.Name = "txtChicken3";
            this.txtChicken3.Size = new System.Drawing.Size(61, 20);
            this.txtChicken3.TabIndex = 10;
            // 
            // txtChicken2
            // 
            this.txtChicken2.Location = new System.Drawing.Point(119, 72);
            this.txtChicken2.Name = "txtChicken2";
            this.txtChicken2.Size = new System.Drawing.Size(61, 20);
            this.txtChicken2.TabIndex = 9;
            // 
            // txtChicken1
            // 
            this.txtChicken1.Location = new System.Drawing.Point(23, 72);
            this.txtChicken1.Name = "txtChicken1";
            this.txtChicken1.Size = new System.Drawing.Size(66, 20);
            this.txtChicken1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClickToCalculate);
            this.Controls.Add(this.txtChicken5);
            this.Controls.Add(this.txtChicken4);
            this.Controls.Add(this.txtChicken3);
            this.Controls.Add(this.txtChicken2);
            this.Controls.Add(this.txtChicken1);
            this.Name = "Form1";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClickToCalculate;
        private System.Windows.Forms.TextBox txtChicken5;
        private System.Windows.Forms.TextBox txtChicken4;
        private System.Windows.Forms.TextBox txtChicken3;
        private System.Windows.Forms.TextBox txtChicken2;
        private System.Windows.Forms.TextBox txtChicken1;
    }
}

