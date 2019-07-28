using System;
using System.Collections.Generic;
using System.Text;
using TestePratico.Domain.Helper;
using TestePratico.Domain.Helper.Definition;

namespace TestePratico.Domain.Model
{
    public class ChowChawGas : PetShop
    {
        public ChowChawGas(decimal smallDogBathPrice, decimal bigDogBathPrice, int dogKennelDistanceMetre)
        {
            PetShopName = "ChowChaw Gas";
            SmallDogBathPrice = smallDogBathPrice;
            BigDogBathPrice = bigDogBathPrice;
            DogKennelDistanceMetre = dogKennelDistanceMetre;
        }
    }
}
