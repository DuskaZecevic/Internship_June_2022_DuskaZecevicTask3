using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.BusinessLogic.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void maxProfitTest1()
        {
            //Arrange
            int[] price = { 7, 1, 5, 3, 6, 4 };
            int expected = 5;

            //Act
            Service.maxProfit(price);

            //Assert
            int actual = Service.maxProfit(price);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void maxProfitTest2()
        {
            //Arrange
            int[] price = { 7, 1, 5, 3, 6, 4 };
            int expected = 3;

            //Act
            Service.maxProfit(price);

            //Assert
            int actual = Service.maxProfit(price);
            Assert.AreNotEqual(expected, actual);
        }

    }
}