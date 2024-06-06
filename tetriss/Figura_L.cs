using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_L:Figura
    {
        int[,,] tetromino;
        public Figura_L(int x, int y, int trenutnaRotacija, Color boja):base(x, y, trenutnaRotacija, boja)
        {
            VrstaOblika = 1;
            tetromino = new int[4, 4, 4]{
                { { 0, -1, 0, 0 },
                  { 0, -1, 0, 0 },
                  { 0, -1, -1, 0},
                  { 0, 0, 0, 0  },
                },
                { 
                  { 0,  0,  0,  0},
                  { 0,   0, -1, 0},
                  { -1, -1, -1, 0},
                  { 0, 0,   0,  0}
                  
                },
                { { 0, 0,   0, 0 },
                  { 0, -1, -1, 0 },
                  { 0,  0, -1, 0 },
                  { 0,  0, -1, 0 },
                },
                { { 0,  0,  0,  0 },
                  { 0, -1, -1, -1 },
                  { 0, -1,  0,  0 },
                  { 0, 0,   0,  0 }
                }
            };
        }
        public Figura_L() { }

        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
    }
}
