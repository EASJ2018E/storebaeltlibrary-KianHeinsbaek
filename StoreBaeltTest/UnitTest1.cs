using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltBilletLibrary;

namespace StoreBaeltTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WeekendRabatTest()
        {
            // Arrange
            Bil bil = new Bil(); 

            // Act
            double result = bil.WeekendRabat();

            // Assert
            Assert.AreEqual(192, result);
        }
    }
}
