using System;
using System.Collections.Generic;

namespace _2_KolekcjeGeneryczne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolejka();
            //Stos();
            //HashSet();
            //LinkedList();

            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);

            var element1 = lista.First;
            var elementOstatni = lista.Last;
            lista.AddAfter(element1, 10);
            lista.AddBefore(element1, 20);

            var node = lista.First;

            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
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

        private static void LinkedList()
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(5);
            lista.AddFirst(6);
            lista.AddFirst(7);
            lista.AddLast(1);
            lista.AddLast(2);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        private static void HashSet()
        {
            Pracownik pracownik = new Pracownik { Imie = "Pawel", Nazwisko = "Delag" };
            HashSet<Pracownik> set = new HashSet<Pracownik>();
            set.Add(new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Tomek", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Grzegorz", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Damian", Nazwisko = "Nowak" });
            set.Add(new Pracownik { Imie = "Anna", Nazwisko = "Nowak" });
            set.Add(pracownik);
            set.Add(pracownik);

            foreach (var item in set)
            {
                Console.WriteLine(item.Imie);
            }
        }
        private static void Stos()
        {
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
        }
        private static void Kolejka()
        {
            Queue<Pracownik> kolejka = new Queue<Pracownik>();
            kolejka.Enqueue(new Pracownik { Imie = "Karol", Nazwisko = "Pokomeda" });
            kolejka.Enqueue(new Pracownik { Imie = "Wojciech", Nazwisko = "Czechyra" });
            kolejka.Enqueue(new Pracownik { Imie = "Tomasz", Nazwisko = "Sola" });
            kolejka.Enqueue(new Pracownik { Imie = "Michal", Nazwisko = "Strongowski" });

            Console.WriteLine("kolejka");

            while (kolejka.Count > 0)
            {
                var pracownik = kolejka.Dequeue();
                Console.WriteLine(pracownik.Imie + " " + pracownik.Nazwisko);
            }
        }
    }
}