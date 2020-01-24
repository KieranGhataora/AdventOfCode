import sys
from functools import reduce

from src.orbit_calculator import count_total_orbits
from src.planet_mapper import map_system

sys.setrecursionlimit(10000)

orbits_array = open('../input.txt').read().split()

mapped_system = map_system(orbits_array)

print(reduce(lambda x, y: x + y,
             map(lambda system: count_total_orbits(system), mapped_system)
             ))
