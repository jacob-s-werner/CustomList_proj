using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CustomList;
using CustomListUnitTesting;

namespace TestTester
{
    [TestClass]
    public class ExtraTestMethodsMethodsTests
    {
        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void CheckIfTwoListsHaveIdenticalIndexes_TwoIntegerListsDifferentSizesDuplicateArrayValues_ExceptionThrown()
        {
            //Arrange
            MinusOperatorOverloadMethodTests minusTests = new MinusOperatorOverloadMethodTests();
            CustomList<int> customList1 = new CustomList<int>();
            CustomList<int> customList2 = new CustomList<int>();

            customList1.Add(1);
            customList2.Add(1);
            customList2.Add(1);
            customList2.Add(1);

            //Act
            minusTests.CheckIfTwoListsHaveIdenticalIndexes(customList1, customList2);
            
        }
    }
}
