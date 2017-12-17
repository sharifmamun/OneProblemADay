public class Solution
{
    public static object RecurseMultiply(int a, int b)
    {
        int smaller = a > b ? b : a;
        int bigger = a > b ? a : b;

        return RecurseMultiplyHelper(smaller, bigger);
    }

    public static int RecurseMultiplyHelper(int smaller, int bigger)
    {
        if (smaller == 0) return 0;
        if (smaller == 1) return bigger;

        int s = smaller >> 1;

        int side1 = RecurseMultiplyHelper(s, bigger);
        if (smaller % 2 == 1)
            return side1 + side1 + bigger;

        return side1 + side1;
    }
}
