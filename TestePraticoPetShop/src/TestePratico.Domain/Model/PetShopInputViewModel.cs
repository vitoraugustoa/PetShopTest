using System;
using System.Collections.Generic;

namespace TestePratico.Domain.Model
{
    public class PetShopInputViewModel
    {
        public DateTime DateOfBath { get; set; }
        public int QuantitySmallDogs { get; set; }
        public int QuantityBigDogs { get; set; }
        public string ErrorMessage { get; set; }
    }
}
