using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace _3_KlasyIInterfejsyGeneryczne
{
    public static class KolejkaExtention
    {
        public delegate void Drukarka<T>(T dane);
        public static IEnumerable<Tout> ElementKonwertowany<T, Tout>(this IKolejka<T> kolejka)
        {
            var konwerter = TypeDescriptor.GetConverter(typeof(T));
            foreach (var item in kolejka)
            {
                var wynik = konwerter.ConvertTo(item, typeof(Tout));
                yield return (Tout)wynik;
            }
        }
        public static void Drukuj<T>(this IKolejka<T> kolejka, Action<T> wydruk)
        {
            foreach (var item in kolejka)
            {
                wydruk(item);
            }
        }
    }
}
