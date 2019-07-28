using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class ChowChawGas : PetShop
    {
        public ChowChawGas(decimal _smallDogBathPrice, decimal _bigDogBathPrice, int _dogKennelDistanceMetre)
        {
            PetShopName = "ChowChaw Gas";
            SmallDogBathPrice = _smallDogBathPrice;
            BigDogBathPrice = _bigDogBathPrice;
            DogKennelDistanceMetre = _dogKennelDistanceMetre;
        }
    }
}
