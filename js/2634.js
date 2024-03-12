/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
  const new_array = [];
  arr.forEach((element, index) => {
    if (fn(element, index)) new_array.push(element);
  });
  return new_array;
};

/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
