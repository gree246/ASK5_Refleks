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
    public partial class gra3 : Form
    {
        Random random;
        int ktory_dzwiek = -1;

        int[] czas;
        int l_prob = 0;
        const int max_l_prob = 5;

        DateTime start;
        DateTime stop;

        System.Media.SoundPlayer krowa;
        System.Media.SoundPlayer pies;

        public gra3()
        {
            InitializeComponent();
            random = new Random();
            czas = new int[5];

            timer1.Enabled = false;

            krowa = new System.Media.SoundPlayer(@"C:\Users\Krzysztof\Source\Repos\ASK5_Refleks\ASK5_Refleks\ASK5_Refleks\cow-moo2.wav");
            pies = new System.Media.SoundPlayer(@"C:\Users\Krzysztof\Source\Repos\ASK5_Refleks\ASK5_Refleks\ASK5_Refleks\dog_bark_x.wav");
        }

        private void b_koniec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_start_Click(object sender, EventArgs e)
        {
            b_start.Enabled = false;
            l_czas.Text = "";
            l_prob = 0;
            l_czas.Text = "Twoje czasy:\n";

            pic_cow.Visible = true;
            pic_dog.Visible = true;

            timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ktory_dzwiek = random.Next() % 2;
            switch (ktory_dzwiek)
            {
                case 0:
                    krowa.Play();
                    break;
                case 1:
                    pies.Play();
                    break;
            }
            start = DateTime.Now;
        }

        private void pic_cow_Click(object sender, EventArgs e)
        {
            if (l_prob < max_l_prob)
            {
                switch (ktory_dzwiek)
                {
                    case 0:
                        stop = DateTime.Now;
                        czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                        l_czas.Text += czas[l_prob].ToString() + " ms\n";
                        l_prob++;
                        ktory_dzwiek = -1;
                        timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                        timer1.Enabled = true;
                        break;
                    case 1:
                        start = start.AddSeconds(-1);

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

        private void pic_dog_Click(object sender, EventArgs e)
        {
            if (l_prob < max_l_prob)
            {
                switch (ktory_dzwiek)
                {
                    case 1:
                        stop = DateTime.Now;
                        czas[l_prob] = (int)(stop - start).TotalMilliseconds;
                        l_czas.Text += czas[l_prob].ToString() + " ms\n";
                        l_prob++;
                        ktory_dzwiek = -1;
                        timer1.Interval = (int)(2000 * random.NextDouble() + 1000);
                        timer1.Enabled = true;
                        break;
                    case 0:
                        start = start.AddSeconds(-1);

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
    }
}
