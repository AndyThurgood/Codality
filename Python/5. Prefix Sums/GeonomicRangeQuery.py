# Write a function that, given a non-empty zero-indexed string S 
# consisting of N characters and two non-empty zero-indexed arrays 
# P and Q consisting of M integers, returns an array consisting 
# of M integers specifying the consecutive answers to all queries

class GeonomicRangeQuery(object):

    def solution(self, sequence, leftArray, rightArray):
        
        #veto empty arrays
        if len(leftArray) == 0 or len(rightArray) == 0:
            return 0

        # store return values and setup a lookup
        returnList = []
        lookup = {"A": 1, "C": 2, "G": 3, "T": 4}

        # iterate on one of the lists
        for index, value in enumerate(leftArray):
            # get the subsequence based on the two array points
            subsequence = sequence[value:(rightArray[index] + 1)]
            
            # do some groovy python list querying to get the values from 
            # the lookup and also find the smallest value
            minvalue = min([lookup[x] for x in subsequence])
            returnList.append(minvalue)
        
        # return
        return returnList
