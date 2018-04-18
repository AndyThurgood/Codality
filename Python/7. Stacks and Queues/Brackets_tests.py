import unittest
from Brackets import Brackets

class TestMaxProductOfThree(unittest.TestCase):

    def test_brackets_should_handle_empty_string(self):
        subject = Brackets()
        testValue = ""
        self.assertEqual(0, subject.solution(testValue))

    def test_brackets_should_process_simple_pattern(self):
        subject = Brackets()
        testValue = "{[()()]}"
        self.assertEqual(1, subject.solution(testValue))

    def test_brackets_should_process_complex_pattern(self):
        subject = Brackets()
        testValue = "{}()[]{()()()()}[][]({}{}{})"
        self.assertEqual(1, subject.solution(testValue))
    
    def test_brackets_should_process_uneven_pattern(self):
        subject = Brackets()
        testValue = "{{}}("
        self.assertEqual(0, subject.solution(testValue))
    
    def test_brackets_should_process_single_char_type_pattern(self):
        subject = Brackets()
        testValue = "[[[["
        self.assertEqual(0, subject.solution(testValue))

if __name__ == '__main__':
    unittest.main()