using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public class ProductA: IProduct
    {
        public const string NameOfProductA = "Basic Electricity Tariff";
        public string TariffName { get { return NameOfProductA; } }
        public decimal AnnualCost { get; set; }
    }
}
