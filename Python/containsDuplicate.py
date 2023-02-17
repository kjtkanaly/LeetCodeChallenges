class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        
        unique = list(set(nums))
        
        return not(len(unique) == len(nums))