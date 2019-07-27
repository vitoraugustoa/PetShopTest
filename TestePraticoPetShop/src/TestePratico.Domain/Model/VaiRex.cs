using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class VaiRex : PetShop
    {
        private IHelper _helper;
        private const decimal ADD_PRICE_WEEKEND = 5.0m;

        public VaiRex()
        {
            PetShopName = "Vai Rex";
            SmallDogBathPrice = 20.0m;
            BigDogBathPrice = 40.0m;
            DogKennelDistanceMetre = 1700;
            _helper = new Helpers();
        }

        protected override decimal GetSmallDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? SmallDogBathPrice += ADD_PRICE_WEEKEND : SmallDogBathPrice;
        }

        protected override decimal GetBigDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? BigDogBathPrice += ADD_PRICE_WEEKEND : BigDogBathPrice;
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
