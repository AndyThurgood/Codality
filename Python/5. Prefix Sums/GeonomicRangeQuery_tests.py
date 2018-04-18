import unittest
from GeonomicRangeQuery import GeonomicRangeQuery

class TestGeonomicRangeQuery(unittest.TestCase):

    def test_grq_process_simple_array(self):
        subject = GeonomicRangeQuery()
        sequence = "CAGCCTA"
        leftArray = [2, 5, 0]
        rightArray = [4, 5, 6]
        self.assertEqual([2, 4, 1], subject.solution(sequence, leftArray, rightArray))

    def test_grq_should_process_complex_Array(self):
        subject = GeonomicRangeQuery()
        sequence = "AGCCTACAGCCTAGCCTAGCCTAGCCTAGCCTAGCCTAGCCT"
        leftArray = [2, 0, 23, 2, 8, 3, 2]
        rightArray = [9, 14, 24, 5, 18, 9, 3]
        self.assertEqual([1, 1, 2, 1, 1, 1, 2], subject.solution(sequence, leftArray, rightArray))
    

if __name__ == '__main__':
    unittest.main()
 