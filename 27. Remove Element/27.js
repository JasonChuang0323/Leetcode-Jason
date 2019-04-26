/**
 * @param {number[]} nums
 * @param {number} val
 * @return {number}
 */


// Given nums = [3,2,2,3], val = 3,

// Your function should return length = 2, with the first two elements of nums being 2.

// It doesn't matter what you leave beyond the returned length.

var removeElement = function(nums, val) {
    last = 0
    
    for(let i = 0, il = nums.length; i < il; i++){
        if (nums[i] != val){
            nums[last] = nums[i]
            last++
        }
    }
    return last
};