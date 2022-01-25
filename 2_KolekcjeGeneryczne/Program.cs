﻿using System;
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
            //LinkedList2();
            //Slownik();
            //Slownik2();

            var pracownicy = new SortedDictionary<string, List<Pracownik>>();
            pracownicy.Add("Sprzedaż", new List<Pracownik>() { new Pracownik { Imie = "Jan", Nazwisko = "Kowalski"},
                                                                            new Pracownik { Imie = "Kazimierz", Nazwisko = "Beton"},
                                                                             new Pracownik { Imie = "Urszula", Nazwisko = "Krzak"} });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Imie = "Marcin", Nazwisko = "Kowal"},
                                                                            new Pracownik { Imie = "Tomek", Nazwisko = "Sola"}});

            pracownicy.Add("Księgowość", new List<Pracownik>() { new Pracownik { Imie = "Monika", Nazwisko = "Wysocka"},
                                                                            new Pracownik { Imie = "Agata", Nazwisko = "Beton"},
                                                                            new Pracownik { Imie = "Marta", Nazwisko = "Tutak"},
                                                                             new Pracownik { Imie = "Renata", Nazwisko = "Popo"} });
            foreach (var item in pracownicy)
            {
                Console.WriteLine("Ilość pracowników w dziale {0} wynosi {1}", item.Key, item.Value.Count);
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

        private static void Slownik2()
        {
            var pracownicy = new Dictionary<string, List<Pracownik>>();
            pracownicy.Add("Ksiegowosc", new List<Pracownik>() { new Pracownik { Nazwisko = "Nowak" }, new Pracownik { Nazwisko = "Kowal" }, new Pracownik { Nazwisko = "Pan" } });

            pracownicy["Ksiegowosc"].Add(new Pracownik { Nazwisko = "Nowak" });

            pracownicy.Add("Informatyka", new List<Pracownik>() { new Pracownik { Nazwisko = "Kowalski" }, new Pracownik { Nazwisko = "Bogacki" } });

            foreach (var item in pracownicy)
            {
                Console.WriteLine("Dział: " + item.Key);

                foreach (var pracownik in item.Value)
                {
                    Console.WriteLine(pracownik.Nazwisko);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Księgowi:");
            foreach (var item in pracownicy["Ksiegowosc"])
            {
                Console.WriteLine(item.Nazwisko);
            }
        }

        private static void Slownik()
        {
            var pracownicy = new Dictionary<string, Pracownik>();
            pracownicy.Add("Nowak", new Pracownik { Imie = "Marcin", Nazwisko = "Nowak" });
            pracownicy.Add("Kowal", new Pracownik { Imie = "Marcin", Nazwisko = "Kowal" });
            pracownicy.Add("Kaczor", new Pracownik { Imie = "Marcin", Nazwisko = "Kaczor" });

            var pracownik = pracownicy["Kowal"];

            foreach (var pracus in pracownicy)
            {
                Console.WriteLine("{0}:{1}", pracus.Key, pracus.Value.Imie);
            }
        }

        private static void LinkedList2()
        {
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