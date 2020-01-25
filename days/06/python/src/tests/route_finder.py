def find_route(planet_x, planet_y):
    common_planet = None
    searched_x = [planet_x]
    searched_y = [planet_y]

    while common_planet is None:
        if searched_x[-1].parent is not None:
            searched_x.append(searched_x[-1].parent)
        if searched_y[-1].parent is not None:
            searched_y.append(searched_y[-1].parent)

        intersection = list(set(searched_x) & set(searched_y))

        if len(intersection) > 0:
            common_planet = intersection[0]

    val = searched_x.index(common_planet) + searched_y.index(common_planet) - 2
    return val
