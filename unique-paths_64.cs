public class Solution {
    public int UniquePaths(int m, int n) {
        int total = 0;
        if(getPath(m-1 , n-1, total))
            return total;
        return 0;
    }

    private bool getPath(int m, int n, int total) {
        if(m < 0 || n < 0)
            return false;

        bool isAtOrigin = (m == 0) && (n == 0);

        if(isAtOrigin || getPath(m-1, n, total) || getPath(m, n-1, total)) {
            total += 1;
            return true;
        }

        return false;
    }

}