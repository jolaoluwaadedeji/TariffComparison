using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public class ProductA : IProduct
    {
        private decimal _consumption;
        public ProductA(decimal consumption)
        {
            _consumption = consumption;
        }
        public string TariffName { get { return "Basic Electricity Tariff"; } }
        public decimal AnnualCost { get => CalculateTariff(_consumption); }
        public decimal CalculateTariff(decimal consumption)
        {
            try
            {
                 return (5.00M * 12) + (consumption * 0.22M);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
