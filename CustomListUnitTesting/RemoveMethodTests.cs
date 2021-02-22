using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void Remove_AddThreeStringsRemoveOne_CountIsTwo()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string one = "One";
            string two = "Two";
            string three = "Three";

            int expected = 2;
            int actual;

            //Act
            customList.Add(one);
            customList.Add(two);
            customList.Add(three);

            customList.Remove(two);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void Remove_AddThreeIntegersRemoveOneDuplicate_CheckIfDuplicateIsStillThere()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            int expected = 2;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(2);

            customList.Remove(2);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AddOneCharRemoveOneChar_CountIsZero()
        {
            //Arrange
            CustomList<char> customList = new CustomList<char>();
            char a = 'a';

            int expected = 0;
            int actual;

            //Act
            customList.Add(a);
            customList.Remove(a);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_AddThreeStringsRemoveOne_PositionThreeStringIsNowInPositionTwo()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string one = "One";
            string two = "Two";
            string three = "Three";

            string expected = three;
            string actual;

            //Act
            customList.Add(one);
            customList.Add(two);
            customList.Add(three);

            customList.Remove(two);
            actual = customList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ReturnsNullList()
        {

        }
    }
}
