using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class SortByShortestToLongestLengthMethodTests : ExtraTestMethods
    {
        [TestMethod]
        public void SortByShortestToLongestLength_ListOfThreeChars_Index3MatchesExpected()
        {
            //Arrange
            CustomList<char> customList = new CustomList<char>();
            CustomList<string> sortedList = new CustomList<string>();
            string expected = "d";
            string actual;
            customList.Add('a');
            customList.Add('b');
            customList.Add('c');
            customList.Add('d');

            //Act
            sortedList = customList.SortByShortestToLongestLength();
            actual = sortedList[3];
            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void SortByShortestToLongestLength_ListOfDifferentLengthsInts_LongestLengthMatches4InLastPostion()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            CustomList<string> sortedList = new CustomList<string>();
            int expected = 4;
            int actual;
            customList.Add(13);
            customList.Add(2);
            customList.Add(9);
            customList.Add(2222);
            customList.Add(333);

            //Act
            sortedList = customList.SortByShortestToLongestLength();
            actual = sortedList[4].Length;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SortByShortestToLongestLength_OneListOfStrings_Index2MatchesExpected()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> sortedList = new CustomList<string>();
            string expected = "Not";
            string actual;
            customList.Add("Not");
            customList.Add("Good");
            customList.Add("It");
            customList.Add("Is");

            //Act
            sortedList = customList.SortByShortestToLongestLength();
            actual = sortedList[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SortByShortestToLongestLength_OneListOfStrings_ListsAreIdentical()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            CustomList<string> expected = new CustomList<string>();
            CustomList<string> actual;
            customList.Add("I");
            customList.Add("Am");
            customList.Add("A");
            customList.Add("String");
            customList.Add("List");

            expected.Add("I");
            expected.Add("A");
            expected.Add("Am");
            expected.Add("List");
            expected.Add("String");

            //Act
            actual = customList.SortByShortestToLongestLength();

            //Assert
            CheckIfTwoListsHaveIdenticalIndexes(expected, actual);
        }
    }
}
