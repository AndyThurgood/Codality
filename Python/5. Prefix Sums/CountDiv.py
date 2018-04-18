# Write a function that, given three integers A, B and K, returns the 
# number of integers within the range [A..B] that are divisible by K
class CountDiv(object):

    def solution(self, a, b, k):
        
        # setup storage variables
        rangeList = range(a, b + 1)
        divisionCount = 0

        # loop through the known range of numbers
        # this is slooooowww, need an alternative solution
        for value in rangeList:
            # check we can divide
            if value % k == 0:
                divisionCount += 1
        # return
        return divisionCount

