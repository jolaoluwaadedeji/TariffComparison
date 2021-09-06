using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public interface IProduct
    {
        string TariffName { get;}
        decimal AnnualCost { get;}
        decimal CalculateTariff(decimal consumption);
    }
}
