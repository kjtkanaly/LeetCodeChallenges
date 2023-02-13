class Solution:
    def findDuplicate(self, nums: List[int]) -> int:
        
        nums.sort()

        index = 1

        while index < len(nums):
            if nums[index] == nums[index - 1]:
                return nums[index]

            index += 1