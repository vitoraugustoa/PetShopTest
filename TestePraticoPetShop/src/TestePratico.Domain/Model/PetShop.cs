using System;
using System.Collections.Generic;
using System.Text;

namespace TestePratico.Domain.Model
{
    public abstract class PetShop
    {
        public string PetShopName { get; protected set; }
        public decimal SmallDogBathPrice { get; protected set; }
        public decimal BigDogBathPrice { get; protected set; }
        public decimal TotalPrice { get; protected set; }
        public int DogKennelDistanceMetre { get; protected set; }

        protected virtual decimal GetSmallDogPrice(DateTime dateOfBath)
        {
            return SmallDogBathPrice;
        }

        protected virtual decimal GetBigDogPrice(DateTime dateOfBath)
        {
            return BigDogBathPrice;
        }

        public virtual PetShopResponseViewModel GetTotalPrice(int QuantitySmallDogs, int QuantityBigDogs, DateTime DateOfBath)
        {
            return new PetShopResponseViewModel
            {
                BestPetShopName = PetShopName,
                DogKennelDistanceMetre = DogKennelDistanceMetre,
                TotalPriceDogBath = (GetSmallDogPrice(DateOfBath) * QuantitySmallDogs) +
                                              (GetBigDogPrice(DateOfBath) * QuantityBigDogs)
            };
        }
    }
}
