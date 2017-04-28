using SZACHY.Szachy1.Szachownica;

namespace SZACHY.Szachy1.Figury
{
    class Pionek : Figura
    {
        private const string NAZWA = "Pionek";

        public Pionek(string kolor, Pozycja pos = null)
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