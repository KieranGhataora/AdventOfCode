import unittest

from src.circuitsolver import findEarliestIntersection, findClosestIntersection


class MyTestCase(unittest.TestCase):
    def test_runA_returns_correct_values(self):
        tests = [
            (["R8,U5,L5,D3", "U7,R6,D4,L4"], 6),
            (["R75,D30,R83,U83,L12,D49,R71,U7,L72",
              "U62,R66,U55,R34,D71,R55,D58,R83"], 159),
            (["R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51",
              "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"], 135)
        ]
        for (instructions, expected) in tests:
            with self.subTest(instructions=instructions):
                self.assertEqual(findClosestIntersection(instructions), expected)

    def test_runB_returns_correct_values(self):
        tests = [
            (["R8,U5,L5,D3", "U7,R6,D4,L4"], 30),
            (["R75,D30,R83,U83,L12,D49,R71,U7,L72",
              "U62,R66,U55,R34,D71,R55,D58,R83"], 610),
            (["R98,U47,R26,D63,R33,U87,L62,D20,R33,U53,R51",
              "U98,R91,D20,R16,D67,R40,U7,R15,U6,R7"], 410)
        ]
        for (instructions, expected) in tests:
            with self.subTest(instructions=instructions):
                self.assertEqual(findEarliestIntersection(instructions), expected)


if __name__ == '__main__':
    unittest.main()
