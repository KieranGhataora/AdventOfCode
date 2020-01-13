import unittest
from src.distancecalc import manhattan_distance


class MyTestCase(unittest.TestCase):
    def test_manhattan_distance(self):
        tests = [
            ([12, 1], [12, 1], 0),
            ([15, -1], [10, 9], 15),
            ([11, -38, 5], [84, 9, 27], 142)
        ]
        for (x, y, expected) in tests:
            with self.subTest(x=x, y=y):
                self.assertEqual(manhattan_distance(x, y), expected)


if __name__ == '__main__':
    unittest.main()
