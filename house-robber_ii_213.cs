public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1)
            return nums[0];
        else if(nums.Length == 2)
            return Math.Max(nums[0], nums[1]);

        int maxFromFront = RobHelper(nums, 0, nums.Length-2);
        // ReverseArray(nums);

        return Math.Max(maxFromFront, RobHelper(nums, 1, nums.Length-1));
    }

    private void ReverseArray(int[] nums) {
        int j = nums.Length - 1;
        for(int i=0; i<j; i++, j--)
        {
            int z = nums[i];
            nums[i] = nums[j];
            nums[j] = z;
        }
    }

    private int RobHelper(int[] nums, int s, int e) {
        int maxMoneyfromEvenHouses = 0;
        int maxMoneyfromOddHouses = 0;

        for(int i=s; i<=e; i++) {
            if(i%2 != 0) {
                maxMoneyfromOddHouses = Math.Max(maxMoneyfromOddHouses+nums[i], maxMoneyfromEvenHouses);
            } else {
                maxMoneyfromEvenHouses = Math.Max(maxMoneyfromOddHouses, maxMoneyfromEvenHouses + nums[i]);
            }
        }

        return Math.Max(maxMoneyfromEvenHouses, maxMoneyfromOddHouses);
    }
}