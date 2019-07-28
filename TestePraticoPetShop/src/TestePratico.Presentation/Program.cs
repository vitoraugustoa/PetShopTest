using System;
using TestePratico.Domain;
using TestePratico.Domain.Model;
using TestePratico.Domain.Services.Definition;
using TestePratico.Presentation.Services;
using TestePratico.Presentation.Services.Definition;

namespace TestePratico.Presentation
{
    public class Program
    {
       private static IPetShopServices _petShopService = new PetShopServices();
       private static IProgramServices _programServices = new ProgramServices();

        static void Main(string[] args)
        {
            var petShopInput = new PetShopInputViewModel();
            bool inputDataIsValid = true;

            do
            {
                Console.WriteLine("Digite os dados de entrada no formato, <data> <Quant Caes pequenos> <Quant Caes grandes>:");
                petShopInput = _programServices.FormatInputData(Console.ReadLine()); 
                inputDataIsValid = String.IsNullOrEmpty(petShopInput.ErrorMessage) ? true : false;    
            } while (inputDataIsValid == false);

            var petShopResponse = _petShopService.GetBetterPetShop(petShopInput);

            Console.WriteLine($"Melhor Canil: {petShopResponse.BestPetShopName}" );
            Console.WriteLine($"Preço Total: {petShopResponse.TotalPriceDogBath}");
            Console.ReadKey();
        }
    }
}
