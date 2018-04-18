# Write a function that, given a non-empty zero-indexed array A 
# consisting of N integers and integer X, returns the earliest time 
# when the frog can jump to the other side of the river.
class FrogRiverOne(object):

    def solution(self, target, numericArray):

        # you know it! defensive code
        if len(numericArray) == 0:
            return -1
        
        # storage
        requiredRange = set()

        # this is a better use of the array index, seems suitable
        for index, value in enumerate(numericArray):
            # check if we have seen this value before and if it's without our target
            if value not in requiredRange and value <= target:
                requiredRange.add(value)
            
            # if our hashset has an equal number of elements as the target, then we know
            # we have all the values we need as the values are unique
            if len(requiredRange) == target:
                return index
        
        return -1
