using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void Add_OneString_ListAddedOneString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string name = "Jake";
            int expected = 1;
            int actual;

            //Act
            customList.Add(name);
            actual = customList.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoCharacters_ListAddedTwoCharacters()
        {
            //Arrange
            CustomList<char> customList = new CustomList<char>();
            char a = 'a';
            char b = 'b';
            int expected = 2;
            int actual;

            //Act
            customList.Add(a);
            customList.Add(b);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneString_IndexMatchesName()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string name = "Jake";
            string expected = name;
            string actual;

            //Act
            customList.Add(name);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_OneInteger_ListAddedInteger()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int number = 7;
            int expected = 1;
            int actual;

            //Act
            customList.Add(number);
            actual = customList.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveStrings_ListIndex2IsAddedProperly()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string one = "One";
            string two = "Two";
            string three = "Three";
            string four = "Four";
            string five = "Five";
            
            string expected = three;
            string actual;
            
            //Act
            customList.Add(one);
            customList.Add(two);
            customList.Add(three);
            customList.Add(four);
            customList.Add(five);

            actual = customList[2];
            
            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
