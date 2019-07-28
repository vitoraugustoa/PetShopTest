using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Tests
{
    [TestClass]
    public class HelpersTest
    {
        IHelpers _helper = new Helpers();

        [TestMethod]
        public void IsWeekend_Receiving_Weekend_Date()
        {
            // Arrange
            DateTime date = DateTime.Parse("28/07/2019");

            // Act
            bool result = _helper.IsWeekend(date);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsWeekend_Receiving_Midweek_Date()
        {
            // Arrange
            DateTime date = DateTime.Parse("10/07/2019");

            // Act
            bool result = _helper.IsWeekend(date);

            // Assert
            Assert.IsFalse(result);
        }
    } 
}
