import unittest

from src.wirepathprocessor import get_list_of_points_from_wire_path, find_intersections


class TestWirePathProcessor(unittest.TestCase):
    def test_get_list_of_points_from_wire_path_returns_correct_list(self):
        tests = [
            (["R1"], [(0, 0), (0, 1)]),
            (["L1"], [(0, 0), (0, -1)]),
            (["U1"], [(0, 0), (1, 0)]),
            (["D1"], [(0, 0), (-1, 0)]),
            (["R2", "L3", "U1", "D3"], [(0, 0), (0, 1), (0, 2), (0, 1), (0, 0), (0, -1), (1, -1), (0, -1), (-1, -1), (-2, -1)])
        ]
        for (instructionArray, expected) in tests:
            with self.subTest(instructionArray=instructionArray):
                self.assertEqual(get_list_of_points_from_wire_path(instructionArray), expected)

    def test_find_intersections_returns_correct_intersections(self):
        tests = [
            ([(0, 0), (0, 1), (0, 2)], [(0, 0), (0, 3), (0, 2)], [(0, 0), (0, 2)]),
            ([(0, 0), (0, 5), (0, 9), (0, 8), (1, 5), (8, 5)], [(0, 0), (0, 3), (0, 9), (1, 5), (0, 2)], [(0, 0), (0, 9), (1, 5)])
        ]
        for (pointsA, pointsB, expected) in tests:
            with self.subTest(pointsA=pointsA, pointsB=pointsB):
                self.assertEqual(find_intersections(pointsA, pointsB), expected)


if __name__ == '__main__':
    unittest.main()
