using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;

namespace TestePratico.Domain.Services.Definition
{
    public interface IPetShopServices
    {
       PetShopResponseViewModel GetBestPetShop(PetShopInputViewModel petShopInput);
    }
}
