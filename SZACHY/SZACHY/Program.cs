using SZACHY.Szachy1;
using SZACHY.Szachy1.Figury;
using SZACHY.Szachy1.Szachownica;
using System;
using SZACHY.Szachy1.Figury.Kolor;
using SZACHY.Szachy1.Util.Extensions;

namespace SZACHY
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Przyklad1

            Console.WriteLine("Przyklad Szachownicy");

            Szachownica plansza = new Szachownica();

            Pionek p = new Pionek(Kolor.Czarny.Name());
            plansza[p, new Pozycja('B', 2)] = p.ShortName();

            Krolowa q = new Krolowa(Kolor.Bialy.Name());
            plansza[q, new Pozycja('C', 7)] = q.ShortName();

            plansza.Printplansza();

            Console.WriteLine("Figury obecnie na planszy:");
            foreach (string s in plansza)
            {
                Console.WriteLine(s);
            }

            #endregion

            #region Przyklad2

            Console.WriteLine("Dziedziczenie cech poprzez komende 'new'");

            Krol k = new Krol(Kolor.Bialy.Name());
            Console.WriteLine(k.ToString());

            Figura f = k;
            Console.WriteLine(f.ToString());

            #endregion

            Console.ReadKey();
        }
    }
}
