using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;

namespace TestePratico.Presentation.Services.Definition
{
    public interface IProgramServices
    {
        PetShopInputViewModel FormatInputData(string inputData);
    }
}
