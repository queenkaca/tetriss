﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetriss
{
    internal class Figura_I : Figura
    {
        int[,,] tetromino;

        public Figura_I(int x, int y, int trenutnaRotacija, Color boja):base(x, y, trenutnaRotacija, boja)
        {
            //indeks oblika I
            VrstaOblika = 0;

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
        public Figura_I() { }
        override public int[,,] Tetromino
        {
            get { return tetromino; }
        }

        public void Crtaj(Graphics g, Random random)
        {
            SolidBrush sb = new SolidBrush(Boja);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tetromino[trenutnaRotacija, i, j] != 0)
                        CrtajNaXY(x + i, y +j, g, sb);
                }
            }
        }

    }
}
