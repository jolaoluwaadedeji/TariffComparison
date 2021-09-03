﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public interface ITariffComparer
    {
        IList<Product> CompareCost(decimal consumption);
    }
}
