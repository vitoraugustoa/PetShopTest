using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;

namespace TestePratico.Tests
{
    [TestClass]
    public class MeuCaninoFelizTest
    {
        [TestMethod]
        public void TotalPriceDogBath_Receiving_Midweek_Date()
        {
            // Arrange
            var meuCaninoFeliz = new MeuCaninoFeliz(20.0m, 40.0m, 2000);
            DateTime date = DateTime.Parse("03/08/2018");

            // Act
            PetShopResponseViewModel petShopResponse = meuCaninoFeliz.GetTotalPrice(3, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 260);
        }

        [TestMethod]
        public void TotalPriceDogBath_Receiving_Weekend_Date()
        {
            // Arrange
            var meuCaninoFeliz = new MeuCaninoFeliz(20.0m, 40.0m, 2000);
            DateTime date = DateTime.Parse("28/07/2019");

            // Act
            PetShopResponseViewModel petShopResponse = meuCaninoFeliz.GetTotalPrice(4, 5, date);

            // Assert
            Assert.AreEqual(petShopResponse.TotalPriceDogBath, 336);
        } 
    }
}
