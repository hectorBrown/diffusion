using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diffusion
{
    public partial class Form1 : Form
    {
        readonly static int arrSize = 1000;
        readonly int particleSize = 5;
        readonly int speed = 5;
        Rectangle[] particles = new Rectangle[arrSize];
        SolidBrush[] colors = new SolidBrush[arrSize];
        Point center;
        readonly int repulseThreshold = 50;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            center = new Point(PB_main.Width / 2, PB_main.Height / 2);
            for (int i = 0; i <= arrSize - 1; i++)
            {
                particles[i] = new Rectangle(center, new Size(particleSize, particleSize));
                colors[i] = new SolidBrush(Color.FromArgb(0, 0, 255));
            }
            PB_main.BackColor = Color.Black;
        }

        private void TIM_main_Tick(object sender, EventArgs e)
        {
            Random rng = new Random();
            Point repulse = MousePosition;
            for (int i = 0; i <= arrSize - 1; i++)
            {
                int angle = rng.Next(0, 360);
                Point particleCenter = new Point(particles[i].Left + particleSize / 2, particles[i].Top + particleSize / 2);
                double distanceFromRepulse = Math.Sqrt(Math.Pow(particleCenter.X - repulse.X, 2) + Math.Pow(particleCenter.Y - repulse.Y, 2));
                if (distanceFromRepulse <= repulseThreshold)
                {
                    double angleToRepulse;
                    try
                    {
                        angleToRepulse = Math.Atan((repulse.X - particleCenter.X) / (particleCenter.Y - repulse.Y));
                    }
                    catch
                    {
                        angleToRepulse = angle;
                    }
                    angle = Convert.ToInt32(Math.Round(angleToRepulse + 180, 0));
                    if (angle >= 360)
                    {
                        angle -= 360;
                    }
                }
                double speedx, speedy;
                speedx = speed * Math.Sin(angle);
                speedy = speed * Math.Cos(angle);
                particles[i].X += Convert.ToInt32(Math.Round(speedx, 0));
                particles[i].Y += Convert.ToInt32(Math.Round(speedy, 0));
                if (particles[i].Left < 0)
                {
                    particles[i].X = 0;
                }
                else if (particles[i].Right > PB_main.Width)
                {
                    particles[i].X = PB_main.Width - particleSize;
                }
                if (particles[i].Top < 0)
                {
                    particles[i].Y = 0;
                }
                else if (particles[i].Bottom > PB_main.Height)
                {
                    particles[i].Y = PB_main.Height - particleSize;
                }
            }
            PB_main.Refresh();
        }
        private void PB_main_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i <= arrSize - 1; i++)
            {
                g.FillRectangle(colors[i], particles[i]);
            }
        }
    }
}
