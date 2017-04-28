using SZACHY.Szachy1;
using SZACHY.Szachy1.Util;
using SZACHY.Szachy1.Util.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SZACHY.Szachy1.Szachownica
{
    sealed class Szachownica : IEnumerable
    {
        #region Fields

        public string[,] plansza;

        private const int rozmiar = Consts.Rozmiar;
        private string fillPattern1 = "[X]", fillPattern2 = "[ ]";

        #endregion

        public Szachownica()
        {
            plansza = new string[rozmiar, rozmiar];
            plansza.Fill("[X]", "[ ]", rozmiar);
        }

        #region Properties

        public string this[Figura f, Pozycja pos]
        {
            get
            {
                return plansza[pos.iX, pos.Y];
            }
            set
            {
                f.Pozycja = pos;
                plansza[pos.iX, pos.Y] = value;
            }
        }

        #endregion

        #region Methods

        public void Printplansza()
        {
            string temp = string.Empty;
            List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for (int i = 0; i < rozmiar; i++)
            {
                temp += (rozmiar - i) + "\t";

                for (int j = 0; j < rozmiar; j++)
                {
                    temp += plansza[i, j] + "\t";
                }

                temp += '\n';
            }

            temp += "\t";
            for (int w = 0; w < letters.Count; w++)
            {
                temp += $" {letters.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(temp);
        }

        public IEnumerator GetEnumerator()
        {
            List<string> list = new List<string>();
            string pole;

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    pole = plansza[i, j];

                    if (!pole.Contains(fillPattern1) && !pole.Contains(fillPattern2))
                    {
                        list.Add(plansza[i, j]);
                    }
                }
            }

            return list.GetEnumerator();
        }

        #endregion
    }
}
