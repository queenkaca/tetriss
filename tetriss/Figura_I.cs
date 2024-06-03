using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Figura_I : Figura
    {
        int[,,] tetromino = new int[4, 4, 4];
        
           
        override public int[,,] Tetromino
        {
            get { return tetromino; }
        }

    }
}
