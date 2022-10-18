/**
 * @param {number[]} nums
 * @return {boolean}
 */

 var containsDuplicate = function(nums) {
    
  for (let i = 0; i < nums.length; i++)
  {
      //console.log(nums[i]);
      
      if (nums.indexOf(nums[i], i + 1) != -1)
      {
          return true;
      }
  }
  
  return false;
};