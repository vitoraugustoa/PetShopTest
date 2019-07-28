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

        public MeuCaninoFeliz(decimal _smallDogBathPrice, decimal _bigDogBathPrice, int _dogKennelDistanceMetre)
        {
            PetShopName = "Meu Canino Feliz";
            SmallDogBathPrice = _smallDogBathPrice;
            BigDogBathPrice = _bigDogBathPrice;
            DogKennelDistanceMetre = _dogKennelDistanceMetre;
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
