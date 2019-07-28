using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;

namespace TestePratico.Tests
{
    [TestClass]
    public class ChowChawGasTest
    {
        [TestMethod]
        public void TotalPriceDogBath_Receiving_Midweek_Date()
        {
            // Arrange
            var chowChawGas = new ChowChawGas(30.0m, 45.0m, 800);
            DateTime date = DateTime.Parse("03/08/2018");

            // Act
            PetShopResponseViewModel petShopResponse = chowChawGas.GetTotalPrice(3, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 315);
        }

        [TestMethod]
        public void TotalPriceDogBath_Receiving_Weekend_Date()
        {
            // Arrange
            var chowChawGas = new ChowChawGas(30.0m, 45.0m, 800);
            DateTime date = DateTime.Parse("28/07/2019");

            // Act
            PetShopResponseViewModel petShopResponse = chowChawGas.GetTotalPrice(4, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 345);
        }
    }
}
