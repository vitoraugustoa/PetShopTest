using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class ChowChawGas : PetShop
    {
        public ChowChawGas()
        {
            PetShopName = "ChowChaw Gas";
            SmallDogBathPrice = 30.0m;
            BigDogBathPrice = 45.0m;
            DogKennelDistanceMetre = 800;
        }

        protected override decimal GetSmallDogPrice(DateTime dateOfBath)
        {
            return SmallDogBathPrice;
        }

        protected override decimal GetBigDogPrice(DateTime dateOfBath)
        {
            return BigDogBathPrice;
        }

        public override PetShopResponseViewModel GetTotalPrice(int QuantitySmallDogs, int QuantityBigDogs, DateTime DateOfBath)
        {
            var petShopResponde = new PetShopResponseViewModel
            {
                BestKennelName = PetShopName,
                DogKennelDistanceMetre = DogKennelDistanceMetre,
                TotalPriceDogBath = (GetSmallDogPrice(DateOfBath) * QuantitySmallDogs) +
                                              (GetBigDogPrice(DateOfBath) * QuantityBigDogs)
            };

            return petShopResponde;
        }
    }
}
