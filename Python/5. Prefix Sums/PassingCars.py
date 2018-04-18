# Write a function that, given a non-empty zero-indexed array A of N 
# integers, returns the number of pairs of passing cars

class PassingCars(object):

    def solution(self, numericArray):

        passCount = 0

        for index, value in enumerate(numericArray):
            if value == 0:
                passCount += sum(numericArray[index:])
        
        return passCount