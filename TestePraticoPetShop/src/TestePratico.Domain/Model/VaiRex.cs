using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class VaiRex : PetShop
    {
        private IHelpers _helper;
        private const decimal ADD_PRICE_WEEKEND = 5.0m;

        public VaiRex(decimal _smallDogBathPrice,decimal _bigDogBathPrice, int _dogKennelDistanceMetre)
        {
            PetShopName = "Vai Rex";
            SmallDogBathPrice = _smallDogBathPrice;
            BigDogBathPrice = _bigDogBathPrice;
            DogKennelDistanceMetre = _dogKennelDistanceMetre;
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
    }
}
