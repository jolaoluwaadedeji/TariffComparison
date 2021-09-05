using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public interface ICalculateTariffService
    {
        decimal CalculateTariff(decimal consumption);

    }
}
