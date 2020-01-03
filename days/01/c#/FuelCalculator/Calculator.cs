using System;

namespace FuelCalculator
{
    public class Calculator
    {
        public decimal CalculateFuelForWeight(decimal fuelWeight) => Math.Floor(fuelWeight / 3) - 2;

        public decimal CalculateTotalFuel(decimal fuelRequired) => fuelRequired <= 0 ? 0: fuelRequired +  CalculateTotalFuel(CalculateFuelForWeight(fuelRequired));
    }
}