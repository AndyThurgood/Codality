import unittest
from MinAvgTwoSlices import MinAvgTwoSlice

class TestMinAvgTwoSlice(unittest.TestCase):

    def test_min_avg_two_slice_should_handle_empty_array(self):
        subject = MinAvgTwoSlice()
        array = []
        self.assertEqual(-1, subject.solution(array))

    def test_min_avg_two_slice_should_process_simple_array(self):
        subject = MinAvgTwoSlice()
        array = [4, 2, 2, 5, 1, 5, 8]
        self.assertEqual(1, subject.solution(array))

if __name__ == '__main__':
    unittest.main()