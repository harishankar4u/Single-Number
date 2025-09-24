**Example 1:**

Input: nums = [2,2,1]

Output: 1

**Example 2:**
Input: nums = [4,1,2,1,2]

Output: 4

**Example 3:**
Input: nums = [1]

Output: 1

**XOR condition**

like 0 0 0 1 1 1
     0 0 0 1 1 1
  --------------------
     0 0 0 0 0 0

     0 0 0 1 1 1
     1 0 0 1 1 1
  --------------------
     1 0 0 0 0 0
res = 0
res = 0 ^ 1 = 1
res = 1 ^ 2 = 3
res = 3 ^ 2 = 1
res = 1 ^ 3 = 2
res = 2 ^ 3 = 1
res = 1 ^ 1 = 0
res = 0 ^ 4 = 4

**Constraints:**

1 <= nums.length <= 3 * 104
-3 * 104 <= nums[i] <= 3 * 104
Each element in the array appears twice except for one element which appears only once.
