using System;
using System.Collections.Generic;
using TariffComparison.Domain;
using TariffComparison.Domain.Models;
using TariffComparison.Domain.Services;

namespace TariffComparison.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var productComparer = new TariffComparer();
                var products = productComparer.CompareTariff(3500.00M);
                foreach (IProduct product in products)
                {
                    Console.WriteLine($"Product Name: {product.TariffName}, Annual Cost: {Convert.ToInt32(product.AnnualCost)}");
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
