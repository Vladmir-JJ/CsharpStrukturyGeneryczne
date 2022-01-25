using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace KolekcjeGeneryczne_TEST
{
    [TestClass]
    public class HashSet_TEST
    {
        [TestMethod]
        public void InersectSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.IntersectWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 2, 3 }));
        }
        [TestMethod]
        public void UnionSet()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.UnionWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 2, 3, 4 }));
        }
        [TestMethod]
        public void SymetricExcept()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };
            var set2 = new HashSet<int>() { 2, 3, 4 };

            set1.SymmetricExceptWith(set2);

            Assert.IsTrue(set1.SetEquals(new[] { 1, 4 }));
        }
        [TestMethod]
        public void Remove()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };           

            set1.Remove(1);

            Assert.AreEqual(2, set1.Count);
        }
        [TestMethod]
        public void RemoveWhere()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };            

            set1.RemoveWhere(x => x >1);

            Assert.AreEqual(1, set1.Count);
        }
        [TestMethod]
        public void Contains()
        {
            var set1 = new HashSet<int>() { 1, 2, 3 };

            set1.Contains(3);

            Assert.IsTrue(set1.Contains(3));
        }
    }
}
