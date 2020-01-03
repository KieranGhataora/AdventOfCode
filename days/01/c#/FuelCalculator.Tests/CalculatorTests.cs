using System;
using Xunit;

namespace FuelCalculator.Tests
{
    public class CalculatorTests
    {
        private Calculator calculator = new Calculator();
        
        [Theory]
        [InlineData(12, 2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        public void CalculateFuel_ReturnsCorrectValue(decimal weight, decimal expectedFuelRequirement)
        {
            Assert.Equal(expectedFuelRequirement, calculator.CalculateFuelForWeight(weight));
        }
        
        [Theory]
        [InlineData(14, 2)]
        [InlineData(1969, 966)]
        [InlineData(100756, 50346)]
        public void CalculateTotalFuel_ReturnsCorrectValue(decimal weight, decimal expectedFuelRequirement)
        {
            Assert.Equal(expectedFuelRequirement, calculator.CalculateTotalFuel(calculator.CalculateFuelForWeight(weight)));
        }

    }
}
