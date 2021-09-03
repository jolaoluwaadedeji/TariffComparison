using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public class TariffComparerService: ITariffComparerService
    {
        private readonly ITariffComparer _tariffComparer; 
        public TariffComparerService(ITariffComparer tariffComparer)
        {
            _tariffComparer = tariffComparer;
        }

        public IList<Product> CompareCost(decimal consumption)
        {
           return _tariffComparer.CompareCost(consumption);
        }
    }
}
