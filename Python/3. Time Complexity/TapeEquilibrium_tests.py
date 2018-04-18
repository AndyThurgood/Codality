import unittest
from TapeEquilibrium import TapeEquilibrium

class TestTapeEquilibrium(unittest.TestCase):

    def test_tape_equilibrium_should_handle_empty_array(self):
        subject = TapeEquilibrium()
        array = []
        self.assertEqual(0, subject.solution(array))

    def test_tape_equilibrium_should_process_simple_values(self):
        subject = TapeEquilibrium()
        array = [3, 1, 2, 4, 3]
        self.assertEqual(1, subject.solution(array))

    def test_tape_equilibrium_should_process_negative_values(self):
        subject = TapeEquilibrium()
        array = [-3, -1, -2, -4, -3]
        self.assertEqual(1, subject.solution(array))

    def test_tape_equilibrium_should_process_max_values(self):
        subject = TapeEquilibrium()
        array = [-1000, 1000]
        self.assertEqual(2000, subject.solution(array))

    def test_tape_equilibrium_should_process_complex_values(self):
        subject = TapeEquilibrium()
        array = [1000, 500, 3, 5, -1000]
        self.assertEqual(1492, subject.solution(array))

if __name__ == '__main__':
    unittest.main()
 