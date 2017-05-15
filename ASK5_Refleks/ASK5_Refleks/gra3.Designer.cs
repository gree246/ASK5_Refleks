namespace ASK5_Refleks
{
    partial class gra3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gra3));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.b_koniec = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.l_czas = new System.Windows.Forms.Label();
            this.pic_cow = new System.Windows.Forms.PictureBox();
            this.pic_dog = new System.Windows.Forms.PictureBox();
            this.l_opis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dog)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // b_koniec
            // 
            this.b_koniec.Location = new System.Drawing.Point(541, 407);
            this.b_koniec.Name = "b_koniec";
            this.b_koniec.Size = new System.Drawing.Size(310, 46);
            this.b_koniec.TabIndex = 9;
            this.b_koniec.Text = "Wyjdź";
            this.b_koniec.UseVisualStyleBackColor = true;
            this.b_koniec.Click += new System.EventHandler(this.b_koniec_Click);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(26, 407);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(310, 46);
            this.b_start.TabIndex = 8;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // l_czas
            // 
            this.l_czas.AutoSize = true;
            this.l_czas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.l_czas.Location = new System.Drawing.Point(552, 24);
            this.l_czas.Name = "l_czas";
            this.l_czas.Size = new System.Drawing.Size(0, 36);
            this.l_czas.TabIndex = 10;
            this.l_czas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pic_cow
            // 
            this.pic_cow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_cow.Image = ((System.Drawing.Image)(resources.GetObject("pic_cow.Image")));
            this.pic_cow.Location = new System.Drawing.Point(53, 63);
            this.pic_cow.Name = "pic_cow";
            this.pic_cow.Size = new System.Drawing.Size(210, 236);
            this.pic_cow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cow.TabIndex = 11;
            this.pic_cow.TabStop = false;
            this.pic_cow.Visible = false;
            this.pic_cow.Click += new System.EventHandler(this.pic_cow_Click);
            // 
            // pic_dog
            // 
            this.pic_dog.Image = ((System.Drawing.Image)(resources.GetObject("pic_dog.Image")));
            this.pic_dog.Location = new System.Drawing.Point(305, 63);
            this.pic_dog.Name = "pic_dog";
            this.pic_dog.Size = new System.Drawing.Size(210, 236);
            this.pic_dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_dog.TabIndex = 12;
            this.pic_dog.TabStop = false;
            this.pic_dog.Visible = false;
            this.pic_dog.Click += new System.EventHandler(this.pic_dog_Click);
            // 
            // l_opis
            // 
            this.l_opis.AutoSize = true;
            this.l_opis.Location = new System.Drawing.Point(23, 467);
            this.l_opis.Name = "l_opis";
            this.l_opis.Size = new System.Drawing.Size(426, 51);
            this.l_opis.TabIndex = 13;
            this.l_opis.Text = "W losowych odstpępach czasu usłyszysz jeden z dwóch dźwięków:\r\nmuczenie krowy lub" +
    " szczekanie psa.\r\nJak najszybciej klikaj w odpowidni obrazek.";
            // 
            // gra3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.l_opis);
            this.Controls.Add(this.pic_dog);
            this.Controls.Add(this.pic_cow);
            this.Controls.Add(this.l_czas);
            this.Controls.Add(this.b_koniec);
            this.Controls.Add(this.b_start);
            this.Name = "gra3";
            this.Text = "gra3";
            ((System.ComponentModel.ISupportInitialize)(this.pic_cow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button b_koniec;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Label l_czas;
        private System.Windows.Forms.PictureBox pic_cow;
        private System.Windows.Forms.PictureBox pic_dog;
        private System.Windows.Forms.Label l_opis;
    }
}