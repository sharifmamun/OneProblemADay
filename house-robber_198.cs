// Sample Input: [2, 1, 1, 2]
// Sample Output: 4

public class Solution {
    public int Rob(int[] nums) {
        int maxMoneyfromEvenHouses = 0;
        int maxMoneyfromOddHouses = 0;

        for(int i=0; i<nums.Length; i++) {
            if(i%2 != 0) {
                maxMoneyfromOddHouses = Math.Max(maxMoneyfromOddHouses+nums[i], maxMoneyfromEvenHouses);
            } else {
                maxMoneyfromEvenHouses = Math.Max(maxMoneyfromOddHouses, maxMoneyfromEvenHouses + nums[i]);
            }
        }

        return Math.Max(maxMoneyfromEvenHouses, maxMoneyfromOddHouses);
    }
}