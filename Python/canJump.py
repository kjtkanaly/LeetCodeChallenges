class Solution:
    def canJump(self, nums: List[int]) -> bool:

        res = 0
        goal = len(nums) - 1

        for i in range(len(nums) - 2, -1, -1):
            # print(nums[i])
            # print("Goal: ", goal)
            if i + nums[i] >= goal:
                goal = i
        return goal == 0

