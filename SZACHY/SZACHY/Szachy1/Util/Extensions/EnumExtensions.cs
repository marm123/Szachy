using SZACHY.Szachy1.Figury.Kolor;
using System;

namespace SZACHY.Szachy1.Util.Extensions
{
    public static class EnumExtensions
    {
        public static string Name(this Kolor kolor)
        {
            return Enum.GetName(typeof(Kolor), kolor);
        }
    }
}
