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
    public partial class gra2 : Form
    {
        Random random;
        
        int[] czas;
        int l_prob = 0;
        int max_l_prob = 5;

        DateTime start;
        DateTime stop;

        public gra2()
        {
            InitializeComponent();
            random = new Random();
            

            
            timer1.Enabled = false;
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            b_start.Enabled = false;
            chart1.Visible = false;
            l_czas.Visible = false;
            numericUpDown1.Enabled = false;
            max_l_prob = (int)numericUpDown1.Value;
            czas = new int[max_l_prob];
            l_czas.Text = "Twoje czasy:\n";
            klikacz.Width = 75;
            klikacz.Height = 75;
            l_prob = 0;
            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            if(klikacz.Width>10) klikacz.Size = new Size((int)(klikacz.Width*0.95), (int)(klikacz.Height*0.95));
            klikacz.Location = new Point(random.Next() % (panel1.Width - klikacz.Width), random.Next() % (panel1.Height - klikacz.Height));
           
            klikacz.Visible = true;
            start = DateTime.Now;
        }

        private void b_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void klikacz_Click(object sender, EventArgs e)
        {
            stop = DateTime.Now;
            czas[l_prob] = (int)(stop - start).TotalMilliseconds;
            l_prob++;
            klikacz.Visible = false;
            if (l_prob < max_l_prob)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                double sr_czas = 0;

                for (int i = 0; i < max_l_prob; i++)
                {
                    sr_czas += czas[i];
                    l_czas.Text += czas[i].ToString() + " ms\n";

                }
                sr_czas /= max_l_prob;
                l_czas.Text += "\nŚredni czas:\n " + sr_czas.ToString() + " ms\n";
                chart1.Series[0].Points.DataBindY(czas);
                chart1.Visible = true;
                l_czas.Visible = true;

                b_start.Enabled = true;
                numericUpDown1.Enabled = true;
            }
            
        }
    }
}
