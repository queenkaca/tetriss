using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush sb = new SolidBrush(Color.Black);
            Pen okvir = new Pen(Color.Gray, 5);
            Pen olovka = new Pen(Color.Gray, 1);

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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
