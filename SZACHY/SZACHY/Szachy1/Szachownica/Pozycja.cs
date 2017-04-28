using SZACHY.Szachy1.Util;
using System;

namespace SZACHY.Szachy1.Szachownica
{
    public class Pozycja
    {
        #region Properties

        public char X { get; }
        /// <summary>
        /// Integer representation of X value
        /// </summary>
        public int iX { get; }
        public int Y { get; }

        #endregion

        #region Constructors and Destructors

        public Pozycja(char X, int Y)
        {
            if (CheckBounds(Consts.Rozmiar, charToChessInt(X), Y))
            {
                this.X = X;
                this.Y = Y;
                this.iX = charToChessInt(X);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Private Methods

        private bool CheckBounds(int rozmiar, params int[] values)
        {
            bool result = true;

            foreach (int value in values)
            {
                if (!(value >= 0 && value - 1 <= rozmiar))
                {
                    result = false;
                }
            }

            return result;
        }

        private int charToChessInt(char c)
        {
            return c - 65;
        }

        #endregion
    }
}
