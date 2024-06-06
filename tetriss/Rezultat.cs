using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Rezultat
    {
        #region atributi
        int poeni;
        #endregion

        #region konstruktori
        public Rezultat()
        {
            poeni = 0;
        }
        #endregion

        #region svojstva
        public int Poeni
        {
            get { return poeni; }
            set 
            {
                if (poeni < 0)
                    throw new Exception("Poeni ne mogu biti negativni.");
                else
                    poeni = value; 
            }
        }
        #endregion

        #region metode
        public void DodajPoene(int p)
        {
            poeni += p;
        }
        #endregion
    }
}
