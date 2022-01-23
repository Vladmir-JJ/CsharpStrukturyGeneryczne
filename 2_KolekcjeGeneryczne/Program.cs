using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Karol", Nazwisko = "Pokomeda" });
            kolejka.Enqueue(new Pracownik { Imie = "Wojciech", Nazwisko = "Czechyra" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomasz", Nazwisko = "Sola" });
            kolejka.Enqueue(new Pracownik { Imie = "Michal", Nazwisko = "Strongowski" });

            Console.WriteLine("kolejka");

            while(kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            Stack<Pracownik> stos = new Stack<Pracownik>();
            stos.Push(new Pracownik { Imie = "Karol", Nazwisko = "Pokomeda" });
            stos.Push(new Pracownik { Imie = "Wojciech", Nazwisko = "Czechyra" });
            stos.Push(new Pracownik { Imie = "Tomasz", Nazwisko = "Sola" });
            stos.Push(new Pracownik { Imie = "Michal", Nazwisko = "Strongowski" });

            Console.WriteLine();
            Console.WriteLine("stos");

            while (stos.Count > 0)
            {
                var pracownik = stos.Pop();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            /*  var liczby = new List<int>(10);
              var pojemnosc = -1;
              while(true)
              {
                  if(liczby.Capacity != pojemnosc)
                  {
                      pojemnosc = liczby.Capacity;
                      Console.WriteLine(pojemnosc);
                  }
                  liczby.Add(1);                
              }*/
            /*List<Pracownik> listaPracownikow = new List<Pracownik>
            {
                new Pracownik{ Imie = "Marcin", Nazwisko = "Nowak" },
                new Pracownik{ Imie = "Jan", Nazwisko = "Nowak" },
                new Pracownik{ Imie = "Tomasz", Nazwisko = "Nowak" }
             };
            listaPracownikow.Add(new Pracownik { Imie = "Krzysztof", Nazwisko = "Bosak" });

            foreach(Pracownik pracownik in listaPracownikow)
            {
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
            for (int i = 0; i < listaPracownikow.Count; i++)
            {
                Console.WriteLine(listaPracownikow[i].Imie + " " + listaPracownikow[i].Nazwisko);
            } */
        }
    }
}