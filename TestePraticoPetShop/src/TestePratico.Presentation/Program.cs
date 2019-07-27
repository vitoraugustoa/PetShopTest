using System;
using TestePratico.Domain;
using TestePratico.Domain.Model;
using TestePratico.Domain.Services.Definition;

namespace TestePratico.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            IPetShopServices petShopService = new PetShopServices();
            var input = new PetShopInputViewModel {
                DateOfBath = DateTime.Now,
                QuantityBigDogs = 2,
                QuantitySmallDogs = 3
            };

            var teste = petShopService.GetBestPetShop(input);

            Console.WriteLine($"Nome Ganhador: {teste.BestKennelName}" );
            Console.WriteLine($"Valor total: {teste.TotalPriceDogBath}");
            Console.WriteLine($"Distancia: {teste.DogKennelDistanceMetre}");
            Console.ReadKey();
        }
    }
}
