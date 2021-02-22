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

            string expected = 2;
            string actual;

            //Act
            customList.Add(one);
            customList.Add(two);
            customList.Add(three);

            customList.Remove(two);
            actual = customList.Count();

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
            actual = customList.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
    }
}
