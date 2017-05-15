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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_gra1_Click(object sender, EventArgs e)
        {
            gra1 gra = new gra1();
            gra.Show();
        }

        private void b_gra2_Click(object sender, EventArgs e)
        {
            gra2 gra = new gra2();
            gra.Show();
        }

        private void b_gra3_Click(object sender, EventArgs e)
        {
            gra3 gra = new gra3();
            gra.Show();
        }
    }
}
