class Solution:
    def findMin(self, nums: List[int]) -> int:
        index = 0
        while (index < (len(nums) - 1)):
            if (nums[index] > nums[index + 1]):
                return nums[index + 1]
            index += 1
        
        return nums[0]