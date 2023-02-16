class Solution:
    def missingNumber(self, nums: List[int]) -> int:

        trueSum = 0
        for x in range(1, len(nums) + 1):
            trueSum += x

        numsSum = sum(nums)

        return trueSum - numsSum
        