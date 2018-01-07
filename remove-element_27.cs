public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int index = 0;

        foreach(int i in nums)
        {
            if (i != val)
            {
                nums[index++] = i;
            }
        }

        return index;
    }
}