using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public interface ITariffComparerService
    {
        IList<Product> CompareCost(decimal consumption);

    }
}
