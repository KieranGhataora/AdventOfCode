import pytest

from src.planet_mapper import map_system
from src.tests.route_finder import find_route

system, planets_dict = map_system(["COM)B",
                                   "B)C",
                                   "C)D",
                                   "D)E",
                                   "E)F",
                                   "B)G",
                                   "G)H",
                                   "D)I",
                                   "E)J",
                                   "J)K",
                                   "K)L",
                                   "K)YOU",
                                   "I)SAN"])


def test_returns_correct_number_of_orbital_transfers():
    assert find_route(planets_dict["YOU"], planets_dict["SAN"]) == 4
