using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_I : Figura
    {
        int[,,] tetromino;

        public Figura_I()
        {
            // prvi broj je broj matrica, drugi je broj redova u matrici i treci je broj kolona u matrici
            tetromino = new int[4, 4, 4] {
                { { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                },
                {
                  { 0, 0, 0, 0 },
                  { -1, -1, -1, -1 },
                  { 0, 0, 0, 0 },
                  { 0, 0, 0, 0 }
                },
                { { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0, -1, 0 },
                },
                {
                  { 0, 0, 0, 0 },
                  { -1, -1, -1, -1 },
                  { 0, 0, 0, 0 },
                  { 0, 0, 0, 0 }
                }
            };
        }
        
        override public int[,,] Tetromino
        {
            get { return tetromino; }
        }

        public void Crtaj(Graphics g, Random random)
        {
            Color boja = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            
        }

    }
}
