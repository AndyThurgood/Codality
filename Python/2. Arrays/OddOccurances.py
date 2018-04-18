import itertools

# Write a function that, given an array A consisting of N integers 
# The array contains an odd number of elements, and each element of the 
# array can be paired with another element that has the same value, 
# except for one element that is left unpaired. 
# Returns the value of the unpaired element.
class OddOccurances(object):

    def solution(self, numericArray):

        # defensive code
        if len(numericArray) == 0:
            return 0
        
        # sort the array
        numericArray = sorted(numericArray)

        # group the array by value
        grouping = itertools.groupby(numericArray)

        # return the the first grouping that has an odd number of values e.g not paired
        # seems to be iterating too much with next() investigate...
        return next(key for key, igroup in grouping if len(list(igroup)) %2==1)
