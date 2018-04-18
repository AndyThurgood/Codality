import unittest
from MaxCounters import MaxCounters

class TestMaxCounters(unittest.TestCase):
    
    def test_max_counters_should_handle_simple_array(self):
        subject = MaxCounters()
        array = [3, 4, 4, 6, 1, 4, 4]
        self.assertEqual([3, 2, 2, 4, 2], subject.solution(5, array))

    def test_max_counters_should_validate_single_array(self):
        subject = MaxCounters()
        array = [3]
        self.assertEqual([0, 0, 1], subject.solution(3,array))

if __name__ == '__main__':
    unittest.main()
    