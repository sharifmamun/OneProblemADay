public class Solution {
    public int ArrangeCoins(int n) {
        int result = 0;

        for (int i=1; i <=n; i++)
        {
            n = n - i;
            result++;
        }

        return result;
    }
}