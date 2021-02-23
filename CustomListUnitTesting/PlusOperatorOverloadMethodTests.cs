using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class PlusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void PlusOperator_TwoListsTotalingSixIntegers_CombinedTwoLists()
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
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(4);
            two.Add(6);

            actual = one + two;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_TwoListsOfIntegers_CountMatches6()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result;
            int expected = 6;
            int actual;

            //Act
            one.Add(1);
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(4);
            two.Add(6);

            result = one + two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_TwoListsOfStrings_Index3MatchesExpected()
        {
            //Arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result;
            string expected = "Four";
            string actual;

            //Act
            one.Add("One");
            one.Add("Two");
            
            two.Add("Three");
            two.Add("Four");

            result = one + two;
            actual = result[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_OneShortCharListAndOneEmptyCharList_ListsAreAdded()
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

            actual = list + empty;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlusOperator_OneShortCharListAndOneLongCharList_ListsAreAddedProperly()
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
            shortList.Add('b');
            
            longList.Add('c');
            longList.Add('d');
            longList.Add('e');
            longList.Add('f');

            actual = shortList + longList;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
