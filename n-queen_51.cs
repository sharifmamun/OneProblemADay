public class Solution {
    /*
    // I will need the positions if there is a solution
     ____________________
    |___|____|_____|_____|
    |___|____|_____|_____|
    |___|____|_____|_____|
    |___|____|_____|_____|

    Step 1: Start from very beginning
    Step 2: Check if the position is safe based on the other Queens' positions
    */

   public IList<IList<string>> SolveNQueens(int n)
    {
        int[] columns = new int[n];
        List<int[]> positions = new List<int[]>();

        SolveNQueens(n, 0, columns, positions);

        List<IList<string>> results = new List<IList<string>>();
        for (int i=0; i<positions.Count; i++)
        {
            List<string> tempResult = new List<string>();
            for(int j=0; j<positions[i].Length; j++)
            {
                StringBuilder temp = new StringBuilder();
                for(int k=0; k<n; k++)
                {
                    if (positions[i][j] == k)
                        temp.Append("Q");
                    else
                        temp.Append(".");
                }
                tempResult.Add(temp.ToString());
            }
            results.Add(tempResult);
        }

        return results;
    }

    private void SolveNQueens(int n, int row, int[] columns, List<int[]> positions)
    {
        if (row == n)
        {
            positions.Add((int[])columns.Clone());
        }
        else
        {
            for(int col = 0; col < n; col++)
            {
                if (IsValid(columns, row, col))
                {
                    columns[row] = col;
                    SolveNQueens(n, row+1, columns, positions);
                }
            }
        }
    }

    private bool IsValid(int[] columns, int row, int col)
    {
        for(int r=0; r<row; r++)
        {
            int c = columns[r];

            if (c == col)
                return false;

            int columnDistance = Math.Abs(c - col);
            int rowDistance = row -r;

            if (columnDistance == rowDistance)
                return false;
        }
        return true;
    }
}