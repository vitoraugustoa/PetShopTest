using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain;
using TestePratico.Domain.Model;
using TestePratico.Domain.Services.Definition;

namespace TestePratico.Tests
{
    [TestClass]
    public class PetShopServicesTest
    {
        IPetShopServices _petShopServices = new PetShopServices();

        [TestMethod]
        public void GetBetterPetShop_MeuCaninoFeliz_Winner()
        {
            // Arrange
            string winnerPetShopName = "Meu Canino Feliz";
            var petShopInput = new PetShopInputViewModel()
            {
                DateOfBath = DateTime.Parse("03/08/2018"),
                ErrorMessage = String.Empty,
                QuantitySmallDogs = 3,
                QuantityBigDogs = 5
            };

            // Act
            PetShopResponseViewModel petShopResponse = _petShopServices.GetBetterPetShop(petShopInput);

            // Assert
            Assert.AreEqual(petShopResponse.BestPetShopName, winnerPetShopName);
        }

        [TestMethod]
        public void GetBetterPetShop_ChowChawGas_Winner()
        {
            // Arrange
            string winnerPetShopName = "ChowChaw Gas";
            var petShopInput = new PetShopInputViewModel()
            {
                DateOfBath = DateTime.Parse("30/06/2019"),
                ErrorMessage = String.Empty,
                QuantitySmallDogs = 1,
                QuantityBigDogs = 8
            };

            // Act
            PetShopResponseViewModel petShopResponse = _petShopServices.GetBetterPetShop(petShopInput);

            // Assert
            Assert.AreEqual(petShopResponse.BestPetShopName, winnerPetShopName);
        }

        [TestMethod]
        public void GetBetterPetShop_VaiRex_Winner()
        {
            // Arrange
            string winnerPetShopName = "Vai Rex";
            var petShopInput = new PetShopInputViewModel()
            {
                DateOfBath = DateTime.Parse("28/07/2019"),
                ErrorMessage = String.Empty,
                QuantitySmallDogs = 2,
                QuantityBigDogs = 1
            };

            // Act
            PetShopResponseViewModel petShopResponse = _petShopServices.GetBetterPetShop(petShopInput);

            // Assert
            Assert.AreEqual(petShopResponse.BestPetShopName, winnerPetShopName);
        }
    }
}

