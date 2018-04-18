import itertools

# Write a function that, given a positive integer N, returns the length 
# of its longest binary gap.The function should return 0 if N doesn't 
# contain a binary gap.
class BinaryGap(object):

    def solution(self, Number):

        # set retun value
        min_return_value = 0

        # gaurd against zero being passed
        if Number < 1:
            return min_return_value

        # make the numeber binary 11100101
        binaryRepresentation = str(bin(Number))[2:]
        
        # remove any trailing zeros
        binaryRepresentation = str(binaryRepresentation[:binaryRepresentation.rfind('1') + 1])

        # split the string by 1's and 0's
        grouping = [''.join(g) for k, g in itertools.groupby(binaryRepresentation)]

        # return the number of groups 
        if len(grouping) <= 1:
            return min_return_value
        
        # return the largest grouping as this (apparently) will equal the gaps
        return len(max(grouping, key=len))