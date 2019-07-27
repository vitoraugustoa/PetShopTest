using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class MeuCaninoFeliz : PetShop
    {
        private IHelper _helper;
        private const decimal ADD_PERCENT_WEEKEND = 1.2m;

        public MeuCaninoFeliz()
        {
            PetShopName = "Meu Canino Feliz";
            SmallDogBathPrice = 20.0m;
            BigDogBathPrice = 40.0m;
            DogKennelDistanceMetre = 2000;
            _helper = new Helpers();
        }

        protected override decimal GetSmallDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? SmallDogBathPrice += SmallDogBathPrice * ADD_PERCENT_WEEKEND : SmallDogBathPrice;
        }

        protected override decimal GetBigDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? BigDogBathPrice += BigDogBathPrice * ADD_PERCENT_WEEKEND : BigDogBathPrice;
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
