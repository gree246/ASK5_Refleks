namespace ASK5_Refleks
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
            this.b_gra1 = new System.Windows.Forms.Button();
            this.b_gra2 = new System.Windows.Forms.Button();
            this.b_gra3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_gra1
            // 
            this.b_gra1.Location = new System.Drawing.Point(12, 61);
            this.b_gra1.Name = "b_gra1";
            this.b_gra1.Size = new System.Drawing.Size(350, 51);
            this.b_gra1.TabIndex = 0;
            this.b_gra1.Text = "Gra 1";
            this.b_gra1.UseVisualStyleBackColor = true;
            this.b_gra1.Click += new System.EventHandler(this.b_gra1_Click);
            // 
            // b_gra2
            // 
            this.b_gra2.Location = new System.Drawing.Point(12, 201);
            this.b_gra2.Name = "b_gra2";
            this.b_gra2.Size = new System.Drawing.Size(350, 46);
            this.b_gra2.TabIndex = 1;
            this.b_gra2.Text = "Gra 2";
            this.b_gra2.UseVisualStyleBackColor = true;
            this.b_gra2.Click += new System.EventHandler(this.b_gra2_Click);
            // 
            // b_gra3
            // 
            this.b_gra3.Location = new System.Drawing.Point(12, 380);
            this.b_gra3.Name = "b_gra3";
            this.b_gra3.Size = new System.Drawing.Size(350, 40);
            this.b_gra3.TabIndex = 2;
            this.b_gra3.Text = "button3";
            this.b_gra3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 533);
            this.Controls.Add(this.b_gra3);
            this.Controls.Add(this.b_gra2);
            this.Controls.Add(this.b_gra1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_gra1;
        private System.Windows.Forms.Button b_gra2;
        private System.Windows.Forms.Button b_gra3;
    }
}

