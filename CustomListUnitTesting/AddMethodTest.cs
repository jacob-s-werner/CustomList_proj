using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class AddMethodTest
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
        [ExpectedException(typeof(ArrayTypeMismatchException))]
        public void Add_ArrayTypeMismatchExceptionThrown()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            int number = 1;

            //Act
            customList.Add(number);
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
            CustomList<string> customList = new CustomList<string>();
            int number = 7;
            int expected = 1;
            int actual;

            //Act
            customList.Add(number);
            actual = customList.Count();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
