# Write a function that, given a zero-indexed array A, 
# returns the value of the missing element.
class PermMissingElem(object):

    def solution(self, numericArray):
        minValue = 1

        # defensive code
        if len(numericArray) == 0:
            return minValue
        
        # get the known possible values between min (always 1) and max values provided
        arrayRange = list(range(minValue, (max(numericArray) +1)))

        # find the first value in the provided array that isn't in our known range
        return next((value for value in arrayRange if value not in numericArray), minValue)
