class Solution:
    def evalRPN(self, tokens: List[str]) -> int:

        operatorMap = ["+","-","*","/"]
        i = 0

        while (i < len(tokens)):

            if tokens[i] in operatorMap:                

                val1 = int(tokens[i-1])
                val2 = int(tokens[i-2])

                # print(tokens)

                if tokens[i] == "+":
                    tokens[i] = str(val2 + val1)

                elif tokens[i] == "-":
                    tokens[i] = str(val2 - val1)

                elif tokens[i] == "*":
                    tokens[i] = str(val2 * val1)

                elif tokens[i] == "/":
                    tokens[i] = str(int(val2 / val1))

                tokens.pop(i - 1)
                tokens.pop(i - 2)

                i -= 2

            else:
                i += 1  

        return int(tokens[0])