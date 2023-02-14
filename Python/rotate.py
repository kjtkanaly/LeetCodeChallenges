class Solution:
    def rotate(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
        # Copy of the matrix we are rotating
        n = len(matrix)
        copy = []

        row = 0
        while (row < n):
            col = 0
            while (col < n):
                copy.append(matrix[row][col])
                col += 1
            row += 1  

        col = 0
        while (col < n):
            row = 0
            while (row < n):
                # print(str(row) + "," + str(col) + ": " + str(copy[(row * n) + col]))
                matrix[col][n - row - 1] = copy[(row * n) + col]
                row += 1
            col += 1