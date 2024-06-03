using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    abstract class Figura
    {
        #region atributi
        int x, y;
        #endregion

        #region konstruktori
        public Figura(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Figura() { }
        #endregion

        #region metode
        public void PomeriDesno()
        {

        }
        public void PomeriLevo()
        { }

        #endregion

        #region svojstva
        abstract public int[,,] Tetromino
        {
            get;
        }

        public int X
        {
            get { return x; }
            set
            {
                if (value > 0) x = value;
                else throw new Exception("Koordinate ne mogu da budu negativne!");
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                if (value > 0) y = value;
                else throw new Exception("Koordinate ne mogu da budu negativne!");
            }
        }
        #endregion
    }

}
