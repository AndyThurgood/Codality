# Write a function that, given an integer N and a non-empty zero-indexed 
# array A consisting of M integers, returns a sequence of integers 
# representing the values of the counters.
class MaxCounters(object):

    def solution(self, counterLimit, numericArray):

        # create an array of zeros
        counters = [0] * counterLimit
        maxValue = 0

        # iterate on the array
        for value in numericArray:

            #check for array out of bounds
            if(value > counterLimit):

                if value == (counterLimit + 1):
                    counters = [maxValue] * counterLimit
                continue
            # assign the counter
            counters[value -1] = (counters[value -1] + 1)
            
            # track the max value
            if  maxValue < counters[value -1]:
                maxValue = counters[value -1]

        return counters