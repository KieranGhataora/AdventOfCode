import math


def basic_fuel_calc(weight_value):
    return math.floor(weight_value / 3) - 2


def fuel_calc_with_fuel_weighting(weight_value):
    return _fuel_calc_recursive(basic_fuel_calc(weight_value))


def _fuel_calc_recursive(fuel_value):
    if fuel_value <= 0:
        return 0
    else:
        return fuel_value + _fuel_calc_recursive(basic_fuel_calc(fuel_value))
