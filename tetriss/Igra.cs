using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace tetriss
{
    internal class Igra
    {
        #region atributi
        public Tabla tabla;
        bool krajIgre;
        #endregion

        #region konstruktori
        public Igra()
        {
            tabla = new Tabla();
        }
        #endregion

        #region svojstva

        #endregion
        
        
        #region metode
        public void Unos()
        {
            if (Keyboard.IsKeyDown(Key.Left))
            {
                tabla.PomeriLevo();
            }
            if (Keyboard.IsKeyDown(Key.Right))
            {
                tabla.PomeriDesno();
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                tabla.PomeriDole();
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                tabla.Rotiraj();
            }
        }

        public void CrtajSveFigure(Graphics g)
        {
            foreach (var f in tabla.figurice)
            {
                f.Crtaj(g);
            }
        }
        #endregion


    }
}
