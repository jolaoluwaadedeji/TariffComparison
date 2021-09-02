using System;
using System.Collections.Generic;
using TariffComparison.Domain;
using TariffComparison.Domain.Services;

namespace TariffComparison
{
    class Program
    {
        private static readonly ITariffComparer _tariffComparer = new TariffComparer();
        static void Main(string[] args)
        {
            var result = _tariffComparer.CompareCost(new List<decimal>() {3500.00M, 4500.00M, 6000.00M });
        }
    }
}
