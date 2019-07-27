using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Model;
using TestePratico.Domain.Services.Definition;
using System.Linq;

namespace TestePratico.Domain
{
    public class PetShopServices : IPetShopServices
    {
        public PetShopResponseViewModel GetBestPetShop(PetShopInputViewModel petShopInput)
        {
            var petShops = new List<PetShopResponseViewModel>();
            var vaiRex = new VaiRex();
            var meuCaninoFeliz = new MeuCaninoFeliz();
            var chowChawGas = new ChowChawGas();

            PetShopResponseViewModel totalPriceMeuCaninoFelizPetShop = meuCaninoFeliz.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);
            PetShopResponseViewModel totalPriceChowChawGasPetShop = chowChawGas.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);
            PetShopResponseViewModel petShopResponseVaiRex = vaiRex.GetTotalPrice(petShopInput.QuantitySmallDogs,
                                                                                    petShopInput.QuantityBigDogs,
                                                                                    petShopInput.DateOfBath);

            petShops.Add(petShopResponseVaiRex);
            petShops.Add(totalPriceChowChawGasPetShop);
            petShops.Add(totalPriceMeuCaninoFelizPetShop);

            //var lista = (from p in petShops
            //             orderby p.DogKennelDistanceMetre descending
            //             select new
            //             {
            //                 total = p.TotalPriceDogBath,
            //                 nome = p.BestKennelName
            //             }).Min();

            return petShops.OrderBy(p => p.TotalPriceDogBath).ThenBy(p => p.DogKennelDistanceMetre).FirstOrDefault();
        }

    }
}
