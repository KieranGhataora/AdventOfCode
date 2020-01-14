import unittest

from src.passwordvalidator import validatePassword, validatePasswordPartTwo


class ValidatePasswordTests(unittest.TestCase):
    def test_validatepassword_returns_correct_passwords(self):
        tests = [
            (111111, (1, 99999999))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertTrue(validatePassword(password, givenrange))


    def test_validatepassword_rejects_non_six_digit_password(self):
        tests = [
            (1234467, (1, 99999999)),
            (12344, (1, 99999999))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertFalse(validatePassword(password, givenrange))

    def test_validatepassword_rejects_passwords_out_of_range(self):
        tests = [
            (123446, (1, 2)),
            (-111, (1, 2))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertFalse(validatePassword(password, givenrange))

    def test_validatepassword_rejects_passwords_witout_at_least_two_adjacent_identical_numbers(self):
        tests = [
            (123789, (1, 99999999))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertFalse(validatePassword(password, givenrange))

    def test_validatepassword_rejects_passwords_with_descending_numbers(self):
        tests = [
            (223450, (1, 99999999))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertFalse(validatePassword(password, givenrange))

    def test_validatepasswordparttwo_rejects_passwords_with_descending_numbers(self):
        tests = [
            (223450, (1, 123444))
        ]
        for (password, givenrange) in tests:
            with self.subTest(password=password, givenrange=givenrange):
                self.assertFalse(validatePasswordPartTwo(password, givenrange))


if __name__ == '__main__':
    unittest.main()
