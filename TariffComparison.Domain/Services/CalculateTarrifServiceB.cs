using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    class CalculateTarrifServiceB : ICalculateTariffService
    {
        public decimal CalculateTariff(decimal consumption)
        {
            try
            {
                if (consumption <= 4000.00M)
                {
                    return 800.00M;
                }
                else
                {
                    var  annualCost =  800.00M + ((consumption - 4000.00M) * 0.30M);
                    return annualCost;
                }
            }
            catch (Exception)
            {
                throw;
            }  
        }
    }
}
