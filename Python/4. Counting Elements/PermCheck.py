# Write a function that, given a zero-indexed array A, returns 1 
# if array A is a permutation and 0 if it is not.
class PermCheck(object):

    def solution(self, numericArray):

        # defensive code
        if len(numericArray) == 0 :
            return 0

        # get the known possible values between min (always 1) and max values provided
        arrayRange = list(range(1, (max(numericArray) +1)))

        # sort the list so it can be compared
        numericArray = sorted(numericArray)

        # if we get a match then return positive
        if(arrayRange == numericArray):
            return 1
        
        # default return
        return 0