from src.fuelcalculator import basic_fuel_calc, fuel_calc_with_fuel_weighting

with open(r'../input.txt', 'r') as f:
    weight_values_array = map(lambda x: int(x), f.readlines())

basicFuelValue = 0
advancedFuelValue = 0

for weight_value in weight_values_array:
    basicFuelValue += basic_fuel_calc(weight_value)
    advancedFuelValue += fuel_calc_with_fuel_weighting(weight_value)

print(basicFuelValue)
print(advancedFuelValue)
