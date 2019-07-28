using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class MeuCaninoFeliz : PetShop
    {
        private IHelpers _helper;
        private const decimal ADD_PERCENT_WEEKEND = 1.2m;

        public MeuCaninoFeliz(decimal smallDogBathPrice, decimal bigDogBathPrice, int dogKennelDistanceMetre)
        {
            PetShopName = "Meu Canino Feliz";
            SmallDogBathPrice = smallDogBathPrice;
            BigDogBathPrice = bigDogBathPrice;
            DogKennelDistanceMetre = dogKennelDistanceMetre;
            _helper = new Helpers();
        }

        protected override decimal GetSmallDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? SmallDogBathPrice = SmallDogBathPrice * ADD_PERCENT_WEEKEND : SmallDogBathPrice;
        }

        protected override decimal GetBigDogPrice(DateTime dateOfBath)
        {
            return (_helper.IsWeekend(dateOfBath)) ? BigDogBathPrice = BigDogBathPrice * ADD_PERCENT_WEEKEND : BigDogBathPrice;
        }
    }
}
