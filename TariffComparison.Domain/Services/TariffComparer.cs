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
        public IDictionary<decimal, IOrderedEnumerable<IProduct>> CompareCost(List<decimal> consumption)
        {
            try
            {
                var baseCost = 5.00M;
                var consumptionCost = 0.22M;
                var additionalCost = 0.30M;
                IDictionary<decimal, IOrderedEnumerable<IProduct>> tariffCompare = new Dictionary<decimal, IOrderedEnumerable<IProduct>>();
                IList<ProductA> productA = new List<ProductA>();
                IList<ProductB> productB = new List<ProductB>();
                ProductA annualProductA;
                ProductB annualProductB;
                consumption.ForEach(x=> {
                    annualProductA = new ProductA { AnnualCost = (baseCost * 12) + (consumptionCost * x) };
                    productA.Add(annualProductA);
                    annualProductB = new ProductB { AnnualCost = x <= 4000.00M ? 800.00M : 800.00M + (x - 4000.00M) * additionalCost };
                    productB.Add(annualProductB);
                    tariffCompare.Add(x, new List<IProduct>() { annualProductA, annualProductB }.OrderBy(x=> x.AnnualCost));
                });
                return tariffCompare;
            }
            catch (Exception)
            {
                throw;
            }      
        }
    }
}
