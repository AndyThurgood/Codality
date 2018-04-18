# Write a function that, given a zero-indexed array A consisting of N 
# integers and an integer K, returns the array A rotated K times.
class CyclicRotations(object):

    def solution(self, numericArray, rotations):

        # defensive code
        if rotations == 0 or len(numericArray) <= 1:
            return numericArray

        index = 0

        # loop and pop and push the values from back to front
        while index < rotations:
            lastvalue = numericArray.pop()
            numericArray.insert(0, lastvalue)
            index+=1
        
        # return the state
        return numericArray
