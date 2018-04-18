import unittest
from BinaryGap import BinaryGap

# Tests to suppor the binary gap solution
class TestBinaryGap(unittest.TestCase):

    def test_binary_gap_should_handle_zero_value(self):
        binarygap = BinaryGap()
        self.assertEqual(0, binarygap.solution(0))
    
    def test_binary_gap_should_process_simple_value(self):
        binarygap = BinaryGap()
        self.assertEqual(0, binarygap.solution(6))

    def test_binary_gap_should_process_complex_value(self):
        binarygap = BinaryGap()
        self.assertEqual(2, binarygap.solution(51712))

if __name__ == '__main__':
    unittest.main()