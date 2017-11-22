public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxSoFar = nums[0];
        int tempMax = nums[0];

        for(int i=1; i<nums.Length; i++) {
            tempMax = Math.Max(tempMax+nums[i], nums[i]);
            maxSoFar = Math.Max(tempMax, maxSoFar);
        }

        return maxSoFar;
    }
}