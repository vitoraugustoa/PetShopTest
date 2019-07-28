using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;
using TestePratico.Presentation.Services;
using TestePratico.Presentation.Services.Definition;

namespace TestePratico.Tests
{
    [TestClass]
    public class ProgramServicesTest
    {
        private IProgramServices _ProgramServices = new ProgramServices();

        [TestMethod]
        public void FormatInputData_Receiving_Empty_Value()
        {
            // Arrange
            string inputData = String.Empty;

            // Act
            PetShopInputViewModel petShopInput = _ProgramServices.FormatInputData(inputData);

            // Assert
            Assert.IsNotNull(petShopInput.ErrorMessage);
        }

        [TestMethod]
        public void FormatInputData_Receiving_Invalid_Format()
        {
            // Arrange
            string inputData = "2013Teste 3239";

            // Act
            PetShopInputViewModel petShopInput = _ProgramServices.FormatInputData(inputData);

            // Assert
            Assert.IsNotNull(petShopInput.ErrorMessage);
        }

        [TestMethod]
        public void FormatInputData_Receiving_Valid_Format()
        {
            // Arrange
            string inputData = "03/08/2018 3 5";

            // Act
            PetShopInputViewModel petShopInput = _ProgramServices.FormatInputData(inputData);

            // Assert
            Assert.IsNull(petShopInput.ErrorMessage);
        }
    }
}
