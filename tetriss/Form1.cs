﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace tetriss
{
    public partial class Form1 : Form
    {
        Igra igra;
        
        public Form1()
        {
            InitializeComponent();
        }
        private SoundPlayer soundPlayer;

        private void Form1_Load(object sender, EventArgs e)
        {
            igra = new Igra();
            // Initialize the SoundPlayer with the path to the audio filee
           // soundPlayer = new SoundPlayer(@"music.wav");

            // Play the sound in a loop
           // soundPlayer.PlayLooping();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color newLightPurple = ColorTranslator.FromHtml("#A08EB9");
            Color newLightYellow = ColorTranslator.FromHtml("#FCE6C1");

            SolidBrush sb = new SolidBrush(newLightPurple);
            Pen okvir = new Pen(newLightYellow, 5);
            Pen olovka = new Pen(newLightYellow, 1);

            //crtanje sredisnje table
            e.Graphics.FillRectangle(sb, 225, 50, 300, 660);
            e.Graphics.DrawRectangle(okvir, 225, 50, 300, 660);

            //crtanje leve table
            e.Graphics.FillRectangle(sb, 50, 50, 150, 150);
            e.Graphics.DrawRectangle(okvir, 50, 50, 150, 150);

            //crtanje mreze
            for (int i = 0; i < 10; i++)
            {
                e.Graphics.DrawLine(olovka, 225 + i * 30, 50, 225 + i * 30, 710);
            }
            for (int i = 0; i < 22; i++)
            {
                e.Graphics.DrawLine(olovka, 225, 50 + i * 30, 525, 50 + i*30);
            }

            Graphics g = CreateGraphics();
            Tabla t = new Tabla();
            Figura f = t.GenerisiFiguru();
            f.Crtaj(g);

            igra.CrtajSveFigure(g);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            igra.Unos();
            
        }
    }
}
