using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
   public class TariffComparison
    {
        public IList<Product> Compare(decimal consumption)
        {
            var productA = new Product()
            {
                TariffName = "Basic Electricity tariff",
                AnnualCost = new CalculateTarrifServiceA().CalculateTariff(consumption)
            };

            var productB = new Product()
            {
                TariffName = "Packaged  tariff",
                AnnualCost = new CalculateTarrifServiceB().CalculateTariff(consumption)
            };

           var products = new List<Product>();
            products.Add(productA);
            products.Add(productB);
            return products.OrderBy(x => x.AnnualCost).ToList();
        }
    }
}
