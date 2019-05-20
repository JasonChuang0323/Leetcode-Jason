/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let dic = {};
    for(let i = 0; i < nums.length; i++){
        let temp = target - nums[i];
        if(dic[temp] != undefined){
            return [i, dic[temp]]
        }
        dic[nums[i]] = i;
    }
    
};