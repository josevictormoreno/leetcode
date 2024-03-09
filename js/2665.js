/**
 * @param {integer} init
 * @return { increment: Function, decrement: Function, reset: Function }
 */
var createCounter = function(init) {
  var current_value = init
  return {
    increment: () => {
      return ++current_value
    },
    decrement: () => {

      return --current_value
    },
    reset: () => {
      current_value = init
      return init
    }
  }
};

