using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void Remove_OneString_CountIsThree()
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
    }
}
