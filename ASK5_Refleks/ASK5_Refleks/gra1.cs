using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASK5_Refleks
{
    public partial class gra1 : Form
    {
        Random random;
        int ktora_strzalka=-1;

        int[] czas;
        int l_prob = 0;
        const int max_l_prob= 5;
        
        DateTime start;
        DateTime stop;

        public gra1()
        {
            InitializeComponent();
            random =  new Random();
            czas = new int[5];
            
            timer1.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            timer1.Enabled = false;
            ktora_strzalka = random.Next() % 4;
            switch (ktora_strzalka)
            {
                case 0:
                    pictureBox1.Visible = true;
                    break;
                case 1:
                    pictureBox2.Visible = true;
                    break;
                case 2:
                    pictureBox3.Visible = true;
                    break;
                case 3:
                    pictureBox4.Visible = true;
                    break;
            }

            start = DateTime.Now;


        }

        private void b_start_Click(object sender, EventArgs e)
        {

            b_start.Enabled = false;
            l_czas.Text = "";
            l_prob = 0;
            l_czas.Text = "Twoje czasy:\n";

            timer1.Interval = (int)(2000*random.NextDouble()+1000);
            timer1.Enabled = true;
        }

        private void gra1_KeyDown(object sender, KeyEventArgs e)
        {
            if (l_prob < max_l_prob)
            {
                switch (ktora_strzalka)
                {
                    case 0:
                        if (e.KeyCode == Keys.Right)
                        {
                            stop = DateTime.Now;
                            czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                            l_czas.Text += czas[l_prob].ToString() + " ms\n";
                            l_prob++;
                            pictureBox1.Visible = false;
                            ktora_strzalka = -1;
                            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                            timer1.Enabled = true;
                            
                        }
                        else
                        {
                            start = start.AddSeconds(-1);
                        }
                        break;
                    case 1:
                        if (e.KeyCode == Keys.Left)
                        {
                            stop = DateTime.Now;
                            czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                            l_czas.Text += czas[l_prob].ToString() + " ms\n";
                            l_prob++;
                            pictureBox2.Visible = false;
                            ktora_strzalka = -1;
                            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                            timer1.Enabled = true;
                        }
                        else
                        {
                            start = start.AddSeconds(-1);
                        }
                        break;
                    case 2:
                        if (e.KeyCode == Keys.Up)
                        {
                            stop = DateTime.Now;
                            czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                            l_czas.Text += czas[l_prob].ToString() + " ms\n";
                            l_prob++;
                            pictureBox3.Visible = false;
                            ktora_strzalka = -1;
                            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                            timer1.Enabled = true;
                        }
                        else
                        {
                            start=start.AddSeconds(-1);
                        }
                        break;
                    case 3:
                        if (e.KeyCode == Keys.Down)
                        {
                            stop = DateTime.Now;
                            czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                            l_czas.Text += czas[l_prob].ToString() + " ms\n";
                            l_prob++;
                            pictureBox4.Visible = false;
                            ktora_strzalka = -1;
                            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                            timer1.Enabled = true;
                        }
                        else
                        {
                            start = start.AddSeconds(-1);
                        }
                        break;

                }

                if (l_prob >= max_l_prob)
                {
                    timer1.Enabled = false;
                    double sr_czas = 0;

                    for (int i = 0; i < max_l_prob; i++)
                    {
                        sr_czas += czas[i];

                    }
                    sr_czas /= max_l_prob;
                    l_czas.Text += "\nŚredni czas:\n " + sr_czas.ToString() + " ms\n";
                    b_start.Enabled = true;

                }
            }
            
        }

        private void gra1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left:
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
                
        }

        private void b_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gra1_Load(object sender, EventArgs e)
        {

        }
    }
}
