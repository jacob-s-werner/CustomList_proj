using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public abstract class ExtraTestMethods
    {
        public void CheckIfTwoListsHaveIdenticalIndexes<T>(CustomList<T> expected, CustomList<T> actual)
        {
            for (int i = 0; i < actual.Count; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }
        }
    }
}
