import itertools
# Write a function that, given a zero-indexed array A consisting of 
# N integers, returns index of any element of array A in which 
# the dominator of A occurs. The function should return −1 if array A does not have a dominator.

class Dominator(object):

    def solution(self, numericArray):
        
        if len(numericArray) == 0:
            return -1
        
        # this is a super swish way to get the highest count :)
        dominator = max(numericArray, key= numericArray.count)

        # check if the dominator is truely 
        if len(numericArray) / 2 > numericArray.count(dominator):
            return -1
        
        return numericArray.index(dominator)
        
