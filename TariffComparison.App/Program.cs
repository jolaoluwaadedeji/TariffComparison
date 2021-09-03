using System;
using System.Collections.Generic;
using TariffComparison.Domain;
using TariffComparison.Domain.Models;
using TariffComparison.Domain.Services;

namespace TariffComparison
{
    class Program
    {
        private static readonly ITariffComparerService _tariffComparerService = new TariffComparerService(new TariffComparer());
        static void Main(string[] args)
        {
            try
            {
                var products = _tariffComparerService.CompareCost(6000.00M);
                foreach (Product product in products)
                {
                    Console.WriteLine($"Annual cost for {product.TariffName} is {product.AnnualCost}");
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred. Details => Message: {ex.Message}, Stack Trace: {ex.StackTrace}");
            }           
        }
    }
}
