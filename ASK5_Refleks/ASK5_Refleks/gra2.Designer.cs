namespace ASK5_Refleks
{
    partial class gra2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gra2));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.l_opis = new System.Windows.Forms.Label();
            this.b_koniec = new System.Windows.Forms.Button();
            this.b_start = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.l_czas = new System.Windows.Forms.Label();
            this.klikacz = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_opis
            // 
            this.l_opis.AutoSize = true;
            this.l_opis.Location = new System.Drawing.Point(39, 489);
            this.l_opis.Name = "l_opis";
            this.l_opis.Size = new System.Drawing.Size(560, 51);
            this.l_opis.TabIndex = 9;
            this.l_opis.Text = resources.GetString("l_opis.Text");
            // 
            // b_koniec
            // 
            this.b_koniec.Location = new System.Drawing.Point(759, 429);
            this.b_koniec.Name = "b_koniec";
            this.b_koniec.Size = new System.Drawing.Size(310, 46);
            this.b_koniec.TabIndex = 11;
            this.b_koniec.Text = "Wyjdź";
            this.b_koniec.UseVisualStyleBackColor = true;
            this.b_koniec.Click += new System.EventHandler(this.b_koniec_Click);
            // 
            // b_start
            // 
            this.b_start.Location = new System.Drawing.Point(42, 429);
            this.b_start.Name = "b_start";
            this.b_start.Size = new System.Drawing.Size(310, 46);
            this.b_start.TabIndex = 10;
            this.b_start.Text = "START";
            this.b_start.UseVisualStyleBackColor = true;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.l_czas);
            this.panel1.Controls.Add(this.klikacz);
            this.panel1.Location = new System.Drawing.Point(51, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 414);
            this.panel1.TabIndex = 12;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(18, 14);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(680, 382);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "wykres";
            this.chart1.Visible = false;
            // 
            // l_czas
            // 
            this.l_czas.AutoSize = true;
            this.l_czas.Location = new System.Drawing.Point(704, 14);
            this.l_czas.Name = "l_czas";
            this.l_czas.Size = new System.Drawing.Size(46, 17);
            this.l_czas.TabIndex = 1;
            this.l_czas.Text = "label1";
            this.l_czas.Visible = false;
            // 
            // klikacz
            // 
            this.klikacz.BackColor = System.Drawing.Color.Red;
            this.klikacz.Location = new System.Drawing.Point(871, 303);
            this.klikacz.Name = "klikacz";
            this.klikacz.Size = new System.Drawing.Size(75, 75);
            this.klikacz.TabIndex = 0;
            this.klikacz.Visible = false;
            this.klikacz.Click += new System.EventHandler(this.klikacz_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(474, 442);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(47, 22);
            this.numericUpDown1.TabIndex = 13;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Liczba prób:";
            // 
            // gra2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 546);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.l_opis);
            this.Controls.Add(this.b_koniec);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.panel1);
            this.Name = "gra2";
            this.Text = "gra2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_opis;
        private System.Windows.Forms.Button b_koniec;
        private System.Windows.Forms.Button b_start;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel klikacz;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label l_czas;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}