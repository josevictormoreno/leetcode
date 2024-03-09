/**
 * @param {number[]} nums1
 * @param {number[]} nums2
 * @return {number}
 */
var getCommon = function (nums1, nums2) {
  for (let i = 0; i < nums1.length; i++) {
    const element1 = nums1[i];
    for (let j = 0; j < nums2.length; j++) {
      const element2 = nums2[j];
      if (element1 === element2) return element1;
    }
  }
  return -1;
};
