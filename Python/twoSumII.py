class Solution:
    def twoSumII(self, numbers: List[int], target: int) -> List[int]:

        left = 0
        right = len(numbers) - 1

        while left < right:
            test = numbers[left] + numbers[right]

            if test > target:
                right -= 1
            
            elif test < target:
                left += 1

            else:
                return [left + 1, right + 1]