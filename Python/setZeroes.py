class Solution:
    def setZeroes(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        w, h = len(matrix[0]), len(matrix)
        tempMatrix = [[0 for x in range(w)] for y in range(h)] 
        row = 0
        while row < len(matrix):
            col = 0
            while col < len(matrix[0]):
                tempMatrix[row][col] = matrix[row][col]
                col += 1
            row += 1

        row = 0
        while row < len(matrix):
            col = 0
            while col < len(matrix[0]):
                if matrix[row][col] == 0:
                    for y in range(h):
                        tempMatrix[y][col] = 0
                    for x in range(w):
                        tempMatrix[row][x] = 0
                col += 1
            row += 1

        row = 0
        while row < len(matrix):
            col = 0
            while col < len(matrix[0]):
                matrix[row][col] = tempMatrix[row][col]
                col += 1
            row += 1