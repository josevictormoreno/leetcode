/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function(arr, fn) {
  const new_array = []
  return arr.foreach( (element, index) => {
    new_array[index] = fn(element, index)
  })   
  return new_array
};

