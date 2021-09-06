using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
   public class TariffComparer
    {
        public IList<IProduct> CompareTariff(decimal consumption)
        {
            IProduct productA = new ProductA(consumption);
            IProduct productB = new ProductB(consumption);
            var products = new List<IProduct>
            {
                productA,
                productB
            };
            return products.OrderBy(x => x.AnnualCost).ToList();
        }
    }
}
