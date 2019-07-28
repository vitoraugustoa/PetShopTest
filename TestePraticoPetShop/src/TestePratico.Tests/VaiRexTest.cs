using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;

namespace TestePratico.Tests
{
    [TestClass]
    public class VaiRexTest
    {
        [TestMethod]
        public void TotalPriceDogBath_Receiving_Midweek_Date()
        {
            // Arrange
            var vaiRex = new VaiRex(15.0m, 50.0m, 1700);
            DateTime date = DateTime.Parse("03/08/2018");

            // Act
            PetShopResponseViewModel petShopResponse = vaiRex.GetTotalPrice(3, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 295);
        }

        [TestMethod]
        public void TotalPriceDogBath_Receiving_Weekend_Date()
        {
            // Arrange
            var vaiRex = new VaiRex(15.0m, 50.0m, 1700);
            DateTime date = DateTime.Parse("28/07/2019");

            // Act
            PetShopResponseViewModel petShopResponse = vaiRex.GetTotalPrice(4, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 355);
        }
    }
}
