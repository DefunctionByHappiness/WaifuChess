
def expPrefija(a,n,index):

    if a[index] in "abcdefghijklmnñopqrstuvwxyz":
        if index == 0:
            return -1
        else:
            #print(index)
            return "index"
    elif n -1 == index:
        #print(n)
        return "n"
    else:
        #print(index)
        expPrefija(a,n,index+1)

        


inputN = 11
inputA = "abracadabra"
inputIndex = 0

print(expPrefija(inputA,inputN,inputIndex))

inputN = 18
inputA = "+-56*78abracadabra"

print(expPrefija(inputA,inputN,inputIndex))

inputN = 7
inputA = "+-56*78"

print(expPrefija(inputA,inputN,inputIndex))