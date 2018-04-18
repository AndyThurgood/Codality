import unittest
from FrogRiverOne import FrogRiverOne

class TestFrogRiverOne(unittest.TestCase):

    def test_frog_river_one_should_handle_empty_array(self):
        subject = FrogRiverOne()
        array = []
        self.assertEqual(-1, subject.solution(0, array))

    def test_frog_river_one_should_validate_complete_array(self):
        subject = FrogRiverOne()
        array = [1, 3, 1, 4, 2, 3, 5, 4]
        self.assertEqual(6, subject.solution(5, array))

    def test_frog_river_one_should_invalidate_incomplete_array(self):
        subject = FrogRiverOne()
        array = [-3, -1, -2, -4, -3]
        self.assertEqual(-1, subject.solution(5, array))

    def test_frog_river_one_should_validate_complex_array(self):
        subject = FrogRiverOne()
        array = [4, 1, 2, 8, 7, 3, 2, 6, 1, 2, 9, 11, 13, 14, 16, 17, 12, 13, 14, 15, 18, 5, 10]
        self.assertEqual(22, subject.solution(10, array))

if __name__ == '__main__':
    unittest.main()
 