import unittest
from Distinct import Distinct

class TestDistinct(unittest.TestCase):

    def test_distinct_should_handle_empty_array(self):
        subject = Distinct()
        array = []
        self.assertEqual(0, subject.solution(array))

    def test_distinct_should_process_simple_array(self):
        subject = Distinct()
        array = [2, 1, 1, 2, 3, 1]
        self.assertEqual(3, subject.solution(array))

    def test_distinct_should_process_complex_array(self):
        subject = Distinct()
        array = [2, 1, 1, 2, 3, 1, 2, 1, 1, 2, 3, 1, 2, 1, 1, 2, 3, 1,
                            5, 7, 8, 3, 2, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 6, 7]
        self.assertEqual(10, subject.solution(array))

if __name__ == '__main__':
    unittest.main()