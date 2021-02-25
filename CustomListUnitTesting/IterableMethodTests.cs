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
    }
}
