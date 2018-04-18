import unittest
from CyclicRotations import CyclicRotations

# Tests to support the binary gap solution
class TestCyclicRotations(unittest.TestCase):

    def test_cyclic_Rotation_should_handle_zero_value(self):
        subject = CyclicRotations()
        self.assertEqual([], subject.solution([], 0))
    
    def test_cyclic_Rotation_should_process_simple_value(self):
        subject = CyclicRotations()
        array = [1, 2, 3, 4]
        self.assertEqual([4,1,2,3], subject.solution(array, 1))

    def test_cyclic_Rotation_should_process_complex_value(self):
        subject = CyclicRotations()
        array = [12, 14, 18, 19, 100, 1999, 345, 1223, 45436, 654654]
        self.assertEqual([1999, 345, 1223, 45436, 654654, 12, 14, 18, 19, 100], subject.solution(array, 15))

if __name__ == '__main__':
    unittest.main()