using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _150204_Win_DXBall
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x = 2;
        int y = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            misket.Left += x;
            misket.Top += y;

            if(misket.Left <= 0 || misket.Right >= this.Width)
            {
                x *= -1;
            }

            if(misket.Top <= 0 || misket.Bottom >= this.Height)
            {
                y *= -1;
            }
        }
    }
}
