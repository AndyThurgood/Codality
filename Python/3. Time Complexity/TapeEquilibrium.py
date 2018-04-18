# Tape equilibrium.
class TapeEquilibrium(object):

    def solution(self, numericArray):

        # defensive code
        if len(numericArray) == 0:
            return 0
    
        # result store
        results = []

        # this sucks, looping and not using the value, also the index modifiers are horrible
        # need to re-write this in a pythonic way
        # essentially get the diff between the value to the left and right of array (n)
        for index, value in enumerate(numericArray[: -1]):
            results.append(abs(sum(numericArray[:index + 1]) - sum(numericArray[index + 1:])))

        # return
        return min(results)