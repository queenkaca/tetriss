using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_I : Figura
    {
        int[,,] tetromino;

       /* public Figura_I()
        {
            tetromino = new 
        }*/
        override public int[,,] Tetromino
        {
            get { return tetromino; }
        }

    }
}
