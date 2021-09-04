using Moq;
using System;
using System.Collections.Generic;
using TariffComparison.Domain.Models;
using TariffComparison.Domain.Services;
using Xunit;

namespace TarrifComparison.UnitTests
{
    public class UnitTest
    {
        private readonly Mock<ITariffComparer> _mockTariffComparer;
        public UnitTest()
        {
            _mockTariffComparer = new Mock<ITariffComparer>();
        }
        [Fact]
        public void Given_ConsumptionWasPassed_When_CallingCompareCostMethod_Then_ListOfProductsAreReturned()
        {
            //Arrange
            _mockTariffComparer.Setup(x => x.CompareCost(3500.00M)).Returns(GetProducts());

            var sut = new TariffComparerService(_mockTariffComparer.Object);

            //Act
            var result = sut.CompareCost(3500.00M);

            //Assert
            Assert.NotEmpty(result);
        }

        [Fact]
        public void Given_ListOfProductsWasReturned_When_CallingCompareCostMethod_Then_ListShouldContainTwoItems()
        {
            //Arrange
            _mockTariffComparer.Setup(x => x.CompareCost(3500.00M)).Returns(GetProducts());

            var sut = new TariffComparerService(_mockTariffComparer.Object);

            //Act
            var result = sut.CompareCost(3500.00M);

            //Assert
            Assert.Equal(result.Count, GetProducts().Count);
        }

        public IList<Product> GetProducts()
        {
            return new List<Product>() {
                new Product() { TariffName = "Basic Electricity Tariff", AnnualCost = 830.00M },
                new Product() { TariffName = "Packaged Tariff", AnnualCost = 800.00M },
            };
        }
    }
}
