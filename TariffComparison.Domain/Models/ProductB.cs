using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public class ProductB: IProduct
    {
        public const string NameOfProductB = "Packaged  Tariff";
        public string TariffName { get { return NameOfProductB; } }
        public decimal AnnualCost { get; set; }
    }
}
