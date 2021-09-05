﻿using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TariffComparison.Domain.Models;
using TariffComparison.Domain.Services;
using Xunit;

namespace TarrifComparison.UnitTests
{
    public class TariffComaprisonTest
    {
        private readonly Mock<TariffComparer> _mockTariffComparer;
        public TariffComaprisonTest()
        {
            _mockTariffComparer = new Mock<TariffComparer>();
        }
        [Fact]
        public void Given_ConsumptionWasPassed_When_CallingCompareCostMethod_Then_ListOfProductsAreReturned()
        {
            //Arrange
            //_mockTariffComparer.Setup(x => x.CompareCost(3500.00M)).Returns(GetProducts());

            var sut = new TariffComparer();

            //Act
            var actual = sut.Compare(3500.00M);

            var expected = CompareProducts();
            //Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Given_ListOfProductsWasReturned_When_CallingCompareCostMethod_Then_ListShouldContainTwoItems()
        {
            var sut = new TariffComparer();

            //Act
            var actual = sut.Compare(3500.00M);

            var expected = CompareProducts();
            //Assert
            Assert.Equal(actual.Count, expected.Count);
        }

        [Fact]
        public void Given_ListOfProductsWasReturned_When_CallingCompareCostMethod_Then_ListShouldBeOrdered()
        {
            var sut = new TariffComparer();

            //Act
            var actual = sut.Compare(3500.00M);

            var expected = CompareProducts();
            //Assert
            Assert.True(actual[0].AnnualCost <= actual[1].AnnualCost);
        }
        public IList<IProduct> CompareProducts()
        {
            return new List<IProduct>() {
                new ProductA(3500.00M),
                new ProductB(3500.00M),
            }.OrderBy(x=> x.AnnualCost).ToList();
        }
    }
}
