using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public interface IProduct
    {
        public string TariffName { get; }
        decimal AnnualCost { get;}
    }
}
