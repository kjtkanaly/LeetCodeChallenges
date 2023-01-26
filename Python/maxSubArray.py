class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        
        left = 0
        end = len(nums) - 1 
        maxSum = max(nums)
        
        while (left <= end):

            right = left + 1

            while (right <= end):

                maxSum = max(maxSum, sum(nums[left:right + 1]))

                # print(str(sum(nums[left:right + 1])) + ": " + str(nums[left:right + 1]))

                right += 1

            left += 1

        return maxSum