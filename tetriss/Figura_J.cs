﻿using System;
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
        public Figura_J(int x, int y, int trenutnaRotacija, Color boja):base(x, y, trenutnaRotacija, boja)
        {
            VrstaOblika = 2;
        tetromino = new int[4, 4, 4] {
                { { 0, 0,  -1, 0},
                  { 0, 0,  -1, 0},
                  { 0, -1, -1, 0},
                  { 0,  0,  0, 0},
                },
                { { 0,   0,  0, 0},
                  { -1, -1, -1, 0},
                  { 0, 0,   -1, 0},
                  { 0, 0,    0, 0}
                },
                { { 0, 0, 0, 0  },
                  { 0, -1, -1, 0},
                  { 0, -1, 0, 0 },
                  { 0, -1, 0, 0 },
                },
                { { 0, 0, 0,  0},
                  { 0,-1, 0,  0},
                  { 0,-1, -1,-1},
                  { 0, 0,  0, 0}
                }
            };
        }
        public Figura_J() { }


        public override int[,,] Tetromino
        {
            get { return tetromino; }
        }
        
    }
}
