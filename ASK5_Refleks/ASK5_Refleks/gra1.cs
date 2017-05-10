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
        int ktora_strzalka;

        int[] czas;
        int l_prob = 0;

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
            ktora_strzalka = random.Next() % 1;
            switch (ktora_strzalka)
            {
                case 0:
                    pictureBox1.Visible = true;
                    break;
            }

            DateTime start = DateTime.Now;


        }

        private void b_start_Click(object sender, EventArgs e)
        {
            b_start.Visible = false;
            timer1.Interval = (int)(2000*random.NextDouble()+1000);
            timer1.Enabled = true;
        }
    }
}
