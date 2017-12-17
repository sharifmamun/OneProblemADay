public class Solution
{
    private static int RecurseMultiplyWithoutCaching(int a, int b)
    {
        int smaller = a > b ? b : a;
        int bigger = a > b ? a : b;

        return RecurseMultiplyWithoutCachingHelper(smaller, bigger);
    }

    private static int RecurseMultiplyWithoutCachingHelper(int smaller, int bigger)
    {
        if (smaller == 0) return 0;
        if (smaller == 1) return bigger;

        int s = smaller >> 1;
        int side1 = RecurseMultiplyWithoutCaching(s, bigger);
        int side2 = side1;

        if (smaller % 2 == 1)
            side2 = RecurseMultiplyWithoutCachingHelper(smaller - s, bigger);

        return side1 + side2;
    }
}