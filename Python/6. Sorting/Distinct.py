# Write a function, that, given a zero-indexed array A consisting of 
# N integers, returns the number of distinct values in array A.

class Distinct(object):

    def solution(self, numericarray):

        if len(numericarray) == 0:
            return 0

        return len(list(set(numericarray)))