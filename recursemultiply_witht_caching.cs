public class Solution
{
    public static int RecurseMultiplyWithCaching(int a, int b)
    {
        int smaller = a > b ? b : a;
        int bigger = a > b ? a : b;
        int[] memo = new int[smaller + 1];

        return RecurseMultiplyWithCachingHelper(smaller, bigger, memo);
    }

    public static int RecurseMultiplyWithCachingHelper(int smaller, int bigger, int[] memo)
    {
        if (smaller == 0) return 0;
        else if (smaller == 1) return bigger;
        else if (memo[smaller] != 0) return memo[smaller];

        int s = smaller >> 1;
        int side1 = RecurseMultiplyWithCaching(s, bigger);
        int side2 = side1;

        if (smaller % 2 == 1)
            side2 = RecurseMultiplyWithCachingHelper(smaller - s, bigger, memo);

        memo[smaller] = side1 + side2;

        return memo[smaller];
    }
}
