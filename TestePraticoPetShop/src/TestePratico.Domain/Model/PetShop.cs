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

        protected abstract decimal GetSmallDogPrice(DateTime dateOfBath);
        protected abstract decimal GetBigDogPrice(DateTime dateOfBath);
        public abstract PetShopResponseViewModel GetTotalPrice(int QuantitySmallDogs, int QuantityBigDogs, DateTime DateOfBath);
    }
}
