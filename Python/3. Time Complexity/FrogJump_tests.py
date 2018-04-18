import unittest
from FrogJump import FrogJump

class TestFrogJump(unittest.TestCase):
    
    def test_frog_jump_should_process_simple_value(self):
        subject = FrogJump()
        self.assertEqual(3, subject.solution(10, 85, 30))

    def test_frog_jump_should_process_maxx_value(self):
        subject = FrogJump()
        self.assertEqual(9999999, subject.solution(1, 10000000, 1))

if __name__ == '__main__':
    unittest.main()