public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 3)
            return n;

        return ClimbStairs(n-1) + ClimbStairs(n-2);
    }
}