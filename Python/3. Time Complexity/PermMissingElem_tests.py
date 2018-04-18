import unittest
from PermMissingElem import PermMissingElem

class TestPermMissingElem(unittest.TestCase):

    def test_perm_missing_elem_should_handle_empty_array(self):
        subject = PermMissingElem()
        array = []
        self.assertEqual(1, subject.solution(array))

    def test_perm_missing_elem_should_process_simple_value(self):
        subject = PermMissingElem()
        array = [2, 3, 1, 5]
        self.assertEqual(4, subject.solution(array))

    def test_perm_missing_elem_should_process_single_value(self):
        subject = PermMissingElem()
        array = [2]
        self.assertEqual(1, subject.solution(array))

    def test_perm_missing_elem_should_process_complex_value(self):
        subject = PermMissingElem()
        array = [2, 3, 1, 5, 4, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20,
                            21, 23, 24, 25, 26, 27, 28, 29, 30]
        self.assertEqual(22, subject.solution(array))

if __name__ == '__main__':
    unittest.main()
