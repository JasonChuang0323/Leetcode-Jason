/**
 * @param {number[]} nums
 * @return {void} Do not return anything, modify nums in-place instead.
 */

 // 先找到非0的数字，放到一个新数组里，然后覆盖住前面的位置，最后剩下的改为0就好
var moveZeroes = function(nums) {
	nonZero = []

	for (let i = 0; i < nums.length; i++){
		if (nums[i] !== 0){
			nonZero.push(nums[i])
		}
	}
	
	for (let j = 0; j < nonZero.length; j++){
		nums[j] = nonZero[j] 
	}
	
	for (let i = nonZero.length; i < nums.length; i++){
		nums[i] = 0
	}
};