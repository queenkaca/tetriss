using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_J : Figura
    {
        int[,,] tetromino;
        public Figura_J()
        {
        tetromino = new int[4, 4, 4] {
                { { 0, 0,  -1, 0 },
                  { 0, 0,  -1, 0 },
                  { 0, -1, -1, 0 },
                  { 0, 0, 0, 0   },
                },
                { { 0,   0,  0, 0},
                  { -1, -1, -1, 0},
                  { 0, 0,   -1, 0},
                  { 0, 0,    0, 0}
                },
                { { 0, 0, 0, 0 },
                  { 0, -1, -1, 0 },
                  { 0, -1, 0, 0 },
                  { 0, -1, 0, 0 },
                },
                { { 0, 0, 0, 0},
                  { 0, -1, 0, 0 },
                  { 0, -1, -1, -1 },
                  { 0, 0, 0, 0 }
                }
            };
        }
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
