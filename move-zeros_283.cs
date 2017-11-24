public class Solution {
    public void MoveZeroes(int[] nums) {
        int numOfZeroOccurred = 0;

        for(int i=0; i<nums.Length; i++) {
            if (nums[i] == 0)
                numOfZeroOccurred++;
            else {
                int temp = nums[i];
                nums[i] = nums[i - numOfZeroOccurred];
                nums[i - numOfZeroOccurred] = temp;
            }
        }
    }
}