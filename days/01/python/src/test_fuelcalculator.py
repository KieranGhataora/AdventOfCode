import unittest

from src.fuelcalculator import basic_fuel_calc, fuel_calc_with_fuel_weighting


class TestBasicFuelCalc(unittest.TestCase):
    def test_basic_fuel_calc(self):
        tests = [
            (12, 2),
            (14, 2),
            (1969, 654),
            (100756, 33583)
        ]
        for value, expected in tests:
            with self.subTest(value=value):
                self.assertEqual(basic_fuel_calc(value), expected)

    def test_fuel_calc_with_weighting(self):
        tests = [
            (14, 2),
            (1969, 966),
            (100756, 50346)
        ]
        for value, expected in tests:
            with self.subTest(value=value):
                self.assertEqual(fuel_calc_with_fuel_weighting(value), expected)

if __name__ == '__main__':
    unittest.main()
