using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczne_TEST
{
    [TestClass]
    public class LinkedList_TEST
    {
        [TestMethod]
        public void ListaDodawanie()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First, "Jacek");
            lista.AddBefore(lista.Last, "Olaf");

            Assert.AreEqual("Jacek", lista.First.Next.Value);
        }
        [TestMethod]
        public void ListaDodawaniePrzed()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.AddAfter(lista.First, "Jacek");
            lista.AddBefore(lista.Last, "Olaf");

            Assert.AreEqual("Olaf", lista.Last.Previous.Value);
        }
        [TestMethod]
        public void UsuwanieElementuOstatniego()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.RemoveLast();

            Assert.AreEqual(1, lista.Count);
            Assert.AreEqual(lista.First, lista.Last);
        }
        [TestMethod]
        public void UsuwanieElementu()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Remove("Marcin");

            Assert.AreEqual(1, lista.Count);
            Assert.AreEqual(lista.First, lista.Last);
            Assert.AreEqual("Tomek", lista.First.Value);
        }
        [TestMethod]
        public void CzyListaZawiera()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            Assert.IsTrue(lista.Contains("Tomek"));
        }
        [TestMethod]
        public void CzyszczenieListy()
        {
            var lista = new LinkedList<string>();

            lista.AddFirst("Marcin");
            lista.AddLast("Tomek");
            lista.Clear();
            Assert.AreEqual(0, lista.Count);
        }
    }
}
