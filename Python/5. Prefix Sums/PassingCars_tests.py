import unittest
from PassingCars import PassingCars

class TestPassingCars(unittest.TestCase):

    def test_passing_cars_should_process_simple_array(self):
        subject = PassingCars()
        array = [0, 1, 0, 1, 1]
        self.assertEqual(5, subject.solution(array))

    def test_passing_cars_should_process_east_only_Array(self):
        subject = PassingCars()
        array = [0, 0, 0, 0, 0]
        self.assertEqual(0, subject.solution(array))

    def test_passing_cars_should_validate_west_only_array(self):
        subject = PassingCars()
        array = [1, 1, 1, 1, 1]
        self.assertEqual(0, subject.solution(array))
    

if __name__ == '__main__':
    unittest.main()
 