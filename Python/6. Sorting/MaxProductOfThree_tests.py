import unittest
from MaxProductOfThree import MaxProductOfThree

class TestMaxProductOfThree(unittest.TestCase):

    def test_max_product_of_three_should_handle_empty_array(self):
        subject = MaxProductOfThree()
        array = []
        self.assertEqual(0, subject.solution(array))

    def test_max_product_of_three_should_process_simple_array(self):
        subject = MaxProductOfThree()
        array = [-3, 1, 2, -2, 5, 6]
        self.assertEqual(60, subject.solution(array))

    def test_max_product_of_three_should_process_negative_array(self):
        subject = MaxProductOfThree()
        array = [ -5, 5, -5, 4 ]
        self.assertEqual(125, subject.solution(array))

if __name__ == '__main__':
    unittest.main()