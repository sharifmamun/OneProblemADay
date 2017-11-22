// Online Judge is expecting for maximum int, which is n=37
// for larger input, we might need to use BigInteger
public class Solution {
    public int ClimbStairs(int n) {
        int[] memo = new int[n];
        for(int i=0; i<n; i++) {
            memo[i] = -1;
        }

        return ClimbStairs(n, memo);
    }

    private int ClimbStairs(int n, int[] memo) {
        if (n <= 3)
            return n;
        else if (memo[n-1] > -1)
            return memo[n-1];
        else{
            memo[n-1] = ClimbStairs(n-1, memo) + ClimbStairs(n-2, memo);
            return memo[n-1];
        }
    }
}