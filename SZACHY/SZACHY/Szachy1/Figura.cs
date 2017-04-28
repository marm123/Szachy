using SZACHY.Szachy1.Szachownica;

namespace SZACHY.Szachy1
{
    abstract class Figura
    {
        #region Properties

        public string Kolor { get; set; }
        public string Nazwa { get; set; }
        public Pozycja Pozycja { get; set; }

        #endregion

        #region Constructors and Destructors

        public Figura(string nazwa, string kolor)
        {
            Nazwa = nazwa;
            Kolor = kolor;
        }

        #endregion

        #region Protected Methods

        protected abstract bool przesuniecie(string pozycja);

        #endregion

        #region Public Methods

        public string ShortName()
        {
            return Kolor[0].ToString() + Nazwa[0].ToString();
        }

        public override string ToString()
        {
            return $"Base class: {Kolor} {Nazwa}";
        }

        #endregion
    }
}
