/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function (functions) {
  return function (x) {
    if (functions.length == 0) {
      return x;
    }
    var sum = x;
    for (let i = functions.length - 1; i >= 0; i--) {
      sum = functions[i](sum);
    }
    return sum;
  };
};

// const fn = compose([(x) => x + 1, (x) => x * x, (x) => 2 * x]);
// fn(4); // 9
