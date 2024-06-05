using System;
using System.Collections.Generic;
using System.Drawing;
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
        protected void CrtajNaXY(int i, int j, Graphics g, Brush brush)
        {
            //crtanje kvadrata na poziciji (x,y) na tabli 10x20
            Color newLightPurple = ColorTranslator.FromHtml("#A08EB9");
            Color newLightYellow = ColorTranslator.FromHtml("#FCE6C1");
            Pen olovka = new Pen(newLightYellow);
            int pocetakTableX = 225;
            int pocetakTableY = 50;

            g.FillRectangle(brush, pocetakTableX + dimenzijeKvadrata * i,
                pocetakTableY + dimenzijeKvadrata * j, dimenzijeKvadrata, dimenzijeKvadrata);
            g.DrawRectangle(olovka, pocetakTableX + dimenzijeKvadrata * i,
                pocetakTableY + dimenzijeKvadrata * j, dimenzijeKvadrata, dimenzijeKvadrata);
        }
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
