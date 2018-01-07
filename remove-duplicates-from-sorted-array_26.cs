public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int index = nums.Length > 0 ? 1 : 0;

        foreach(int i in nums)
        {
            if (i > nums[index-1])
            {
                nums[index++] = i;
            }
        }

        return index;
    }
}