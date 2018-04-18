import unittest
from MissingIntegers import MissingIntegers

class TestMissingIntegers(unittest.TestCase):

    def test_missing_integers_should_handle_empty_array(self):
        subject = MissingIntegers()
        array = []
        self.assertEqual(1, subject.solution(array))

    def test_missing_integers_should_handle_negative_array(self):
        subject = MissingIntegers()
        array = [-1, -2, -3]
        self.assertEqual(1, subject.solution(array))

    def test_missing_integers_should_handle_simple_array(self):
        subject = MissingIntegers()
        array = [1, 2, 3, 6, 7, 8, 9]
        self.assertEqual(4, subject.solution(array))

    def test_missing_integers_should_handle_sequential_array(self):
        subject = MissingIntegers()
        array = [1, 2, 3]
        self.assertEqual(4, subject.solution(array))
    
    def test_missing_integers_should_handle_mixed_array(self):
        subject = MissingIntegers()
        array = [-1000, 2000]
        self.assertEqual(1, subject.solution(array))
    
    def test_missing_integers_should_handle_max_values_array(self):
        subject = MissingIntegers()
        array = [-100000, 100000]
        self.assertEqual(1, subject.solution(array))

if __name__ == '__main__':
    unittest.main()
 