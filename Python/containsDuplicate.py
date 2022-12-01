class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        
        MyList = set();
        
        for num in nums:
            if num in MyList:
                return True
            
            MyList.add(num)
            
        return False
            