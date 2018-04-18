import math
# Write a function that, given three integers X, Y and D, returns 
# the minimal number of jumps from position X to a position equal 
# to or greater than Y.
class FrogJump(object):

    def solution(self, x, y, d):

        # instantiate a return value
        returnValue = 0

        # do some math in python!
        returnValue = int(math.ceil(float(y-x) / d))

        return returnValue