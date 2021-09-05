using System;
using System.Collections.Generic;
using TariffComparison.Domain;
using TariffComparison.Domain.Models;


namespace TariffComparison.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var productComparer = new Domain.Services.TariffComparison();
                var products = productComparer.Compare(3500.00M);
                foreach (Product product in products)
                {
                    Console.WriteLine($"Product Name: {product.TariffName}, Annual Cost: {product.AnnualCost}");
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
