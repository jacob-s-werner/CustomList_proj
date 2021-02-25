using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class IterableMethodTests
    {
        [TestMethod]
        public void Iterable_OneShortListOfStrings_IterationMatches3()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("One");
            stringList.Add("Two");
            stringList.Add("Three");
            
            int expected = 3;
            int actual = 0;

            //Act
            foreach (string item in stringList)
            {
                actual++;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterable_OneEmptyList_NoIteration()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            int expected = 0;
            int actual = 0;

            //Act
            foreach (int item in intList)
            {
                actual++;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterable_OneLongList_CharMatchesExpected()
        {
            //Arrange
            CustomList<char> charList = new CustomList<char>();
            charList.Add('a');
            charList.Add('b');
            charList.Add('c');
            charList.Add('d');
            charList.Add('e');
            charList.Add('f');

            char expected = 'c';
            char actual = 'g';
            int iteration = 0;

            //Act
            foreach (char character in charList)
            {
                iteration++;
                if (iteration == 3)
                {
                    actual = character;
                }
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterable_OneShortListOfStrings_StringListMatchesExpected()
        {
            //Arrange
            CustomList<string> stringList = new CustomList<string>();
            stringList.Add("I");
            stringList.Add("Am");
            stringList.Add("Jake");

            string expected = "IAmJake";
            string actual = "";

            //Act
            foreach (string item in stringList)
            {
                actual += item;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Iterable_OneListOfFourInts_IntsAddedEquals10()
        {
            //Arrange
            CustomList<int> intList = new CustomList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);
            intList.Add(4);

            int expected = 10;
            int actual = 0;

            //Act
            foreach (int integer in intList)
            {
                actual += integer;
            }

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
