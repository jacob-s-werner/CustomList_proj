using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class MinusOperatorOverloadMethodTests
    {
        [TestMethod]
        public void MinusOperator_TwoListsTotalingSixIntegers_RemoveIntegersInSecondListFromFirstList()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>();
            expected.Add(3);
            expected.Add(5);

            CustomList<int> actual;

            //Act
            one.Add(1);
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(1);
            two.Add(6);

            actual = one - two;

            //Assert
            Assert.ReferenceEquals(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_TwoListsTotalingSixIntegers_CountMatches2()
        {
            //Arrange
            CustomList<int> one = new CustomList<int>();
            CustomList<int> two = new CustomList<int>();
            CustomList<int> result;
            int expected = 2;
            int actual;

            //Act
            one.Add(1);
            one.Add(3);
            one.Add(5);

            two.Add(2);
            two.Add(1);
            two.Add(6);

            result = one - two;
            actual = result.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MinusOperator_TwoListsOfStrings_Index2MatchesExpected()
        {
            //Arrange
            CustomList<string> one = new CustomList<string>();
            CustomList<string> two = new CustomList<string>();
            CustomList<string> result;
            string expected = "Five";
            string actual;

            //Act
            one.Add("One");
            one.Add("Two");
            one.Add("Three");
            one.Add("Four");
            one.Add("Five");

            two.Add("Three");
            two.Add("Four");

            result = one - two;
            actual = result[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
