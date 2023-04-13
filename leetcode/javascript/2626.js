/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function(nums, fn, init) {
    let sum=0;
    let val=init;
    
    for(var i = 0; i < nums.length; i++)
        {sum=Number(fn(val,nums[i]));
         val=Number(sum);}
    return val;
};