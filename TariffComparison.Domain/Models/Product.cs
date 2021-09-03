using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public class Product
    {
        public string TariffName { get; set; }
        public decimal AnnualCost { get; set; }
    }
}
