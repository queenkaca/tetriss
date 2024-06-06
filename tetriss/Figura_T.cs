using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_T : Figura
    {
        int[,,] tetromino;
        public Figura_T(int x, int y, int trenutnaRotacija, Color boja):base(x, y, trenutnaRotacija, boja)
        {
            VrstaOblika = 4;
            tetromino = new int[4, 4, 4]{
                { { 0,  0, 0, 0 },
                  {-1, -1,-1, 0 },
                  { 0, -1, 0, 0 },
                  { 0,  0, 0, 0 },
                },
                {
                  { 0,  0,  0, 0},
                  { 0, -1,  0, 0},
                  { 0, -1, -1, 0},
                  { 0, -1,  0, 0}
                },
                {
                  { 0, 0,  0, 0 },
                  { 0, 0, -1, 0 },
                  { 0,-1, -1,-1 },
                  { 0, 0,  0, 0 }
                },
                { { 0, 0, -1, 0 },
                  { 0,-1, -1, 0 },
                  { 0, 0, -1, 0 },
                  { 0, 0,  0, 0 }
                }
            };
        }
        public Figura_T() { }

        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
    }
}
