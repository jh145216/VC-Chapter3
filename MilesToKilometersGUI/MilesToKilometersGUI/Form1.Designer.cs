﻿namespace MilesToKilometersGUI
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
            this.btnCulcaluate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCulcaluate
            // 
            this.btnCulcaluate.Location = new System.Drawing.Point(76, 183);
            this.btnCulcaluate.Name = "btnCulcaluate";
            this.btnCulcaluate.Size = new System.Drawing.Size(73, 47);
            this.btnCulcaluate.TabIndex = 9;
            this.btnCulcaluate.Text = "Culcaluate";
            this.btnCulcaluate.UseVisualStyleBackColor = true;
            this.btnCulcaluate.Click += new System.EventHandler(this.btnCulcaluate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kilometers";
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(153, 112);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(100, 23);
            this.lblResults.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Miles";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(153, 32);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 20);
            this.txtMiles.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCulcaluate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMiles);
            this.Name = "Form1";
            this.Text = "Miles To Kilometers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCulcaluate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiles;
    }
}
