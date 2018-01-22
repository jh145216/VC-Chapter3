namespace Hello_Visual_World
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
            this.btnClickherelast = new System.Windows.Forms.Button();
            this.btnClickHere = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickherelast
            // 
            this.btnClickherelast.Location = new System.Drawing.Point(96, 171);
            this.btnClickherelast.Name = "btnClickherelast";
            this.btnClickherelast.Size = new System.Drawing.Size(96, 23);
            this.btnClickherelast.TabIndex = 5;
            this.btnClickherelast.Text = "Click here last";
            this.btnClickherelast.UseVisualStyleBackColor = true;
            this.btnClickherelast.Click += new System.EventHandler(this.btnClickherelast_Click);
            // 
            // btnClickHere
            // 
            this.btnClickHere.Location = new System.Drawing.Point(105, 124);
            this.btnClickHere.Name = "btnClickHere";
            this.btnClickHere.Size = new System.Drawing.Size(75, 23);
            this.btnClickHere.TabIndex = 4;
            this.btnClickHere.Text = "Click here";
            this.btnClickHere.UseVisualStyleBackColor = true;
            this.btnClickHere.Click += new System.EventHandler(this.btnClickHere_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.AutoSize = true;
            this.lblHelloWorld.Location = new System.Drawing.Point(93, 69);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(99, 13);
            this.lblHelloWorld.TabIndex = 3;
            this.lblHelloWorld.Text = "Hello, Visual World!";
            this.lblHelloWorld.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnClickherelast);
            this.Controls.Add(this.btnClickHere);
            this.Controls.Add(this.lblHelloWorld);
            this.Name = "Form1";
            this.Text = "Hello Visual World";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickherelast;
        private System.Windows.Forms.Button btnClickHere;
        private System.Windows.Forms.Label lblHelloWorld;
    }
}

