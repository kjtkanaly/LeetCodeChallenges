class Solution:
    def multiply(self, num1: str, num2: str) -> str:

        # Default
        if (num1 == "0") | (num2 == "0"):
            return "0"

        numDict = {
        "0": 0,
        "1": 1,
        "2": 2,
        "3": 3,
        "4": 4,
        "5": 5,
        "6": 6,
        "7": 7,
        "8": 8,
        "9": 9,
        }

        def convtStrToInt(strNum):
            num = 0
            for char in strNum:
                num *= 10
                num += numDict[char]
            return num
            
        numb1 = convtStrToInt(num1)
        numb2 = convtStrToInt(num2)
        
        prod = numb1 * numb2

        dictKeys = list(numDict.keys())

        def convtIntToStr(num):
            str = ""
            while (num > 0):
                str = dictKeys[num % 10] + str
                num = num // 10
            return str

        return convtIntToStr(prod)