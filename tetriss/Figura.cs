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
        protected int x, y;
        protected int trenutnaRotacija;
        int dimenzijeKvadrata = 30;
        #endregion

        #region konstruktori
        public Figura(int x, int y, int trenutnaRotacija)
        {
            X = x;
            Y = y;
            TrenutnaRotacija = trenutnaRotacija;
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
        public int TrenutnaRotacija
        {
            get { return trenutnaRotacija; }
            set
            {
                if (value < 0 || value > 3)
                    throw new Exception("Indeks rotacije mora biti u intervalu [0, 3]!");
                else
                    trenutnaRotacija = value;
            }
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
