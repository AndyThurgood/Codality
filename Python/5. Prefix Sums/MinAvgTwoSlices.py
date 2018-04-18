# Write a function that, given a non-empty zero-indexed array A 
# consisting of N integers, returns the starting position of the slice 
# with the minimal average. If there is more than one slice with a 
# minimal average, you should return the smallest starting position of 
# such a slice.

class MinAvgTwoSlice(object):

    def solution(self, numericArray):
        
        # defensive code
        if len(numericArray) == 0:
            return -1
        
        # storage values
        minimumSliceAverage = 10000
        returnValue = 0

        for index, value in enumerate(numericArray):
            # check if we can get a slice of 2
            if index + 1 < len(numericArray):
                twoSliceValue = (value + numericArray[index +1])
                threeSliceValue = 10000

                # check if we can get a slice of 3
                if index + 2 < len(numericArray):
                    threeSliceValue = twoSliceValue + numericArray[index + 2]
                
                # calcuate the lowest average
                sliceAverage =  twoSliceValue / 2.0 if twoSliceValue / 2.0 < threeSliceValue / 3.0 else threeSliceValue / 3.0
                
                # store the calculated values
                if sliceAverage < minimumSliceAverage:
                    minimumSliceAverage = sliceAverage
                    returnValue = index
        
        # return
        return returnValue



