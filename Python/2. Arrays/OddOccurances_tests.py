import unittest
from OddOccurances import OddOccurances

# Tests to support the binary gap solution
class TestOddOccurances(unittest.TestCase):

    def test_cyclic_Rotation_should_handle_zero_value(self):
        subject = OddOccurances()
        self.assertEqual(0, subject.solution([]))
    
    def test_cyclic_Rotation_should_process_simple_value(self):
        subject = OddOccurances()
        array = [1, 5, 9, 1, 4, 5, 9, 4, 11]
        self.assertEqual(11, subject.solution(array))

    def test_cyclic_Rotation_should_process_complex_value(self):
        subject = OddOccurances()
        array = [1, 4, 5, 9, 1, 4, 5, 9, 11 , 11, 11]
        self.assertEqual(11, subject.solution(array))

if __name__ == '__main__':
    unittest.main()