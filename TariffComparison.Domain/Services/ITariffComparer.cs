using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public interface ITariffComparer
    {
        IDictionary<decimal, IOrderedEnumerable<IProduct>> CompareCost(List<decimal> consumption);
    }
}
