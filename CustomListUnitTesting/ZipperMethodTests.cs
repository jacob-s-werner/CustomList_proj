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
        [TestMethod]
        public void Zipper_TwoListsFourStrings_Index3MatchesExpected()
        {
            //Arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result;
            string expected = "Four";
            string actual;

            //Act
            one.Add("One");
            one.Add("Three");

            two.Add("Two");
            two.Add("Four");

            result = one.Zipper(two);
            actual = result[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Zipper_OneCharListOneEmptyList_ListZipperedProperly()
        {
            //Arrange
            CustomList<char> list = new CustomList<char>();
            CustomList<char> empty = new CustomList<char>();
            CustomList<char> expected = new CustomList<char>();
            expected.Add('a');
            expected.Add('b');
            expected.Add('c');

            CustomList<char> actual;

            //Act
            list.Add('a');
            list.Add('b');
            list.Add('c');

            actual = list.Zipper(empty);

            //Assert
            CheckIfTwoListsHaveIdenticalIndexes(expected, actual);
        }
        [TestMethod]
        public void Zipper_OneShortCharListAndOneLongCharList_ListZipperedProperly()
        {
            //Arrange
            CustomList<char> shortList = new CustomList<char>();
            CustomList<char> longList = new CustomList<char>();
            CustomList<char> expected = new CustomList<char>();
            expected.Add('a');
            expected.Add('b');
            expected.Add('c');
            expected.Add('d');
            expected.Add('e');
            expected.Add('f');

            CustomList<char> actual;

            //Act
            shortList.Add('a');
            shortList.Add('c');

            longList.Add('b');
            longList.Add('d');
            longList.Add('e');
            longList.Add('f');

            actual = shortList.Zipper(longList);

            //Assert
            CheckIfTwoListsHaveIdenticalIndexes(expected, actual);
        }
    }
}
