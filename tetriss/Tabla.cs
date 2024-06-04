﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetriss
{
    internal class Tabla
    {
        #region atributi
        int[,] mreza;
        int sirina;
        int visina;
        Figura trenutnaFigura;
        Figura sledecaFigura;
        Rezultat poeni;

        #endregion

        #region konstruktori
        public Tabla(int[,] mreza, int sirina, int visina)
        {
            if (visina <= 0 || sirina <= 0)
                throw new Exception("Dimenzije table moraju biti vece od 0.");
            else
            {
                this.mreza = mreza;
                this.sirina = sirina;
                this.visina = visina;
            }
        }
        public Tabla()
        {

        }
        #endregion

        #region svojstva
        public int Visina
        {
            get { return visina; }
            set 
            {
                if (visina <= 0)
                    throw new Exception("Visina mora biti veca od 0.");
                visina = value;
            }
        }
        public int Sirina
        {
            get { return sirina; }
            set
            {
                if (sirina <= 0)
                    throw new Exception("Sirina mora biti veca od 0.");
                sirina = value;
            }
        }
        #endregion

        #region metode
        public bool ProveriSudar()
        {
            if (MozeDaSePomera())
                return true;

            poeni.DodajPoene(4);
            ZakucajTrenutniOblik();
            UkloniPuneRedove();
            AzurirajMrezu();

            return false;
        }
        private bool MozeDaSePomera()
        {
            // prolazi kroz sve koordinate trenutnog oblika i proverava sudaranje
            for (int i = Math.Max(trenutnaFigura.X, 0); i < Math.Min(trenutnaFigura.X + 4, sirina); i++)
            {
                for (int j = Math.Max(trenutnaFigura.Y, 0); j < Math.Min(trenutnaFigura.Y + 4, visina); j++)
                {
                    // proverava sudaranje sa donjim delom ploce ili postojecim blokovima
                    if (mreza[i, j] < 0 && (j + 1 == visina || mreza[i, j + 1] > 0))
                        return false;
                }
            }
            return true;
        }
        private void ZakucajTrenutniOblik()
        {
            // zakucava trenutni oblik na dno ploce (cini ga trajnim delom ploce)
            for (int i = Math.Max(trenutnaFigura.X, 0); i < Math.Min(trenutnaFigura.X + 4, sirina); i++)
            {
                for (int j = Math.Max(trenutnaFigura.Y, 0); j < Math.Min(trenutnaFigura.Y + 4, visina); j++)
                {
                    // ako je vrednost na ploci negativna, to znaci da je deo trenutnog oblika
                    if (mreza[i, j] < 0)
                        mreza[i, j] = -mreza[i, j];
                }
            }

        }
        private void UkloniPuneRedove()
        {
            // provera i uklanjanje punih redova
            for (int j = visina - 1; j >= 0; j--)
            {
                int brojBlokova = 0;
                for (int i = 0; i < sirina; i++)
                {
                    if (mreza[i, j] > 0)
                    {
                        brojBlokova++;
                    }
                }

                if (brojBlokova == sirina)
                {
                    poeni.DodajPoene(10);
                    for (int k = j; k > 0; k--)
                    {
                        for (int i = 0; i < sirina; i++)
                        {
                            mreza[i, k] = mreza[i, k - 1];
                        }
                    }
                    for (int i = 0; i < sirina; i++)
                    {
                        mreza[i, 0] = 0;
                    }
                    j++;
                }
            }
        }
        private void AzurirajMrezu()
        {
            // prolazi kroz oblik i postavlja negativne vrednosti na pozitivne
            for (int i = Math.Max(trenutnaFigura.X, 0); i < Math.Min(trenutnaFigura.X + 4, sirina); i++)
            {
                for (int j = Math.Max(trenutnaFigura.Y, 0); j < Math.Min(trenutnaFigura.Y + 4, visina); j++)
                {
                    if (mreza[i, j] == 0)
                    {
                        mreza[i, j] = -mreza[i, j];
                    }
                }
            }
        }
        public bool DodajFiguru(Random r)
        {
            // % 7 osigurava da trenutna figura ne izadje iz polja za igru
            trenutnaFigura.X = r.Next() % 7;
            trenutnaFigura.Y = 0;
            //trenutnaRotacija = 0;
            trenutnaFigura = sledecaFigura;
            return false;
        }
        #endregion
    }
}
