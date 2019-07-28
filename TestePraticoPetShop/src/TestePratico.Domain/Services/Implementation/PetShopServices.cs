using System.Collections.Generic;
using TestePratico.Domain.Model;
using TestePratico.Domain.Services.Definition;
using System.Linq;

namespace TestePratico.Domain
{
    public class PetShopServices : IPetShopServices
    {
        public PetShopResponseViewModel GetBetterPetShop(PetShopInputViewModel petShopInput)
        {
            var petShopResponseList = new List<PetShopResponseViewModel>();
            var vaiRex = new VaiRex(15.0m, 50.0m, 1700);
            var meuCaninoFeliz = new MeuCaninoFeliz(20.0m, 40.0m, 2000);
            var chowChawGas = new ChowChawGas(30.0m, 45.0m, 800);

            PetShopResponseViewModel totalPriceVaiRexPetShop = vaiRex.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);
            PetShopResponseViewModel totalPriceMeuCaninoFelizPetShop = meuCaninoFeliz.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);
            PetShopResponseViewModel totalPriceChowChawGasPetShop = chowChawGas.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);
            
            petShopResponseList.Add(totalPriceVaiRexPetShop);
            petShopResponseList.Add(totalPriceMeuCaninoFelizPetShop);
            petShopResponseList.Add(totalPriceChowChawGasPetShop);

            return petShopResponseList.OrderBy(p => p.TotalPriceDogBath).ThenBy(p => p.DogKennelDistanceMetre).FirstOrDefault();
        }

    }
}
