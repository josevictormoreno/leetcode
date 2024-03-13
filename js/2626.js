/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function (nums, fn, init) {
  var value = init;
  for (let index = 0; index < nums.length; index++) {
    value = fn(value, nums[index]);
  }
  return value;
};
