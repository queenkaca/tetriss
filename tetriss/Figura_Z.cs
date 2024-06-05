using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_Z : Figura
    {
        int[,,] tetromino;
        public Figura_Z(int x, int y, int trenutnaRotacija):base(x, y, trenutnaRotacija)
        {
            tetromino = new int[4, 4, 4]{
                { { 0,  0, 0, 0 },
                  {-1, -1, 0, 0 },
                  { 0, -1, -1, 0},
                  { 0, 0, 0, 0  },
                },
                {
                  { 0,  0,  0,  0},
                  { 0,   0, -1, 0},
                  { 0,  -1, -1, 0},
                  { 0,  -1,  0, 0}

                },
                { { 0, 0,   0, 0 },
                  { 0, -1, -1, 0 },
                  { 0,  0, -1,-1 },
                  { 0,  0,  0, 0 },
                },
                { { 0,  0, -1,  0 },
                  { 0, -1, -1,  0 },
                  { 0, -1,  0,  0 },
                  { 0, 0,   0,  0 }
                }
            };
        }
        public Figura_Z() { }

        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
        public void Crtaj(Graphics g, Random random)
        {
            Color boja = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
            SolidBrush sb = new SolidBrush(boja);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tetromino[trenutnaRotacija, i, j] != 0)
                        CrtajNaXY(x + i,y+ j, g, sb);
                }
            }
        }

    }
}

