/**
 * @param {number[]} nums
 * @return {boolean}
 */

 function onlyUnique(value, index, self) {
    return self.indexOf(value) === index;
  }
  
  
  var containsDuplicate = function(nums) {
      
      var unique = nums.filter(onlyUnique);
      
      return (unique.length != nums.length);
  };