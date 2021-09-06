using System;
using System.Collections.Generic;
using System.Text;

namespace TariffComparison.Domain.Models
{
    public class ProductB: IProduct
    {
        private decimal _consumption;
        public ProductB(decimal consumption)
        {
            _consumption = consumption;
        }
        public string TariffName { get { return "Packaged Tariff"; } }
        public decimal AnnualCost { get => CalculateTariff(_consumption); }
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
                    return  800.00M + ((consumption - 4000.00M) * 0.30M);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
