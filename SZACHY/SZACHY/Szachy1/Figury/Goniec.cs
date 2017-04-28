using SZACHY.Szachy1.Szachownica;

namespace SZACHY.Szachy1.Figury
{
    class Goniec : Figura
    {
        private const string NAZWA = "Goniec";

        public Goniec(string kolor, Pozycja pos = null)
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
