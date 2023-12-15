# 2023, Dec
# https://www.codewars.com/kata/57eb8fcdf670e99d9b000272/solutions/python
# https://twitter.com/user_phone01

def high(x):
    
    alphabet = "abcdefghijklmnopqrstuvwxyz"
    charsIndex_reverse ={}
    charsIndex = {}
    keyValuePairs = {}
    data = []
    count = 0;

    for i, s in enumerate(alphabet):
        keyValuePairs.update({s : (i + 1)})

    for i, s in enumerate(x.lower().split(" ")):
        for c in s:
            count += keyValuePairs[c]

        charsIndex_reverse.update({s : count})
        charsIndex.update({count : s})
        count = 0

    for s in x.lower().split(" "): 
        if charsIndex_reverse[s] == sorted((charsIndex.keys()), reverse=True)[0]:
            return s


    return charsIndex[sorted((charsIndex.keys()), reverse=True)[0]]

print(high('man i need a taxi driver'))
print(high('what time are we climbing up the volcano'))
print(high("aa b"))


