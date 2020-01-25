import pytest

from .orbit_calculator import count_total_orbits
from .planet import Planet

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


@pytest.mark.parametrize("test_input, expected, expected2", [
    (planetArray, 11, 31)
])
def test_count_orbits_calculates_correct_number_of_orbits(test_input, expected, expected2):
    direct_orbits, indirect_orbits = count_total_orbits(test_input)

    print(direct_orbits)
    print(indirect_orbits)
    assert direct_orbits + indirect_orbits == expected

