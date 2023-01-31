class Solution:
    def search(self, nums: List[int], target: int) -> int:

        index = 0

        while (index < len(nums)):
            if (nums[index] == target):
                return index
            
            index += 1

        return -1