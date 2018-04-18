# Write a function that, given a string S consisting of N characters, 
# returns 1 if S is properly nested and 0 otherwise.

class Brackets(object):

    def solution(self, stringToParse):
        
        # guard against empty strings
        if len(stringToParse) == 0:
            return 0

        # guard against uneven strings
        if len(stringToParse) % 2 != 0:
            return 0

        # setup a lookup and stash
        brackets = {"{":"}", "(":")", "[":"]"}
        openedBrackets = []

        for char in stringToParse:
            # check if we have seen this char
            if char in brackets:
                openedBrackets.append(char)
            # if no open brackets then bail
            elif len(openedBrackets) == 0:
                return 0
            # if we don't have the expected closing bracket then also bail
            elif char != brackets[openedBrackets.pop()]:
                return 0

        # at this point we should be bak to an empty stash
        if len(openedBrackets) != 0:
            return 0
        # return happiness
        return 1