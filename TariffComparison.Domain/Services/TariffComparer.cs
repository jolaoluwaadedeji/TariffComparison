using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public class TariffComparer : ITariffComparer
    {
        public const string NameOfProductA = "Basic Electricity Tariff";
        public const string NameOfProductB = "Packaged Tariff";
        public TariffComparer()
        {

        }
        public IList<Product> CompareCost(decimal consumption)
        {
            try
            {
                var baseCost = 5.00M;
                var consumptionCost = 0.22M;
                var additionalCost = 0.30M;
                IList<Product> products = new List<Product>
                {
                    new Product() { AnnualCost = (baseCost * 12) + (consumptionCost * consumption), TariffName = NameOfProductA },
                    new Product() { AnnualCost = consumption <= 4000.00M ? 800.00M : 800.00M + (consumption - 4000.00M) * additionalCost, TariffName = NameOfProductB }
                };
                return products.OrderBy(x => x.AnnualCost).ToList();
            }
            catch (Exception)
            {
                throw;
            }      
        }
    }
}
