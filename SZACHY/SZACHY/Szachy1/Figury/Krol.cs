using SZACHY.Szachy1.Szachownica;

namespace SZACHY.Szachy1.Figury
{
    class Krol : Figura
    {
        private const string NAZWA = "Krol";

        public Krol(string kolor, Pozycja pos = null)
            : base(NAZWA, kolor)
        {
        }

        protected override bool przesuniecie(string Pozycja)
        {
            //kodzik
            return true;
        }
        public new string ToString()
        {
            return $"Krol class: {Kolor} {Nazwa}";
        }
    }
}