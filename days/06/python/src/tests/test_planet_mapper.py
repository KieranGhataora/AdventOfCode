import pytest

from src.planet import Planet
from src.planet_mapper import map_system

planetArray = Planet("COM", [
    Planet("B", [
        Planet("C", [Planet("D", [
            Planet("E", [
                Planet("F", []),
                Planet("J", [
                    Planet("K", [
                        Planet("L", [])
                    ])
                ])
            ]),
            Planet("I", []),
        ])]),
        Planet("G", [Planet("H", [])]),
    ])
])

input = ["COM)B",
         "B)C",
         "C)D",
         "D)E",
         "E)F",
         "B)G",
         "G)H",
         "D)I",
         "E)J",
         "J)K",
         "K)L"]


@pytest.mark.parametrize("test_input, expected", [
    (input, planetArray)
])
def test_count_orbits_calculates_correct_number_of_orbits(test_input, expected):
    planets = map_system(test_input)
    assert planets.toJSON() == planetArray.toJSON()
