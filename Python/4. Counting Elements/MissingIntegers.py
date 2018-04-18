# Write a function that, given an array A of N integers, returns the 
# smallest positive integer(greater than 0) that does not occur in A.
class MissingIntegers(object):

    def solution(self, numericArray):

        minReturnValue = 1

        # defensive code
        if len(numericArray) == 0:
            return minReturnValue
        
        # check edge case, all negative so next positive has to be 1
        if all(value < 0 for value in numericArray):
            return minReturnValue
        
        # get the known possible values between min (always 1) and max of values provided
        arrayRange = list(range(1, (max(numericArray) +1)))

        # find first number not encountered, default is the next possible value (edge case)
        returnValue = next((value for value in arrayRange if value not in numericArray), (max(numericArray) + 1))

        # return what we know
        if returnValue > 0:
            return returnValue
        
        # further bolt and braces against negative values
        if returnValue < 0:
            return minReturnValue
