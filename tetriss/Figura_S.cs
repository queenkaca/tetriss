using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetriss
{
    internal class Figura_S : Figura
    {
        public Figura_S(int x, int y, int trenutnaRotacija, Color boja):base(x, y, trenutnaRotacija, boja)
        {
            VrstaOblika = 5;
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
        public Figura_S() { }


        int[,,] tetromino;
        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
        
    }
}
