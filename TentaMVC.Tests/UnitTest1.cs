using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TentaMVC.Models;

namespace TentaMVC.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            // Arrange
            CalculateSpeed speedOne = new CalculateSpeed();

            //Act
            var expected = speedOne.GetCurrentSpeed(40);
            var actual = 232323;

            // Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod2()
        {

            // Arrange
            CalculateSpeed speedOne = new CalculateSpeed();

            //Act
            var expected = speedOne.GetCurrentSpeed(-40);
            var actual = 8.232323;

            // Assert

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestMethod3()
        {

            // Arrange
            CalculateSpeed speedOne = new CalculateSpeed();

            //Act
            var expected = speedOne.GetCurrentSpeed(20);
            var actual = 3.232323;

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }





}
