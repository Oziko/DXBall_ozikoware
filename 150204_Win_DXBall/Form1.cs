using System;
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

            if(misket.Left <= 0 || misket.Right >= ClientSize.Width)
            {
                x *= -1;
            }

            if(misket.Top <= 0 || misket.Bottom >= ClientSize.Height)
            {
                y *= -1;
            }
        }
    }
}
