using System;
using System.Collections.Generic;
using System.Text;
using TariffComparison.Domain.Models;

namespace TariffComparison.Domain.Services
{
    public class CalculateTarrifServiceA : ICalculateTariffService
    {

        public decimal CalculateTariff(decimal consumption)
        {
            try
            {
                return  (5.00M * 12) + (consumption * 0.22M);
            }
            catch (Exception)
            {
                throw;
            }  
        }
    }
}
