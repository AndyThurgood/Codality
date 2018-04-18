# Write a function that, given a non-empty zero-indexed array A, 
# returns the value of the maximal product of any triplet

class MaxProductOfThree(object):

    def solution(self, numericArray):
        
        # Defensive!
        if len(numericArray) == 0:
            return 0

        # Get the values in order High --> Low
        sortedList = list(reversed(sorted(numericArray)))

        # think there is a nicer way to do this in python will investigate
        positiveCalculation = (sortedList[0] * sortedList[1] * sortedList[2])
        negativeCalculation = (sortedList[len(sortedList) -1 ] * sortedList[len(sortedList) - 1] * sortedList[0])

        # return the largest calculation
        return positiveCalculation if positiveCalculation > negativeCalculation else negativeCalculation