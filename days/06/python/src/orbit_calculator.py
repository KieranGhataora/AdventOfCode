from functools import reduce

from src.planet import Planet


def count_total_orbits(planet_system: Planet):
    return __count_planets(planet_system, 0)


def __count_planets(system: Planet, depth):
    if len(system.planets) == 0:
        return depth

    return depth + reduce(lambda y, z: y + z,
                          map((lambda x: __count_planets(x, depth + 1)), system.planets))
