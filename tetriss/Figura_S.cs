using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_S : Figura
    {
        public Figura_S()
        {
            tetromino = new int[4, 4, 4]{
                { { 0,  0, 0, 0 },
                  { 0, -1,-1, 0 },
                  {-1, -1, 0, 0 },
                  { 0,  0, 0, 0 },
                },
                {
                  { 0,  0,  0, 0},
                  { 0, -1,  0, 0},
                  { 0, -1, -1, 0},
                  { 0,  0, -1, 0}
                },
                { 
                  { 0, 0,  0, 0 },
                  { 0, 0, -1,-1 },
                  { 0,-1, -1, 0 },
                  { 0, 0,  0, 0 }
                },
                { { 0,-1,  0, 0 },
                  { 0,-1, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0,  0, 0 }
                }
            };
        }
        int[,,] tetromino;
        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
        public void Crtaj(Graphics g, Random random)
        {
            Color boja = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

        }
    }
}
