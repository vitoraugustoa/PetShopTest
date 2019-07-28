using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;
using TestePratico.Presentation.Services.Definition;

namespace TestePratico.Presentation.Services
{
    public class ProgramServices : IProgramServices
    {
        public PetShopInputViewModel FormatInputData(string inputData)
        {
            string[] data = inputData.Split(' ');

            try
            {
                var petShopInput = new PetShopInputViewModel()
                {
                    DateOfBath = Convert.ToDateTime(data[0]),
                    QuantitySmallDogs = Convert.ToInt32(data[1]),
                    QuantityBigDogs = Convert.ToInt32(data[2])
                };

                return petShopInput;
            }
            catch(Exception e)
            {
                return new PetShopInputViewModel()
                {
                    ErrorMessage = e.Message
                };
            }
        }
    }
}
