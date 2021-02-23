using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;

namespace CustomListUnitTesting
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void ToString_FourStrings_ItemsAreCombinedIntoOneString()
        {
            //Arrange
            CustomList<string> customList = new CustomList<string>();
            string string1 = "My";
            string string2 = "Name";
            string string3 = "Is";
            string string4 = "Jacob";
            string expected = "MyNameIsJacob";
            string actual;

            //Act
            customList.Add(string1);
            customList.Add(string2);
            customList.Add(string3);
            customList.Add(string4);

            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void ToString_FourIntegers_ConvertedIntoOneString()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            string expected = "1234";
            string actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);

            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
