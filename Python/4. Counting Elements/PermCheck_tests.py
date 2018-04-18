import unittest
from PermCheck import PermCheck

class TestPermCheck(unittest.TestCase):

    def test_perm_check_should_handle_empty_array(self):
        subject = PermCheck()
        array = []
        self.assertEqual(0, subject.solution(array))

    def test_perm_check_should_validate_valid_array(self):
        subject = PermCheck()
        array = [4, 1, 3, 2]
        self.assertEqual(1, subject.solution(array))

    def test_perm_check_should_validate_single_array(self):
        subject = PermCheck()
        array = [1]
        self.assertEqual(1, subject.solution(array))

    def test_perm_check_should_invalidate_invalid_array(self):
        subject = PermCheck()
        array = [4, 1, 2]
        self.assertEqual(0, subject.solution(array))

if __name__ == '__main__':
    unittest.main()
 