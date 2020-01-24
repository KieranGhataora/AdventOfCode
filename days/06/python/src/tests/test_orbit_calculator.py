import pytest

from src.orbit_calculator import count_total_orbits
from src.planet import Planet

planetArray = Planet("COM", [
    Planet("B", [
        Planet("G", [Planet("H", [])]),
        Planet("C", [Planet("D", [
            Planet("I", []),
            Planet("E", [
                Planet("F", []),
                Planet("J", [
                    Planet("K", [
                        Planet("L", [])
                    ])
                ])
            ])
        ])])
    ])
])


@pytest.mark.parametrize("test_input, expected", [
    (planetArray, 42)
])
def test_count_orbits_calculates_correct_number_of_orbits(test_input, expected):
    x = count_total_orbits(test_input)
    assert x == expected
