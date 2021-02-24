using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ZipperMethodTests : ExtraTestMethods
    {
        [TestMethod]
        public void Zipper_TwoListsSixIntegers_ZipperedList()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            expected.Add(1);
            expected.Add(3);
            expected.Add(5);
            expected.Add(2);
            expected.Add(4);
            expected.Add(6);

            CustomList<int> actual;

            //Act
            one.Add(1);
            one.Add(5);
            one.Add(4);

            two.Add(3);
            two.Add(2);
            two.Add(6);

            actual = one.Zipper(two);

            //Assert
            CheckIfTwoListsHaveIdenticalIndexes(expected, actual);
        }
        [TestMethod]
        public void Zipper_TwoListsSixIntegers_CountMatches6()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result;
            int expected = 6;
            int actual;

            //Act
            one.Add(1);
            one.Add(5);
            one.Add(4);

            two.Add(3);
            two.Add(2);
            two.Add(6);

            result = one.Zipper(two);
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
