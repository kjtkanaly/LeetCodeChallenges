class Solution:
    def searchMatrix(self, matrix: List[List[int]], target: int) -> bool:

        numRows = len(matrix)
        numCols = len(matrix[0])
        row = 0
        col = 0

        while (row < numRows):
            if ((target >= matrix[row][0]) & (target <= matrix[row][numCols - 1])):
                while (col < numCols):
                    if (target == matrix[row][col]):
                        return True
                    col += 1

            elif ((target < matrix[row][0])):
                return False
            
            row += 1


        return False