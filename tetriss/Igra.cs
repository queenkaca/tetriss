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
        Tabla tabla;
        bool krajIgre;
        Rezultat poeni;
        #endregion

        #region konstruktori
        public Igra(Tabla tabla)
        {
            this.tabla = tabla;
        }
        public Igra()
        {

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
        #endregion
    }
}
