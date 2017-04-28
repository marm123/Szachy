using SZACHY.Szachy1.Szachownica;

namespace SZACHY.Szachy1.Figury
{
    class Krolowa : Figura
    {
        private const string NAZWA = "Krolowa";

        public Krolowa(string kolor, Pozycja pos = null)
            : base(NAZWA, kolor)
        {
        }

        protected override bool przesuniecie(string Pozycja)
        {
            //kodzik
            return true;
        }
    }
}