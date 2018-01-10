public class Solution {
    public int Change(int amount, int[] coins) {
        if (amount == 0)
            return 1;

        if(coins.Length == 0)
            return 0;
        //int maps[][] = new int[amount+1][coins.Length];
        int[,] maps = new int[amount+1, coins.Length];
        for (int i = 0; i < maps.GetLength(0); i++)
        {
            for (int j = 0; j < maps.GetLength(1); j++) maps[i, j] = -1;
        }

        return Change(amount, coins, maps, coins.Length-1);
    }

    public int Change(int amount, int[] coins, int[,] maps, int index)
    {
        if(maps[amount, index] > -1)
            return maps[amount, index];

        if (index == 0)
        {
            if (amount % coins[index] == 0)
                return 1;
            else
                return 0;
        }

        int denomAmount = coins[index];
        int ways = 0;

        for (int i=0; i*denomAmount <= amount; i++)
        {
            int remainingAmount = amount - i*denomAmount;
            ways += Change(remainingAmount, coins, maps, index-1);
        }

        maps[amount, index] = ways;

        return ways;
    }
}