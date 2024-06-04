using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetriss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SoundPlayer soundPlayer;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the SoundPlayer with the path to the audio filee
            soundPlayer = new SoundPlayer(@"C:\Users\Radovanovic\Downloads\lofitet.wav");

            // Play the sound in a loop
            soundPlayer.PlayLooping();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color newLightPurple = ColorTranslator.FromHtml("#A08EB9");
            Color newLightYellow = ColorTranslator.FromHtml("#FCE6C1");

            SolidBrush sb = new SolidBrush(newLightPurple);
            Pen okvir = new Pen(newLightYellow, 5);
            Pen olovka = new Pen(newLightYellow, 1);

            //crtanje sredisnje table
            e.Graphics.FillRectangle(sb, 225, 50, 300, 600);
            e.Graphics.DrawRectangle(okvir, 225, 50, 300, 600);

            //crtanje leve table
            e.Graphics.FillRectangle(sb, 50, 50, 150, 150);
            e.Graphics.DrawRectangle(okvir, 50, 50, 150, 150);

            //crtanje mreze
            for (int i = 0; i < 10; i++)
            {
                e.Graphics.DrawLine(olovka, 225 + i * 30, 50, 225 + i * 30, 650);
            }
            for (int i = 0; i < 20; i++)
            {
                e.Graphics.DrawLine(olovka, 225, 50 + i * 30, 525, 50 + i*30);
            }
            Graphics g = CreateGraphics();
            Random random = new Random();
            Figura_J f = new Figura_J(5, 5, 1);
            f.Crtaj(g, random);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
