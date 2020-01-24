from src.planet import Planet


def map_system(orbits_array):
    planets_dict = {}

    for parent, child in map(lambda x: x.split(')'), orbits_array):
        if parent not in planets_dict:
            planets_dict[parent] = Planet(parent, [])
        if child not in planets_dict:
            planets_dict[child] = Planet(child, [])

        planets_dict[child].root = False
        planets_dict[parent].planets.append(planets_dict[child])

    return list(filter(lambda p: p.root, planets_dict.values()))
