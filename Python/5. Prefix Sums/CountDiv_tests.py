import unittest
from CountDiv import CountDiv

class TestCountDiv(unittest.TestCase):

    def test_count_div_should_process_simple_range(self):
        subject = CountDiv()
        self.assertEqual(3, subject.solution(6, 11, 2))

    def test_count_div_should_process_alternate_range(self):
        subject = CountDiv()
        self.assertEqual(20, subject.solution(11, 345, 17))

    def test_count_div_should_validate_min_max_array(self):
        subject = CountDiv()
        self.assertEqual(200000001, subject.solution(0, 200000000, 1))
    
    def test_count_div_should_validate_min_min_array(self):
        subject = CountDiv()
        self.assertEqual(1, subject.solution(0, 0, 11))

if __name__ == '__main__':
    unittest.main()
 