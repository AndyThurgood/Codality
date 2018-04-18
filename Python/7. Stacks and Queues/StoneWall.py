# Write a function that, given an array H of N positive integers 
# specifying the height of the wall, returns the minimum number of 
# blocks needed to build it.
class StoneWall(object):
    
    def solution(self, heightArray):
        
        # defend against a single wall piece
        if len(heightArray) <= 1:
            return len(heightArray)
        
        # storage values
        blockcount = 0
        stack = []

        for height in heightArray:

            # check for large block heights
            while len(stack) != 0 and height < stack[-1]:
                stack.pop()
            
            # Stack the current value if we don't have a value
            # or if the next height is less than the current height
            if len(stack) == 0:
                stack.append(height)
                blockcount += 1
            elif stack[-1] < height:
                stack.append(height)
                blockcount += 1
        
        return blockcount


        

