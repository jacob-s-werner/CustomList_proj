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
    }
}
