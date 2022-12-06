class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:

        for i in range(0, len(nums)):

            diff = target - nums[i]

            try:
                index = nums.index(diff)
            except:
                index = -1
            else:
                if i != index:
                    print(i,index)
                    return [i,index]

        return [-1,-1]