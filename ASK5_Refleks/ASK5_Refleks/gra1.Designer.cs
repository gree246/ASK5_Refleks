﻿namespace ASK5_Refleks
{
    partial class gra1
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
            this.components = new System.ComponentModel.Container();
            this.l_czas = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.l_opis = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_czas
            // 
            this.l_czas.AutoSize = true;
            this.l_czas.Location = new System.Drawing.Point(795, 26);
            this.l_czas.Name = "l_czas";
            this.l_czas.Size = new System.Drawing.Size(46, 17);
            this.l_czas.TabIndex = 0;
            this.l_czas.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::ASK5_Refleks.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(392, 125);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // l_opis
            // 
            this.l_opis.AutoSize = true;
            this.l_opis.Location = new System.Drawing.Point(144, 387);
            this.l_opis.Name = "l_opis";
            this.l_opis.Size = new System.Drawing.Size(81, 17);
            this.l_opis.TabIndex = 2;
            this.l_opis.Text = "Opis todo...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(322, 271);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(326, 77);
            this.b_start.TabIndex = 3;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // gra1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 468);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.l_opis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.l_czas);
            this.Name = "gra1";
            this.Text = "gra1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_czas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label l_opis;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_start;
    }
}