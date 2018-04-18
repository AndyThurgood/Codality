import unittest
from Dominator import Dominator

class TestDominator(unittest.TestCase):

    def test_dominator_should_handle_empty_array(self):
        subject = Dominator()
        array = []
        self.assertEqual(-1, subject.solution(array))

    def test_dominator_should_process_simple_array(self):
        subject = Dominator()
        array = [3, 4, 3, 2, 3, -1, 3, 3]
        self.assertEqual(0, subject.solution(array))

    def test_dominator_should_process_one_value_array(self):
        subject = Dominator()
        array = [ 3 ]
        self.assertEqual(0, subject.solution(array))
    
    def test_dominator_should_process_complex_value_array(self):
        subject = Dominator()
        array = [ 3, 3, 3, 3, 5, 4, 4, 4, 4 ]
        self.assertEqual(-1, subject.solution(array))

if __name__ == '__main__':
    unittest.main()