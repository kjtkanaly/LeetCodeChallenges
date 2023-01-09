class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:

        nums.sort()

        output = []

        for index in range(0,len(nums)):

            left = index + 1
            right = len(nums) - 1

            while(left < right):

                test = nums[left] + nums[right]

                if test < (-1 * nums[index]):
                    left += 1

                elif test > (-1 * nums[index]):
                    right -= 1

                else:
                    inputSeq = [nums[left], nums[index], nums[right]]
                    
                    if inputSeq not in output:
                        output.append(inputSeq)
                    
                    left += 1
                    right -= 1

        return output