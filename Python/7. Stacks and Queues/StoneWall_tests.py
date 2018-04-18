import unittest
from StoneWall import StoneWall

class TestStoneWall(unittest.TestCase):

    def test_stonewall_should_handle_empty_array(self):
        subject = StoneWall()
        array = []
        self.assertEqual(0, subject.solution(array))

    def test_stonewall_should_process_simple_array(self):
        subject = StoneWall()
        array = [8, 8, 5, 7, 9, 8, 7, 4, 8]
        self.assertEqual(7, subject.solution(array))

    def test_stonewall_should_process_one_value_array(self):
        subject = StoneWall()
        array = [ 1 ]
        self.assertEqual(1, subject.solution(array))
    
    def test_stonewall_should_process_two_value_array(self):
        subject = StoneWall()
        array = [ -1, 2 ]
        self.assertEqual(2, subject.solution(array))

if __name__ == '__main__':
    unittest.main()